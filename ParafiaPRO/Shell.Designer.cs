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
            this.SuspendLayout();
            // 
            // AccountRegion
            // 
            this.AccountRegion.Location = new System.Drawing.Point(12, 12);
            this.AccountRegion.Name = "AccountRegion";
            this.AccountRegion.Size = new System.Drawing.Size(973, 188);
            this.AccountRegion.TabIndex = 0;
            this.AccountRegion.TabStop = false;
            // 
            // ControlPanelRegion
            // 
            this.ControlPanelRegion.Location = new System.Drawing.Point(991, 12);
            this.ControlPanelRegion.Name = "ControlPanelRegion";
            this.ControlPanelRegion.Size = new System.Drawing.Size(206, 188);
            this.ControlPanelRegion.TabIndex = 1;
            this.ControlPanelRegion.TabStop = false;
            // 
            // Shell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 410);
            this.Controls.Add(this.ControlPanelRegion);
            this.Controls.Add(this.AccountRegion);
            this.Name = "Shell";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.Shell_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox AccountRegion;
        private System.Windows.Forms.GroupBox ControlPanelRegion;
    }
}