using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using Spring.Context;
using Spring.Context.Support;

namespace ForexIoC
{

    using ForexIoC.Service.Forex;

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
           /* Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());*/

            IApplicationContext ctx = ContextRegistry.GetContext();

            ForexService forex1 = (ForexService)ctx.GetObject("ForexService");
            ForexService forex2 = (ForexService)ctx.GetObject("ForexService");

            if (forex1 == forex2)
            {
                Console.Write("sgdfg");
            }

            ForexIoC.Core.Worker.Worker worker = (ForexIoC.Core.Worker.Worker)ctx.GetObject("Worker");
            ForexIoC.Core.Worker.Worker worker1 = (ForexIoC.Core.Worker.Worker)ctx.GetObject("Worker");

            if (worker == worker1)
            {
                Console.Write("sgdfg");
            }
        }
    }
}
