using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net;
using System.IO;
using System.Xml;
using System.Xml.XPath;
using HttpUtils;
using Parafia.Attributes;


namespace ParafiaTest
{
    [TestClass]
    public class ParafiaTest
    {
        private String user = "sairo";
        private String passwd = "sairoroan";

        private DefaultHttpClient httpClient;

        //[TestInitialize]
        public void init()
        {
            httpClient = new DefaultHttpClient();
            
            WebProxy proxy = new WebProxy("126.179.0.200", 3128);
            proxy.Credentials = new NetworkCredential("wrobese2", "#Sierpien2011#", "TP");
            httpClient.SetWebProxy = proxy;
        }

        //[TestMethod]
        public void loginTest()
        {
            String responseContent = httpClient.SendHttpGetAndReturnResponseContent("http://parafia.biz/");
            String csrf = HtmlUtils.GetStringValueByXPathExpression(responseContent, "//input[@name='login_csrf']");

            FormData formData = new FormData();
            formData.addValue("formo_login_form", "login_form");
            formData.addValue("login_csrf", csrf);
            formData.addValue("user_name", user);
            formData.addValue("user_pass", passwd);
            formData.addValue("login_submit", "");

            responseContent = httpClient.SendHttpPostAndReturnResponseContent("http://parafia.biz/", formData);

            String errorMessage = HtmlUtils.GetStringValueByXPathExpression(responseContent, "//div[@class='form-error']/text()");

            if (!String.IsNullOrEmpty(errorMessage))
            {
                Assert.Fail();
            }
            else
            {
                Attributes att = new Attributes(responseContent);
            }

        }

        //[TestMethod]
        public void getTest()
        {
            HttpWebResponse response = httpClient.HttpGet("http://parafia.biz/");
            String responseContent = HtmlUtils.GetContentForResponse(response);
            String csrfValue = HtmlUtils.GetStringValueByXPathExpression(responseContent, "//input[@name='login_csrf']");
        }
    }
}
