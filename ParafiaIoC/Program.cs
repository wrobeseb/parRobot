using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using Spring.Context;
using Spring.Context.Support;

namespace ParafiaIoC
{
    public sealed class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(true);

            IApplicationContext ctx = ContextRegistry.GetContext();

            MainForm mainForm = (MainForm)ctx.GetObject("mainForm");

            
            Application.Run(mainForm);
        }
    }
}
