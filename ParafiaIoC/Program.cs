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
            IApplicationContext ctx = ContextRegistry.GetContext();  

            //Application.EnableVisualStyles();
           // Application.SetCompatibleTextRenderingDefault(false);
           // Application.Run(new Form1());
        }
    }
}
