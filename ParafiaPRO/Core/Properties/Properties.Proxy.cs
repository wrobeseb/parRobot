using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParafiaPRO.Core.Properties
{
    public partial class Properties
    {
        private static String DEFAULT_PROXY_HOST = "126.179.0.200";
        private static int DEFAULT_PROXY_PORT = 3128;

        private Boolean mProxyEnabled;
        private String mProxyHost;
        private int mProxyPort;
        private String mProxyUser;
        private String mProxyUserDomain;
        private String mProxyPasswd;

        public Boolean ProxyEnabled
        {
            get { return this.mProxyEnabled; }
            set { this.mProxyEnabled = value; }
        }

        public String ProxyHost
        {
            get
            {
                if (String.IsNullOrEmpty(mProxyHost))
                    return DEFAULT_PROXY_HOST;
                else
                    return this.mProxyHost;
            }
            set { this.mProxyHost = value; }
        }

        public int ProxyPort
        {
            get
            {
                if (mProxyPort == 0)
                    return DEFAULT_PROXY_PORT;
                else
                    return this.mProxyPort;
            }
            set { this.mProxyPort = value; }
        }

        public String ProxyUser
        {
            get { return this.mProxyUser; }
            set { this.mProxyUser = value; }
        }

        public String ProxyUserDomain
        {
            get { return this.mProxyUserDomain; }
            set { this.mProxyUserDomain = value; }
        }

        public String ProxyPasswd
        {
            get { return this.mProxyPasswd; }
            set { this.mProxyPasswd = value; }
        }
    }
}
