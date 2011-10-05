using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PBizBot.Model
{
    public partial class Account
    {
        private String m_login;
        private String m_passwd;

        private Boolean m_enabled;
        private Boolean m_selected;
        private Boolean m_attacker;

        private Boolean m_sentEmailCheckBox;
        private TimeSpan m_nextLoginTimeSpan;

        private int m_hitCount;

        public Account()
        {
            m_sentEmailCheckBox = false;
            m_enabled = true;
        }

        public String Login
        {
            get { return this.m_login; }
            set { this.m_login = value; }
        }

        public String Passwd
        {
            get { return this.m_passwd; }
            set { this.m_passwd = value; }
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

        public Boolean Attacker
        {
            get { return this.m_attacker; }
            set { this.m_attacker = value; }
        }

        public Boolean SentMail
        {
            get { return this.m_sentEmailCheckBox; }
            set { this.m_sentEmailCheckBox = value; }
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
