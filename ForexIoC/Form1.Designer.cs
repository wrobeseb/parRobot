namespace ForexIoC
{
    partial class Form1
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
            this.gbChart = new System.Windows.Forms.GroupBox();
            this.pChart = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.gbChart.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbChart
            // 
            this.gbChart.BackColor = System.Drawing.SystemColors.Control;
            this.gbChart.Controls.Add(this.pChart);
            this.gbChart.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gbChart.Location = new System.Drawing.Point(9, 9);
            this.gbChart.Margin = new System.Windows.Forms.Padding(0);
            this.gbChart.Name = "gbChart";
            this.gbChart.Padding = new System.Windows.Forms.Padding(0);
            this.gbChart.Size = new System.Drawing.Size(507, 321);
            this.gbChart.TabIndex = 0;
            this.gbChart.TabStop = false;
            // 
            // pChart
            // 
            this.pChart.BackColor = System.Drawing.Color.White;
            this.pChart.Location = new System.Drawing.Point(3, 16);
            this.pChart.Name = "pChart";
            this.pChart.Size = new System.Drawing.Size(500, 300);
            this.pChart.TabIndex = 0;
            this.pChart.Layout += new System.Windows.Forms.LayoutEventHandler(this.pChart_Layout);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 350);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(93, 350);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 394);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gbChart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbChart.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbChart;
        private System.Windows.Forms.Panel pChart;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;

    }
}

