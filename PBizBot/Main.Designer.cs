namespace PBizBot
{
    partial class Main
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
            this.tbBot = new System.Windows.Forms.TabControl();
            this.tpBot = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gbAccounts = new System.Windows.Forms.GroupBox();
            this.pAccounts = new System.Windows.Forms.Panel();
            this.gbBotMainPanel = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btSettings = new System.Windows.Forms.Button();
            this.btOFF = new System.Windows.Forms.Button();
            this.btON = new System.Windows.Forms.Button();
            this.btAddUsersList = new System.Windows.Forms.Button();
            this.btAddUser = new System.Windows.Forms.Button();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tpManual = new System.Windows.Forms.TabPage();
            this.ssStatus = new System.Windows.Forms.StatusStrip();
            this.attackList1 = new PBizBot.View.AttackList();
            this.tbBot.SuspendLayout();
            this.tpBot.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbAccounts.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbBot
            // 
            this.tbBot.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tbBot.Controls.Add(this.tpBot);
            this.tbBot.Controls.Add(this.tpManual);
            this.tbBot.Location = new System.Drawing.Point(2, 12);
            this.tbBot.Name = "tbBot";
            this.tbBot.SelectedIndex = 0;
            this.tbBot.Size = new System.Drawing.Size(1192, 761);
            this.tbBot.TabIndex = 1;
            this.tbBot.SelectedIndexChanged += new System.EventHandler(this.tbBot_SelectedIndexChanged);
            // 
            // tpBot
            // 
            this.tpBot.Controls.Add(this.groupBox2);
            this.tpBot.Controls.Add(this.gbAccounts);
            this.tpBot.Controls.Add(this.gbBotMainPanel);
            this.tpBot.Controls.Add(this.groupBox1);
            this.tpBot.Location = new System.Drawing.Point(4, 25);
            this.tpBot.Name = "tpBot";
            this.tpBot.Padding = new System.Windows.Forms.Padding(3);
            this.tpBot.Size = new System.Drawing.Size(1184, 732);
            this.tpBot.TabIndex = 0;
            this.tpBot.Text = "Automat";
            this.tpBot.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.attackList1);
            this.groupBox2.Location = new System.Drawing.Point(552, 193);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(630, 533);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            // 
            // gbAccounts
            // 
            this.gbAccounts.Controls.Add(this.pAccounts);
            this.gbAccounts.Location = new System.Drawing.Point(0, 0);
            this.gbAccounts.Name = "gbAccounts";
            this.gbAccounts.Size = new System.Drawing.Size(975, 187);
            this.gbAccounts.TabIndex = 8;
            this.gbAccounts.TabStop = false;
            // 
            // pAccounts
            // 
            this.pAccounts.AutoScroll = true;
            this.pAccounts.Location = new System.Drawing.Point(2, 8);
            this.pAccounts.Name = "pAccounts";
            this.pAccounts.Size = new System.Drawing.Size(968, 177);
            this.pAccounts.TabIndex = 0;
            this.pAccounts.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.pAccounts_ControlAdded);
            this.pAccounts.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.pAccounts_ControlRemoved);
            // 
            // gbBotMainPanel
            // 
            this.gbBotMainPanel.Location = new System.Drawing.Point(0, 193);
            this.gbBotMainPanel.Name = "gbBotMainPanel";
            this.gbBotMainPanel.Size = new System.Drawing.Size(546, 533);
            this.gbBotMainPanel.TabIndex = 7;
            this.gbBotMainPanel.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btSettings);
            this.groupBox1.Controls.Add(this.btOFF);
            this.groupBox1.Controls.Add(this.btON);
            this.groupBox1.Controls.Add(this.btAddUsersList);
            this.groupBox1.Controls.Add(this.btAddUser);
            this.groupBox1.Controls.Add(this.tbLogin);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbPassword);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(981, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(201, 187);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // btSettings
            // 
            this.btSettings.Location = new System.Drawing.Point(9, 137);
            this.btSettings.Name = "btSettings";
            this.btSettings.Size = new System.Drawing.Size(184, 44);
            this.btSettings.TabIndex = 10;
            this.btSettings.Text = "Ustawienia";
            this.btSettings.UseVisualStyleBackColor = true;
            this.btSettings.Click += new System.EventHandler(this.btSettings_Click);
            // 
            // btOFF
            // 
            this.btOFF.Enabled = false;
            this.btOFF.Location = new System.Drawing.Point(103, 94);
            this.btOFF.Name = "btOFF";
            this.btOFF.Size = new System.Drawing.Size(90, 37);
            this.btOFF.TabIndex = 9;
            this.btOFF.Text = "OFF";
            this.btOFF.UseVisualStyleBackColor = true;
            this.btOFF.Click += new System.EventHandler(this.btOFF_Click);
            // 
            // btON
            // 
            this.btON.Location = new System.Drawing.Point(9, 94);
            this.btON.Name = "btON";
            this.btON.Size = new System.Drawing.Size(90, 37);
            this.btON.TabIndex = 8;
            this.btON.Text = "ON";
            this.btON.UseVisualStyleBackColor = true;
            this.btON.Click += new System.EventHandler(this.btON_Click);
            // 
            // btAddUsersList
            // 
            this.btAddUsersList.Location = new System.Drawing.Point(103, 65);
            this.btAddUsersList.Name = "btAddUsersList";
            this.btAddUsersList.Size = new System.Drawing.Size(90, 23);
            this.btAddUsersList.TabIndex = 7;
            this.btAddUsersList.Text = "Lista";
            this.btAddUsersList.UseVisualStyleBackColor = true;
            // 
            // btAddUser
            // 
            this.btAddUser.Location = new System.Drawing.Point(9, 65);
            this.btAddUser.Name = "btAddUser";
            this.btAddUser.Size = new System.Drawing.Size(90, 23);
            this.btAddUser.TabIndex = 6;
            this.btAddUser.Text = "Dodaj";
            this.btAddUser.UseVisualStyleBackColor = true;
            this.btAddUser.Click += new System.EventHandler(this.btAddUser_Click);
            // 
            // tbLogin
            // 
            this.tbLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbLogin.Location = new System.Drawing.Point(48, 13);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(145, 20);
            this.tbLogin.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Hasło:";
            // 
            // tbPassword
            // 
            this.tbPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPassword.Location = new System.Drawing.Point(48, 39);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(145, 20);
            this.tbPassword.TabIndex = 3;
            this.tbPassword.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Login:";
            // 
            // tpManual
            // 
            this.tpManual.Location = new System.Drawing.Point(4, 25);
            this.tpManual.Name = "tpManual";
            this.tpManual.Padding = new System.Windows.Forms.Padding(3);
            this.tpManual.Size = new System.Drawing.Size(1184, 732);
            this.tpManual.TabIndex = 1;
            this.tpManual.Text = "Manual";
            this.tpManual.UseVisualStyleBackColor = true;
            // 
            // ssStatus
            // 
            this.ssStatus.Location = new System.Drawing.Point(0, 773);
            this.ssStatus.Name = "ssStatus";
            this.ssStatus.Size = new System.Drawing.Size(1195, 22);
            this.ssStatus.SizingGrip = false;
            this.ssStatus.TabIndex = 2;
            // 
            // attackList1
            // 
            this.attackList1.Location = new System.Drawing.Point(6, 19);
            this.attackList1.Name = "attackList1";
            this.attackList1.Size = new System.Drawing.Size(622, 504);
            this.attackList1.TabIndex = 9;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 795);
            this.Controls.Add(this.ssStatus);
            this.Controls.Add(this.tbBot);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PBiz Control Panel";
            this.Load += new System.EventHandler(this.Main_Load);
            this.tbBot.ResumeLayout(false);
            this.tpBot.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.gbAccounts.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tbBot;
        private System.Windows.Forms.TabPage tpBot;
        private System.Windows.Forms.TabPage tpManual;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btAddUser;
        private System.Windows.Forms.Button btOFF;
        private System.Windows.Forms.Button btON;
        private System.Windows.Forms.Button btAddUsersList;
        private System.Windows.Forms.GroupBox gbAccounts;
        private System.Windows.Forms.GroupBox gbBotMainPanel;
        private System.Windows.Forms.Button btSettings;
        private System.Windows.Forms.Panel pAccounts;
        private View.AttackList attackList1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.StatusStrip ssStatus;
        //private Skybound.Gecko.GeckoWebBrowser webBrowser;
    }
}

