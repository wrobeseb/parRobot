using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PBizBot.Providers
{
    using View;

    public class ViewProvider
    {
        private Main m_mainForm;
        private AppSettings m_appSettings;

        private AccountList m_accountList;
        private AttackList m_attackList;

        public Main MainForm
        {
            set { this.m_mainForm = value; }
        }

        public AppSettings AppSettings
        {
            set { this.m_appSettings = value; }
        }

        public AccountList AccountList
        {
            set { this.m_accountList = value; }
        }

        public AttackList AttackList
        {
            set { this.m_attackList = value; }
        }
    }
}
