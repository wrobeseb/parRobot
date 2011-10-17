using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PBizBot.Model
{
    public class AccountSettings
    {
        private int m_nextTimeLoginMin = 20;
        private int m_nextTimeLoginMax = 30;

        public int NextTimeLoginMin
        {
            set { this.m_nextTimeLoginMin = value; }
            get { return this.m_nextTimeLoginMin; }
        }

        public int NextTimeLoginMax
        {
            set { this.m_nextTimeLoginMax = value; }
            get { return this.m_nextTimeLoginMax; }
        }

        public AccountSettings() { }
    }
}
