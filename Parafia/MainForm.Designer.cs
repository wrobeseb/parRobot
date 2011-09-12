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
            this.btAttackFile = new System.Windows.Forms.Button();
            this.btAttackON = new System.Windows.Forms.Button();
            this.btAttackOFF = new System.Windows.Forms.Button();
            this.lvAttackList = new System.Windows.Forms.ListView();
            this.chCheck = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chCash = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.lvQuests = new System.Windows.Forms.ListView();
            this.chCheckbox = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chQuestName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chQuestProgress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pQuestsButtons = new System.Windows.Forms.Panel();
            this.bQuestOff = new System.Windows.Forms.Button();
            this.bQuestOn = new System.Windows.Forms.Button();
            this.bQuestRefresh = new System.Windows.Forms.Button();
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
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.tbNextQuestDt = new System.Windows.Forms.TextBox();
            this.tbLastQuestDt = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tbRelicName = new System.Windows.Forms.TextBox();
            this.btRelicsOff = new System.Windows.Forms.Button();
            this.btRelicsOn = new System.Windows.Forms.Button();
            this.tbHourField = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbDefense = new System.Windows.Forms.TextBox();
            this.tbAttack = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lbLog = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ofdAttackFile = new System.Windows.Forms.OpenFileDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.tbAttackCash = new System.Windows.Forms.TextBox();
            this.tbAttackLast = new System.Windows.Forms.TextBox();
            this.tbAttackNext = new System.Windows.Forms.TextBox();
            this.tbAttackName = new System.Windows.Forms.TextBox();
            this.btAttackAdd = new System.Windows.Forms.Button();
            this.btAttackRemove = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.tbControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.pQuestsButtons.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(605, 473);
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
            this.btStop.Location = new System.Drawing.Point(669, 473);
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
            this.bConfig.Location = new System.Drawing.Point(605, 527);
            this.bConfig.Name = "bConfig";
            this.bConfig.Size = new System.Drawing.Size(122, 50);
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
            this.tbControl.Size = new System.Drawing.Size(739, 612);
            this.tbControl.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btAttackRemove);
            this.tabPage1.Controls.Add(this.btAttackAdd);
            this.tabPage1.Controls.Add(this.tbAttackName);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.btAttackFile);
            this.tabPage1.Controls.Add(this.btAttackON);
            this.tabPage1.Controls.Add(this.btAttackOFF);
            this.tabPage1.Controls.Add(this.lvAttackList);
            this.tabPage1.Controls.Add(this.groupBox8);
            this.tabPage1.Controls.Add(this.lvQuests);
            this.tabPage1.Controls.Add(this.pQuestsButtons);
            this.tabPage1.Controls.Add(this.groupBox6);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox7);
            this.tabPage1.Controls.Add(this.groupBox5);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.btStop);
            this.tabPage1.Controls.Add(this.lbLog);
            this.tabPage1.Controls.Add(this.btStart);
            this.tabPage1.Controls.Add(this.bConfig);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(731, 583);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Automat";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btAttackFile
            // 
            this.btAttackFile.Location = new System.Drawing.Point(605, 135);
            this.btAttackFile.Name = "btAttackFile";
            this.btAttackFile.Size = new System.Drawing.Size(122, 55);
            this.btAttackFile.TabIndex = 19;
            this.btAttackFile.Text = "Lista";
            this.btAttackFile.UseVisualStyleBackColor = true;
            this.btAttackFile.Click += new System.EventHandler(this.btAttackFile_Click);
            // 
            // btAttackON
            // 
            this.btAttackON.Location = new System.Drawing.Point(605, 92);
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
            this.btAttackOFF.Location = new System.Drawing.Point(669, 92);
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
            this.chName,
            this.chCash,
            this.chNo});
            this.lvAttackList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lvAttackList.Location = new System.Drawing.Point(242, 10);
            this.lvAttackList.Name = "lvAttackList";
            this.lvAttackList.Size = new System.Drawing.Size(355, 154);
            this.lvAttackList.TabIndex = 16;
            this.lvAttackList.UseCompatibleStateImageBehavior = false;
            this.lvAttackList.View = System.Windows.Forms.View.Details;
            // 
            // chCheck
            // 
            this.chCheck.Width = 30;
            // 
            // chName
            // 
            this.chName.Width = 145;
            // 
            // chCash
            // 
            this.chCash.Width = 120;
            // 
            // groupBox8
            // 
            this.groupBox8.Location = new System.Drawing.Point(242, 370);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(355, 97);
            this.groupBox8.TabIndex = 15;
            this.groupBox8.TabStop = false;
            // 
            // lvQuests
            // 
            this.lvQuests.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvQuests.CheckBoxes = true;
            this.lvQuests.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chCheckbox,
            this.chQuestName,
            this.chQuestProgress});
            this.lvQuests.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lvQuests.Location = new System.Drawing.Point(242, 201);
            this.lvQuests.MultiSelect = false;
            this.lvQuests.Name = "lvQuests";
            this.lvQuests.ShowGroups = false;
            this.lvQuests.Size = new System.Drawing.Size(355, 163);
            this.lvQuests.TabIndex = 6;
            this.lvQuests.TabStop = false;
            this.lvQuests.UseCompatibleStateImageBehavior = false;
            this.lvQuests.View = System.Windows.Forms.View.Details;
            // 
            // chCheckbox
            // 
            this.chCheckbox.Text = "";
            this.chCheckbox.Width = 25;
            // 
            // chQuestName
            // 
            this.chQuestName.Text = "";
            this.chQuestName.Width = 230;
            // 
            // chQuestProgress
            // 
            this.chQuestProgress.Text = "";
            this.chQuestProgress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chQuestProgress.Width = 100;
            // 
            // pQuestsButtons
            // 
            this.pQuestsButtons.Controls.Add(this.bQuestOff);
            this.pQuestsButtons.Controls.Add(this.bQuestOn);
            this.pQuestsButtons.Controls.Add(this.bQuestRefresh);
            this.pQuestsButtons.Location = new System.Drawing.Point(600, 263);
            this.pQuestsButtons.Name = "pQuestsButtons";
            this.pQuestsButtons.Size = new System.Drawing.Size(135, 101);
            this.pQuestsButtons.TabIndex = 0;
            // 
            // bQuestOff
            // 
            this.bQuestOff.Enabled = false;
            this.bQuestOff.Location = new System.Drawing.Point(69, 3);
            this.bQuestOff.Name = "bQuestOff";
            this.bQuestOff.Size = new System.Drawing.Size(58, 37);
            this.bQuestOff.TabIndex = 13;
            this.bQuestOff.TabStop = false;
            this.bQuestOff.Text = "OFF";
            this.bQuestOff.UseVisualStyleBackColor = true;
            this.bQuestOff.Click += new System.EventHandler(this.bQuestOff_Click);
            // 
            // bQuestOn
            // 
            this.bQuestOn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bQuestOn.Location = new System.Drawing.Point(5, 3);
            this.bQuestOn.Name = "bQuestOn";
            this.bQuestOn.Size = new System.Drawing.Size(58, 37);
            this.bQuestOn.TabIndex = 12;
            this.bQuestOn.TabStop = false;
            this.bQuestOn.Text = "ON";
            this.bQuestOn.UseVisualStyleBackColor = true;
            this.bQuestOn.Click += new System.EventHandler(this.bQuestOn_Click);
            // 
            // bQuestRefresh
            // 
            this.bQuestRefresh.Location = new System.Drawing.Point(5, 46);
            this.bQuestRefresh.Name = "bQuestRefresh";
            this.bQuestRefresh.Size = new System.Drawing.Size(122, 55);
            this.bQuestRefresh.TabIndex = 11;
            this.bQuestRefresh.TabStop = false;
            this.bQuestRefresh.Text = "Aktualizuj";
            this.bQuestRefresh.UseVisualStyleBackColor = true;
            this.bQuestRefresh.Click += new System.EventHandler(this.bQuestRefresh_Click);
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
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.tbNextQuestDt);
            this.groupBox7.Controls.Add(this.tbLastQuestDt);
            this.groupBox7.Controls.Add(this.label15);
            this.groupBox7.Controls.Add(this.label14);
            this.groupBox7.Location = new System.Drawing.Point(606, 196);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(122, 61);
            this.groupBox7.TabIndex = 14;
            this.groupBox7.TabStop = false;
            // 
            // tbNextQuestDt
            // 
            this.tbNextQuestDt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbNextQuestDt.Location = new System.Drawing.Point(68, 36);
            this.tbNextQuestDt.Name = "tbNextQuestDt";
            this.tbNextQuestDt.ReadOnly = true;
            this.tbNextQuestDt.Size = new System.Drawing.Size(48, 13);
            this.tbNextQuestDt.TabIndex = 17;
            this.tbNextQuestDt.TabStop = false;
            this.tbNextQuestDt.Text = "00:00:00";
            this.tbNextQuestDt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbLastQuestDt
            // 
            this.tbLastQuestDt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbLastQuestDt.Location = new System.Drawing.Point(72, 16);
            this.tbLastQuestDt.Name = "tbLastQuestDt";
            this.tbLastQuestDt.ReadOnly = true;
            this.tbLastQuestDt.Size = new System.Drawing.Size(44, 13);
            this.tbLastQuestDt.TabIndex = 16;
            this.tbLastQuestDt.TabStop = false;
            this.tbLastQuestDt.Text = "00:00:00";
            this.tbLastQuestDt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 36);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(56, 13);
            this.label15.TabIndex = 15;
            this.label15.Text = "Następne:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 16);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 13);
            this.label14.TabIndex = 14;
            this.label14.Text = "Ostatnie:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.tbRelicName);
            this.groupBox5.Controls.Add(this.btRelicsOff);
            this.groupBox5.Controls.Add(this.btRelicsOn);
            this.groupBox5.Controls.Add(this.tbHourField);
            this.groupBox5.Location = new System.Drawing.Point(6, 370);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(230, 97);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            // 
            // tbRelicName
            // 
            this.tbRelicName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbRelicName.Location = new System.Drawing.Point(9, 42);
            this.tbRelicName.Name = "tbRelicName";
            this.tbRelicName.Size = new System.Drawing.Size(215, 20);
            this.tbRelicName.TabIndex = 3;
            // 
            // btRelicsOff
            // 
            this.btRelicsOff.Enabled = false;
            this.btRelicsOff.Location = new System.Drawing.Point(119, 68);
            this.btRelicsOff.Name = "btRelicsOff";
            this.btRelicsOff.Size = new System.Drawing.Size(105, 23);
            this.btRelicsOff.TabIndex = 2;
            this.btRelicsOff.Text = "OFF";
            this.btRelicsOff.UseVisualStyleBackColor = true;
            this.btRelicsOff.Click += new System.EventHandler(this.btRelicsOff_Click);
            // 
            // btRelicsOn
            // 
            this.btRelicsOn.Location = new System.Drawing.Point(9, 68);
            this.btRelicsOn.Name = "btRelicsOn";
            this.btRelicsOn.Size = new System.Drawing.Size(105, 23);
            this.btRelicsOn.TabIndex = 1;
            this.btRelicsOn.Text = "ON";
            this.btRelicsOn.UseVisualStyleBackColor = true;
            this.btRelicsOn.Click += new System.EventHandler(this.btRelicsOn_Click);
            // 
            // tbHourField
            // 
            this.tbHourField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbHourField.Location = new System.Drawing.Point(9, 19);
            this.tbHourField.Name = "tbHourField";
            this.tbHourField.Size = new System.Drawing.Size(215, 20);
            this.tbHourField.TabIndex = 0;
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
            this.lbLog.Location = new System.Drawing.Point(6, 473);
            this.lbLog.Name = "lbLog";
            this.lbLog.ScrollAlwaysVisible = true;
            this.lbLog.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lbLog.Size = new System.Drawing.Size(591, 104);
            this.lbLog.TabIndex = 0;
            this.lbLog.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(731, 583);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Obsługa Ręczna";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ofdAttackFile
            // 
            this.ofdAttackFile.FileName = "lista.txt";
            this.ofdAttackFile.Filter = "Plik text|*.txt|Wszystkie pliki|*.*";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbAttackNext);
            this.groupBox2.Controls.Add(this.tbAttackLast);
            this.groupBox2.Controls.Add(this.tbAttackCash);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Location = new System.Drawing.Point(605, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(123, 80);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
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
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 35);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(49, 13);
            this.label18.TabIndex = 2;
            this.label18.Text = "Ostatnie:";
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
            // tbAttackName
            // 
            this.tbAttackName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbAttackName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbAttackName.Location = new System.Drawing.Point(242, 170);
            this.tbAttackName.Name = "tbAttackName";
            this.tbAttackName.Size = new System.Drawing.Size(273, 20);
            this.tbAttackName.TabIndex = 21;
            // 
            // btAttackAdd
            // 
            this.btAttackAdd.Location = new System.Drawing.Point(521, 170);
            this.btAttackAdd.Name = "btAttackAdd";
            this.btAttackAdd.Size = new System.Drawing.Size(35, 20);
            this.btAttackAdd.TabIndex = 22;
            this.btAttackAdd.Text = "+";
            this.btAttackAdd.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btAttackAdd.UseVisualStyleBackColor = true;
            this.btAttackAdd.Click += new System.EventHandler(this.btAttackAdd_Click);
            // 
            // btAttackRemove
            // 
            this.btAttackRemove.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btAttackRemove.Location = new System.Drawing.Point(562, 170);
            this.btAttackRemove.Margin = new System.Windows.Forms.Padding(0);
            this.btAttackRemove.Name = "btAttackRemove";
            this.btAttackRemove.Size = new System.Drawing.Size(35, 20);
            this.btAttackRemove.TabIndex = 23;
            this.btAttackRemove.Text = "-";
            this.btAttackRemove.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btAttackRemove.UseVisualStyleBackColor = true;
            this.btAttackRemove.Click += new System.EventHandler(this.btAttackRemove_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 622);
            this.Controls.Add(this.tbControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Parafia";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tbControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.pQuestsButtons.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        public System.Windows.Forms.ListView lvQuests;
        public System.Windows.Forms.ColumnHeader chCheckbox;
        public System.Windows.Forms.ColumnHeader chQuestName;
        public System.Windows.Forms.ColumnHeader chQuestProgress;
        public System.Windows.Forms.ListBox lbLog;
        public System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.GroupBox groupBox5;
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
        public System.Windows.Forms.Button bQuestOn;
        public System.Windows.Forms.Button bQuestRefresh;
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
        public System.Windows.Forms.GroupBox groupBox7;
        public System.Windows.Forms.Label label15;
        public System.Windows.Forms.Label label14;
        public System.Windows.Forms.Button bQuestOff;
        public System.Windows.Forms.TextBox tbNextQuestDt;
        public System.Windows.Forms.TextBox tbLastQuestDt;
        public System.Windows.Forms.Panel pQuestsButtons;
        public System.Windows.Forms.GroupBox groupBox8;
        public System.Windows.Forms.Button btRelicsOff;
        public System.Windows.Forms.Button btRelicsOn;
        public System.Windows.Forms.TextBox tbHourField;
        public System.Windows.Forms.TextBox tbRelicName;
        public System.Windows.Forms.ListView lvAttackList;
        public System.Windows.Forms.ColumnHeader chCheck;
        public System.Windows.Forms.ColumnHeader chName;
        public System.Windows.Forms.ColumnHeader chCash;
        public System.Windows.Forms.ColumnHeader chNo;
        public System.Windows.Forms.Button btAttackFile;
        public System.Windows.Forms.Button btAttackON;
        public System.Windows.Forms.Button btAttackOFF;
        public System.Windows.Forms.OpenFileDialog ofdAttackFile;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbAttackNext;
        private System.Windows.Forms.TextBox tbAttackLast;
        private System.Windows.Forms.TextBox tbAttackCash;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btAttackRemove;
        private System.Windows.Forms.Button btAttackAdd;
        private System.Windows.Forms.TextBox tbAttackName;
    }
}

