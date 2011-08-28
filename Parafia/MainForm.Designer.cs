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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lbLog = new System.Windows.Forms.ListBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.tbControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.tbControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(6, 10);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(143, 51);
            this.btStart.TabIndex = 0;
            this.btStart.TabStop = false;
            this.btStart.Text = "Start";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // btStop
            // 
            this.btStop.Enabled = false;
            this.btStop.Location = new System.Drawing.Point(6, 67);
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
            this.tbUpTime.Text = "00:00:00";
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
            this.groupBox2.Size = new System.Drawing.Size(370, 101);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // bConfig
            // 
            this.bConfig.Location = new System.Drawing.Point(6, 96);
            this.bConfig.Name = "bConfig";
            this.bConfig.Size = new System.Drawing.Size(143, 23);
            this.bConfig.TabIndex = 5;
            this.bConfig.TabStop = false;
            this.bConfig.Text = "Ustawienia";
            this.bConfig.UseVisualStyleBackColor = true;
            this.bConfig.Click += new System.EventHandler(this.bConfig_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(6, 113);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(230, 218);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(242, 113);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(370, 218);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lbLog);
            this.groupBox5.Location = new System.Drawing.Point(6, 337);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(445, 125);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            // 
            // lbLog
            // 
            this.lbLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbLog.FormattingEnabled = true;
            this.lbLog.Location = new System.Drawing.Point(9, 20);
            this.lbLog.Name = "lbLog";
            this.lbLog.ScrollAlwaysVisible = true;
            this.lbLog.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lbLog.Size = new System.Drawing.Size(430, 93);
            this.lbLog.TabIndex = 0;
            this.lbLog.TabStop = false;
            this.lbLog.UseWaitCursor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btStop);
            this.groupBox6.Controls.Add(this.btStart);
            this.groupBox6.Controls.Add(this.bConfig);
            this.groupBox6.Location = new System.Drawing.Point(457, 337);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(155, 125);
            this.groupBox6.TabIndex = 9;
            this.groupBox6.TabStop = false;
            // 
            // tbControl
            // 
            this.tbControl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tbControl.Controls.Add(this.tabPage1);
            this.tbControl.Controls.Add(this.tabPage2);
            this.tbControl.Location = new System.Drawing.Point(2, 7);
            this.tbControl.Name = "tbControl";
            this.tbControl.SelectedIndex = 0;
            this.tbControl.Size = new System.Drawing.Size(627, 496);
            this.tbControl.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.groupBox6);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox5);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(619, 467);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Automat";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(619, 467);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Obsługa Ręczna";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 504);
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
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.tbControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TabControl tbControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        public System.Windows.Forms.ListBox lbLog;
    }
}

