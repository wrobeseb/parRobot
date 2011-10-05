namespace PBizBot.View
{
    partial class BotMainPanel
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
            this.lbLog = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbStats = new System.Windows.Forms.TabPage();
            this.tbMailBox = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tabControl1.SuspendLayout();
            this.tbStats.SuspendLayout();
            this.tbMailBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbLog
            // 
            this.lbLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbLog.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbLog.FormattingEnabled = true;
            this.lbLog.Location = new System.Drawing.Point(3, 416);
            this.lbLog.Name = "lbLog";
            this.lbLog.ScrollAlwaysVisible = true;
            this.lbLog.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lbLog.Size = new System.Drawing.Size(536, 104);
            this.lbLog.TabIndex = 3;
            this.lbLog.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tbStats);
            this.tabControl1.Controls.Add(this.tbMailBox);
            this.tabControl1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(542, 410);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 4;
            // 
            // tbStats
            // 
            this.tbStats.Controls.Add(this.groupBox2);
            this.tbStats.Location = new System.Drawing.Point(4, 25);
            this.tbStats.Name = "tbStats";
            this.tbStats.Padding = new System.Windows.Forms.Padding(3);
            this.tbStats.Size = new System.Drawing.Size(534, 381);
            this.tbStats.TabIndex = 0;
            this.tbStats.Text = "Staty";
            this.tbStats.UseVisualStyleBackColor = true;
            // 
            // tbMailBox
            // 
            this.tbMailBox.Controls.Add(this.groupBox1);
            this.tbMailBox.Location = new System.Drawing.Point(4, 25);
            this.tbMailBox.Name = "tbMailBox";
            this.tbMailBox.Padding = new System.Windows.Forms.Padding(3);
            this.tbMailBox.Size = new System.Drawing.Size(534, 381);
            this.tbMailBox.TabIndex = 1;
            this.tbMailBox.Text = "Poczta";
            this.tbMailBox.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(534, 381);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(534, 381);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // BotMainPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lbLog);
            this.Name = "BotMainPanel";
            this.Size = new System.Drawing.Size(542, 523);
            this.tabControl1.ResumeLayout(false);
            this.tbStats.ResumeLayout(false);
            this.tbMailBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListBox lbLog;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbStats;
        private System.Windows.Forms.TabPage tbMailBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}
