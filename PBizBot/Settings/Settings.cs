using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PBizBot.Settings
{
    public partial class Settings
    {
        private int m_accountFirstFireTime = 5;

        public int AccountFirstFireTime
        {
            set { this.m_accountFirstFireTime = value; }
            get { return this.m_accountFirstFireTime; }
        }
    }
}
