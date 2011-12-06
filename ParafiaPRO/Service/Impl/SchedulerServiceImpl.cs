using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Quartz;

namespace ParafiaPRO.Service.Impl
{
    using Model.Account;
    using Spring.Context;

    public class SchedulerServiceImpl : ISchedulerService, IApplicationContextAware
    {
        public event EventHandler OnSchedule;
        public event EventHandler OnReSchedule;
        public event EventHandler OnUnSchedule;
        public event EventHandler OnJobStarted;

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
            foreach (Account account in accounts)
                if (account.Enabled)
                    ScheduleAccount(account, DateTime.UtcNow.AddTicks(account.NextLoginTime.Ticks));
        }

        public void UnScheduleAccounts(List<Account> accounts)
        {
            foreach (Account account in accounts)
                if (account.Enabled)
                    UnScheduleAccount(account);
        }

        public void ScheduleAccount(Account account, DateTime nextLoginTime)
        {
            account.SchedulerTrigger.StartTimeUtc = nextLoginTime;
            m_SchedulerFactory.ScheduleJob(account.SchedulerJobDetail, account.SchedulerTrigger);

            if (OnSchedule != null)
                OnSchedule(account, EventArgs.Empty);
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

            if (OnReSchedule != null)
                OnReSchedule(account, EventArgs.Empty);
        }

        public void UnScheduleAccount(Account account)
        {
            account.SchedulerTrigger.StartTimeUtc = DateTime.MinValue;
            m_SchedulerFactory.DeleteJob(account.SchedulerJobDetail.Name, account.SchedulerJobDetail.Group);
            m_SchedulerFactory.UnscheduleJob(account.SchedulerTrigger.Name, account.SchedulerTrigger.Group);

            if (OnUnSchedule != null)
                OnUnSchedule(account, EventArgs.Empty);
        }

        public void JobStarted(Account account)
        {
            if (OnJobStarted != null)
                OnJobStarted(account, EventArgs.Empty);
        }
    }
}
