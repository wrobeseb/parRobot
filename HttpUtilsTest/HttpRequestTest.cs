using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HttpUtils;

namespace HttpUtilsTest
{
    [TestClass]
    public class HttpRequestTest
    {
        [TestMethod]
        public void SendRequestTest()
        {
            FormData formData = new FormData();
            formData.addValue("formo_login_form", "login_form");
            formData.addValue("login_csrf", "128e641cd470cb2f08484d309211e0f8");
            formData.addValue("user_name", "sairo");
            formData.addValue("login_submit", "");

            WebProxy webProxy = new WebProxy("126.179.0.200", 3128);

            DefaultHttpClient httpClient = new DefaultHttpClient();
            httpClient.SetWebProxy = webProxy;

            HttpWebResponse loginResponse =  httpClient.HttpPost("http://parafia.biz/", formData);

            HttpWebResponse test = httpClient.HttpGet("http://parafia.biz/units/buy/4/amount/1");

            //Console.WriteLine(response.StatusCode);
        }
    }
}
