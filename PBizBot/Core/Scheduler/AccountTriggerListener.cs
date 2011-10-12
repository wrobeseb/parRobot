using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Quartz;

namespace PBizBot.Core.Scheduler
{
    using Providers;

    public class AccountTriggerListener : ITriggerListener
    {
        private SqlDataProvider m_sqlDataProvider;

        public SqlDataProvider SqlDataProvider
        {
            set { this.m_sqlDataProvider = value; }
        }

        public string Name
        {
            get { return "AccountTriggerListener"; }
        }

        public void TriggerComplete(Trigger trigger, JobExecutionContext context, SchedulerInstruction triggerInstructionCode)
        {
            
        }

        public void TriggerFired(Trigger trigger, JobExecutionContext context)
        {
            
        }

        public void TriggerMisfired(Trigger trigger)
        {
            
        }

        public bool VetoJobExecution(Trigger trigger, JobExecutionContext context)
        {
            return true;
        }
    }
}
