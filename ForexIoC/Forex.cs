using System;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Net;
using System.Web;

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

            String base64String = Convert.ToBase64String(Encoding.UTF8.GetBytes(password.ToCharArray()));

            httpClient.AddCookie(new Cookie("MachineID", MachineId, "/", "trade.plus500.com"));
            httpClient.AddCookie(new Cookie("IsRealMode", "False", "/", "trade.plus500.com"));
            httpClient.AddCookie(new Cookie("UserName", HttpUtility.UrlEncode(login), "/", "trade.plus500.com"));
            httpClient.AddCookie(new Cookie("ChoseAccountModeActively", "True", "/", "trade.plus500.com"));
            httpClient.AddCookie(new Cookie("Password", base64String, "/", "trade.plus500.com"));
            httpClient.AddCookie(new Cookie("PasswordHidden" , "1", "/", "trade.plus500.com"));
            httpClient.AddCookie(new Cookie("PasswordDontPersist", "1", "/", "trade.plus500.com"));

            HttpWebResponse response1 = httpClient.HttpPost("https://trade.plus500.com/Login?forceDisplay=True&IsRealMode=False", formData);

            //HttpWebResponse response1 = httpClient.HttpGet("http://trade.plus500.com/Trade");

            httpClient.CookieContainer = prepareCookies(httpClient.CookieContainer);

            String content = httpClient.SendHttpGetAndReturnResponseContent("http://trade.plus500.com/Trade");

            HtmlNode node = HtmlUtils.GetSingleNodeByXPathExpression(content, "//div[@id='session_id']");
        }

        public void ping()
        {
        }

        private CookieContainer prepareCookies(CookieContainer oldCookies)
        {
            CookieCollection cookies = oldCookies.GetCookies(new Uri("http://trade.plus500.com"));

            CookieCollection newCookies = new CookieCollection();

            foreach (Cookie cookie in cookies)
            {
                if (!cookie.Name.Contains("Password"))
                {
                    newCookies.Add(cookie);
                }
            }

            CookieContainer cookieContainer = new CookieContainer();
            cookieContainer.Add(newCookies);

            return cookieContainer;
        }
    }
}
