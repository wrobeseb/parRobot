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
    using Model;
    using Service;
    using Scheduler.Job;

    public class AccountControllerImpl : AbstractController, IAccountController, IApplicationContextAware
    {
        private IAccountListView m_AccountListView;
        private IApplicationContext m_ApplicationContext;

        public IApplicationContext ApplicationContext
        {
            set { this.m_ApplicationContext = value; }
        }

        public IAccountListView AccountListView
        {
            set 
            {
                this.m_AccountListView = value;
                this.m_AccountListView.AddAccountEvent += new EventHandler(AddAccount);
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

        void AddAccount(object sender, EventArgs e)
        {
            Debug.Assert(m_AccountListView != null, "Widok listy kont nie został zainicjowany.");

            Account account = NewAccountInstance();

            IAccountListItemView accountListItemView = new AccountListItemView();
            accountListItemView.RemoveAccountEvent += new EventHandler(RemoveAccount);
            accountListItemView.EnabledCheckedChangedEvent += new EventHandler(EnabledCheckedChange);
            accountListItemView.Account = account;

            BeginInvoke(delegate
            {
                m_AccountListView.AddAccountListItemView(accountListItemView);
            });
        }

        void RemoveAccount(object sender, EventArgs e)
        {
            BeginInvoke(delegate
            {
                m_AccountListView.RemoveAccountListItemView((AccountListItemView)sender);
            });
        }

        void EnabledCheckedChange(object sender, EventArgs e)
        {
            IAccountListItemView item = (IAccountListItemView)sender;
            IControlPanelView controlPanelView = (IControlPanelView)m_ApplicationContext.GetObject("ControlPanelView"); 

            BeginInvoke(delegate
            {
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
            });
        }

        private Account NewAccountInstance()
        {
            Account account = new Account();
            account.Login = m_AccountListView.Login;
            account.Passwd = m_AccountListView.Passwd;

            AccountJob accountJobObject = (AccountJob)m_ApplicationContext.GetObject("AccountJobObject");
            accountJobObject.Account = account;
            accountJobObject.SchedulerService = (ISchedulerService)m_ApplicationContext.GetObject("SchedulerService");

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
