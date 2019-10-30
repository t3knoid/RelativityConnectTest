namespace RelativityConnectTest
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
            this.tbRestURL = new System.Windows.Forms.TextBox();
            this.lbServer = new System.Windows.Forms.Label();
            this.btConnect = new System.Windows.Forms.Button();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbUsername = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbServicesURL = new System.Windows.Forms.TextBox();
            this.tbClientSecret = new System.Windows.Forms.TextBox();
            this.tbClientID = new System.Windows.Forms.TextBox();
            this.tbIdentityTokenURL = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rbAuth2 = new System.Windows.Forms.RadioButton();
            this.rbWinAuth = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.rbImportAPI = new System.Windows.Forms.RadioButton();
            this.llShowPassword = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // tbRestURL
            // 
            this.tbRestURL.Location = new System.Drawing.Point(155, 22);
            this.tbRestURL.Name = "tbRestURL";
            this.tbRestURL.Size = new System.Drawing.Size(272, 20);
            this.tbRestURL.TabIndex = 0;
            this.tbRestURL.Text = "https://devaon.myrelativity.legal";
            // 
            // lbServer
            // 
            this.lbServer.AutoSize = true;
            this.lbServer.Location = new System.Drawing.Point(19, 25);
            this.lbServer.Name = "lbServer";
            this.lbServer.Size = new System.Drawing.Size(52, 13);
            this.lbServer.TabIndex = 1;
            this.lbServer.Text = "REST Uri";
            // 
            // btConnect
            // 
            this.btConnect.Location = new System.Drawing.Point(155, 330);
            this.btConnect.Name = "btConnect";
            this.btConnect.Size = new System.Drawing.Size(75, 23);
            this.btConnect.TabIndex = 2;
            this.btConnect.Text = "Connect";
            this.btConnect.UseVisualStyleBackColor = true;
            this.btConnect.Click += new System.EventHandler(this.btConnect_Click);
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(155, 99);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(172, 20);
            this.tbPassword.TabIndex = 3;
            this.tbPassword.UseSystemPasswordChar = true;
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(155, 73);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(172, 20);
            this.tbUsername.TabIndex = 4;
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(19, 102);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(53, 13);
            this.lbPassword.TabIndex = 5;
            this.lbPassword.Text = "Password";
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Location = new System.Drawing.Point(19, 76);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(55, 13);
            this.lbUsername.TabIndex = 6;
            this.lbUsername.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Services Uri";
            // 
            // tbServicesURL
            // 
            this.tbServicesURL.Location = new System.Drawing.Point(155, 48);
            this.tbServicesURL.Name = "tbServicesURL";
            this.tbServicesURL.Size = new System.Drawing.Size(272, 20);
            this.tbServicesURL.TabIndex = 7;
            this.tbServicesURL.Text = "https://devaonapi.myrelativity.legal";
            // 
            // tbClientSecret
            // 
            this.tbClientSecret.Location = new System.Drawing.Point(155, 208);
            this.tbClientSecret.Name = "tbClientSecret";
            this.tbClientSecret.PasswordChar = '*';
            this.tbClientSecret.Size = new System.Drawing.Size(272, 20);
            this.tbClientSecret.TabIndex = 9;
            // 
            // tbClientID
            // 
            this.tbClientID.Location = new System.Drawing.Point(155, 182);
            this.tbClientID.Name = "tbClientID";
            this.tbClientID.Size = new System.Drawing.Size(272, 20);
            this.tbClientID.TabIndex = 10;
            // 
            // tbIdentityTokenURL
            // 
            this.tbIdentityTokenURL.Location = new System.Drawing.Point(155, 156);
            this.tbIdentityTokenURL.Name = "tbIdentityTokenURL";
            this.tbIdentityTokenURL.Size = new System.Drawing.Size(272, 20);
            this.tbIdentityTokenURL.TabIndex = 11;
            this.tbIdentityTokenURL.Text = "https://aon.myrelativity.legal/Relativity/Identity/connect/token";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Identity Server Token URL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Client ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Client Secret";
            // 
            // rbAuth2
            // 
            this.rbAuth2.AutoSize = true;
            this.rbAuth2.Location = new System.Drawing.Point(155, 256);
            this.rbAuth2.Name = "rbAuth2";
            this.rbAuth2.Size = new System.Drawing.Size(61, 17);
            this.rbAuth2.TabIndex = 15;
            this.rbAuth2.Text = "OAuth2";
            this.rbAuth2.UseVisualStyleBackColor = true;
            // 
            // rbWinAuth
            // 
            this.rbWinAuth.AutoSize = true;
            this.rbWinAuth.Checked = true;
            this.rbWinAuth.Location = new System.Drawing.Point(155, 279);
            this.rbWinAuth.Name = "rbWinAuth";
            this.rbWinAuth.Size = new System.Drawing.Size(66, 17);
            this.rbWinAuth.TabIndex = 16;
            this.rbWinAuth.TabStop = true;
            this.rbWinAuth.Text = "WinAuth";
            this.rbWinAuth.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Authorization Type";
            // 
            // rbImportAPI
            // 
            this.rbImportAPI.AutoSize = true;
            this.rbImportAPI.Location = new System.Drawing.Point(155, 302);
            this.rbImportAPI.Name = "rbImportAPI";
            this.rbImportAPI.Size = new System.Drawing.Size(71, 17);
            this.rbImportAPI.TabIndex = 18;
            this.rbImportAPI.Text = "ImportAPI";
            this.rbImportAPI.UseVisualStyleBackColor = true;
            // 
            // llShowPassword
            // 
            this.llShowPassword.AutoSize = true;
            this.llShowPassword.Location = new System.Drawing.Point(333, 102);
            this.llShowPassword.Name = "llShowPassword";
            this.llShowPassword.Size = new System.Drawing.Size(34, 13);
            this.llShowPassword.TabIndex = 19;
            this.llShowPassword.TabStop = true;
            this.llShowPassword.Text = "Show";
            this.llShowPassword.MouseDown += new System.Windows.Forms.MouseEventHandler(this.llShowPassword_MouseDown);
            this.llShowPassword.MouseUp += new System.Windows.Forms.MouseEventHandler(this.llShowPassword_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 384);
            this.Controls.Add(this.llShowPassword);
            this.Controls.Add(this.rbImportAPI);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rbWinAuth);
            this.Controls.Add(this.rbAuth2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbIdentityTokenURL);
            this.Controls.Add(this.tbClientID);
            this.Controls.Add(this.tbClientSecret);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbServicesURL);
            this.Controls.Add(this.lbUsername);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.btConnect);
            this.Controls.Add(this.lbServer);
            this.Controls.Add(this.tbRestURL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Relativity Connectivity Test";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbRestURL;
        private System.Windows.Forms.Label lbServer;
        private System.Windows.Forms.Button btConnect;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbServicesURL;
        private System.Windows.Forms.TextBox tbClientSecret;
        private System.Windows.Forms.TextBox tbClientID;
        private System.Windows.Forms.TextBox tbIdentityTokenURL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbAuth2;
        private System.Windows.Forms.RadioButton rbWinAuth;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbImportAPI;
        private System.Windows.Forms.LinkLabel llShowPassword;
    }
}

