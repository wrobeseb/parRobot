using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParafiaPRO.Scheduler.Job
{
    using Model;
    using Service;

    public class AccountJob
    {
        private Account m_Account;
        private ISchedulerService m_SchedulerService;

        public Account Account
        {
            set { this.m_Account = value; }
        }

        public ISchedulerService SchedulerService
        {
            set { this.m_SchedulerService = value; }
        }

        public void RunProcess()
        {
            // TODO

            m_SchedulerService.ReScheduleAccount(this.m_Account, DateTime.UtcNow.AddSeconds(50));
        }
    }
}
