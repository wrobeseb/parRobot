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

    public class AccountJob : QuartzJobObject
    {
        private ViewProvider m_viewProvider;

        public AccountJob(ViewProvider viewProvider)
        {
            this.m_viewProvider = viewProvider;
        }

        public void RunProcess()
        {

        }

        protected override void ExecuteInternal(JobExecutionContext context)
        {
            
        }
    }
}
