using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Spring.Objects.Factory;

using Quartz;

using Spring.Scheduling.Quartz;

namespace PBizBot.Core
{
    using Model;
    using View;
    using Settings;
    using Scheduler;
    using Providers;

    public class AccountManager : IInitializingObject
    {
        private SqlDataProvider m_sqlDataProvider;
        private ViewProvider m_viewProvider;
        private IScheduler m_schedulerFactory;
        private SettingsFactory m_settingsFactory;
        private AccountTriggerListener m_accountTriggerListener;

        public SqlDataProvider SqlDataProvider
        {
            set { this.m_sqlDataProvider = value; }
        }

        public ViewProvider ViewProvider
        {
            set { this.m_viewProvider = value; }
        }

        public SettingsFactory SettingsFactory
        {
            set { this.m_settingsFactory = value; }
        }

        public IScheduler SchedulerFactory
        {
            set { this.m_schedulerFactory = value; }
        }

        public AccountTriggerListener AccountTriggerLister
        {
            set { this.m_accountTriggerListener = value; }
        }

        public void StartAccounts()
        {
            foreach (Account account in m_viewProvider.GetAccounts())
            {
                account.SchedulerTrigger.StartTimeUtc = DateTime.UtcNow.AddSeconds(m_settingsFactory.Default.AccountFirstFireTime);
                ScheduleAccount(account);
            }
        }

        public void StartAccount(Account account)
        {
            account.SchedulerTrigger.StartTimeUtc = DateTime.UtcNow.AddSeconds(m_settingsFactory.Default.AccountFirstFireTime);
            ScheduleAccount(account);
        }

        private void ScheduleAccount(Account account)
        {
            Schedule(account);
        }

        private void ScheduleAccounts(List<Account> accounts)
        {
            foreach (Account account in accounts)
            {
                Schedule(account);
            }
        }

        private void UnScheduleAccounts(List<Account> accounts)
        {
            foreach (Account account in accounts)
            {
                UnSchedule(account);
            }
        }

        private void UnScheduleAccount(Account account)
        {
            UnSchedule(account);
        }

        private void Schedule(Account account)
        {
            m_schedulerFactory.AddJob(account.SchedulerJobDetail, true);
            m_schedulerFactory.ScheduleJob(account.SchedulerTrigger);
        }

        private void UnSchedule(Account account)
        {
            m_schedulerFactory.DeleteJob(account.SchedulerJobDetail.Name, account.SchedulerJobDetail.Group);
            m_schedulerFactory.UnscheduleJob(account.SchedulerTrigger.Name, account.SchedulerTrigger.Group);
        }

        public void AfterPropertiesSet()
        {
            m_schedulerFactory.AddGlobalTriggerListener(this.m_accountTriggerListener);
        }
    }
}
