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
            this.gbProxyConfig.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bSave
            // 
            this.bSave.Location = new System.Drawing.Point(290, 141);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(98, 23);
            this.bSave.TabIndex = 0;
            this.bSave.Text = "Zapisz";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // bReset
            // 
            this.bReset.Location = new System.Drawing.Point(224, 141);
            this.bReset.Name = "bReset";
            this.bReset.Size = new System.Drawing.Size(60, 23);
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
            this.groupBox2.Location = new System.Drawing.Point(224, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(164, 123);
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
            this.cbUnitType.Location = new System.Drawing.Point(91, 70);
            this.cbUnitType.Name = "cbUnitType";
            this.cbUnitType.Size = new System.Drawing.Size(67, 21);
            this.cbUnitType.TabIndex = 2;
            this.cbUnitType.Text = "Obrona";
            // 
            // tbAccountUserPasswd
            // 
            this.tbAccountUserPasswd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbAccountUserPasswd.Location = new System.Drawing.Point(91, 45);
            this.tbAccountUserPasswd.Name = "tbAccountUserPasswd";
            this.tbAccountUserPasswd.Size = new System.Drawing.Size(65, 20);
            this.tbAccountUserPasswd.TabIndex = 1;
            this.tbAccountUserPasswd.UseSystemPasswordChar = true;
            // 
            // tbAccountUser
            // 
            this.tbAccountUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbAccountUser.Location = new System.Drawing.Point(91, 19);
            this.tbAccountUser.Name = "tbAccountUser";
            this.tbAccountUser.Size = new System.Drawing.Size(65, 20);
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
            // ConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 175);
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
    }
}