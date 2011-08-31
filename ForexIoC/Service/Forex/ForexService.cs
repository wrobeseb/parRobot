using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ForexIoC.Service.Forex
{
    using ForexIoC.Service.Http;

    public class ForexService
    {
        private HttpService m_httpService;

        public HttpService HttpService
        {
            set { m_httpService = value; }
        }
    }
}
