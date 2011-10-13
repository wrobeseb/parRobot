using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PBizBot.View
{
    using Model;
    using Providers;
    using Core;
    using Core.Context;
    using Core.Scheduler;
    using Spring.Scheduling.Quartz;
    using Quartz;

    public partial class AccountList : UserControl
    {
        private SqlDataProvider m_sqlDataProvider;
        private AccountManager m_accountManager;
        private ApplicationContext m_applicationContext;

        public SqlDataProvider SqlDataProvider
        {
            set { this.m_sqlDataProvider = value; }
        }

        public AccountManager AccountManager
        {
            set { this.m_accountManager = value; }
        }

        public ApplicationContext ApplicationContext
        {
            set { this.m_applicationContext = value; }
        }

        public AccountList()
        {
            InitializeComponent();
        }

        private void pbAdd_Click(object sender, EventArgs e)
        {
            Account account = new Account();
            account.Login = tbLogin.Text;
            account.Passwd = tbPasswd.Text;
            AccountListItem accountDetailsControl = new AccountListItem(account);
            int position = 0;
            if (pAccounts.Controls.Count != 0)
            {
                position += 22 * pAccounts.Controls.Count;
            }
            else
            {
                account.Selected = true;
            }
            accountDetailsControl.Location = new Point(0, position);

            this.Invoke((Action)(delegate
            {
                pAccounts.Controls.Add(accountDetailsControl);
            }));

            tbLogin.Text = String.Empty;
            tbPasswd.Text = String.Empty;

            SimpleTriggerObject triggerObject = new SimpleTriggerObject();

            triggerObject.Name = "testTrigger";
            triggerObject.JobName = "testJop";

            MethodInvokingJobDetailFactoryObject job = new MethodInvokingJobDetailFactoryObject();
            //job.TargetObject = new Job();
            job.Name = "testJob";
            job.TargetMethod = "runProcess";
            job.Concurrent = false;

            job.AfterPropertiesSet();

            JobDetail jobDetail = (JobDetail)job.GetObject();

            triggerObject.JobDetail = jobDetail;

            triggerObject.StartDelay = new TimeSpan(0, 0, 5);

            triggerObject.RepeatInterval = new TimeSpan(1, 0, 0);

            triggerObject.AfterPropertiesSet();
        }

        private void PrepareSchedulerObjects(ref Account account)
        {
            MethodInvokingJobDetailFactoryObject job = new MethodInvokingJobDetailFactoryObject();
            job.TargetObject = m_applicationContext.GetComponentFromContext<AccountJob>("accountJob");
            job.Name = account.Login + "Job"; 
            job.TargetMethod = "runProcess";
            job.Concurrent = false;

            job.AfterPropertiesSet();

            JobDetail jobDetail = (JobDetail)job.GetObject();

            SimpleTrigger triggerObject = new SimpleTrigger("testTrigger", "account", DateTime.UtcNow.AddSeconds(5), null, 0, TimeSpan.Zero);

            triggerObject.JobName = "testJob";
        }

        private void pAccounts_ControlAdded(object sender, ControlEventArgs e)
        {
            System.Windows.Forms.Control.ControlCollection allAccounts = pAccounts.Controls;

            foreach (Control control in allAccounts)
            {
                ((AccountListItem)control).cbTransferToAccount.Items.Clear();
                ((AccountListItem)control).cbTransferToAccount.Items.Add("");
            }

            foreach (Control control in allAccounts)
            {
                AccountListItem accountDetailsControl = (AccountListItem)control;
                foreach (Control control1 in allAccounts)
                {
                    AccountListItem accountDetailsControl1 = (AccountListItem)control1;
                    if (!accountDetailsControl1.Equals(accountDetailsControl))
                    {
                        accountDetailsControl1.Invoke((Action)(delegate
                        {
                            accountDetailsControl1.cbTransferToAccount.Items.Add(accountDetailsControl.Account.Login);
                        }));
                        accountDetailsControl1.Refresh();
                    }
                }
            }
        }

        private void pAccounts_ControlRemoved(object sender, ControlEventArgs e)
        {
            System.Windows.Forms.Control.ControlCollection allAccounts = pAccounts.Controls;

            foreach (Control control in allAccounts)
            {
                ((AccountListItem)control).cbTransferToAccount.Items.Clear();
                ((AccountListItem)control).cbTransferToAccount.Items.Add("");
            }

            int position = 0;

            foreach (Control control in allAccounts)
            {
                AccountListItem accountDetailsControl = (AccountListItem)control;
                control.Location = new Point(0, position);
                foreach (Control control1 in allAccounts)
                {
                    AccountListItem accountDetailsControl1 = (AccountListItem)control1;
                    if (!accountDetailsControl1.Equals(accountDetailsControl))
                    {
                        accountDetailsControl1.Invoke((Action)(delegate
                        {
                            accountDetailsControl1.cbTransferToAccount.Items.Add(accountDetailsControl.Account.Login);
                        }));
                        accountDetailsControl1.Refresh();
                    }
                }
                position += 22;
            }
        }
    }
}
