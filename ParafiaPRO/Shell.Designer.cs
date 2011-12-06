namespace ParafiaPRO
{
    partial class Shell
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
            this.AccountRegion = new System.Windows.Forms.GroupBox();
            this.ControlPanelRegion = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbMain = new System.Windows.Forms.TabControl();
            this.tpMain = new System.Windows.Forms.TabPage();
            this.tpAccountData = new System.Windows.Forms.TabPage();
            this.SettingsPanelRegion = new System.Windows.Forms.Panel();
            this.ssMain = new System.Windows.Forms.StatusStrip();
            this.tsslSerwerTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.tpLog = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tbMain.SuspendLayout();
            this.tpMain.SuspendLayout();
            this.tpAccountData.SuspendLayout();
            this.ssMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // AccountRegion
            // 
            this.AccountRegion.Location = new System.Drawing.Point(6, 200);
            this.AccountRegion.Name = "AccountRegion";
            this.AccountRegion.Size = new System.Drawing.Size(1179, 555);
            this.AccountRegion.TabIndex = 0;
            this.AccountRegion.TabStop = false;
            // 
            // ControlPanelRegion
            // 
            this.ControlPanelRegion.Location = new System.Drawing.Point(6, 6);
            this.ControlPanelRegion.Name = "ControlPanelRegion";
            this.ControlPanelRegion.Size = new System.Drawing.Size(200, 188);
            this.ControlPanelRegion.TabIndex = 1;
            this.ControlPanelRegion.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, -6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(543, 551);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(3, 224);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(0, 0);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1186, 534);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1178, 505);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1178, 505);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(549, -6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(630, 551);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // tbMain
            // 
            this.tbMain.Controls.Add(this.tpMain);
            this.tbMain.Controls.Add(this.tpAccountData);
            this.tbMain.Controls.Add(this.tpLog);
            this.tbMain.Location = new System.Drawing.Point(3, 3);
            this.tbMain.Name = "tbMain";
            this.tbMain.SelectedIndex = 0;
            this.tbMain.Size = new System.Drawing.Size(1200, 787);
            this.tbMain.TabIndex = 4;
            // 
            // tpMain
            // 
            this.tpMain.Controls.Add(this.SettingsPanelRegion);
            this.tpMain.Controls.Add(this.AccountRegion);
            this.tpMain.Controls.Add(this.ControlPanelRegion);
            this.tpMain.Location = new System.Drawing.Point(4, 22);
            this.tpMain.Name = "tpMain";
            this.tpMain.Padding = new System.Windows.Forms.Padding(3);
            this.tpMain.Size = new System.Drawing.Size(1192, 761);
            this.tpMain.TabIndex = 0;
            this.tpMain.Text = "Panel Główny";
            this.tpMain.UseVisualStyleBackColor = true;
            // 
            // tpAccountData
            // 
            this.tpAccountData.Controls.Add(this.tabControl1);
            this.tpAccountData.Location = new System.Drawing.Point(4, 22);
            this.tpAccountData.Name = "tpAccountData";
            this.tpAccountData.Padding = new System.Windows.Forms.Padding(3);
            this.tpAccountData.Size = new System.Drawing.Size(1192, 761);
            this.tpAccountData.TabIndex = 1;
            this.tpAccountData.Text = "Dane Konta";
            this.tpAccountData.UseVisualStyleBackColor = true;
            // 
            // SettingsPanelRegion
            // 
            this.SettingsPanelRegion.Location = new System.Drawing.Point(212, 6);
            this.SettingsPanelRegion.Name = "SettingsPanelRegion";
            this.SettingsPanelRegion.Size = new System.Drawing.Size(612, 188);
            this.SettingsPanelRegion.TabIndex = 3;
            // 
            // ssMain
            // 
            this.ssMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslSerwerTime});
            this.ssMain.Location = new System.Drawing.Point(0, 795);
            this.ssMain.Name = "ssMain";
            this.ssMain.Size = new System.Drawing.Size(1204, 22);
            this.ssMain.SizingGrip = false;
            this.ssMain.TabIndex = 5;
            // 
            // tsslSerwerTime
            // 
            this.tsslSerwerTime.Name = "tsslSerwerTime";
            this.tsslSerwerTime.Size = new System.Drawing.Size(109, 17);
            this.tsslSerwerTime.Text = "toolStripStatusLabel1";
            // 
            // tpLog
            // 
            this.tpLog.Location = new System.Drawing.Point(4, 22);
            this.tpLog.Name = "tpLog";
            this.tpLog.Size = new System.Drawing.Size(1192, 761);
            this.tpLog.TabIndex = 2;
            this.tpLog.Text = "Logi";
            this.tpLog.UseVisualStyleBackColor = true;
            // 
            // Shell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 817);
            this.Controls.Add(this.ssMain);
            this.Controls.Add(this.tbMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Shell";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parafia";
            this.Load += new System.EventHandler(this.Shell_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tbMain.ResumeLayout(false);
            this.tpMain.ResumeLayout(false);
            this.tpAccountData.ResumeLayout(false);
            this.ssMain.ResumeLayout(false);
            this.ssMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox AccountRegion;
        private System.Windows.Forms.GroupBox ControlPanelRegion;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TabControl tbMain;
        private System.Windows.Forms.TabPage tpMain;
        private System.Windows.Forms.TabPage tpAccountData;
        private System.Windows.Forms.Panel SettingsPanelRegion;
        public System.Windows.Forms.StatusStrip ssMain;
        private System.Windows.Forms.ToolStripStatusLabel tsslSerwerTime;
        public System.Windows.Forms.TabPage tpLog;
    }
}