namespace PBizBot.View
{
    partial class AttackListItem
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
            this.cbEnabled = new System.Windows.Forms.CheckBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbCash = new System.Windows.Forms.TextBox();
            this.tbWin = new System.Windows.Forms.TextBox();
            this.tbLose = new System.Windows.Forms.TextBox();
            this.tbLastAttackDt = new System.Windows.Forms.TextBox();
            this.lbDelete = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // cbEnabled
            // 
            this.cbEnabled.AutoSize = true;
            this.cbEnabled.Location = new System.Drawing.Point(3, 3);
            this.cbEnabled.Name = "cbEnabled";
            this.cbEnabled.Size = new System.Drawing.Size(15, 14);
            this.cbEnabled.TabIndex = 0;
            this.cbEnabled.UseVisualStyleBackColor = true;
            // 
            // tbName
            // 
            this.tbName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbName.Location = new System.Drawing.Point(24, 3);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(141, 13);
            this.tbName.TabIndex = 1;
            // 
            // tbCash
            // 
            this.tbCash.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbCash.Location = new System.Drawing.Point(171, 3);
            this.tbCash.Name = "tbCash";
            this.tbCash.Size = new System.Drawing.Size(73, 13);
            this.tbCash.TabIndex = 2;
            this.tbCash.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbWin
            // 
            this.tbWin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbWin.Location = new System.Drawing.Point(250, 3);
            this.tbWin.Name = "tbWin";
            this.tbWin.Size = new System.Drawing.Size(50, 13);
            this.tbWin.TabIndex = 3;
            this.tbWin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbLose
            // 
            this.tbLose.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbLose.Location = new System.Drawing.Point(306, 3);
            this.tbLose.Name = "tbLose";
            this.tbLose.Size = new System.Drawing.Size(50, 13);
            this.tbLose.TabIndex = 4;
            this.tbLose.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbLastAttackDt
            // 
            this.tbLastAttackDt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbLastAttackDt.Location = new System.Drawing.Point(362, 3);
            this.tbLastAttackDt.Name = "tbLastAttackDt";
            this.tbLastAttackDt.Size = new System.Drawing.Size(115, 13);
            this.tbLastAttackDt.TabIndex = 5;
            this.tbLastAttackDt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbDelete
            // 
            this.lbDelete.Image = global::PBizBot.Properties.Resources.minus;
            this.lbDelete.Location = new System.Drawing.Point(485, 2);
            this.lbDelete.Name = "lbDelete";
            this.lbDelete.Size = new System.Drawing.Size(16, 16);
            this.lbDelete.TabIndex = 6;
            // 
            // AttackListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbDelete);
            this.Controls.Add(this.tbLastAttackDt);
            this.Controls.Add(this.tbLose);
            this.Controls.Add(this.tbWin);
            this.Controls.Add(this.tbCash);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.cbEnabled);
            this.Name = "AttackListItem";
            this.Size = new System.Drawing.Size(505, 19);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbEnabled;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbCash;
        private System.Windows.Forms.TextBox tbWin;
        private System.Windows.Forms.TextBox tbLose;
        private System.Windows.Forms.TextBox tbLastAttackDt;
        private System.Windows.Forms.LinkLabel lbDelete;
    }
}
