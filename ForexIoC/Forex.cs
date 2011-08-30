using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;

using HttpUtils;
using HtmlAgilityPack;

namespace ForexIoC
{
    public class Forex
    {
        private DefaultHttpClient httpClient;

        private String sessionId;
        private String subSessionId;

        public void initConnection(WebProxy proxy)
        {
            httpClient = new DefaultHttpClient();
            if (proxy != null)
                httpClient.SetWebProxy = proxy;
        }

        public void login(String login, String password)
        {
            FormData formData = new FormData();
            formData.addValue("isRealMode", "False");
            formData.addValue("userName", login);
            formData.addValue("password", password);
            formData.addValue("savePassword", "false");

            HttpWebResponse response2 = httpClient.HttpGet("https://trade.plus500.com/");

            String MachineId = "";

            Random rand = new Random();
            for (int i = 0; i < 32; i++)
            {
                MachineId += "0123456789abcdef".Substring((int)Math.Floor(rand.NextDouble() * 16), 1);
            }

            httpClient.AddCookie(new Cookie("MachineID", MachineId, "/", "trade.plus500.com"));

            HttpWebResponse response = httpClient.HttpPost("https://trade.plus500.com/Login?IsRealMode=False", formData);

            HttpWebResponse response1 = httpClient.HttpGet("http://trade.plus500.com/Trade");

            //HtmlNode node = HtmlUtils.GetSingleNodeByXPathExpression(content, "//div[@id='session_id']");
        }

        public void ping()
        {
        }
    }
}
