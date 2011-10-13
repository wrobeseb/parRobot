using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PBizBot.Settings
{
    public partial class Settings
    {
        private bool sentMail;
        private String smtpHost;
        private int smtpPort;
        private String smtpAccount;
        private String smtpAccountPasswd;
        private String smtpTo;
        private String smtpSubject;
        private bool smtpEnableSSL;

        public bool SentMail
        {
            get { return this.sentMail; }
            set { this.sentMail = value; }
        }

        public String SmtpHost
        {
            get { return this.smtpHost; }
            set { this.smtpHost = value; }
        }

        public int SmtpPort
        {
            get { return this.smtpPort; }
            set { this.smtpPort = value; }
        }

        public String SmtpAccount
        {
            get { return this.smtpAccount; }
            set { this.smtpAccount = value; }
        }

        public String SmtpAccountPasswd
        {
            get { return this.smtpAccountPasswd; }
            set { this.smtpAccountPasswd = value; }
        }

        public String SmtpTo
        {
            get { return this.smtpTo; }
            set { this.smtpTo = value; }
        }

        public String SmtpSubject
        {
            get { return this.smtpSubject; }
            set { this.smtpSubject = value; }
        }

        public bool SmtpEnableSSL
        {
            get { return this.smtpEnableSSL; }
            set { this.smtpEnableSSL = value; }
        }
    }
}
