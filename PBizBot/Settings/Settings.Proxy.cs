using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PBizBot.Settings
{
    public partial class Settings
    {
        private bool useProxy;
        private String proxyHost;
        private int proxyPort;
        private String proxyUser;
        private String proxyDomain;
        private String proxyPassword;

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
    }
}
