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

namespace RelativityConnectTest
{
    public partial class Form1 : Form
    {

        string RestServer
        { 
            get { return _restserver;} 
            set { _restserver = value; }
        }

        static string _restserver;

        string ServicesServer
        { 
            get { return _servicesserver;} 
            set { _servicesserver = value; }
        }

        static string _servicesserver;


        public Form1()
        {
            InitializeComponent();
        }

        static public string GetServicesURL()
        {
            return String.Format("{0}/relativity.services", _servicesserver);
        }

        static public string GetRestHostURL()
        {
            return String.Format("{0}/relativity.Rest/API", _restserver);
        }

        static public string GetIdentityServerTokenHostURL()
        {
            return String.Format("{0}/Relativity/Identity/connect/token", _restserver);
        }

        static public Uri GetServiceHostURI()
        {
            // string serverName = String.Format("{0}.{1}", Environment.MachineName, System.Net.NetworkInformation.IPGlobalProperties.GetIPGlobalProperties().DomainName);

            Uri uri = new Uri(string.Format("{0}/relativity.services/", _servicesserver));
            return uri;
        }
        
        static public Uri GetRestHostURI()
        {
            // string serverName = String.Format("{0}.{1}", Environment.MachineName, System.Net.NetworkInformation.IPGlobalProperties.GetIPGlobalProperties().DomainName);

            Uri uri = new Uri(string.Format("{0}/relativity.rest/", _restserver));
            return uri;
        }

        static public Uri GetWebAPIURI()
        {
            // string serverName = String.Format("{0}.{1}", Environment.MachineName, System.Net.NetworkInformation.IPGlobalProperties.GetIPGlobalProperties().DomainName);

            Uri uri = new Uri(string.Format("{0}/relativitywebapi/", _restserver));
            return uri;
        }

        static public string GetWebAPIURL()
        {
            // string serverName = String.Format("{0}.{1}", Environment.MachineName, System.Net.NetworkInformation.IPGlobalProperties.GetIPGlobalProperties().DomainName);

            return string.Format("{0}/relativitywebapi/", _restserver);
        }


        private void btConnect_Click(object sender, EventArgs e)
        {           
            RestServer = this.tbRestURL.Text;
            ServicesServer = this.tbServicesURL.Text;

            //if (rbAuth2.Checked)
            //{
            //    try
            //    {
            //        OAuth2 oauth2 = new OAuth2
            //        {
            //            RestUri = GetRestHostURL(),
            //            ServicesUri = GetServicesURL(),
            //            IdentityServerTokenUrl = GetIdentityServerTokenHostURL(),
            //            ClientID = this.tbClientID.Text,
            //            ClientSecret = this.tbClientSecret.Text

            //        };
            //        bool success = oauth2.RetrieveRelativityWorkspaces();
            //        if (success)
            //        {
            //            MessageBox.Show("Successful", "Oauth2", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        }
            //        else
            //        {
            //            MessageBox.Show("Failed", "Oauth2", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show("Failed enumerating workspaces using OAuth2. " + ex.Message + "\n" + ex.StackTrace, "OAuth2 Authorization");
            //    }
            //}

            //if (rbWinAuth.Checked)
            //{
            //    try
            //    {
            //        WinAuth winauth = new WinAuth
            //        {
            //            RestURL = GetRestHostURL(),
            //            ServicesURL = GetServicesURL(),
            //            Username = this.tbUsername.Text,
            //            Password = this.tbPassword.Text
            //        };
            //        bool success = winauth.RetrieveRelativityWorkspaces();
            //        if (success)
            //        {
            //            MessageBox.Show("Successful", "WinAuth", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        }
            //        else
            //        {
            //            MessageBox.Show("Failed", "WinAuth", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show("Failed enumerating workspaces using Windows Auth. " + ex.Message + "\n" + ex.StackTrace, "Windows Authorization");
            //    }
            //}

            if (rbImportAPI.Checked)
            {
                try
                {
                    iAPI iapi = new iAPI();
                    bool success = iapi.Login(this.tbUsername.Text, this.tbPassword.Text, GetWebAPIURL());
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

        //public async Task<global::Relativity.Services.Objects.DataContracts.QueryResult> RetrieveRelativityWorkspaces2()
        //{
        //    Relativity.Services.Objects.DataContracts.QueryResult result = null;

        //    try
        //    {

        //        //  var serviceManager = Relativity.CustomPages.ConnectionHelper.Helper().GetServicesManager();
        //        //using (IObjectManager objectManager = serviceManager.CreateProxy<IObjectManager>(Relativity.API.ExecutionIdentity.CurrentUser))
        //        using (IObjectManager objectManager = GetServiceFactory().CreateProxy<IObjectManager>())
        //        {
        //            NameValueObject currentWorkspaceInfo = new NameValueObject();
        //            var queryRequest = new Relativity.Services.Objects.DataContracts.QueryRequest()
        //            {
        //                ObjectType = new global::Relativity.Services.Objects.DataContracts.ObjectTypeRef { ArtifactTypeID = 8},                             
        //                Fields = new List<global::Relativity.Services.Objects.DataContracts.FieldRef>()	//array of fields to return.  ArtifactId will always be returned.
        //                {
        //                    new global::Relativity.Services.Objects.DataContracts.FieldRef { ArtifactID = new kCura.Relativity.Client.DTOs.FieldValue("Name").ArtifactID },
        //                    new global::Relativity.Services.Objects.DataContracts.FieldRef { ArtifactID = new kCura.Relativity.Client.DTOs.FieldValue("Status").ArtifactID },
        //                },
        //            };
        //            result = await objectManager.QueryAsync(-1, queryRequest, 1, 100);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine("Error loading workspace: " + ex.Message);
        //    }

        //    return result;
        //}

    }
}
