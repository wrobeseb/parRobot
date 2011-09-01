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
            this.tbHitCount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNextLogin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbUpTime = new System.Windows.Forms.TextBox();
            this.tbSystemTime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bConfig = new System.Windows.Forms.Button();
            this.tbControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lvQuests = new System.Windows.Forms.ListView();
            this.chCheckbox = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chQuestName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chQuestProgress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbLog = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.tbControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(584, 473);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(143, 48);
            this.btStart.TabIndex = 0;
            this.btStart.TabStop = false;
            this.btStart.Text = "Start";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // btStop
            // 
            this.btStop.Enabled = false;
            this.btStop.Location = new System.Drawing.Point(584, 527);
            this.btStop.Name = "btStop";
            this.btStop.Size = new System.Drawing.Size(143, 23);
            this.btStop.TabIndex = 1;
            this.btStop.TabStop = false;
            this.btStop.Text = "Stop";
            this.btStop.UseVisualStyleBackColor = true;
            this.btStop.Click += new System.EventHandler(this.btStop_Click);
            // 
            // groupBox1
            // 
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
            this.groupBox1.Size = new System.Drawing.Size(230, 101);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // tbHitCount
            // 
            this.tbHitCount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbHitCount.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tbHitCount.Location = new System.Drawing.Point(124, 76);
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
            this.label4.Location = new System.Drawing.Point(6, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ilość Logowań:";
            // 
            // tbNextLogin
            // 
            this.tbNextLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbNextLogin.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tbNextLogin.Location = new System.Drawing.Point(124, 56);
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
            this.label3.Location = new System.Drawing.Point(6, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Następne Logowanie:";
            // 
            // tbUpTime
            // 
            this.tbUpTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbUpTime.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tbUpTime.Location = new System.Drawing.Point(124, 36);
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
            this.tbSystemTime.Location = new System.Drawing.Point(124, 16);
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
            this.label2.Location = new System.Drawing.Point(6, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Czas Uruchomienia:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Czas Systemowy:";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(242, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(483, 101);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // bConfig
            // 
            this.bConfig.Location = new System.Drawing.Point(584, 556);
            this.bConfig.Name = "bConfig";
            this.bConfig.Size = new System.Drawing.Size(143, 23);
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
            this.tabPage1.Controls.Add(this.groupBox6);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox5);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.lvQuests);
            this.tabPage1.Controls.Add(this.btStop);
            this.tabPage1.Controls.Add(this.lbLog);
            this.tabPage1.Controls.Add(this.btStart);
            this.tabPage1.Controls.Add(this.bConfig);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(731, 583);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Automat";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Location = new System.Drawing.Point(6, 349);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(719, 118);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(6, 108);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(230, 61);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            // 
            // lvQuests
            // 
            this.lvQuests.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvQuests.CheckBoxes = true;
            this.lvQuests.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chCheckbox,
            this.chQuestName,
            this.chQuestProgress});
            this.lvQuests.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lvQuests.Location = new System.Drawing.Point(242, 115);
            this.lvQuests.MultiSelect = false;
            this.lvQuests.Name = "lvQuests";
            this.lvQuests.ShowGroups = false;
            this.lvQuests.Size = new System.Drawing.Size(483, 228);
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
            this.chQuestName.Width = 300;
            // 
            // chQuestProgress
            // 
            this.chQuestProgress.Text = "";
            this.chQuestProgress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chQuestProgress.Width = 130;
            // 
            // lbLog
            // 
            this.lbLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbLog.FormattingEnabled = true;
            this.lbLog.Location = new System.Drawing.Point(6, 473);
            this.lbLog.Name = "lbLog";
            this.lbLog.ScrollAlwaysVisible = true;
            this.lbLog.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lbLog.Size = new System.Drawing.Size(572, 104);
            this.lbLog.TabIndex = 0;
            this.lbLog.TabStop = false;
            this.lbLog.UseWaitCursor = true;
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Obrona:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Atak:";
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
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Location = new System.Drawing.Point(6, 175);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(230, 81);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
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
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Organiści:";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label12);
            this.groupBox6.Controls.Add(this.label11);
            this.groupBox6.Controls.Add(this.label10);
            this.groupBox6.Location = new System.Drawing.Point(6, 262);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(230, 81);
            this.groupBox6.TabIndex = 10;
            this.groupBox6.TabStop = false;
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
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 36);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Babcie Moherowe:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 56);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(124, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "Gospodynie Proboszcza:";
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
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Button btStop;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox tbUpTime;
        public System.Windows.Forms.TextBox tbSystemTime;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.TextBox tbNextLogin;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox tbHitCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bConfig;
        private System.Windows.Forms.TabControl tbControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListView lvQuests;
        private System.Windows.Forms.ColumnHeader chCheckbox;
        private System.Windows.Forms.ColumnHeader chQuestName;
        private System.Windows.Forms.ColumnHeader chQuestProgress;
        public System.Windows.Forms.ListBox lbLog;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}

