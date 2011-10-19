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

    public class AccountControllerImpl : AbstractController, IAccountController, IApplicationContextAware
    {
        private IAccountListView m_accountListView;
        private IApplicationContext m_applicationContext;

        public IApplicationContext ApplicationContext
        {
            set { this.m_applicationContext = value; }
        }

        public IAccountListView AccountListView
        {
            set 
            {
                this.m_accountListView = value;
                this.m_accountListView.AddAccountEvent += new EventHandler(AddAccount);
            }
            get
            {
                return this.m_accountListView;
            }
        }

        void AddAccount(object sender, EventArgs e)
        {
            Debug.Assert(m_accountListView != null, "Widok listy kont nie został zainicjowany.");

            Account account = NewAccountInstance();

            IAccountListItemView accountListItemView = new AccountListItemView();
            accountListItemView.RemoveAccountEvent += new EventHandler(RemoveAccount);
            accountListItemView.Account = account;

            BeginInvoke(delegate
            {
                m_accountListView.AddAccountListItemView(accountListItemView);
            });
        }

        private Account NewAccountInstance()
        {
            Account account = new Account();
            account.Login = m_accountListView.Login;
            account.Passwd = m_accountListView.Passwd;

            MethodInvokingJobDetailFactoryObject job = new MethodInvokingJobDetailFactoryObject();
            job.Concurrent = false;
            job.TargetObject = m_applicationContext.GetObject("AccountJobObject");
            job.TargetMethod = "RunProcess";
            job.Name = account.Login + "Job";

            account.SchedulerJobDetail = (JobDetail)job.GetObject();

            SimpleTrigger triggerObject = (SimpleTrigger)m_applicationContext.GetObject("AccountTrigger");
            triggerObject.StartTimeUtc = DateTime.MinValue;
            triggerObject.RepeatInterval = TimeSpan.Zero;
            triggerObject.Name = account.Login + "Trigger";
            triggerObject.JobName = account.Login + "Job";
            triggerObject.JobDataMap.Add("account", account);

            account.SchedulerTrigger = triggerObject;

            return account;
        }

        void RemoveAccount(object sender, EventArgs e)
        {
            BeginInvoke(delegate
            {
                m_accountListView.RemoveAccountListItemView((AccountListItemView)sender);
            });
        }
    }
}
