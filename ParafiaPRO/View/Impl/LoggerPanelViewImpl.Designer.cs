namespace ParafiaPRO.View.Impl
{
    partial class LoggerPanelViewImpl
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
            this.rtbMainLog = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtbMainLog
            // 
            this.rtbMainLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbMainLog.Location = new System.Drawing.Point(0, 0);
            this.rtbMainLog.Name = "rtbMainLog";
            this.rtbMainLog.Size = new System.Drawing.Size(796, 535);
            this.rtbMainLog.TabIndex = 0;
            this.rtbMainLog.Text = "";
            // 
            // LoggerPanelViewImpl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rtbMainLog);
            this.Name = "LoggerPanelViewImpl";
            this.Size = new System.Drawing.Size(796, 535);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.RichTextBox rtbMainLog;

    }
}
