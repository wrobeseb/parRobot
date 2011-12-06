using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

using Quartz;
using Spring.Context;
using Spring.Scheduling.Quartz;

namespace ParafiaPRO.Controller.Impl
{
    using View;
    using View.Impl;
    using Model.Account;
    using Service;
    using Scheduler.Job;

    public class AccountControllerImpl : AbstractController, IAccountController, IApplicationContextAware
    {
        private IAccountListView m_AccountListView;
        private IAccountService mAccountService;
        private IApplicationContext m_ApplicationContext;

        public IApplicationContext ApplicationContext
        {
            set { this.m_ApplicationContext = value; }
        }

        public IAccountService AccountService
        {
            set { this.mAccountService = value; }
        }

        public IAccountListView AccountListView
        {
            set 
            {
                this.m_AccountListView = value;
                this.m_AccountListView.AddAccountEvent += new EventHandler(AddAccount);
                this.m_AccountListView.OnLoadEvent += new EventHandler(OnLoad);
            }
            get
            {
                return this.m_AccountListView;
            }
        }

        public void UpdateStartTimeForAccounts()
        {
            m_AccountListView.UpdateStartTimeForAccounts();
        }

        public void SetStartTimeForAccountToZero()
        {
            m_AccountListView.SetStartTimeForAccountToZero();
        }

        void OnLoad(object sender, EventArgs e)
        {
            List<Account> accounts = mAccountService.Accounts();
            foreach (Account account in accounts)
                PrepareAccount(account);
        }

        void AddAccount(object sender, EventArgs e)
        {
            PrepareAccount();
        }

        void RemoveAccount(object sender, EventArgs e)
        {
            //BeginInvoke(delegate
            //{
                m_AccountListView.RemoveAccountListItemView((AccountListItemView)sender);
           // });
        }

        void EnabledCheckedChange(object sender, EventArgs e)
        {
            IAccountListItemView item = (IAccountListItemView)sender;
            IControlPanelView controlPanelView = (IControlPanelView)m_ApplicationContext.GetObject("ControlPanelView"); 

            //BeginInvoke(delegate
            //{
                Account account = item.Account;

                if (controlPanelView.Started) {
                    ISchedulerService schedulerService = (ISchedulerService)m_ApplicationContext.GetObject("SchedulerService"); 
                    if (account.Enabled)
                    {
                        schedulerService.ScheduleAccount(account, DateTime.UtcNow.AddSeconds(5));
                    }
                    else
                    {
                        schedulerService.UnScheduleAccount(account);
                    }
                }   
            //});
        }

        private void PrepareAccount()
        {
            Debug.Assert(m_AccountListView != null, "Widok listy kont nie został zainicjowany.");
            AddAccountListItem(PrepareAccountScheduler());
        }

        private void PrepareAccount(Account account)
        {
            AddAccountListItem(PrepareAccountScheduler(account));
        }

        private void AddAccountListItem(Account account)
        {
            IAccountListItemView accountListItemView = new AccountListItemView();
            accountListItemView.RemoveAccountEvent += new EventHandler(RemoveAccount);
            accountListItemView.EnabledCheckedChangedEvent += new EventHandler(EnabledCheckedChange);
            accountListItemView.Account = account;

            //BeginInvoke(delegate
            //{
                m_AccountListView.AddAccountListItemView(accountListItemView);
            //});
        }

        private Account PrepareAccountScheduler()
        {
            return PrepareAccountScheduler(m_AccountListView.Login, m_AccountListView.Passwd);
        }

        private Account PrepareAccountScheduler(String login, String passwd)
        {
            Account account = new Account();
            account.Login = login;
            account.Passwd = passwd;
            return PrepareAccountScheduler(account);
        }

        private Account PrepareAccountScheduler(Account account)
        {
            AccountJob accountJobObject = (AccountJob)m_ApplicationContext.GetObject("AccountJobObject");
            accountJobObject.Account = account;
            accountJobObject.AfterPropertiesSet();
            //accountJobObject.SchedulerService = (ISchedulerService)m_ApplicationContext.GetObject("SchedulerService");

            MethodInvokingJobDetailFactoryObject job = new MethodInvokingJobDetailFactoryObject();
            job.Concurrent = false;
            job.TargetObject = accountJobObject;
            job.TargetMethod = "RunProcess";
            job.Name = account.Login + "Job";

            job.AfterPropertiesSet();

            account.SchedulerJobDetail = (JobDetail)job.GetObject();

            SimpleTrigger triggerObject = (SimpleTrigger)m_ApplicationContext.GetObject("AccountTrigger");
            triggerObject.StartTimeUtc = DateTime.MinValue;
            triggerObject.RepeatInterval = TimeSpan.Zero;
            triggerObject.Name = account.Login + "Trigger";
            triggerObject.JobName = account.Login + "Job";

            account.SchedulerTrigger = triggerObject;

            return account;
        }
    }
}
