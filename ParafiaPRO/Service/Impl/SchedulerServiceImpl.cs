using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Quartz;

namespace ParafiaPRO.Service.Impl
{
    using Model;
    using Spring.Context;

    public class SchedulerServiceImpl : ISchedulerService, IApplicationContextAware
    {
        private IScheduler m_SchedulerFactory;
        private IApplicationContext m_ApplicationContext;

        public IApplicationContext ApplicationContext
        {
            set { this.m_ApplicationContext = value; }
        }

        public IScheduler SchedulerFactory
        {
            set { this.m_SchedulerFactory = value; }
        }

        public void ScheduleAccounts(List<Account> accounts)
        {
            int count = 0;
            foreach (Account account in accounts)
            {
                ScheduleAccount(account, DateTime.UtcNow.AddSeconds(5 + (300*count)));
                count++;
            }
        }

        public void UnScheduleAccounts(List<Account> accounts)
        {
            foreach (Account account in accounts)
            {
                UnScheduleAccount(account);
            }
        }

        public void ScheduleAccount(Account account, DateTime nextLoginTime)
        {
            account.SchedulerTrigger.StartTimeUtc = nextLoginTime;
            m_SchedulerFactory.ScheduleJob(account.SchedulerJobDetail, account.SchedulerTrigger);
        }

        public void ReScheduleAccount(Account account, DateTime nextLoginTime)
        {
            SimpleTrigger triggerObject = (SimpleTrigger)m_ApplicationContext.GetObject("AccountTrigger");
            triggerObject.StartTimeUtc = nextLoginTime;
            triggerObject.RepeatInterval = TimeSpan.Zero;
            triggerObject.Name = account.Login + "Trigger";
            triggerObject.JobName = account.Login + "Job";

            account.SchedulerTrigger = triggerObject;

            m_SchedulerFactory.RescheduleJob(account.SchedulerTrigger.Name, account.SchedulerTrigger.Group, triggerObject);
        }

        public void UnScheduleAccount(Account account)
        {
            account.SchedulerTrigger.StartTimeUtc = DateTime.MinValue;
            m_SchedulerFactory.DeleteJob(account.SchedulerJobDetail.Name, account.SchedulerJobDetail.Group);
            m_SchedulerFactory.UnscheduleJob(account.SchedulerTrigger.Name, account.SchedulerTrigger.Group);
        }
    }
}
