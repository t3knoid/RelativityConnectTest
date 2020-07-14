using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using kCura.Relativity.Client;
using kCura.Relativity.Client.DTOs;
using DTOs = kCura.Relativity.Client.DTOs;
using Relativity.Services.ServiceProxy;
using Relativity.Services.Objects;
using Relativity.OAuth2Client.IdentityModel.Client;
using Relativity.OAuth2Client.IdentityModel.Interfaces;
using System.Xml;

namespace RelativityConnectTest
{
    public partial class Form1 : Form
    {

        string BaseURLServer
        { 
            get { return _baseurlserver;} 
            set { _baseurlserver = value; }
        }

        static string _baseurlserver;        

        public Form1()
        {
            InitializeComponent();
        }

        static public string GetServicesURL()
        {
            return String.Format("{0}/relativity.services", _baseurlserver);
        }

        static public string GetRestHostURL()
        {
            return String.Format("{0}/relativity.Rest/API", _baseurlserver);
        }

        static public string GetIdentityServerTokenHostURL()
        {
            return String.Format("{0}/Relativity/Identity/connect/token", _baseurlserver);
        }

        static public Uri GetServiceHostURI()
        {
            // string serverName = String.Format("{0}.{1}", Environment.MachineName, System.Net.NetworkInformation.IPGlobalProperties.GetIPGlobalProperties().DomainName);

            Uri uri = new Uri(string.Format("{0}/relativity.services/", _baseurlserver));
            return uri;
        }
        
        static public Uri GetRestHostURI()
        {
            // string serverName = String.Format("{0}.{1}", Environment.MachineName, System.Net.NetworkInformation.IPGlobalProperties.GetIPGlobalProperties().DomainName);

            Uri uri = new Uri(string.Format("{0}/relativity.rest/", _baseurlserver));
            return uri;
        }

        static public Uri GetWebAPIURI()
        {
            // string serverName = String.Format("{0}.{1}", Environment.MachineName, System.Net.NetworkInformation.IPGlobalProperties.GetIPGlobalProperties().DomainName);

            Uri uri = new Uri(string.Format("{0}/relativitywebapi/", _baseurlserver));
            return uri;
        }

        static public string GetWebAPIURL()
        {
            // string serverName = String.Format("{0}.{1}", Environment.MachineName, System.Net.NetworkInformation.IPGlobalProperties.GetIPGlobalProperties().DomainName);

            return string.Format("{0}/relativitywebapi/", _baseurlserver);
        }


