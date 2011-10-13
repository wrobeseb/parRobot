using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Quartz;

using System.Windows.Forms;
using Spring.Scheduling.Quartz;

namespace PBizBot.Core.Scheduler
{
    using Providers;
    

    public class Job : QuartzJobObject
    {
        private ViewProvider m_viewProvider;

        public Job()
        {
        }

        public Job(ViewProvider viewProvider)
        {
            this.m_viewProvider = viewProvider;
        }

        public void runProcess()
        {
        }

        protected override void ExecuteInternal(JobExecutionContext context)
        {
            
        }
    }
}
