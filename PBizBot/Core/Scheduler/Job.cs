using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Windows.Forms;

namespace PBizBot.Core.Scheduler
{
    using Providers;

    public class Job
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
    }
}
