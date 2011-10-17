using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using Spring.Context;
using Spring.Context.Support;
using log4net.Config;
using log4net;

namespace PBizBot
{
    using Core.Logger;

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

            //XmlConfigurator.Configure();

            IApplicationContext ctx = ContextRegistry.GetContext();

            Main mainForm = (Main)ctx.GetObject("mainForm");

            Logger logger = (Logger)ctx.GetObject("logger");

            InitializeLogging(logger);

            Application.Run(mainForm);

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
                if (appender.GetType() == typeof(PBizBotLoggerAppender.PBizBotLoggerAppender))
                {
                    PBizBotLoggerAppender.PBizBotLoggerAppender pBizBotLoggerAppender = (PBizBotLoggerAppender.PBizBotLoggerAppender)appender;
                    pBizBotLoggerAppender.Log = logger.log;
                }
            }
        }
    }
}
