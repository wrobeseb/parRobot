using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ParafiaPRO.View;

namespace ParafiaPRO.Core.Logging
{
    public class Logger
    {
        private ILoggerPanelView mLoggerPanelView;

        public ILoggerPanelView LoggerPanelView
        {
            set { this.mLoggerPanelView = value; }
        }

        public void Log(String message)
        {
            mLoggerPanelView.PrintLog(message);
        }
    }
}
