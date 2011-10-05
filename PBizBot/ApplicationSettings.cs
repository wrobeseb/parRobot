using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PBizBot
{
    public class ApplicationSettings
    {
        private bool useProxy;
        private String proxyHost;
        private int proxyPort;
        private String proxyUser;
        private String proxyDomain;
        private String proxyPassword;
        private String accountUser;
        private String accountPassword;

        private bool sentMail;
        private String smtpHost;
        private int smtpPort;
        private String smtpAccount;
        private String smtpAccountPasswd;
        private String smtpTo;
        private String smtpSubject;
        private bool smtpEnableSSL;

        public bool UseProxy
        {
            get { return this.useProxy; }
            set { this.useProxy = value; }
        }

        public String ProxyHost
        {
            get { return this.proxyHost; }
            set { this.proxyHost = value; }
        }

        public int ProxyPort
        {
            get { return this.proxyPort; }
            set { this.proxyPort = value; }
        }

        public String ProxyUser
        {
            get { return this.proxyUser; }
            set { this.proxyUser = value; }
        }

        public String ProxyPassword
        {
            get { return this.proxyPassword; }
            set { this.proxyPassword = value; }
        }

        public String ProxyDomain
        {
            get { return this.proxyDomain; }
            set { this.proxyDomain = value; }
        }

        public String AccountUser
        {
            get { return this.accountUser; }
            set { this.accountUser = value; }
        }

        public String AccountPassword
        {
            get { return this.accountPassword; }
            set { this.accountPassword = value; }
        }

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
