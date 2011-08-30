using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Threading;

namespace ForexIoC
{
    public class Worker
    {
        private volatile bool semafor = true;
        private volatile bool workIsActive = false;

        private Forex forex; 

        public void run()
        {
            while (semafor)
            {
                if (workIsActive)
                {
                    if (forex == null)
                    {
                        forex = new Forex();
                        WebProxy proxy = new WebProxy("126.179.0.200", 3128);
                        proxy.Credentials = new NetworkCredential("wrobese2", "#Sierpien2011#", "TP");
                        forex.initConnection(proxy);
                        forex.login("sairo149240@gmail.com", "sairoroan");
                    }
                    forex.ping();
                }
                Thread.Sleep(500);
            }
        }

        public void StopWorker()
        {
            this.workIsActive = false;
        }

        public void StartWorker()
        {
            this.workIsActive = true;
        }
    }
}
