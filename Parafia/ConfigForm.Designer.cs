namespace Parafia
{
    partial class ConfigForm
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
            this.bSave = new System.Windows.Forms.Button();
            this.bReset = new System.Windows.Forms.Button();
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbSendPilgrimage = new System.Windows.Forms.CheckBox();
            this.cbUnitType = new System.Windows.Forms.ComboBox();
            this.tbAccountUserPasswd = new System.Windows.Forms.TextBox();
            this.tbAccountUser = new System.Windows.Forms.TextBox();
            this.cbProxyYesOrNo = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
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
            this.label4 = new System.Windows.Forms.Label();
            this.cbSentMail = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbArmyTimeStop = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tbArmyTimeStart = new System.Windows.Forms.TextBox();
            this.tbMasterLogin = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.tbMasterPassword = new System.Windows.Forms.TextBox();
            this.gbProxyConfig.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbMailConfig.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // bSave
            // 
            this.bSave.Location = new System.Drawing.Point(90, 299);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(508, 39);
            this.bSave.TabIndex = 0;
            this.bSave.Text = "Zapisz";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // bReset
            // 
            this.bReset.Location = new System.Drawing.Point(12, 299);
            this.bReset.Name = "bReset";
            this.bReset.Size = new System.Drawing.Size(72, 39);
            this.bReset.TabIndex = 1;
            this.bReset.Text = "Wyczyść";
            this.bReset.UseVisualStyleBackColor = true;
            this.bReset.Click += new System.EventHandler(this.bReset_Click);
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
            this.gbProxyConfig.Location = new System.Drawing.Point(12, 43);
            this.gbProxyConfig.Name = "gbProxyConfig";
            this.gbProxyConfig.Size = new System.Drawing.Size(206, 121);
            this.gbProxyConfig.TabIndex = 2;
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cbSendPilgrimage);
            this.groupBox2.Controls.Add(this.cbUnitType);
            this.groupBox2.Controls.Add(this.tbAccountUserPasswd);
            this.groupBox2.Controls.Add(this.tbAccountUser);
            this.groupBox2.Location = new System.Drawing.Point(12, 170);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(206, 123);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ustawienia konta";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Co kupować?";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Hasło";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Użyszkodnik";
            // 
            // cbSendPilgrimage
            // 
            this.cbSendPilgrimage.AutoSize = true;
            this.cbSendPilgrimage.Location = new System.Drawing.Point(9, 97);
            this.cbSendPilgrimage.Name = "cbSendPilgrimage";
            this.cbSendPilgrimage.Size = new System.Drawing.Size(118, 17);
            this.cbSendPilgrimage.TabIndex = 3;
            this.cbSendPilgrimage.Text = "Wysyłaj pielgrzymki";
            this.cbSendPilgrimage.UseVisualStyleBackColor = true;
            // 
            // cbUnitType
            // 
            this.cbUnitType.FormattingEnabled = true;
            this.cbUnitType.Items.AddRange(new object[] {
            "Obrona",
            "Atak"});
            this.cbUnitType.Location = new System.Drawing.Point(139, 70);
            this.cbUnitType.Name = "cbUnitType";
            this.cbUnitType.Size = new System.Drawing.Size(61, 21);
            this.cbUnitType.TabIndex = 2;
            this.cbUnitType.Text = "Obrona";
            // 
            // tbAccountUserPasswd
            // 
            this.tbAccountUserPasswd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbAccountUserPasswd.Location = new System.Drawing.Point(91, 45);
            this.tbAccountUserPasswd.Name = "tbAccountUserPasswd";
            this.tbAccountUserPasswd.Size = new System.Drawing.Size(109, 20);
            this.tbAccountUserPasswd.TabIndex = 1;
            this.tbAccountUserPasswd.UseSystemPasswordChar = true;
            // 
            // tbAccountUser
            // 
            this.tbAccountUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbAccountUser.Location = new System.Drawing.Point(91, 19);
            this.tbAccountUser.Name = "tbAccountUser";
            this.tbAccountUser.Size = new System.Drawing.Size(109, 20);
            this.tbAccountUser.TabIndex = 0;
            // 
            // cbProxyYesOrNo
            // 
            this.cbProxyYesOrNo.FormattingEnabled = true;
            this.cbProxyYesOrNo.Items.AddRange(new object[] {
            "Tak",
            "Nie"});
            this.cbProxyYesOrNo.Location = new System.Drawing.Point(109, 16);
            this.cbProxyYesOrNo.Name = "cbProxyYesOrNo";
            this.cbProxyYesOrNo.Size = new System.Drawing.Size(109, 21);
            this.cbProxyYesOrNo.TabIndex = 4;
            this.cbProxyYesOrNo.Text = "Nie";
            this.cbProxyYesOrNo.SelectedValueChanged += new System.EventHandler(this.cbProxyYesOrNo_SelectedValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Korzystaj z proxy";
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
            this.gbMailConfig.Location = new System.Drawing.Point(225, 43);
            this.gbMailConfig.Name = "gbMailConfig";
            this.gbMailConfig.Size = new System.Drawing.Size(206, 166);
            this.gbMailConfig.TabIndex = 6;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(224, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Wysyłaj maile";
            // 
            // cbSentMail
            // 
            this.cbSentMail.FormattingEnabled = true;
            this.cbSentMail.Items.AddRange(new object[] {
            "Tak",
            "Nie"});
            this.cbSentMail.Location = new System.Drawing.Point(322, 16);
            this.cbSentMail.Name = "cbSentMail";
            this.cbSentMail.Size = new System.Drawing.Size(109, 21);
            this.cbSentMail.TabIndex = 5;
            this.cbSentMail.Text = "Nie";
            this.cbSentMail.SelectedIndexChanged += new System.EventHandler(this.cbSentMail_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbArmyTimeStop);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.tbArmyTimeStart);
            this.groupBox1.Location = new System.Drawing.Point(225, 215);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(206, 78);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Wojsko";
            // 
            // tbArmyTimeStop
            // 
            this.tbArmyTimeStop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbArmyTimeStop.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbArmyTimeStop.Location = new System.Drawing.Point(34, 45);
            this.tbArmyTimeStop.Name = "tbArmyTimeStop";
            this.tbArmyTimeStop.Size = new System.Drawing.Size(166, 20);
            this.tbArmyTimeStop.TabIndex = 4;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 47);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(22, 13);
            this.label14.TabIndex = 3;
            this.label14.Text = "do:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 21);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(22, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "od:";
            // 
            // tbArmyTimeStart
            // 
            this.tbArmyTimeStart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbArmyTimeStart.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbArmyTimeStart.Location = new System.Drawing.Point(34, 19);
            this.tbArmyTimeStart.Name = "tbArmyTimeStart";
            this.tbArmyTimeStart.Size = new System.Drawing.Size(166, 20);
            this.tbArmyTimeStart.TabIndex = 0;
            // 
            // tbMasterLogin
            // 
            this.tbMasterLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbMasterLogin.Location = new System.Drawing.Point(45, 14);
            this.tbMasterLogin.Name = "tbMasterLogin";
            this.tbMasterLogin.Size = new System.Drawing.Size(100, 20);
            this.tbMasterLogin.TabIndex = 9;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.tbMasterPassword);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.tbMasterLogin);
            this.groupBox3.Location = new System.Drawing.Point(437, 43);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(161, 72);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 16);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(33, 13);
            this.label15.TabIndex = 10;
            this.label15.Text = "Login";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 42);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(36, 13);
            this.label16.TabIndex = 12;
            this.label16.Text = "Hasło";
            // 
            // tbMasterPassword
            // 
            this.tbMasterPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbMasterPassword.Location = new System.Drawing.Point(45, 39);
            this.tbMasterPassword.Name = "tbMasterPassword";
            this.tbMasterPassword.Size = new System.Drawing.Size(100, 20);
            this.tbMasterPassword.TabIndex = 11;
            // 
            // ConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 344);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbSentMail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gbMailConfig);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbProxyYesOrNo);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbProxyConfig);
            this.Controls.Add(this.bReset);
            this.Controls.Add(this.bSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConfigForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ustawienia";
            this.Load += new System.EventHandler(this.ConfigForm_Load);
            this.gbProxyConfig.ResumeLayout(false);
            this.gbProxyConfig.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbMailConfig.ResumeLayout(false);
            this.gbMailConfig.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.Button bReset;
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
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox cbSendPilgrimage;
        private System.Windows.Forms.ComboBox cbUnitType;
        private System.Windows.Forms.TextBox tbAccountUserPasswd;
        private System.Windows.Forms.TextBox tbAccountUser;
        private System.Windows.Forms.ComboBox cbProxyYesOrNo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox gbMailConfig;
        private System.Windows.Forms.TextBox tbSmtpAccountPasswd;
        private System.Windows.Forms.TextBox tbSmtpAccount;
        private System.Windows.Forms.TextBox tbSmtpPort;
        private System.Windows.Forms.TextBox tbSmtpHost;
        private System.Windows.Forms.CheckBox cbEnableSSL;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbSentMail;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbArmyTimeStop;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbArmyTimeStart;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox tbMailSubject;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox tbMailTo;
        private System.Windows.Forms.TextBox tbMasterLogin;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tbMasterPassword;
        private System.Windows.Forms.Label label15;
    }
}