using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PBizBot.Core.Logger
{
    using Providers;

    public class Logger
    {
        private ViewProvider m_viewProvider;

        public ViewProvider ViewProvider
        {
            set { this.m_viewProvider = value; }
        }

        public void log(String message)
        {
            m_viewProvider.PrintLog(message);
        }
    }
}
