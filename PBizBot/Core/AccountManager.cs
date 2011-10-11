using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Quartz;

using Spring.Scheduling.Quartz;

namespace PBizBot.Core
{
    public class AccountManager
    {
        private SchedulerFactoryObject m_schedulerFactory;

        public SchedulerFactoryObject SchedulerFactory
        {
            set { this.m_schedulerFactory = value; }
        }

        public void test()
        {
            SimpleTriggerObject triggerObject = new SimpleTriggerObject();


            MethodInvokingJobDetailFactoryObject job = new MethodInvokingJobDetailFactoryObject();
            job.TargetObject = new Job();
            job.TargetMethod = "runProcess";
            job.Concurrent = false;

            triggerObject.JobDetail = (JobDetail)job.GetObject();

            triggerObject.StartDelay = new TimeSpan(0, 0, 5);

           // m_schedulerFactory.Triggers
            

        }
    }
}
