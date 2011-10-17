using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Quartz;

using Spring.Scheduling.Quartz;

namespace PBizBot.Core.Scheduler
{
    public class TimerJob
    {
        private IScheduler m_schedulerFactory;
        

        public IScheduler SchedulerFactory
        {
            set { this.m_schedulerFactory = value; }
        }

        //public 
    }
}
