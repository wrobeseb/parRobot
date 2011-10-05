namespace PBizBot.View
{
    partial class AccountDetailsControl
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
            this.tbCash = new System.Windows.Forms.TextBox();
            this.tbSafe = new System.Windows.Forms.TextBox();
            this.tbNextLogin = new System.Windows.Forms.TextBox();
            this.cbEnabled = new System.Windows.Forms.CheckBox();
            this.tbMailMessages = new System.Windows.Forms.TextBox();
            this.lbSettings = new System.Windows.Forms.LinkLabel();
            this.tbAttack = new System.Windows.Forms.TextBox();
            this.tbDefense = new System.Windows.Forms.TextBox();
            this.tbHitCount = new System.Windows.Forms.TextBox();
            this.cbSentEmail = new System.Windows.Forms.CheckBox();
            this.rbSelectedAccount = new System.Windows.Forms.RadioButton();
            this.cbTransferToAccount = new System.Windows.Forms.ComboBox();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.tbPasswd = new System.Windows.Forms.TextBox();
            this.pbMinus = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinus)).BeginInit();
            this.SuspendLayout();
            // 
            // tbCash
            // 
            this.tbCash.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbCash.Location = new System.Drawing.Point(181, 4);
            this.tbCash.Name = "tbCash";
            this.tbCash.ReadOnly = true;
            this.tbCash.Size = new System.Drawing.Size(150, 13);
            this.tbCash.TabIndex = 2;
            this.tbCash.Text = "1 000 000 C$ / 2 000 000 C$";
            this.tbCash.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbSafe
            // 
            this.tbSafe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSafe.Location = new System.Drawing.Point(335, 4);
            this.tbSafe.Name = "tbSafe";
            this.tbSafe.ReadOnly = true;
            this.tbSafe.Size = new System.Drawing.Size(150, 13);
            this.tbSafe.TabIndex = 3;
            this.tbSafe.Text = "1 000 000 C$ / 2 000 000 C$";
            this.tbSafe.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbNextLogin
            // 
            this.tbNextLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbNextLogin.Location = new System.Drawing.Point(711, 4);
            this.tbNextLogin.Name = "tbNextLogin";
            this.tbNextLogin.ReadOnly = true;
            this.tbNextLogin.Size = new System.Drawing.Size(72, 13);
            this.tbNextLogin.TabIndex = 4;
            this.tbNextLogin.Text = "00 00:00:00";
            this.tbNextLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cbEnabled
            // 
            this.cbEnabled.AutoSize = true;
            this.cbEnabled.Location = new System.Drawing.Point(24, 4);
            this.cbEnabled.Name = "cbEnabled";
            this.cbEnabled.Size = new System.Drawing.Size(15, 14);
            this.cbEnabled.TabIndex = 8;
            this.cbEnabled.UseVisualStyleBackColor = true;
            // 
            // tbMailMessages
            // 
            this.tbMailMessages.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbMailMessages.Location = new System.Drawing.Point(659, 4);
            this.tbMailMessages.Name = "tbMailMessages";
            this.tbMailMessages.ReadOnly = true;
            this.tbMailMessages.Size = new System.Drawing.Size(20, 13);
            this.tbMailMessages.TabIndex = 10;
            this.tbMailMessages.Text = "00";
            this.tbMailMessages.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbSettings
            // 
            this.lbSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbSettings.Image = global::PBizBot.Properties.Resources.settings;
            this.lbSettings.Location = new System.Drawing.Point(906, 3);
            this.lbSettings.Name = "lbSettings";
            this.lbSettings.Size = new System.Drawing.Size(16, 16);
            this.lbSettings.TabIndex = 11;
            this.lbSettings.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbSettings_LinkClicked);
            // 
            // tbAttack
            // 
            this.tbAttack.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbAttack.Location = new System.Drawing.Point(491, 4);
            this.tbAttack.Name = "tbAttack";
            this.tbAttack.ReadOnly = true;
            this.tbAttack.Size = new System.Drawing.Size(78, 13);
            this.tbAttack.TabIndex = 12;
            this.tbAttack.Text = "1234567899";
            this.tbAttack.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbDefense
            // 
            this.tbDefense.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbDefense.Location = new System.Drawing.Point(575, 4);
            this.tbDefense.Name = "tbDefense";
            this.tbDefense.ReadOnly = true;
            this.tbDefense.Size = new System.Drawing.Size(78, 13);
            this.tbDefense.TabIndex = 13;
            this.tbDefense.Text = "1234567899";
            this.tbDefense.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbHitCount
            // 
            this.tbHitCount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbHitCount.Location = new System.Drawing.Point(685, 4);
            this.tbHitCount.Name = "tbHitCount";
            this.tbHitCount.ReadOnly = true;
            this.tbHitCount.Size = new System.Drawing.Size(20, 13);
            this.tbHitCount.TabIndex = 14;
            this.tbHitCount.Text = "00";
            this.tbHitCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cbSentEmail
            // 
            this.cbSentEmail.AutoSize = true;
            this.cbSentEmail.Location = new System.Drawing.Point(798, 4);
            this.cbSentEmail.Name = "cbSentEmail";
            this.cbSentEmail.Size = new System.Drawing.Size(15, 14);
            this.cbSentEmail.TabIndex = 15;
            this.cbSentEmail.UseVisualStyleBackColor = true;
            // 
            // rbSelectedAccount
            // 
            this.rbSelectedAccount.AutoSize = true;
            this.rbSelectedAccount.Location = new System.Drawing.Point(4, 4);
            this.rbSelectedAccount.Name = "rbSelectedAccount";
            this.rbSelectedAccount.Size = new System.Drawing.Size(14, 13);
            this.rbSelectedAccount.TabIndex = 18;
            this.rbSelectedAccount.TabStop = true;
            this.rbSelectedAccount.UseVisualStyleBackColor = true;
            this.rbSelectedAccount.CheckedChanged += new System.EventHandler(this.rbSelectedAccount_CheckedChanged);
            // 
            // cbTransferToAccount
            // 
            this.cbTransferToAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTransferToAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbTransferToAccount.ItemHeight = 12;
            this.cbTransferToAccount.Location = new System.Drawing.Point(819, 1);
            this.cbTransferToAccount.MaxDropDownItems = 10;
            this.cbTransferToAccount.Name = "cbTransferToAccount";
            this.cbTransferToAccount.Size = new System.Drawing.Size(80, 20);
            this.cbTransferToAccount.TabIndex = 19;
            this.cbTransferToAccount.SelectedIndexChanged += new System.EventHandler(this.cbTransferToAccount_SelectedIndexChanged);
            // 
            // tbLogin
            // 
            this.tbLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbLogin.Location = new System.Drawing.Point(45, 4);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.ReadOnly = true;
            this.tbLogin.Size = new System.Drawing.Size(60, 13);
            this.tbLogin.TabIndex = 0;
            // 
            // tbPasswd
            // 
            this.tbPasswd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPasswd.Location = new System.Drawing.Point(107, 4);
            this.tbPasswd.Name = "tbPasswd";
            this.tbPasswd.ReadOnly = true;
            this.tbPasswd.Size = new System.Drawing.Size(72, 13);
            this.tbPasswd.TabIndex = 1;
            this.tbPasswd.UseSystemPasswordChar = true;
            this.tbPasswd.MouseEnter += new System.EventHandler(this.tbPasswd_MouseEnter);
            this.tbPasswd.MouseLeave += new System.EventHandler(this.tbPasswd_MouseLeave);
            // 
            // pbMinus
            // 
            this.pbMinus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbMinus.Image = global::PBizBot.Properties.Resources.minus;
            this.pbMinus.Location = new System.Drawing.Point(928, 3);
            this.pbMinus.Name = "pbMinus";
            this.pbMinus.Size = new System.Drawing.Size(16, 16);
            this.pbMinus.TabIndex = 20;
            this.pbMinus.TabStop = false;
            this.pbMinus.Click += new System.EventHandler(this.pbMinus_Click);
            // 
            // AccountDetailsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pbMinus);
            this.Controls.Add(this.cbTransferToAccount);
            this.Controls.Add(this.rbSelectedAccount);
            this.Controls.Add(this.cbSentEmail);
            this.Controls.Add(this.tbHitCount);
            this.Controls.Add(this.tbDefense);
            this.Controls.Add(this.tbAttack);
            this.Controls.Add(this.lbSettings);
            this.Controls.Add(this.tbMailMessages);
            this.Controls.Add(this.cbEnabled);
            this.Controls.Add(this.tbNextLogin);
            this.Controls.Add(this.tbSafe);
            this.Controls.Add(this.tbCash);
            this.Controls.Add(this.tbLogin);
            this.Controls.Add(this.tbPasswd);
            this.Name = "AccountDetailsControl";
            this.Size = new System.Drawing.Size(950, 22);
            this.Load += new System.EventHandler(this.AccountDetailsControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbMinus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox tbLogin;
        public System.Windows.Forms.TextBox tbPasswd;
        public System.Windows.Forms.TextBox tbCash;
        public System.Windows.Forms.TextBox tbSafe;
        public System.Windows.Forms.TextBox tbNextLogin;
        public System.Windows.Forms.CheckBox cbEnabled;
        public System.Windows.Forms.TextBox tbMailMessages;
        public System.Windows.Forms.LinkLabel lbSettings;
        public System.Windows.Forms.TextBox tbAttack;
        public System.Windows.Forms.TextBox tbDefense;
        public System.Windows.Forms.TextBox tbHitCount;
        public System.Windows.Forms.CheckBox cbSentEmail;
        public System.Windows.Forms.RadioButton rbSelectedAccount;
        public System.Windows.Forms.ComboBox cbTransferToAccount;
        private System.Windows.Forms.PictureBox pbMinus;
    }
}
