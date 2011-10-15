namespace PBizBot.View
{
    partial class AccountList
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
            this.pAccounts = new System.Windows.Forms.Panel();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.cbEnabled = new System.Windows.Forms.CheckBox();
            this.tbPasswd = new System.Windows.Forms.TextBox();
            this.cbSentEmail = new System.Windows.Forms.CheckBox();
            this.cbTransferToAccount = new System.Windows.Forms.ComboBox();
            this.pbSettings = new System.Windows.Forms.PictureBox();
            this.pbAdd = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbSettings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // pAccounts
            // 
            this.pAccounts.AutoScroll = true;
            this.pAccounts.Location = new System.Drawing.Point(0, 0);
            this.pAccounts.Name = "pAccounts";
            this.pAccounts.Size = new System.Drawing.Size(968, 155);
            this.pAccounts.TabIndex = 1;
            this.pAccounts.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.pAccounts_ControlAdded);
            this.pAccounts.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.pAccounts_ControlRemoved);
            // 
            // tbLogin
            // 
            this.tbLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbLogin.Location = new System.Drawing.Point(45, 160);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(60, 13);
            this.tbLogin.TabIndex = 2;
            // 
            // cbEnabled
            // 
            this.cbEnabled.AutoSize = true;
            this.cbEnabled.Location = new System.Drawing.Point(24, 160);
            this.cbEnabled.Name = "cbEnabled";
            this.cbEnabled.Size = new System.Drawing.Size(15, 14);
            this.cbEnabled.TabIndex = 9;
            this.cbEnabled.UseVisualStyleBackColor = true;
            // 
            // tbPasswd
            // 
            this.tbPasswd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPasswd.Location = new System.Drawing.Point(107, 160);
            this.tbPasswd.Name = "tbPasswd";
            this.tbPasswd.Size = new System.Drawing.Size(72, 13);
            this.tbPasswd.TabIndex = 10;
            this.tbPasswd.UseSystemPasswordChar = true;
            // 
            // cbSentEmail
            // 
            this.cbSentEmail.AutoSize = true;
            this.cbSentEmail.Location = new System.Drawing.Point(798, 160);
            this.cbSentEmail.Name = "cbSentEmail";
            this.cbSentEmail.Size = new System.Drawing.Size(15, 14);
            this.cbSentEmail.TabIndex = 16;
            this.cbSentEmail.UseVisualStyleBackColor = true;
            // 
            // cbTransferToAccount
            // 
            this.cbTransferToAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTransferToAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbTransferToAccount.ItemHeight = 12;
            this.cbTransferToAccount.Location = new System.Drawing.Point(819, 156);
            this.cbTransferToAccount.MaxDropDownItems = 10;
            this.cbTransferToAccount.Name = "cbTransferToAccount";
            this.cbTransferToAccount.Size = new System.Drawing.Size(80, 20);
            this.cbTransferToAccount.TabIndex = 20;
            // 
            // pbSettings
            // 
            this.pbSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbSettings.Image = global::PBizBot.Properties.Resources.settings;
            this.pbSettings.Location = new System.Drawing.Point(906, 158);
            this.pbSettings.Name = "pbSettings";
            this.pbSettings.Size = new System.Drawing.Size(16, 16);
            this.pbSettings.TabIndex = 21;
            this.pbSettings.TabStop = false;
            // 
            // pbAdd
            // 
            this.pbAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbAdd.Image = global::PBizBot.Properties.Resources.plus;
            this.pbAdd.Location = new System.Drawing.Point(928, 158);
            this.pbAdd.Name = "pbAdd";
            this.pbAdd.Size = new System.Drawing.Size(16, 16);
            this.pbAdd.TabIndex = 22;
            this.pbAdd.TabStop = false;
            this.pbAdd.Click += new System.EventHandler(this.pbAdd_Click);
            // 
            // AccountList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pbAdd);
            this.Controls.Add(this.pbSettings);
            this.Controls.Add(this.cbTransferToAccount);
            this.Controls.Add(this.cbSentEmail);
            this.Controls.Add(this.tbPasswd);
            this.Controls.Add(this.cbEnabled);
            this.Controls.Add(this.tbLogin);
            this.Controls.Add(this.pAccounts);
            this.Name = "AccountList";
            this.Size = new System.Drawing.Size(968, 177);
            ((System.ComponentModel.ISupportInitialize)(this.pbSettings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Panel pAccounts;
        public System.Windows.Forms.TextBox tbLogin;
        public System.Windows.Forms.CheckBox cbEnabled;
        public System.Windows.Forms.TextBox tbPasswd;
        public System.Windows.Forms.CheckBox cbSentEmail;
        public System.Windows.Forms.ComboBox cbTransferToAccount;
        public System.Windows.Forms.PictureBox pbSettings;
        public System.Windows.Forms.PictureBox pbAdd;

    }
}
