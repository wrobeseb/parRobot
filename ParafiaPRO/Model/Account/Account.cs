using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Text;
using Quartz;
using Spring.Scheduling.Quartz;

namespace ParafiaPRO.Model.Account
{
    [Table(Name = "account")]
    public class Account
    {
        private int m_id;

        private String m_login;
        private String m_passwd;

        private Boolean m_enabled = true;
        private Boolean m_selected;
        private Boolean m_attacker;

        private Boolean m_sentEmailCheckBox;

        [Column(Name = "next_login", Storage = "m_nextLoginTics", DbType = "int NOT NULL", CanBeNull = false)]
        private double m_nextLoginTics;

        private int m_hitCount;

        private JobDetail m_jobDetail;

        private Trigger m_trigger;

        public JobDetail SchedulerJobDetail
        {
            get { return this.m_jobDetail; }
            set { this.m_jobDetail = value; }
        }

        public Trigger SchedulerTrigger
        {
            get { return this.m_trigger; }
            set { this.m_trigger = value; }
        }

        [Column(Name = "id", Storage = "m_id", IsPrimaryKey = true, IsDbGenerated = true, DbType = "int NOT NULL IDENTITY", CanBeNull = false)]
        public int Id
        {
            get { return this.m_id; }
            set { this.m_id = value; }
        }

        [Column(Name = "login", Storage = "m_login", DbType = "NVARCHAR(255) NOT NULL", CanBeNull = false)]
        public String Login
        {
            get { return this.m_login; }
            set { this.m_login = value; }
        }

        [Column(Name = "passwd", Storage = "m_passwd", DbType = "NVARCHAR(255) NOT NULL", CanBeNull = false)]
        public String Passwd
        {
            get { return this.m_passwd; }
            set { this.m_passwd = value; }
        }

        [Column(Name = "enabled", Storage = "m_enabled", DbType = "bit NOT NULL", CanBeNull = false)]
        public Boolean Enabled
        {
            get { return this.m_enabled; }
            set { this.m_enabled = value; }
        }

        [Column(Name = "selected", Storage = "m_selected", DbType = "bit NOT NULL", CanBeNull = false)]
        public Boolean Selected
        {
            get { return this.m_selected; }
            set { this.m_selected = value; }
        }

        [Column(Name = "attacker", Storage = "m_attacker", DbType = "bit NOT NULL", CanBeNull = false)]
        public Boolean Attacker
        {
            get { return this.m_attacker; }
            set { this.m_attacker = value; }
        }

        [Column(Name = "sent_mail", Storage = "m_sentEmailCheckBox", DbType = "bit NOT NULL", CanBeNull = false)]
        public Boolean SentMail
        {
            get { return this.m_sentEmailCheckBox; }
            set { this.m_sentEmailCheckBox = value; }
        }

        [Column(Name = "hit_count", Storage = "m_hitCount", DbType = "int NOT NULL", CanBeNull = false)]
        public int HitCount
        {
            get { return this.m_hitCount; }
            set { this.m_hitCount = value; }
        }

        public TimeSpan NextLoginTime
        {
            get { return TimeSpan.FromSeconds(this.m_nextLoginTics); }
            set { this.m_nextLoginTics = value.TotalSeconds; }
        }

    }
}
