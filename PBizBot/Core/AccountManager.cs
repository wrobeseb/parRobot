using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Quartz;

using Spring.Scheduling.Quartz;

namespace PBizBot.Core
{
    using Scheduler;

    public class AccountManager
    {
        private IScheduler m_schedulerFactory;
        private AccountTriggerListener m_accountTriggerListener;

        public AccountTriggerListener AccountTriggerListener
        {
            set { this.m_accountTriggerListener = value; }
        }

        public IScheduler SchedulerFactory
        {
            set { this.m_schedulerFactory = value; }
        }

        public void test(Main main)
        {
            SimpleTriggerObject triggerObject = new SimpleTriggerObject();

            triggerObject.Name = "testTrigger";
            triggerObject.Group = "account";
            //triggerObject.JobName = "testJop";

            MethodInvokingJobDetailFactoryObject job = new MethodInvokingJobDetailFactoryObject();
            job.TargetObject = new Job();
            job.Name = "testJob";
            job.TargetMethod = "runProcess";
            job.Concurrent = false;

            job.AfterPropertiesSet();

            JobDetail jobDetail = (JobDetail)job.GetObject();

            triggerObject.JobDetail = jobDetail;

            triggerObject.StartDelay = new TimeSpan(0, 0, 5);

            triggerObject.RepeatInterval = new TimeSpan(1, 0, 0);

            triggerObject.AfterPropertiesSet();

            m_schedulerFactory.AddGlobalTriggerListener(m_accountTriggerListener);
            m_schedulerFactory.AddJob(jobDetail, true);
            m_schedulerFactory.ScheduleJob(triggerObject);

           // m_schedulerFactory.lis

           // m_schedulerFactory.Triggers
            

        }
    }
}
