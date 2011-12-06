namespace ParafiaPRO.View.Impl
{
    partial class SettingsPanelViewImpl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbSmtpMainSwitch = new System.Windows.Forms.CheckBox();
            this.gbSyncAccount = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbSyncPasswd = new System.Windows.Forms.TextBox();
            this.tbSyncLogin = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbSyncTimeSwitch = new System.Windows.Forms.CheckBox();
            this.cbProxyEnabled = new System.Windows.Forms.CheckBox();
            this.gbSmtp = new System.Windows.Forms.GroupBox();
            this.gbProxy = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbProxyPasswd = new System.Windows.Forms.TextBox();
            this.tbProxyLogin = new System.Windows.Forms.TextBox();
            this.tbProxyPort = new System.Windows.Forms.TextBox();
            this.tbProxyAddress = new System.Windows.Forms.TextBox();
            this.btSave = new System.Windows.Forms.Button();
            this.tbProxyDomain = new System.Windows.Forms.TextBox();
            this.gbSyncAccount.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbProxy.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbSmtpMainSwitch
            // 
            this.cbSmtpMainSwitch.AutoSize = true;
            this.cbSmtpMainSwitch.Location = new System.Drawing.Point(6, 33);
            this.cbSmtpMainSwitch.Name = "cbSmtpMainSwitch";
            this.cbSmtpMainSwitch.Size = new System.Drawing.Size(152, 17);
            this.cbSmtpMainSwitch.TabIndex = 5;
            this.cbSmtpMainSwitch.Text = "Notyfikacja poprzez SMTP";
            this.cbSmtpMainSwitch.UseVisualStyleBackColor = true;
            this.cbSmtpMainSwitch.CheckedChanged += new System.EventHandler(this.cbSmtpMainSwitch_CheckedChanged);
            // 
            // gbSyncAccount
            // 
            this.gbSyncAccount.Controls.Add(this.label5);
            this.gbSyncAccount.Controls.Add(this.label4);
            this.gbSyncAccount.Controls.Add(this.tbSyncPasswd);
            this.gbSyncAccount.Controls.Add(this.tbSyncLogin);
            this.gbSyncAccount.Enabled = false;
            this.gbSyncAccount.Location = new System.Drawing.Point(179, 96);
            this.gbSyncAccount.Name = "gbSyncAccount";
            this.gbSyncAccount.Size = new System.Drawing.Size(189, 92);
            this.gbSyncAccount.TabIndex = 4;
            this.gbSyncAccount.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Hasło";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Login";
            // 
            // tbSyncPasswd
            // 
            this.tbSyncPasswd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSyncPasswd.Location = new System.Drawing.Point(50, 42);
            this.tbSyncPasswd.Name = "tbSyncPasswd";
            this.tbSyncPasswd.Size = new System.Drawing.Size(133, 20);
            this.tbSyncPasswd.TabIndex = 1;
            this.tbSyncPasswd.UseSystemPasswordChar = true;
            // 
            // tbSyncLogin
            // 
            this.tbSyncLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSyncLogin.Location = new System.Drawing.Point(50, 15);
            this.tbSyncLogin.Name = "tbSyncLogin";
            this.tbSyncLogin.Size = new System.Drawing.Size(133, 20);
            this.tbSyncLogin.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbSyncTimeSwitch);
            this.groupBox1.Controls.Add(this.cbSmtpMainSwitch);
            this.groupBox1.Controls.Add(this.cbProxyEnabled);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(173, 159);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // cbSyncTimeSwitch
            // 
            this.cbSyncTimeSwitch.AutoSize = true;
            this.cbSyncTimeSwitch.Location = new System.Drawing.Point(6, 53);
            this.cbSyncTimeSwitch.Name = "cbSyncTimeSwitch";
            this.cbSyncTimeSwitch.Size = new System.Drawing.Size(111, 17);
            this.cbSyncTimeSwitch.TabIndex = 6;
            this.cbSyncTimeSwitch.Text = "Synchronizuj czas";
            this.cbSyncTimeSwitch.UseVisualStyleBackColor = true;
            this.cbSyncTimeSwitch.CheckedChanged += new System.EventHandler(this.cbSyncTimeSwitch_CheckedChanged);
            // 
            // cbProxyEnabled
            // 
            this.cbProxyEnabled.AutoSize = true;
            this.cbProxyEnabled.Location = new System.Drawing.Point(6, 13);
            this.cbProxyEnabled.Name = "cbProxyEnabled";
            this.cbProxyEnabled.Size = new System.Drawing.Size(148, 17);
            this.cbProxyEnabled.TabIndex = 2;
            this.cbProxyEnabled.Text = "Połączenie poprzez proxy";
            this.cbProxyEnabled.UseVisualStyleBackColor = true;
            this.cbProxyEnabled.CheckedChanged += new System.EventHandler(this.cbProxyEnabled_CheckedChanged);
            // 
            // gbSmtp
            // 
            this.gbSmtp.Enabled = false;
            this.gbSmtp.Location = new System.Drawing.Point(374, 0);
            this.gbSmtp.Name = "gbSmtp";
            this.gbSmtp.Size = new System.Drawing.Size(152, 188);
            this.gbSmtp.TabIndex = 1;
            this.gbSmtp.TabStop = false;
            // 
            // gbProxy
            // 
            this.gbProxy.Controls.Add(this.tbProxyDomain);
            this.gbProxy.Controls.Add(this.label3);
            this.gbProxy.Controls.Add(this.label2);
            this.gbProxy.Controls.Add(this.label1);
            this.gbProxy.Controls.Add(this.tbProxyPasswd);
            this.gbProxy.Controls.Add(this.tbProxyLogin);
            this.gbProxy.Controls.Add(this.tbProxyPort);
            this.gbProxy.Controls.Add(this.tbProxyAddress);
            this.gbProxy.Enabled = false;
            this.gbProxy.Location = new System.Drawing.Point(179, 0);
            this.gbProxy.Name = "gbProxy";
            this.gbProxy.Size = new System.Drawing.Size(189, 96);
            this.gbProxy.TabIndex = 0;
            this.gbProxy.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Hasło";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Login";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "IP/Port";
            // 
            // tbProxyPasswd
            // 
            this.tbProxyPasswd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbProxyPasswd.Location = new System.Drawing.Point(50, 67);
            this.tbProxyPasswd.Name = "tbProxyPasswd";
            this.tbProxyPasswd.Size = new System.Drawing.Size(133, 20);
            this.tbProxyPasswd.TabIndex = 3;
            this.tbProxyPasswd.UseSystemPasswordChar = true;
            // 
            // tbProxyLogin
            // 
            this.tbProxyLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbProxyLogin.Location = new System.Drawing.Point(87, 41);
            this.tbProxyLogin.Name = "tbProxyLogin";
            this.tbProxyLogin.Size = new System.Drawing.Size(96, 20);
            this.tbProxyLogin.TabIndex = 2;
            // 
            // tbProxyPort
            // 
            this.tbProxyPort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbProxyPort.Location = new System.Drawing.Point(142, 15);
            this.tbProxyPort.Name = "tbProxyPort";
            this.tbProxyPort.Size = new System.Drawing.Size(41, 20);
            this.tbProxyPort.TabIndex = 1;
            // 
            // tbProxyAddress
            // 
            this.tbProxyAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbProxyAddress.Location = new System.Drawing.Point(50, 15);
            this.tbProxyAddress.Name = "tbProxyAddress";
            this.tbProxyAddress.Size = new System.Drawing.Size(91, 20);
            this.tbProxyAddress.TabIndex = 0;
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(0, 165);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(173, 23);
            this.btSave.TabIndex = 7;
            this.btSave.Text = "Zapisz";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // tbProxyDomain
            // 
            this.tbProxyDomain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbProxyDomain.Location = new System.Drawing.Point(50, 41);
            this.tbProxyDomain.Name = "tbProxyDomain";
            this.tbProxyDomain.Size = new System.Drawing.Size(36, 20);
            this.tbProxyDomain.TabIndex = 7;
            // 
            // SettingsPanelViewImpl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.gbSyncAccount);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbSmtp);
            this.Controls.Add(this.gbProxy);
            this.Name = "SettingsPanelViewImpl";
            this.Size = new System.Drawing.Size(532, 190);
            this.gbSyncAccount.ResumeLayout(false);
            this.gbSyncAccount.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbProxy.ResumeLayout(false);
            this.gbProxy.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbProxy;
        private System.Windows.Forms.GroupBox gbSmtp;
        private System.Windows.Forms.TextBox tbProxyPasswd;
        private System.Windows.Forms.TextBox tbProxyLogin;
        private System.Windows.Forms.TextBox tbProxyPort;
        private System.Windows.Forms.TextBox tbProxyAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbProxyEnabled;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gbSyncAccount;
        private System.Windows.Forms.CheckBox cbSmtpMainSwitch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbSyncPasswd;
        private System.Windows.Forms.TextBox tbSyncLogin;
        private System.Windows.Forms.CheckBox cbSyncTimeSwitch;
        public System.Windows.Forms.Button btSave;
        private System.Windows.Forms.TextBox tbProxyDomain;
    }
}
