using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using Spring.Context;
using Spring.Context.Support;
using log4net.Config;

namespace PBizBot
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            XmlConfigurator.Configure();

            IApplicationContext ctx = ContextRegistry.GetContext();

            Main mainForm = (Main)ctx.GetObject("mainForm");

            Application.Run(mainForm);

            ctx.Dispose();
        }
    }
}
