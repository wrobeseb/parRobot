using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ForexIoC.Core.Worker
{
    using ForexIoC.Service.Forex;
    using ForexIoC.Service.Mail;

    public class Worker
    {
        private ForexService m_forexService;
        private MailService m_mailService;

        public ForexService ForexService
        {
            set { m_forexService = value; }
        }

        public MailService MailService
        {
            set { m_mailService = value; }
        }

        public void run()
        {

        }
    }
}
