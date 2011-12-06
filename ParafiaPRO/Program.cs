using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using Spring.Context;
using Spring.Context.Support;
using Quartz;
using Spring.Scheduling.Quartz;
using log4net;
using ParafiaPRO.Core.Logging;

namespace ParafiaPRO
{
    static class Program
    {
        private static ILog log = LogManager.GetLogger(typeof(Program));

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            IApplicationContext ctx = ContextRegistry.GetContext();
            Form shell = ctx.GetObject("Shell") as Form;
            Logger logger = ctx.GetObject("Logger") as Logger;

            InitializeLogging(logger);

            Application.Run(shell);

            IScheduler schedulerFactory = (IScheduler)ctx.GetObject("SchedulerFactory");
            schedulerFactory.Shutdown(true);

            ctx.Dispose();
        }

        private static void InitializeLogging(Logger logger)
        {
            if (!log.Logger.Repository.Configured)
            {
                log4net.Config.XmlConfigurator.Configure();
            }

            foreach (log4net.Appender.IAppender appender in log.Logger.Repository.GetAppenders())
            {
                if (appender.GetType() == typeof(LoggerAppender))
                {
                    LoggerAppender loggerAppender = (LoggerAppender)appender;
                    loggerAppender.Log = logger.Log;
                }
            }
        }
    }
}