        private void btConnect_Click(object sender, EventArgs e)
        {
            try
            {
                // Make sure to grab base URL of what the user entered
                var uri = new Uri(this.tbBaseURL.Text);
                BaseURLServer = uri.GetLeftPart(System.UriPartial.Authority).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed getting base URL. Check to make sure you entered a valid URL.");
                return;
            }

            SaveSettings();
                
            if (rbOAuth2.Checked)
            {
                try
                {
                    OAuth2 oauth2 = new OAuth2
                    {
                        RestUri = GetRestHostURL(),
                        ServicesUri = GetServicesURL(),
                        IdentityServerTokenUrl = GetIdentityServerTokenHostURL(),
                        ClientID = this.tbClientID.Text,
                        ClientSecret = this.tbClientSecret.Text

                    };
                    bool success = oauth2.RetrieveRelativityWorkspaces();
                    if (success)
                    {
                        MessageBox.Show("Successful", "Oauth2", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Failed", "Oauth2", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed authenticating using OAuth2. " + ex.Message + "\n" + ex.StackTrace, "OAuth2 Authorization");
                }
            }

            if (rbWinAuth.Checked)
            {
                try
                {
                    string username = "";
                    string password = "";

                    if (!cbWinAuthPassthru.Checked)
                    {
                        username = this.tbUsername.Text;
                        password = this.tbPassword.Text;
                    }

                    WinAuth winauth = new WinAuth
                    {
                        RestURL = GetRestHostURL(),
                        ServicesURL = GetServicesURL(),
                        Username = username,
                        Password = password
                    };
                    bool success = winauth.RetrieveRelativityWorkspaces();
                    if (success)
                    {
                        MessageBox.Show("Successful", "WinAuth", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Failed", "WinAuth", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed authenticating using Windows Auth. " + ex.Message + "\n" + ex.StackTrace, "Windows Authorization");
                }
            }

            if (rbImportAPI.Checked)
            {
                try
                {
                    iAPI iapi = new iAPI();
                    string username = "";
                    string password = "";                       

                    if (!cbWinAuthPassthru.Checked)
                    {
                        username = this.tbUsername.Text;
                        password = this.tbPassword.Text;
                    }

                    bool success = iapi.Login(username, password, GetWebAPIURL());                       

                    if (success)
                    {
                        MessageBox.Show("Successful", "ImportAPI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Failed", "ImportAPI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed import API login. " + ex.Message + " " + ex.InnerException, "Import API Authorization");
                }
            }

        }

        private static void ShowWorkspaces(List<NameValueObject> wsList, string title)
        {
            List<string> wslist = new List<string>();
            foreach (NameValueObject workspace in wsList)
            {
                wslist.Add(workspace.Name);
            }
            string toDisplay = toDisplay = String.Join(Environment.NewLine, wslist);
            MessageBox.Show(toDisplay, title);
        }

        private void llShowPassword_MouseDown(object sender, MouseEventArgs e)
        {
            this.tbPassword.UseSystemPasswordChar = false;
        }

        private void llShowPassword_MouseUp(object sender, MouseEventArgs e)
        {
            this.tbPassword.UseSystemPasswordChar = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadSettings();
            rbWinAuth.Checked = true;
        }

        private void LoadSettings()
        {
            Settings1 settings = new Settings1();
            this.tbUsername.Text = settings.Username;
            if (!string.IsNullOrEmpty(settings.Password))
            {
                this.tbPassword.Text = Helpers.Decrypt(settings.Password);
            }
            this.tbBaseURL.Text = settings.BaseURL;
        }

        private void SaveSettings()
        {
            Settings1 settings = new Settings1();
            settings.Username = this.tbUsername.Text;
            if (!string.IsNullOrEmpty(this.tbPassword.Text))
            {
                settings.Password = Helpers.Encrypt(this.tbPassword.Text);
            }
            settings.BaseURL = this.tbBaseURL.Text;
            settings.Save();
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            this.tbUsername.Text = Settings1.Default.Properties["Username"].DefaultValue.ToString();
            this.tbPassword.Text = Settings1.Default.Properties["Password"].DefaultValue.ToString();
            this.tbBaseURL.Text = Settings1.Default.Properties["RESTUrl"].DefaultValue.ToString();
            SaveSettings();
        }

        private void rbWinAuth_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rbWinAuth.Checked)
            {
                this.cbWinAuthPassthru.Enabled = true;
            }
            else
            {
                this.cbWinAuthPassthru.Enabled = false;
            }
            if (this.cbWinAuthPassthru.Checked)
            {
                this.tbUsername.Enabled = false;
                this.tbPassword.Enabled = false;
            }
            else
            {
                this.tbUsername.Enabled = true;
                this.tbPassword.Enabled = true;
            }
            this.tbClientID.Enabled = false;
            this.tbClientSecret.Enabled = false;
            this.tbBaseURL.Enabled = true;
        }

        private void rbOAuth2_CheckedChanged(object sender, EventArgs e)
        {
            this.tbUsername.Enabled = false;
            this.tbPassword.Enabled = false;
            this.tbClientID.Enabled = true;
            this.tbClientSecret.Enabled = true;
            this.tbBaseURL.Enabled = false;            
        }

        private void rbImportAPI_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rbImportAPI.Checked)
            {
                this.cbImportAPIPassthru.Enabled = true;
            }
            else
            {
                this.cbImportAPIPassthru.Enabled = false;
            }
            if (this.cbImportAPIPassthru.Checked)
            {
                this.tbUsername.Enabled = false;
                this.tbPassword.Enabled = false;
            }
            else
            {
                this.tbUsername.Enabled = true;
                this.tbPassword.Enabled = true;
            }
            this.tbClientID.Enabled = false;
            this.tbClientSecret.Enabled = false;
            this.tbBaseURL.Enabled = true;
        }

        private void cbWinAuthPassthru_CheckedChanged(object sender, EventArgs e)
        {
            if (!cbWinAuthPassthru.Checked)
            {
                this.tbUsername.Enabled = true;
                this.tbPassword.Enabled = true;
            }
            else
            {
                this.tbUsername.Enabled = false;
                this.tbPassword.Enabled = false;
            }
        }

        private void cbImportAPIPassthru_CheckedChanged(object sender, EventArgs e)
        {
            if (!cbImportAPIPassthru.Checked)
            {
                this.tbUsername.Enabled = true;
                this.tbPassword.Enabled = true;
            }
            else
            {
                this.tbUsername.Enabled = false;
                this.tbPassword.Enabled = false;
            }
        }

    }
}
