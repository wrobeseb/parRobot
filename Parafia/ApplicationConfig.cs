using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Parafia.Enums;

namespace Parafia
{
    public class ApplicationConfig
    {
        private bool useProxy;
        private String proxyHost;
        private int proxyPort;
        private String proxyUser;
        private String proxyDomain;
        private String proxyPassword;
        private String accountUser;
        private String accountPassword;
        private ArmyType armyType;
        private bool sendPilgrimage;

        public bool UseProxy
        {
            get { return this.useProxy; }
            set { this.useProxy = value; }
        }
    }
}
