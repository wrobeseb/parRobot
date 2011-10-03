using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PBizBot.Model
{
    public class Account
    {
        //private String m_login;
        private TextBox m_login;
        private TextBox m_passwd;

        private Boolean m_enabled;
        private Boolean m_selected;

        private Attributes m_attributes;

        private Boolean m_sentEmailCheckBox;
        private Boolean m_attackCheckBox;

        private Boolean m_isRootAccount;

        private TimeSpan m_nextLoginTimeSpan;
        private int m_hitCount;



        public Account(Boolean isRootAccount)
        {
            this.m_login = new TextBox();
            this.m_login.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.m_login.Location = new System.Drawing.Point(45, 3);
            this.m_login.Name = "tbLogin";
            this.m_login.ReadOnly = true;
            this.m_login.Size = new System.Drawing.Size(60, 13);
            this.m_login.TabIndex = 0;

            this.m_passwd = new TextBox();
            this.m_passwd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.m_passwd.Location = new System.Drawing.Point(107, 3);
            this.m_passwd.Name = "tbPasswd";
            this.m_passwd.ReadOnly = true;
            this.m_passwd.Size = new System.Drawing.Size(72, 13);
            this.m_passwd.TabIndex = 1;
            this.m_passwd.AcceptsReturn = false;
            this.m_passwd.UseSystemPasswordChar = true;
            this.m_passwd.MouseEnter += new System.EventHandler(this.m_passwd_MouseEnter);
            this.m_passwd.MouseLeave += new System.EventHandler(this.m_passwd_MouseLeave);

            m_isRootAccount = isRootAccount;
            m_sentEmailCheckBox = false;
            m_attackCheckBox = false;
            m_enabled = true;
        }

        private void m_passwd_MouseEnter(object sender, EventArgs e)
        {
            m_passwd.ReadOnly = false;
        }

        private void m_passwd_MouseLeave(object sender, EventArgs e)
        {
            m_passwd.ReadOnly = true;
        }

        public String Login
        {
            get { return this.m_login.Text; }
            set { this.m_login.Text = value; }
        }

        public TextBox LoginCtr
        {
            get { return this.m_login; }
        }

        public String Passwd
        {
            get { return this.m_passwd.Text; }
            set { this.m_passwd.Text = value; }
        }

        public TextBox PasswdCtr
        {
            get { return this.m_passwd; }
        }

        public Boolean Enabled
        {
            get { return this.m_enabled; }
            set { this.m_enabled = value; }
        }

        public Boolean Selected
        {
            get { return this.m_selected; }
            set { this.m_selected = value; }
        }

        public Attributes Attributes
        {
            get { return this.m_attributes; }
            set { this.m_attributes = value; }
        }

        public Boolean SentMail
        {
            get { return this.m_sentEmailCheckBox; }
            set { this.m_sentEmailCheckBox = value; }
        }

        public Boolean Attacker
        {
            get { return this.m_attackCheckBox; }
            set { this.m_attackCheckBox = value; }
        }

        public Boolean RootAccount
        {
            get { return this.m_isRootAccount; }
            set { this.m_isRootAccount = value; }
        }

        public TimeSpan NextLoginTime
        {
            get { return this.m_nextLoginTimeSpan; }
            set { this.m_nextLoginTimeSpan = value; }
        }

        public int HitCount
        {
            get { return this.m_hitCount; }
            set { this.m_hitCount = value; }
        }
    }
}
