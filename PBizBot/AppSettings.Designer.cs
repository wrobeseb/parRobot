namespace PBizBot
{
    partial class AppSettings
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
            this.label9 = new System.Windows.Forms.Label();
            this.cbProxyYesOrNo = new System.Windows.Forms.ComboBox();
            this.gbProxyConfig = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbProxyPassword = new System.Windows.Forms.TextBox();
            this.tbProxyUser = new System.Windows.Forms.TextBox();
            this.tbProxyDomain = new System.Windows.Forms.TextBox();
            this.tbProxyPort = new System.Windows.Forms.TextBox();
            this.tbProxyHost = new System.Windows.Forms.TextBox();
            this.bReset = new System.Windows.Forms.Button();
            this.bSave = new System.Windows.Forms.Button();
            this.cbSentMail = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gbMailConfig = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.tbMailSubject = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.tbMailTo = new System.Windows.Forms.TextBox();
            this.tbSmtpAccountPasswd = new System.Windows.Forms.TextBox();
            this.tbSmtpAccount = new System.Windows.Forms.TextBox();
            this.tbSmtpPort = new System.Windows.Forms.TextBox();
            this.tbSmtpHost = new System.Windows.Forms.TextBox();
            this.cbEnableSSL = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.gbProxyConfig.SuspendLayout();
            this.gbMailConfig.SuspendLayout();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Korzystaj z proxy";
            // 
            // cbProxyYesOrNo
            // 
            this.cbProxyYesOrNo.FormattingEnabled = true;
            this.cbProxyYesOrNo.Items.AddRange(new object[] {
            "Tak",
            "Nie"});
            this.cbProxyYesOrNo.Location = new System.Drawing.Point(109, 8);
            this.cbProxyYesOrNo.Name = "cbProxyYesOrNo";
            this.cbProxyYesOrNo.Size = new System.Drawing.Size(109, 21);
            this.cbProxyYesOrNo.TabIndex = 7;
            this.cbProxyYesOrNo.Text = "Nie";
            this.cbProxyYesOrNo.SelectedIndexChanged += new System.EventHandler(this.cbProxyYesOrNo_SelectedIndexChanged);
            // 
            // gbProxyConfig
            // 
            this.gbProxyConfig.Controls.Add(this.label5);
            this.gbProxyConfig.Controls.Add(this.label3);
            this.gbProxyConfig.Controls.Add(this.label2);
            this.gbProxyConfig.Controls.Add(this.label1);
            this.gbProxyConfig.Controls.Add(this.tbProxyPassword);
            this.gbProxyConfig.Controls.Add(this.tbProxyUser);
            this.gbProxyConfig.Controls.Add(this.tbProxyDomain);
            this.gbProxyConfig.Controls.Add(this.tbProxyPort);
            this.gbProxyConfig.Controls.Add(this.tbProxyHost);
            this.gbProxyConfig.Enabled = false;
            this.gbProxyConfig.Location = new System.Drawing.Point(12, 35);
            this.gbProxyConfig.Name = "gbProxyConfig";
            this.gbProxyConfig.Size = new System.Drawing.Size(206, 121);
            this.gbProxyConfig.TabIndex = 6;
            this.gbProxyConfig.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Użyszkodnik";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Hasło";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Domena";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Host/Port";
            // 
            // tbProxyPassword
            // 
            this.tbProxyPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbProxyPassword.Location = new System.Drawing.Point(78, 92);
            this.tbProxyPassword.Name = "tbProxyPassword";
            this.tbProxyPassword.Size = new System.Drawing.Size(122, 20);
            this.tbProxyPassword.TabIndex = 4;
            this.tbProxyPassword.UseSystemPasswordChar = true;
            // 
            // tbProxyUser
            // 
            this.tbProxyUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbProxyUser.Location = new System.Drawing.Point(78, 66);
            this.tbProxyUser.Name = "tbProxyUser";
            this.tbProxyUser.Size = new System.Drawing.Size(122, 20);
            this.tbProxyUser.TabIndex = 3;
            // 
            // tbProxyDomain
            // 
            this.tbProxyDomain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbProxyDomain.Location = new System.Drawing.Point(78, 40);
            this.tbProxyDomain.Name = "tbProxyDomain";
            this.tbProxyDomain.Size = new System.Drawing.Size(122, 20);
            this.tbProxyDomain.TabIndex = 2;
            // 
            // tbProxyPort
            // 
            this.tbProxyPort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbProxyPort.Location = new System.Drawing.Point(169, 14);
            this.tbProxyPort.Name = "tbProxyPort";
            this.tbProxyPort.Size = new System.Drawing.Size(31, 20);
            this.tbProxyPort.TabIndex = 1;
            this.tbProxyPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbProxyHost
            // 
            this.tbProxyHost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbProxyHost.Location = new System.Drawing.Point(78, 14);
            this.tbProxyHost.Name = "tbProxyHost";
            this.tbProxyHost.Size = new System.Drawing.Size(85, 20);
            this.tbProxyHost.TabIndex = 0;
            this.tbProxyHost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bReset
            // 
            this.bReset.Location = new System.Drawing.Point(12, 162);
            this.bReset.Name = "bReset";
            this.bReset.Size = new System.Drawing.Size(73, 39);
            this.bReset.TabIndex = 10;
            this.bReset.Text = "Wyczyść";
            this.bReset.UseVisualStyleBackColor = true;
            this.bReset.Click += new System.EventHandler(this.bReset_Click);
            // 
            // bSave
            // 
            this.bSave.Location = new System.Drawing.Point(90, 162);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(128, 39);
            this.bSave.TabIndex = 9;
            this.bSave.Text = "Zapisz";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // cbSentMail
            // 
            this.cbSentMail.FormattingEnabled = true;
            this.cbSentMail.Items.AddRange(new object[] {
            "Tak",
            "Nie"});
            this.cbSentMail.Location = new System.Drawing.Point(321, 8);
            this.cbSentMail.Name = "cbSentMail";
            this.cbSentMail.Size = new System.Drawing.Size(109, 21);
            this.cbSentMail.TabIndex = 11;
            this.cbSentMail.Text = "Nie";
            this.cbSentMail.SelectedIndexChanged += new System.EventHandler(this.cbSentMail_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(223, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Wysyłaj maile";
            // 
            // gbMailConfig
            // 
            this.gbMailConfig.Controls.Add(this.label18);
            this.gbMailConfig.Controls.Add(this.tbMailSubject);
            this.gbMailConfig.Controls.Add(this.label17);
            this.gbMailConfig.Controls.Add(this.tbMailTo);
            this.gbMailConfig.Controls.Add(this.tbSmtpAccountPasswd);
            this.gbMailConfig.Controls.Add(this.tbSmtpAccount);
            this.gbMailConfig.Controls.Add(this.tbSmtpPort);
            this.gbMailConfig.Controls.Add(this.tbSmtpHost);
            this.gbMailConfig.Controls.Add(this.cbEnableSSL);
            this.gbMailConfig.Controls.Add(this.label12);
            this.gbMailConfig.Controls.Add(this.label11);
            this.gbMailConfig.Controls.Add(this.label10);
            this.gbMailConfig.Enabled = false;
            this.gbMailConfig.Location = new System.Drawing.Point(224, 35);
            this.gbMailConfig.Name = "gbMailConfig";
            this.gbMailConfig.Size = new System.Drawing.Size(206, 166);
            this.gbMailConfig.TabIndex = 12;
            this.gbMailConfig.TabStop = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(7, 120);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(35, 13);
            this.label18.TabIndex = 11;
            this.label18.Text = "Tytuł:";
            // 
            // tbMailSubject
            // 
            this.tbMailSubject.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbMailSubject.Location = new System.Drawing.Point(78, 118);
            this.tbMailSubject.Name = "tbMailSubject";
            this.tbMailSubject.Size = new System.Drawing.Size(122, 20);
            this.tbMailSubject.TabIndex = 10;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(7, 94);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(24, 13);
            this.label17.TabIndex = 9;
            this.label17.Text = "Do:";
            // 
            // tbMailTo
            // 
            this.tbMailTo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbMailTo.Location = new System.Drawing.Point(78, 92);
            this.tbMailTo.Name = "tbMailTo";
            this.tbMailTo.Size = new System.Drawing.Size(122, 20);
            this.tbMailTo.TabIndex = 8;
            // 
            // tbSmtpAccountPasswd
            // 
            this.tbSmtpAccountPasswd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSmtpAccountPasswd.Location = new System.Drawing.Point(78, 66);
            this.tbSmtpAccountPasswd.Name = "tbSmtpAccountPasswd";
            this.tbSmtpAccountPasswd.Size = new System.Drawing.Size(122, 20);
            this.tbSmtpAccountPasswd.TabIndex = 7;
            this.tbSmtpAccountPasswd.UseSystemPasswordChar = true;
            // 
            // tbSmtpAccount
            // 
            this.tbSmtpAccount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSmtpAccount.Location = new System.Drawing.Point(78, 39);
            this.tbSmtpAccount.Name = "tbSmtpAccount";
            this.tbSmtpAccount.Size = new System.Drawing.Size(122, 20);
            this.tbSmtpAccount.TabIndex = 6;
            // 
            // tbSmtpPort
            // 
            this.tbSmtpPort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSmtpPort.Location = new System.Drawing.Point(169, 14);
            this.tbSmtpPort.Name = "tbSmtpPort";
            this.tbSmtpPort.Size = new System.Drawing.Size(31, 20);
            this.tbSmtpPort.TabIndex = 5;
            // 
            // tbSmtpHost
            // 
            this.tbSmtpHost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSmtpHost.Location = new System.Drawing.Point(78, 14);
            this.tbSmtpHost.Name = "tbSmtpHost";
            this.tbSmtpHost.Size = new System.Drawing.Size(85, 20);
            this.tbSmtpHost.TabIndex = 4;
            // 
            // cbEnableSSL
            // 
            this.cbEnableSSL.AutoSize = true;
            this.cbEnableSSL.Location = new System.Drawing.Point(9, 143);
            this.cbEnableSSL.Name = "cbEnableSSL";
            this.cbEnableSSL.Size = new System.Drawing.Size(99, 17);
            this.cbEnableSSL.TabIndex = 3;
            this.cbEnableSSL.Text = "Korzystaj z SSL";
            this.cbEnableSSL.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 68);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "Hasło";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 42);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Adres email";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Host/Port";
            // 
            // AppSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 210);
            this.Controls.Add(this.cbSentMail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gbMailConfig);
            this.Controls.Add(this.bReset);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbProxyYesOrNo);
            this.Controls.Add(this.gbProxyConfig);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AppSettings";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Application Settings";
            this.Load += new System.EventHandler(this.AppSettings_Load);
            this.gbProxyConfig.ResumeLayout(false);
            this.gbProxyConfig.PerformLayout();
            this.gbMailConfig.ResumeLayout(false);
            this.gbMailConfig.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbProxyYesOrNo;
        private System.Windows.Forms.GroupBox gbProxyConfig;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbProxyPassword;
        private System.Windows.Forms.TextBox tbProxyUser;
        private System.Windows.Forms.TextBox tbProxyDomain;
        private System.Windows.Forms.TextBox tbProxyPort;
        private System.Windows.Forms.TextBox tbProxyHost;
        private System.Windows.Forms.Button bReset;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.ComboBox cbSentMail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbMailConfig;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox tbMailSubject;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox tbMailTo;
        private System.Windows.Forms.TextBox tbSmtpAccountPasswd;
        private System.Windows.Forms.TextBox tbSmtpAccount;
        private System.Windows.Forms.TextBox tbSmtpPort;
        private System.Windows.Forms.TextBox tbSmtpHost;
        private System.Windows.Forms.CheckBox cbEnableSSL;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
    }
}