namespace Parafia
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btStart = new System.Windows.Forms.Button();
            this.btStop = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbServerTime = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbHitCount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNextLogin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbUpTime = new System.Windows.Forms.TextBox();
            this.tbSystemTime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bConfig = new System.Windows.Forms.Button();
            this.tbControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cbClient = new System.Windows.Forms.CheckBox();
            this.cbServer = new System.Windows.Forms.CheckBox();
            this.cbHoldSession = new System.Windows.Forms.CheckBox();
            this.pbStatDownload = new System.Windows.Forms.ProgressBar();
            this.btStatDownload = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbAttackNext = new System.Windows.Forms.TextBox();
            this.tbAttackLast = new System.Windows.Forms.TextBox();
            this.tbAttackCash = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.btAttackFile = new System.Windows.Forms.Button();
            this.btAttackON = new System.Windows.Forms.Button();
            this.btAttackOFF = new System.Windows.Forms.Button();
            this.lvAttackList = new System.Windows.Forms.ListView();
            this.chCheck = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chCash = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chWinsNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chLoseNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chLastAttackDt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbDefense = new System.Windows.Forms.TextBox();
            this.tbAttack = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lbLog = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ofdAttackFile = new System.Windows.Forms.OpenFileDialog();
            this.sfdStatsFile = new System.Windows.Forms.SaveFileDialog();
            this.niMain = new System.Windows.Forms.NotifyIcon(this.components);
            this.ssMain = new System.Windows.Forms.StatusStrip();
            this.tssTransferedCash = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssTransferNo = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssCash = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssSafe = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssTransferedCashValue = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssTransferNoValue = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssCashValue = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssSafeValue = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1.SuspendLayout();
            this.tbControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.ssMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(688, 273);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(58, 30);
            this.btStart.TabIndex = 0;
            this.btStart.TabStop = false;
            this.btStart.Text = "Start";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // btStop
            // 
            this.btStop.Enabled = false;
            this.btStop.Location = new System.Drawing.Point(752, 273);
            this.btStop.Name = "btStop";
            this.btStop.Size = new System.Drawing.Size(58, 30);
            this.btStop.TabIndex = 1;
            this.btStop.TabStop = false;
            this.btStop.Text = "Stop";
            this.btStop.UseVisualStyleBackColor = true;
            this.btStop.Click += new System.EventHandler(this.btStop_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbServerTime);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.tbHitCount);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbNextLogin);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbUpTime);
            this.groupBox1.Controls.Add(this.tbSystemTime);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(230, 117);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // tbServerTime
            // 
            this.tbServerTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbServerTime.Location = new System.Drawing.Point(124, 15);
            this.tbServerTime.Name = "tbServerTime";
            this.tbServerTime.ReadOnly = true;
            this.tbServerTime.Size = new System.Drawing.Size(100, 13);
            this.tbServerTime.TabIndex = 10;
            this.tbServerTime.TabStop = false;
            this.tbServerTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 15);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 13);
            this.label13.TabIndex = 9;
            this.label13.Text = "Czas Serwera:";
            // 
            // tbHitCount
            // 
            this.tbHitCount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbHitCount.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tbHitCount.Location = new System.Drawing.Point(124, 95);
            this.tbHitCount.Name = "tbHitCount";
            this.tbHitCount.ReadOnly = true;
            this.tbHitCount.Size = new System.Drawing.Size(100, 13);
            this.tbHitCount.TabIndex = 8;
            this.tbHitCount.TabStop = false;
            this.tbHitCount.Text = "0";
            this.tbHitCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ilość Logowań:";
            // 
            // tbNextLogin
            // 
            this.tbNextLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbNextLogin.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tbNextLogin.Location = new System.Drawing.Point(124, 75);
            this.tbNextLogin.Name = "tbNextLogin";
            this.tbNextLogin.ReadOnly = true;
            this.tbNextLogin.Size = new System.Drawing.Size(100, 13);
            this.tbNextLogin.TabIndex = 6;
            this.tbNextLogin.TabStop = false;
            this.tbNextLogin.Text = "brak danych";
            this.tbNextLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Następne Logowanie:";
            // 
            // tbUpTime
            // 
            this.tbUpTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbUpTime.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tbUpTime.Location = new System.Drawing.Point(124, 55);
            this.tbUpTime.Name = "tbUpTime";
            this.tbUpTime.ReadOnly = true;
            this.tbUpTime.Size = new System.Drawing.Size(100, 13);
            this.tbUpTime.TabIndex = 4;
            this.tbUpTime.TabStop = false;
            this.tbUpTime.Text = "00 00:00:00";
            this.tbUpTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbSystemTime
            // 
            this.tbSystemTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSystemTime.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tbSystemTime.Location = new System.Drawing.Point(124, 35);
            this.tbSystemTime.Name = "tbSystemTime";
            this.tbSystemTime.ReadOnly = true;
            this.tbSystemTime.Size = new System.Drawing.Size(100, 13);
            this.tbSystemTime.TabIndex = 3;
            this.tbSystemTime.TabStop = false;
            this.tbSystemTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Czas Uruchomienia:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Czas Systemowy:";
            // 
            // bConfig
            // 
            this.bConfig.Location = new System.Drawing.Point(687, 309);
            this.bConfig.Name = "bConfig";
            this.bConfig.Size = new System.Drawing.Size(122, 53);
            this.bConfig.TabIndex = 5;
            this.bConfig.TabStop = false;
            this.bConfig.Text = "Ustawienia";
            this.bConfig.UseVisualStyleBackColor = true;
            this.bConfig.Click += new System.EventHandler(this.bConfig_Click);
            // 
            // tbControl
            // 
            this.tbControl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tbControl.Controls.Add(this.tabPage1);
            this.tbControl.Controls.Add(this.tabPage2);
            this.tbControl.Location = new System.Drawing.Point(2, 7);
            this.tbControl.Name = "tbControl";
            this.tbControl.SelectedIndex = 0;
            this.tbControl.Size = new System.Drawing.Size(824, 397);
            this.tbControl.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cbClient);
            this.tabPage1.Controls.Add(this.cbServer);
            this.tabPage1.Controls.Add(this.cbHoldSession);
            this.tabPage1.Controls.Add(this.pbStatDownload);
            this.tabPage1.Controls.Add(this.btStatDownload);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.btAttackFile);
            this.tabPage1.Controls.Add(this.btAttackON);
            this.tabPage1.Controls.Add(this.btAttackOFF);
            this.tabPage1.Controls.Add(this.lvAttackList);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.btStop);
            this.tabPage1.Controls.Add(this.lbLog);
            this.tabPage1.Controls.Add(this.btStart);
            this.tabPage1.Controls.Add(this.bConfig);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(816, 368);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Automat";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cbClient
            // 
            this.cbClient.AutoSize = true;
            this.cbClient.Location = new System.Drawing.Point(753, 252);
            this.cbClient.Name = "cbClient";
            this.cbClient.Size = new System.Drawing.Size(52, 17);
            this.cbClient.TabIndex = 28;
            this.cbClient.Text = "Klient";
            this.cbClient.UseVisualStyleBackColor = true;
            this.cbClient.CheckedChanged += new System.EventHandler(this.cbClient_CheckedChanged);
            // 
            // cbServer
            // 
            this.cbServer.AutoSize = true;
            this.cbServer.Location = new System.Drawing.Point(688, 252);
            this.cbServer.Name = "cbServer";
            this.cbServer.Size = new System.Drawing.Size(59, 17);
            this.cbServer.TabIndex = 27;
            this.cbServer.Text = "Serwer";
            this.cbServer.UseVisualStyleBackColor = true;
            this.cbServer.CheckedChanged += new System.EventHandler(this.cbServer_CheckedChanged);
            // 
            // cbHoldSession
            // 
            this.cbHoldSession.AutoSize = true;
            this.cbHoldSession.Location = new System.Drawing.Point(688, 232);
            this.cbHoldSession.Name = "cbHoldSession";
            this.cbHoldSession.Size = new System.Drawing.Size(93, 17);
            this.cbHoldSession.TabIndex = 26;
            this.cbHoldSession.Text = "Utrzymuj sesje";
            this.cbHoldSession.UseVisualStyleBackColor = true;
            this.cbHoldSession.CheckedChanged += new System.EventHandler(this.cbHoldSession_CheckedChanged);
            // 
            // pbStatDownload
            // 
            this.pbStatDownload.Location = new System.Drawing.Point(6, 202);
            this.pbStatDownload.Name = "pbStatDownload";
            this.pbStatDownload.Size = new System.Drawing.Size(675, 23);
            this.pbStatDownload.Step = 1;
            this.pbStatDownload.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbStatDownload.TabIndex = 25;
            // 
            // btStatDownload
            // 
            this.btStatDownload.Location = new System.Drawing.Point(687, 202);
            this.btStatDownload.Name = "btStatDownload";
            this.btStatDownload.Size = new System.Drawing.Size(122, 23);
            this.btStatDownload.TabIndex = 24;
            this.btStatDownload.Text = "Pobierz Staty";
            this.btStatDownload.UseVisualStyleBackColor = true;
            this.btStatDownload.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbAttackNext);
            this.groupBox2.Controls.Add(this.tbAttackLast);
            this.groupBox2.Controls.Add(this.tbAttackCash);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Location = new System.Drawing.Point(687, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(123, 80);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            // 
            // tbAttackNext
            // 
            this.tbAttackNext.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbAttackNext.Location = new System.Drawing.Point(73, 55);
            this.tbAttackNext.Name = "tbAttackNext";
            this.tbAttackNext.ReadOnly = true;
            this.tbAttackNext.Size = new System.Drawing.Size(47, 13);
            this.tbAttackNext.TabIndex = 6;
            this.tbAttackNext.TabStop = false;
            this.tbAttackNext.Text = "00:00:00";
            this.tbAttackNext.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbAttackLast
            // 
            this.tbAttackLast.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbAttackLast.Location = new System.Drawing.Point(73, 35);
            this.tbAttackLast.Name = "tbAttackLast";
            this.tbAttackLast.ReadOnly = true;
            this.tbAttackLast.Size = new System.Drawing.Size(47, 13);
            this.tbAttackLast.TabIndex = 5;
            this.tbAttackLast.TabStop = false;
            this.tbAttackLast.Text = "00:00:00";
            this.tbAttackLast.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbAttackCash
            // 
            this.tbAttackCash.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbAttackCash.Location = new System.Drawing.Point(46, 15);
            this.tbAttackCash.Name = "tbAttackCash";
            this.tbAttackCash.ReadOnly = true;
            this.tbAttackCash.Size = new System.Drawing.Size(74, 13);
            this.tbAttackCash.TabIndex = 4;
            this.tbAttackCash.TabStop = false;
            this.tbAttackCash.Text = "0";
            this.tbAttackCash.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 55);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(56, 13);
            this.label17.TabIndex = 3;
            this.label17.Text = "Następne:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 35);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(49, 13);
            this.label18.TabIndex = 2;
            this.label18.Text = "Ostatnie:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 15);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(34, 13);
            this.label16.TabIndex = 0;
            this.label16.Text = "Kasa:";
            // 
            // btAttackFile
            // 
            this.btAttackFile.Location = new System.Drawing.Point(687, 135);
            this.btAttackFile.Name = "btAttackFile";
            this.btAttackFile.Size = new System.Drawing.Size(122, 55);
            this.btAttackFile.TabIndex = 19;
            this.btAttackFile.Text = "Lista";
            this.btAttackFile.UseVisualStyleBackColor = true;
            this.btAttackFile.Click += new System.EventHandler(this.btAttackFile_Click);
            // 
            // btAttackON
            // 
            this.btAttackON.Location = new System.Drawing.Point(687, 92);
            this.btAttackON.Name = "btAttackON";
            this.btAttackON.Size = new System.Drawing.Size(58, 37);
            this.btAttackON.TabIndex = 18;
            this.btAttackON.Text = "ON";
            this.btAttackON.UseVisualStyleBackColor = true;
            this.btAttackON.Click += new System.EventHandler(this.btAttackON_Click);
            // 
            // btAttackOFF
            // 
            this.btAttackOFF.Enabled = false;
            this.btAttackOFF.Location = new System.Drawing.Point(751, 92);
            this.btAttackOFF.Name = "btAttackOFF";
            this.btAttackOFF.Size = new System.Drawing.Size(58, 37);
            this.btAttackOFF.TabIndex = 17;
            this.btAttackOFF.Text = "OFF";
            this.btAttackOFF.UseVisualStyleBackColor = true;
            this.btAttackOFF.Click += new System.EventHandler(this.btAttackOFF_Click);
            // 
            // lvAttackList
            // 
            this.lvAttackList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvAttackList.CheckBoxes = true;
            this.lvAttackList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chCheck,
            this.chId,
            this.chName,
            this.chCash,
            this.chWinsNo,
            this.chLoseNo,
            this.chLastAttackDt});
            this.lvAttackList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lvAttackList.Location = new System.Drawing.Point(242, 10);
            this.lvAttackList.Name = "lvAttackList";
            this.lvAttackList.Size = new System.Drawing.Size(439, 180);
            this.lvAttackList.TabIndex = 16;
            this.lvAttackList.UseCompatibleStateImageBehavior = false;
            this.lvAttackList.View = System.Windows.Forms.View.Details;
            // 
            // chCheck
            // 
            this.chCheck.Text = "";
            this.chCheck.Width = 30;
            // 
            // chId
            // 
            this.chId.Text = "Id";
            this.chId.Width = 47;
            // 
            // chName
            // 
            this.chName.Text = "Name";
            this.chName.Width = 79;
            // 
            // chCash
            // 
            this.chCash.Text = "Cash";
            this.chCash.Width = 65;
            // 
            // chWinsNo
            // 
            this.chWinsNo.Text = "Wins";
            this.chWinsNo.Width = 41;
            // 
            // chLoseNo
            // 
            this.chLoseNo.Text = "Lose";
            this.chLoseNo.Width = 43;
            // 
            // chLastAttackDt
            // 
            this.chLastAttackDt.Text = "2011-01-01 11-11-11";
            this.chLastAttackDt.Width = 113;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.tbDefense);
            this.groupBox3.Controls.Add(this.tbAttack);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(6, 129);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(230, 61);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Obrona:";
            // 
            // tbDefense
            // 
            this.tbDefense.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbDefense.Location = new System.Drawing.Point(124, 36);
            this.tbDefense.Name = "tbDefense";
            this.tbDefense.ReadOnly = true;
            this.tbDefense.Size = new System.Drawing.Size(100, 13);
            this.tbDefense.TabIndex = 2;
            this.tbDefense.TabStop = false;
            this.tbDefense.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbAttack
            // 
            this.tbAttack.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbAttack.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbAttack.Location = new System.Drawing.Point(124, 16);
            this.tbAttack.Name = "tbAttack";
            this.tbAttack.ReadOnly = true;
            this.tbAttack.Size = new System.Drawing.Size(100, 13);
            this.tbAttack.TabIndex = 3;
            this.tbAttack.TabStop = false;
            this.tbAttack.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Atak:";
            // 
            // lbLog
            // 
            this.lbLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbLog.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbLog.FormattingEnabled = true;
            this.lbLog.Location = new System.Drawing.Point(6, 232);
            this.lbLog.Name = "lbLog";
            this.lbLog.ScrollAlwaysVisible = true;
            this.lbLog.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lbLog.Size = new System.Drawing.Size(675, 130);
            this.lbLog.TabIndex = 0;
            this.lbLog.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(816, 368);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Obsługa Ręczna";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ofdAttackFile
            // 
            this.ofdAttackFile.FileName = "lista.txt";
            this.ofdAttackFile.Filter = "Plik text|*.txt|Wszystkie pliki|*.*";
            // 
            // sfdStatsFile
            // 
            this.sfdStatsFile.FileName = "staty.txt";
            this.sfdStatsFile.Filter = "Text files|*.txt|All files|*.*";
            // 
            // niMain
            // 
            this.niMain.Icon = ((System.Drawing.Icon)(resources.GetObject("niMain.Icon")));
            this.niMain.Text = "Parafia (brak danych)";
            this.niMain.Visible = true;
            this.niMain.DoubleClick += new System.EventHandler(this.niMain_DoubleClick);
            // 
            // ssMain
            // 
            this.ssMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssTransferedCash,
            this.tssTransferedCashValue,
            this.tssTransferNo,
            this.tssTransferNoValue,
            this.tssCash,
            this.tssCashValue,
            this.tssSafe,
            this.tssSafeValue});
            this.ssMain.Location = new System.Drawing.Point(0, 404);
            this.ssMain.Name = "ssMain";
            this.ssMain.Size = new System.Drawing.Size(828, 22);
            this.ssMain.SizingGrip = false;
            this.ssMain.TabIndex = 11;
            // 
            // tssTransferedCash
            // 
            this.tssTransferedCash.Name = "tssTransferedCash";
            this.tssTransferedCash.Size = new System.Drawing.Size(101, 17);
            this.tssTransferedCash.Text = "Kasa z transferów: ";
            this.tssTransferedCash.Visible = false;
            // 
            // tssTransferNo
            // 
            this.tssTransferNo.Name = "tssTransferNo";
            this.tssTransferNo.Size = new System.Drawing.Size(92, 17);
            this.tssTransferNo.Text = "Ilość transferów: ";
            this.tssTransferNo.Visible = false;
            // 
            // tssCash
            // 
            this.tssCash.Name = "tssCash";
            this.tssCash.Size = new System.Drawing.Size(37, 17);
            this.tssCash.Text = "Kasa: ";
            this.tssCash.Visible = false;
            this.tssCash.Click += new System.EventHandler(this.tssCash_Click);
            // 
            // tssSafe
            // 
            this.tssSafe.Name = "tssSafe";
            this.tssSafe.Size = new System.Drawing.Size(33, 17);
            this.tssSafe.Text = "Sejf: ";
            this.tssSafe.Visible = false;
            this.tssSafe.Click += new System.EventHandler(this.tssSafe_Click);
            // 
            // tssTransferedCashValue
            // 
            this.tssTransferedCashValue.AutoSize = false;
            this.tssTransferedCashValue.Margin = new System.Windows.Forms.Padding(0, 3, 5, 2);
            this.tssTransferedCashValue.Name = "tssTransferedCashValue";
            this.tssTransferedCashValue.Size = new System.Drawing.Size(80, 17);
            this.tssTransferedCashValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tssTransferedCashValue.Visible = false;
            // 
            // tssTransferNoValue
            // 
            this.tssTransferNoValue.AutoSize = false;
            this.tssTransferNoValue.Margin = new System.Windows.Forms.Padding(0, 3, 5, 2);
            this.tssTransferNoValue.Name = "tssTransferNoValue";
            this.tssTransferNoValue.Size = new System.Drawing.Size(30, 17);
            this.tssTransferNoValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tssTransferNoValue.Visible = false;
            // 
            // tssCashValue
            // 
            this.tssCashValue.AutoSize = false;
            this.tssCashValue.Margin = new System.Windows.Forms.Padding(0, 3, 5, 2);
            this.tssCashValue.Name = "tssCashValue";
            this.tssCashValue.Size = new System.Drawing.Size(120, 17);
            this.tssCashValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tssCashValue.Visible = false;
            // 
            // tssSafeValue
            // 
            this.tssSafeValue.AutoSize = false;
            this.tssSafeValue.Margin = new System.Windows.Forms.Padding(0, 3, 5, 2);
            this.tssSafeValue.Name = "tssSafeValue";
            this.tssSafeValue.Size = new System.Drawing.Size(120, 17);
            this.tssSafeValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tssSafeValue.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 426);
            this.Controls.Add(this.ssMain);
            this.Controls.Add(this.tbControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowInTaskbar = false;
            this.Text = "Parafia (brak danych)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tbControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ssMain.ResumeLayout(false);
            this.ssMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btStart;
        public System.Windows.Forms.Button btStop;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox tbUpTime;
        public System.Windows.Forms.TextBox tbSystemTime;
        public System.Windows.Forms.TextBox tbNextLogin;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox tbHitCount;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Button bConfig;
        public System.Windows.Forms.TabControl tbControl;
        public System.Windows.Forms.TabPage tabPage1;
        public System.Windows.Forms.TabPage tabPage2;
        public System.Windows.Forms.ListBox lbLog;
        public System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox tbServerTime;
        public System.Windows.Forms.Label label13;
        public System.Windows.Forms.TextBox tbAttack;
        public System.Windows.Forms.TextBox tbDefense;
        public System.Windows.Forms.ListView lvAttackList;
        public System.Windows.Forms.ColumnHeader chCheck;
        public System.Windows.Forms.ColumnHeader chName;
        public System.Windows.Forms.ColumnHeader chCash;
        public System.Windows.Forms.ColumnHeader chWinsNo;
        public System.Windows.Forms.Button btAttackFile;
        public System.Windows.Forms.Button btAttackON;
        public System.Windows.Forms.Button btAttackOFF;
        public System.Windows.Forms.OpenFileDialog ofdAttackFile;
        public System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.TextBox tbAttackNext;
        public System.Windows.Forms.TextBox tbAttackLast;
        public System.Windows.Forms.TextBox tbAttackCash;
        public System.Windows.Forms.Label label17;
        public System.Windows.Forms.Label label18;
        public System.Windows.Forms.Label label16;
        public System.Windows.Forms.Button btStatDownload;
        public System.Windows.Forms.ColumnHeader chId;
        public System.Windows.Forms.ProgressBar pbStatDownload;
        private System.Windows.Forms.SaveFileDialog sfdStatsFile;
        private System.Windows.Forms.ColumnHeader chLoseNo;
        private System.Windows.Forms.ColumnHeader chLastAttackDt;
        private System.Windows.Forms.CheckBox cbHoldSession;
        private System.Windows.Forms.CheckBox cbClient;
        private System.Windows.Forms.CheckBox cbServer;
        public System.Windows.Forms.NotifyIcon niMain;
        private System.Windows.Forms.StatusStrip ssMain;
        public System.Windows.Forms.ToolStripStatusLabel tssTransferedCash;
        public System.Windows.Forms.ToolStripStatusLabel tssTransferNo;
        public System.Windows.Forms.ToolStripStatusLabel tssCash;
        public System.Windows.Forms.ToolStripStatusLabel tssSafe;
        public System.Windows.Forms.ToolStripStatusLabel tssTransferedCashValue;
        public System.Windows.Forms.ToolStripStatusLabel tssTransferNoValue;
        public System.Windows.Forms.ToolStripStatusLabel tssCashValue;
        public System.Windows.Forms.ToolStripStatusLabel tssSafeValue;
    }
}

