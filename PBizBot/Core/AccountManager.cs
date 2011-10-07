using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Spring.Scheduling.Quartz;

namespace PBizBot.Core
{
    public class AccountManager
    {
        private SchedulerFactoryObject m_schedulerFactory;

        public SchedulerFactoryObject SchedulerFactory
        {
            set { this.m_schedulerFactory = value; }
        }
    }
}
