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
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.tbGospo = new System.Windows.Forms.TextBox();
            this.tbMoher = new System.Windows.Forms.TextBox();
            this.tbDewot = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tbOrgan = new System.Windows.Forms.TextBox();
            this.tbLektor = new System.Windows.Forms.TextBox();
            this.tbMinistr = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbDefense = new System.Windows.Forms.TextBox();
            this.tbAttack = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lbLog = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ofdAttackFile = new System.Windows.Forms.OpenFileDialog();
            this.sfdStatsFile = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1.SuspendLayout();
            this.tbControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(687, 232);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(58, 48);
            this.btStart.TabIndex = 0;
            this.btStart.TabStop = false;
            this.btStart.Text = "Start";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // btStop
            // 
            this.btStop.Enabled = false;
            this.btStop.Location = new System.Drawing.Point(751, 232);
            this.btStop.Name = "btStop";
            this.btStop.Size = new System.Drawing.Size(58, 48);
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
            this.bConfig.Location = new System.Drawing.Point(687, 286);
            this.bConfig.Name = "bConfig";
            this.bConfig.Size = new System.Drawing.Size(122, 76);
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
            this.tabPage1.Controls.Add(this.pbStatDownload);
            this.tabPage1.Controls.Add(this.btStatDownload);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.btAttackFile);
            this.tabPage1.Controls.Add(this.btAttackON);
            this.tabPage1.Controls.Add(this.btAttackOFF);
            this.tabPage1.Controls.Add(this.lvAttackList);
            this.tabPage1.Controls.Add(this.groupBox6);
            this.tabPage1.Controls.Add(this.groupBox4);
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
            // pbStatDownload
            // 
            this.pbStatDownload.Location = new System.Drawing.Point(242, 202);
            this.pbStatDownload.Name = "pbStatDownload";
            this.pbStatDownload.Size = new System.Drawing.Size(439, 23);
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
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.tbGospo);
            this.groupBox6.Controls.Add(this.tbMoher);
            this.groupBox6.Controls.Add(this.tbDewot);
            this.groupBox6.Controls.Add(this.label12);
            this.groupBox6.Controls.Add(this.label11);
            this.groupBox6.Controls.Add(this.label10);
            this.groupBox6.Location = new System.Drawing.Point(6, 283);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(230, 81);
            this.groupBox6.TabIndex = 10;
            this.groupBox6.TabStop = false;
            // 
            // tbGospo
            // 
            this.tbGospo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbGospo.Location = new System.Drawing.Point(124, 56);
            this.tbGospo.Name = "tbGospo";
            this.tbGospo.ReadOnly = true;
            this.tbGospo.Size = new System.Drawing.Size(100, 13);
            this.tbGospo.TabIndex = 10;
            this.tbGospo.TabStop = false;
            this.tbGospo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbMoher
            // 
            this.tbMoher.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbMoher.Location = new System.Drawing.Point(124, 36);
            this.tbMoher.Name = "tbMoher";
            this.tbMoher.ReadOnly = true;
            this.tbMoher.Size = new System.Drawing.Size(100, 13);
            this.tbMoher.TabIndex = 9;
            this.tbMoher.TabStop = false;
            this.tbMoher.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbDewot
            // 
            this.tbDewot.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbDewot.Location = new System.Drawing.Point(124, 16);
            this.tbDewot.Name = "tbDewot";
            this.tbDewot.ReadOnly = true;
            this.tbDewot.Size = new System.Drawing.Size(100, 13);
            this.tbDewot.TabIndex = 8;
            this.tbDewot.TabStop = false;
            this.tbDewot.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 56);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(102, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "Gospo. Proboszcza:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 36);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Babcie Moherowe:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Małe Dewotki:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tbOrgan);
            this.groupBox4.Controls.Add(this.tbLektor);
            this.groupBox4.Controls.Add(this.tbMinistr);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Location = new System.Drawing.Point(6, 196);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(230, 81);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            // 
            // tbOrgan
            // 
            this.tbOrgan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbOrgan.Location = new System.Drawing.Point(124, 56);
            this.tbOrgan.Name = "tbOrgan";
            this.tbOrgan.ReadOnly = true;
            this.tbOrgan.Size = new System.Drawing.Size(100, 13);
            this.tbOrgan.TabIndex = 7;
            this.tbOrgan.TabStop = false;
            this.tbOrgan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbLektor
            // 
            this.tbLektor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbLektor.Location = new System.Drawing.Point(124, 36);
            this.tbLektor.Name = "tbLektor";
            this.tbLektor.ReadOnly = true;
            this.tbLektor.Size = new System.Drawing.Size(100, 13);
            this.tbLektor.TabIndex = 6;
            this.tbLektor.TabStop = false;
            this.tbLektor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbMinistr
            // 
            this.tbMinistr.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbMinistr.Location = new System.Drawing.Point(124, 16);
            this.tbMinistr.Name = "tbMinistr";
            this.tbMinistr.ReadOnly = true;
            this.tbMinistr.Size = new System.Drawing.Size(100, 13);
            this.tbMinistr.TabIndex = 5;
            this.tbMinistr.TabStop = false;
            this.tbMinistr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Organiści:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Lektorzy:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Ministranci:";
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
            this.lbLog.Location = new System.Drawing.Point(242, 232);
            this.lbLog.Name = "lbLog";
            this.lbLog.ScrollAlwaysVisible = true;
            this.lbLog.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lbLog.Size = new System.Drawing.Size(439, 130);
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 403);
            this.Controls.Add(this.tbControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Parafia (brak danych)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tbControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

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
        public System.Windows.Forms.GroupBox groupBox6;
        public System.Windows.Forms.Label label12;
        public System.Windows.Forms.Label label11;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.GroupBox groupBox4;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox tbServerTime;
        public System.Windows.Forms.Label label13;
        public System.Windows.Forms.TextBox tbAttack;
        public System.Windows.Forms.TextBox tbDefense;
        public System.Windows.Forms.TextBox tbGospo;
        public System.Windows.Forms.TextBox tbMoher;
        public System.Windows.Forms.TextBox tbDewot;
        public System.Windows.Forms.TextBox tbOrgan;
        public System.Windows.Forms.TextBox tbLektor;
        public System.Windows.Forms.TextBox tbMinistr;
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
    }
}

