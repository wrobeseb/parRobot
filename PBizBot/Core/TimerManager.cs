using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Spring.Objects.Factory;
using Quartz;
using Spring.Scheduling.Quartz;

namespace PBizBot.Core
{
    using Providers;
    using Core.Scheduler;

    public class TimerManager : IInitializingObject
    {
        private IScheduler m_schedulerFactory;
        private ViewProvider m_viewProvider;

        public IScheduler SchedulerFactory
        {
            set { this.m_schedulerFactory = value; }
        }

        public ViewProvider ViewProvider
        {
            set { this.m_viewProvider = value; }
        }

        public void AfterPropertiesSet()
        {
            MethodInvokingJobDetailFactoryObject job = new MethodInvokingJobDetailFactoryObject();
            job.TargetObject = new TimerJob(m_viewProvider);
            job.Name = "TimerJob";
            job.TargetMethod = "RunProcess";
            job.Concurrent = false;

            job.AfterPropertiesSet();

            JobDetail jobDetail = (JobDetail)job.GetObject();

            SimpleTriggerObject triggerObject = new SimpleTriggerObject();

            triggerObject.Name = "TimerTrigger";

            triggerObject.JobName = "TimerJob";

            triggerObject.JobDetail = jobDetail;

            triggerObject.RepeatInterval = new TimeSpan(0, 0, 1);

            triggerObject.StartDelay = TimeSpan.Zero;

            triggerObject.AfterPropertiesSet();

            m_schedulerFactory.ScheduleJob(jobDetail, triggerObject);
        }
    }
}
