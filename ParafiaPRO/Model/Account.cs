using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Quartz;
using Spring.Scheduling.Quartz;

namespace ParafiaPRO.Model
{
    public class Account
    {
        private int m_id;

        private String m_login;
        private String m_passwd;

        private Boolean m_enabled = true;
        private Boolean m_selected;
        private Boolean m_attacker;

        private Boolean m_sentEmailCheckBox;
        private TimeSpan m_nextLoginTimeSpan;

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

        //[Column(Name = "id", Storage = "m_id", IsPrimaryKey = true, IsDbGenerated = true, DbType = "int NOT NULL IDENTITY", CanBeNull = false)]
        public int Id
        {
            get { return this.m_id; }
            set { this.m_id = value; }
        }

        //[Column(Name = "login", Storage = "m_login")]
        public String Login
        {
            get { return this.m_login; }
            set { this.m_login = value; }
        }

        //[Column(Name = "passwd", Storage = "m_passwd")]
        public String Passwd
        {
            get { return this.m_passwd; }
            set { this.m_passwd = value; }
        }

       // [Column(Name = "enabled", Storage = "m_enabled")]
        public Boolean Enabled
        {
            get { return this.m_enabled; }
            set { this.m_enabled = value; }
        }

        //[Column(Name = "selected", Storage = "m_selected")]
        public Boolean Selected
        {
            get { return this.m_selected; }
            set { this.m_selected = value; }
        }

        //[Column(Name = "attacker", Storage = "m_attacker")]
        public Boolean Attacker
        {
            get { return this.m_attacker; }
            set { this.m_attacker = value; }
        }

        //[Column(Name = "sent_mail", Storage = "m_sentEmailCheckBox")]
        public Boolean SentMail
        {
            get { return this.m_sentEmailCheckBox; }
            set { this.m_sentEmailCheckBox = value; }
        }

        //[Column(Name = "next_login", Storage = "m_nextLoginTimeSpan")]
        public TimeSpan NextLoginTime
        {
            get { return this.m_nextLoginTimeSpan; }
            set { this.m_nextLoginTimeSpan = value; }
        }

       // [Column(Name = "hit_count", Storage = "m_hitCount")]
        public int HitCount
        {
            get { return this.m_hitCount; }
            set { this.m_hitCount = value; }
        }

    }
}
