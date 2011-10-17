using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using log4net.Appender;

namespace PBizBot.Core.Logging
{
    public class MainAppender : AppenderSkeleton
    {
        protected override void Append(log4net.Core.LoggingEvent loggingEvent)
        {
            throw new NotImplementedException();
        }
    }
}
