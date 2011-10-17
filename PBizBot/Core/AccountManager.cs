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

    public class AccountManager : IInitializingObject
    {
        private AccountList m_accountList; 
        private IScheduler m_schedulerFactory;
        private SettingsFactory m_settingsFactory;
        private AccountTriggerListener m_accountTriggerListener;

        public AccountList AccountList
        {
            set { this.m_accountList = value; }
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
            foreach (AccountListItem accountListItem in m_accountList.pAccounts.Controls)
            {
                Account account = (Account)accountListItem.Account;
                account.SchedulerTrigger.StartTimeUtc = DateTime.UtcNow.AddSeconds(m_settingsFactory.Default.AccountFirstFireTime);
                ScheduleAccount(account);
            }
        }

        public void StartAccount(Account account)
        {
            account.SchedulerTrigger.StartTimeUtc = DateTime.UtcNow.AddSeconds(m_settingsFactory.Default.AccountFirstFireTime);
            ScheduleAccount(account);
        }

        public void ScheduleAccount(Account account)
        {
            Schedule(account);
        }

        public void ScheduleAccounts(List<Account> accounts)
        {
            foreach (Account account in accounts)
            {
                Schedule(account);
            }
        }

        public void UnScheduleAccounts(List<Account> accounts)
        {
            foreach (Account account in accounts)
            {
                UnSchedule(account);
            }
        }

        public void UnScheduleAccount(Account account)
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
