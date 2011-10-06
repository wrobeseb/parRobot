using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PBizBot.Providers
{
    public class ViewProvider
    {
        private Main mainForm;
        private AppSettings appSettings;

        public Main MainForm
        {
            set { this.mainForm = value; }
        }

        public AppSettings AppSettings
        {
            set { this.appSettings = value; }
        }
    }
}
