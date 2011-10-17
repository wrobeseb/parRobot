using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Quartz;


namespace PBizBot.Core.Scheduler
{
    using Model;
    using Providers;
    using Spring.Scheduling.Quartz;

    public class AccountTriggerListener : ITriggerListener
    {
        private SqlDataProvider m_sqlDataProvider;
        private AccountManager m_accountManager;

        public SqlDataProvider SqlDataProvider
        {
            set { this.m_sqlDataProvider = value; }
        }

        public AccountManager AccountManager
        {
            set { this.m_accountManager = value; }
        }

        public string Name
        {
            get { return "AccountTriggerListener"; }
        }

        public void TriggerComplete(Trigger trigger, JobExecutionContext context, SchedulerInstruction triggerInstructionCode)
        {
            if (!trigger.Name.Equals("TimerTrigger"))
            {
                Account account = (Account)trigger.JobDataMap.Get("account");
                if (account != null)
                {
                    trigger.StartTimeUtc = DateTime.UtcNow.AddSeconds(new Random().Next(account.Settings.NextTimeLoginMin, account.Settings.NextTimeLoginMax));
                    
                    account.SchedulerTrigger = trigger;

                    m_accountManager.SetNextLoginTimeForAccount(account);
                }
            }
          
        }

        public void TriggerFired(Trigger trigger, JobExecutionContext context)
        {

        }

        public void TriggerMisfired(Trigger trigger)
        {
            
        }

        public bool VetoJobExecution(Trigger trigger, JobExecutionContext context)
        {
            return false;
        }
    }
}
