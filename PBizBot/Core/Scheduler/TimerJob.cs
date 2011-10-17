using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PBizBot.Core.Scheduler
{
    using Providers;

    public class TimerJob
    {
        private ViewProvider m_viewProvider;

        public TimerJob(ViewProvider viewProvider)
        {
            this.m_viewProvider = viewProvider;
        }

        public void RunProcess()
        {
            if (m_viewProvider.IsON)
            {
                m_viewProvider.SetTime();
            }
        }
    }
}
