namespace BipAnna
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
            this.btStop = new System.Windows.Forms.Button();
            this.btStart = new System.Windows.Forms.Button();
            this.tbMailHost = new System.Windows.Forms.TextBox();
            this.tbMailLogin = new System.Windows.Forms.TextBox();
            this.tbMailPassword = new System.Windows.Forms.TextBox();
            this.tbMailPort = new System.Windows.Forms.TextBox();
            this.tbMailTo = new System.Windows.Forms.TextBox();
            this.tbMailSubject = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbSentMails = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbProxyPort = new System.Windows.Forms.TextBox();
            this.tbProxyPassword = new System.Windows.Forms.TextBox();
            this.tbProxyLogin = new System.Windows.Forms.TextBox();
            this.tbProxyHost = new System.Windows.Forms.TextBox();
            this.tbProxyDomain = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbMailSendHits = new System.Windows.Forms.TextBox();
            this.tbNextDt = new System.Windows.Forms.TextBox();
            this.tbLastDt = new System.Windows.Forms.TextBox();
            this.tbUpTime = new System.Windows.Forms.TextBox();
            this.tbSystemTime = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tbTimeSpan = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btStop
            // 
            this.btStop.Enabled = false;
            this.btStop.Location = new System.Drawing.Point(116, 169);
            this.btStop.Name = "btStop";
            this.btStop.Size = new System.Drawing.Size(75, 23);
            this.btStop.TabIndex = 0;
            this.btStop.Text = "Stop";
            this.btStop.UseVisualStyleBackColor = true;
            this.btStop.Click += new System.EventHandler(this.btStop_Click);
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(12, 169);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(85, 23);
            this.btStart.TabIndex = 1;
            this.btStart.Text = "Start";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // tbMailHost
            // 
            this.tbMailHost.Location = new System.Drawing.Point(68, 48);
            this.tbMailHost.Name = "tbMailHost";
            this.tbMailHost.Size = new System.Drawing.Size(100, 20);
            this.tbMailHost.TabIndex = 2;
            // 
            // tbMailLogin
            // 
            this.tbMailLogin.Location = new System.Drawing.Point(68, 74);
            this.tbMailLogin.Name = "tbMailLogin";
            this.tbMailLogin.Size = new System.Drawing.Size(148, 20);
            this.tbMailLogin.TabIndex = 3;
            // 
            // tbMailPassword
            // 
            this.tbMailPassword.Location = new System.Drawing.Point(68, 100);
            this.tbMailPassword.Name = "tbMailPassword";
            this.tbMailPassword.Size = new System.Drawing.Size(148, 20);
            this.tbMailPassword.TabIndex = 4;
            this.tbMailPassword.UseSystemPasswordChar = true;
            // 
            // tbMailPort
            // 
            this.tbMailPort.Location = new System.Drawing.Point(174, 48);
            this.tbMailPort.Name = "tbMailPort";
            this.tbMailPort.Size = new System.Drawing.Size(42, 20);
            this.tbMailPort.TabIndex = 5;
            // 
            // tbMailTo
            // 
            this.tbMailTo.Location = new System.Drawing.Point(68, 126);
            this.tbMailTo.Name = "tbMailTo";
            this.tbMailTo.Size = new System.Drawing.Size(148, 20);
            this.tbMailTo.TabIndex = 6;
            // 
            // tbMailSubject
            // 
            this.tbMailSubject.Location = new System.Drawing.Point(68, 152);
            this.tbMailSubject.Name = "tbMailSubject";
            this.tbMailSubject.Size = new System.Drawing.Size(148, 20);
            this.tbMailSubject.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbSentMails);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbMailHost);
            this.groupBox1.Controls.Add(this.tbMailSubject);
            this.groupBox1.Controls.Add(this.tbMailLogin);
            this.groupBox1.Controls.Add(this.tbMailTo);
            this.groupBox1.Controls.Add(this.tbMailPassword);
            this.groupBox1.Controls.Add(this.tbMailPort);
            this.groupBox1.Location = new System.Drawing.Point(249, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(222, 186);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Tytuł";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "eMail";
            // 
            // cbSentMails
            // 
            this.cbSentMails.AutoSize = true;
            this.cbSentMails.Location = new System.Drawing.Point(9, 19);
            this.cbSentMails.Name = "cbSentMails";
            this.cbSentMails.Size = new System.Drawing.Size(91, 17);
            this.cbSentMails.TabIndex = 9;
            this.cbSentMails.Text = "Wysyłaj maile";
            this.cbSentMails.UseVisualStyleBackColor = true;
            this.cbSentMails.CheckedChanged += new System.EventHandler(this.cbSentMails_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Hasło";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Login";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Host/Port";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.tbProxyPort);
            this.groupBox2.Controls.Add(this.tbProxyPassword);
            this.groupBox2.Controls.Add(this.tbProxyLogin);
            this.groupBox2.Controls.Add(this.tbProxyHost);
            this.groupBox2.Controls.Add(this.tbProxyDomain);
            this.groupBox2.Location = new System.Drawing.Point(477, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(222, 128);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Hasło";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Login";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Domena";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Host/Port";
            // 
            // tbProxyPort
            // 
            this.tbProxyPort.Location = new System.Drawing.Point(172, 19);
            this.tbProxyPort.Name = "tbProxyPort";
            this.tbProxyPort.Size = new System.Drawing.Size(42, 20);
            this.tbProxyPort.TabIndex = 8;
            // 
            // tbProxyPassword
            // 
            this.tbProxyPassword.Location = new System.Drawing.Point(66, 97);
            this.tbProxyPassword.Name = "tbProxyPassword";
            this.tbProxyPassword.Size = new System.Drawing.Size(148, 20);
            this.tbProxyPassword.TabIndex = 3;
            this.tbProxyPassword.UseSystemPasswordChar = true;
            // 
            // tbProxyLogin
            // 
            this.tbProxyLogin.Location = new System.Drawing.Point(66, 71);
            this.tbProxyLogin.Name = "tbProxyLogin";
            this.tbProxyLogin.Size = new System.Drawing.Size(148, 20);
            this.tbProxyLogin.TabIndex = 2;
            // 
            // tbProxyHost
            // 
            this.tbProxyHost.Location = new System.Drawing.Point(66, 19);
            this.tbProxyHost.Name = "tbProxyHost";
            this.tbProxyHost.Size = new System.Drawing.Size(100, 20);
            this.tbProxyHost.TabIndex = 0;
            // 
            // tbProxyDomain
            // 
            this.tbProxyDomain.Location = new System.Drawing.Point(66, 45);
            this.tbProxyDomain.Name = "tbProxyDomain";
            this.tbProxyDomain.Size = new System.Drawing.Size(148, 20);
            this.tbProxyDomain.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbMailSendHits);
            this.groupBox3.Controls.Add(this.tbNextDt);
            this.groupBox3.Controls.Add(this.tbLastDt);
            this.groupBox3.Controls.Add(this.tbUpTime);
            this.groupBox3.Controls.Add(this.tbSystemTime);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Location = new System.Drawing.Point(12, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(231, 157);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            // 
            // tbMailSendHits
            // 
            this.tbMailSendHits.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbMailSendHits.Location = new System.Drawing.Point(104, 129);
            this.tbMailSendHits.Name = "tbMailSendHits";
            this.tbMailSendHits.ReadOnly = true;
            this.tbMailSendHits.Size = new System.Drawing.Size(121, 13);
            this.tbMailSendHits.TabIndex = 9;
            this.tbMailSendHits.Text = "0";
            this.tbMailSendHits.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbNextDt
            // 
            this.tbNextDt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbNextDt.Location = new System.Drawing.Point(104, 103);
            this.tbNextDt.Name = "tbNextDt";
            this.tbNextDt.ReadOnly = true;
            this.tbNextDt.Size = new System.Drawing.Size(121, 13);
            this.tbNextDt.TabIndex = 8;
            this.tbNextDt.Text = "0000-00-00 00:00:00";
            this.tbNextDt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbLastDt
            // 
            this.tbLastDt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbLastDt.Location = new System.Drawing.Point(104, 77);
            this.tbLastDt.Name = "tbLastDt";
            this.tbLastDt.ReadOnly = true;
            this.tbLastDt.Size = new System.Drawing.Size(121, 13);
            this.tbLastDt.TabIndex = 7;
            this.tbLastDt.Text = "0000-00-00 00:00:00";
            this.tbLastDt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbUpTime
            // 
            this.tbUpTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbUpTime.Location = new System.Drawing.Point(104, 51);
            this.tbUpTime.Name = "tbUpTime";
            this.tbUpTime.ReadOnly = true;
            this.tbUpTime.Size = new System.Drawing.Size(121, 13);
            this.tbUpTime.TabIndex = 6;
            this.tbUpTime.Text = "00 00:00:00";
            this.tbUpTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbSystemTime
            // 
            this.tbSystemTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSystemTime.Location = new System.Drawing.Point(104, 25);
            this.tbSystemTime.Name = "tbSystemTime";
            this.tbSystemTime.ReadOnly = true;
            this.tbSystemTime.Size = new System.Drawing.Size(121, 13);
            this.tbSystemTime.TabIndex = 5;
            this.tbSystemTime.Text = "0000-00-00 00:00:00";
            this.tbSystemTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 51);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(99, 13);
            this.label14.TabIndex = 4;
            this.label14.Text = "Czas uruchomienia:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 25);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(87, 13);
            this.label13.TabIndex = 3;
            this.label13.Text = "Czas systemowy:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 129);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "Wysłań:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 103);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Następny:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 77);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Ostatni:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.tbTimeSpan);
            this.groupBox4.Location = new System.Drawing.Point(477, 139);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(222, 53);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 22);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 13);
            this.label15.TabIndex = 1;
            this.label15.Text = "Odstęp";
            // 
            // tbTimeSpan
            // 
            this.tbTimeSpan.Location = new System.Drawing.Point(66, 19);
            this.tbTimeSpan.Name = "tbTimeSpan";
            this.tbTimeSpan.Size = new System.Drawing.Size(148, 20);
            this.tbTimeSpan.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 202);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btStart);
            this.Controls.Add(this.btStop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btStop;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.TextBox tbMailHost;
        private System.Windows.Forms.TextBox tbMailLogin;
        private System.Windows.Forms.TextBox tbMailPassword;
        private System.Windows.Forms.TextBox tbMailPort;
        private System.Windows.Forms.TextBox tbMailTo;
        private System.Windows.Forms.TextBox tbMailSubject;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbSentMails;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbProxyPort;
        private System.Windows.Forms.TextBox tbProxyPassword;
        private System.Windows.Forms.TextBox tbProxyLogin;
        private System.Windows.Forms.TextBox tbProxyHost;
        private System.Windows.Forms.TextBox tbProxyDomain;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbMailSendHits;
        private System.Windows.Forms.TextBox tbNextDt;
        private System.Windows.Forms.TextBox tbLastDt;
        private System.Windows.Forms.TextBox tbUpTime;
        private System.Windows.Forms.TextBox tbSystemTime;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbTimeSpan;
    }
}

