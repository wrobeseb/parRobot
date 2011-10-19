using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using Spring.Context;
using Spring.Context.Support;

namespace ParafiaPRO
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

            IApplicationContext ctx = ContextRegistry.GetContext();
            Form shell = ctx.GetObject("Shell") as Form;

            log4net.Config.XmlConfigurator.Configure();

            Application.Run(shell);
        }
    }
}
