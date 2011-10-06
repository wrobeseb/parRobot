using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Text;
using System.Windows.Forms;

namespace PBizBot.Model
{
    [Table(Name="account")]
    public class Account
    {
        private int m_id;

        private String m_login;
        private String m_passwd;

        private Boolean m_enabled;
        private Boolean m_selected;
        private Boolean m_attacker;

        private Boolean m_sentEmailCheckBox;
        private TimeSpan m_nextLoginTimeSpan;

        private AccountAttributes m_attributes;
        private AccountSettings m_settings;
        private AccountUnits m_units;

        private int m_hitCount;

        public Account()
        {
            m_attributes = new AccountAttributes();
            m_settings = new AccountSettings();
            m_units = new AccountUnits();

            m_sentEmailCheckBox = false;
            m_enabled = true;
        }

        [Column(Name="id", Storage="m_id", IsPrimaryKey=true, IsDbGenerated=true, DbType="int NOT NULL IDENTITY", CanBeNull=false)]
        public int Id
        {
            get { return this.m_id; }
            set { this.m_id = value; }
        }

        [Column(Name = "login", Storage = "m_login")]
        public String Login
        {
            get { return this.m_login; }
            set { this.m_login = value; }
        }

        [Column(Name = "passwd", Storage = "m_passwd")]
        public String Passwd
        {
            get { return this.m_passwd; }
            set { this.m_passwd = value; }
        }

        [Column(Name = "enabled", Storage = "m_enabled")]
        public Boolean Enabled
        {
            get { return this.m_enabled; }
            set { this.m_enabled = value; }
        }

        [Column(Name = "selected", Storage = "m_selected")]
        public Boolean Selected
        {
            get { return this.m_selected; }
            set { this.m_selected = value; }
        }

        [Column(Name = "attacker", Storage = "m_attacker")]
        public Boolean Attacker
        {
            get { return this.m_attacker; }
            set { this.m_attacker = value; }
        }

        [Column(Name = "sent_mail", Storage = "m_sentEmailCheckBox")]
        public Boolean SentMail
        {
            get { return this.m_sentEmailCheckBox; }
            set { this.m_sentEmailCheckBox = value; }
        }

        [Column(Name = "next_login", Storage = "m_nextLoginTimeSpan")]
        public TimeSpan NextLoginTime
        {
            get { return this.m_nextLoginTimeSpan; }
            set { this.m_nextLoginTimeSpan = value; }
        }

        [Column(Name = "hit_count", Storage = "m_hitCount")]
        public int HitCount
        {
            get { return this.m_hitCount; }
            set { this.m_hitCount = value; }
        }

        public AccountAttributes Attributes
        {
            get { return this.m_attributes; }
        }

        public AccountSettings Settings
        {
            get { return this.m_settings; }
        }

        public AccountUnits Units
        {
            get { return this.m_units; }
        }
    }
}
