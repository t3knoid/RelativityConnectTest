﻿namespace RelativityConnectTest
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbBaseURL = new System.Windows.Forms.TextBox();
            this.lbServer = new System.Windows.Forms.Label();
            this.btConnect = new System.Windows.Forms.Button();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbUsername = new System.Windows.Forms.Label();
            this.tbClientSecret = new System.Windows.Forms.TextBox();
            this.tbClientID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rbOAuth2 = new System.Windows.Forms.RadioButton();
            this.rbWinAuth = new System.Windows.Forms.RadioButton();
            this.rbImportAPI = new System.Windows.Forms.RadioButton();
            this.llShowPassword = new System.Windows.Forms.LinkLabel();
            this.btReset = new System.Windows.Forms.Button();
            this.gbOauth2 = new System.Windows.Forms.GroupBox();
            this.tbStandardAuth = new System.Windows.Forms.GroupBox();
            this.cbWinAuthPassthru = new System.Windows.Forms.CheckBox();
            this.cbImportAPIPassthru = new System.Windows.Forms.CheckBox();
            this.gbConnectionType = new System.Windows.Forms.GroupBox();
            this.gbConnectionType.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbBaseURL
            // 
            this.tbBaseURL.Location = new System.Drawing.Point(155, 29);
            this.tbBaseURL.Name = "tbBaseURL";
            this.tbBaseURL.Size = new System.Drawing.Size(272, 20);
            this.tbBaseURL.TabIndex = 0;
            // 
            // lbServer
            // 
            this.lbServer.AutoSize = true;
            this.lbServer.Location = new System.Drawing.Point(19, 32);
            this.lbServer.Name = "lbServer";
            this.lbServer.Size = new System.Drawing.Size(93, 13);
            this.lbServer.TabIndex = 1;
            this.lbServer.Text = "Relativity Base Url";
            // 
            // btConnect
            // 
            this.btConnect.Location = new System.Drawing.Point(176, 378);
            this.btConnect.Name = "btConnect";
            this.btConnect.Size = new System.Drawing.Size(75, 23);
            this.btConnect.TabIndex = 11;
            this.btConnect.Text = "Connect";
            this.btConnect.UseVisualStyleBackColor = true;
            this.btConnect.Click += new System.EventHandler(this.btConnect_Click);
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(155, 97);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(172, 20);
            this.tbPassword.TabIndex = 3;
            this.tbPassword.UseSystemPasswordChar = true;
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(155, 71);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(172, 20);
            this.tbUsername.TabIndex = 2;
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(19, 100);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(53, 13);
            this.lbPassword.TabIndex = 5;
            this.lbPassword.Text = "Password";
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Location = new System.Drawing.Point(19, 74);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(55, 13);
            this.lbUsername.TabIndex = 6;
            this.lbUsername.Text = "Username";
            // 
            // tbClientSecret
            // 
            this.tbClientSecret.Location = new System.Drawing.Point(155, 194);
            this.tbClientSecret.Name = "tbClientSecret";
            this.tbClientSecret.PasswordChar = '*';
            this.tbClientSecret.Size = new System.Drawing.Size(272, 20);
            this.tbClientSecret.TabIndex = 7;
            // 
            // tbClientID
            // 
            this.tbClientID.Location = new System.Drawing.Point(155, 168);
            this.tbClientID.Name = "tbClientID";
            this.tbClientID.Size = new System.Drawing.Size(272, 20);
            this.tbClientID.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Client ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Client Secret";
            // 
            // rbOAuth2
            // 
            this.rbOAuth2.AutoSize = true;
            this.rbOAuth2.Location = new System.Drawing.Point(10, 19);
            this.rbOAuth2.Name = "rbOAuth2";
            this.rbOAuth2.Size = new System.Drawing.Size(61, 17);
            this.rbOAuth2.TabIndex = 8;
            this.rbOAuth2.Text = "OAuth2";
            this.rbOAuth2.UseVisualStyleBackColor = true;
            this.rbOAuth2.CheckedChanged += new System.EventHandler(this.rbOAuth2_CheckedChanged);
            // 
            // rbWinAuth
            // 
            this.rbWinAuth.AutoSize = true;
            this.rbWinAuth.Location = new System.Drawing.Point(10, 42);
            this.rbWinAuth.Name = "rbWinAuth";
            this.rbWinAuth.Size = new System.Drawing.Size(66, 17);
            this.rbWinAuth.TabIndex = 9;
            this.rbWinAuth.Text = "WinAuth";
            this.rbWinAuth.UseVisualStyleBackColor = true;
            this.rbWinAuth.CheckedChanged += new System.EventHandler(this.rbWinAuth_CheckedChanged);
            // 
            // rbImportAPI
            // 
            this.rbImportAPI.AutoSize = true;
            this.rbImportAPI.Location = new System.Drawing.Point(10, 65);
            this.rbImportAPI.Name = "rbImportAPI";
            this.rbImportAPI.Size = new System.Drawing.Size(71, 17);
            this.rbImportAPI.TabIndex = 10;
            this.rbImportAPI.Text = "ImportAPI";
            this.rbImportAPI.UseVisualStyleBackColor = true;
            this.rbImportAPI.CheckedChanged += new System.EventHandler(this.rbImportAPI_CheckedChanged);
            // 
            // llShowPassword
            // 
            this.llShowPassword.AutoSize = true;
            this.llShowPassword.Location = new System.Drawing.Point(333, 100);
            this.llShowPassword.Name = "llShowPassword";
            this.llShowPassword.Size = new System.Drawing.Size(34, 13);
            this.llShowPassword.TabIndex = 4;
            this.llShowPassword.TabStop = true;
            this.llShowPassword.Text = "Show";
            this.llShowPassword.MouseDown += new System.Windows.Forms.MouseEventHandler(this.llShowPassword_MouseDown);
            this.llShowPassword.MouseUp += new System.Windows.Forms.MouseEventHandler(this.llShowPassword_MouseUp);
            // 
            // btReset
            // 
            this.btReset.Location = new System.Drawing.Point(364, 239);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(75, 23);
            this.btReset.TabIndex = 12;
            this.btReset.Text = "Reset";
            this.btReset.UseVisualStyleBackColor = true;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // gbOauth2
            // 
            this.gbOauth2.Location = new System.Drawing.Point(12, 145);
            this.gbOauth2.Name = "gbOauth2";
            this.gbOauth2.Size = new System.Drawing.Size(427, 87);
            this.gbOauth2.TabIndex = 21;
            this.gbOauth2.TabStop = false;
            this.gbOauth2.Text = "OAuth2 Settings";
            // 
            // tbStandardAuth
            // 
            this.tbStandardAuth.Location = new System.Drawing.Point(12, 12);
            this.tbStandardAuth.Name = "tbStandardAuth";
            this.tbStandardAuth.Size = new System.Drawing.Size(427, 122);
            this.tbStandardAuth.TabIndex = 22;
            this.tbStandardAuth.TabStop = false;
            this.tbStandardAuth.Text = "Standard Auth";
            // 
            // cbWinAuthPassthru
            // 
            this.cbWinAuthPassthru.AutoSize = true;
            this.cbWinAuthPassthru.Location = new System.Drawing.Point(102, 43);
            this.cbWinAuthPassthru.Name = "cbWinAuthPassthru";
            this.cbWinAuthPassthru.Size = new System.Drawing.Size(74, 17);
            this.cbWinAuthPassthru.TabIndex = 23;
            this.cbWinAuthPassthru.Text = "Pass Thru";
            this.cbWinAuthPassthru.UseVisualStyleBackColor = true;
            this.cbWinAuthPassthru.CheckedChanged += new System.EventHandler(this.cbWinAuthPassthru_CheckedChanged);
            // 
            // cbImportAPIPassthru
            // 
            this.cbImportAPIPassthru.AutoSize = true;
            this.cbImportAPIPassthru.Location = new System.Drawing.Point(102, 66);
            this.cbImportAPIPassthru.Name = "cbImportAPIPassthru";
            this.cbImportAPIPassthru.Size = new System.Drawing.Size(74, 17);
            this.cbImportAPIPassthru.TabIndex = 24;
            this.cbImportAPIPassthru.Text = "Pass Thru";
            this.cbImportAPIPassthru.UseVisualStyleBackColor = true;
            this.cbImportAPIPassthru.CheckedChanged += new System.EventHandler(this.cbImportAPIPassthru_CheckedChanged);
            // 
            // gbConnectionType
            // 
            this.gbConnectionType.Controls.Add(this.cbImportAPIPassthru);
            this.gbConnectionType.Controls.Add(this.rbOAuth2);
            this.gbConnectionType.Controls.Add(this.cbWinAuthPassthru);
            this.gbConnectionType.Controls.Add(this.rbWinAuth);
            this.gbConnectionType.Controls.Add(this.rbImportAPI);
            this.gbConnectionType.Location = new System.Drawing.Point(12, 265);
            this.gbConnectionType.Name = "gbConnectionType";
            this.gbConnectionType.Size = new System.Drawing.Size(427, 91);
            this.gbConnectionType.TabIndex = 25;
            this.gbConnectionType.TabStop = false;
            this.gbConnectionType.Text = "Connection Type";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 414);
            this.Controls.Add(this.btReset);
            this.Controls.Add(this.llShowPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbClientID);
            this.Controls.Add(this.tbClientSecret);
            this.Controls.Add(this.lbUsername);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.btConnect);
            this.Controls.Add(this.lbServer);
            this.Controls.Add(this.tbBaseURL);
            this.Controls.Add(this.gbOauth2);
            this.Controls.Add(this.tbStandardAuth);
            this.Controls.Add(this.gbConnectionType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Relativity Connectivity Test";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbConnectionType.ResumeLayout(false);
            this.gbConnectionType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbBaseURL;
        private System.Windows.Forms.Label lbServer;
        private System.Windows.Forms.Button btConnect;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.TextBox tbClientSecret;
        private System.Windows.Forms.TextBox tbClientID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbOAuth2;
        private System.Windows.Forms.RadioButton rbWinAuth;
        private System.Windows.Forms.RadioButton rbImportAPI;
        private System.Windows.Forms.LinkLabel llShowPassword;
        private System.Windows.Forms.Button btReset;
        private System.Windows.Forms.GroupBox gbOauth2;
        private System.Windows.Forms.GroupBox tbStandardAuth;
        private System.Windows.Forms.CheckBox cbWinAuthPassthru;
        private System.Windows.Forms.CheckBox cbImportAPIPassthru;
        private System.Windows.Forms.GroupBox gbConnectionType;
    }
}

