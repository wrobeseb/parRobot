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
using HtmlAgilityPack;

using System.Net.Sockets;

namespace ParafiaTest
{
    //[TestClass]
    public class ParafiaClassTest
    {
        private String user = "sairo";
        private String passwd = "sairoroan";

        private DefaultHttpClient httpClient;

        //[TestInitialize]
        public void init()
        {
            httpClient = new DefaultHttpClient();
            
            WebProxy proxy = new WebProxy("126.179.0.200", 3128);
            proxy.Credentials = new NetworkCredential("wrobese2", "#Pazdziernik2011#", "TP");
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
        public void buyRelic()
        {
            loginTest();

            String content = httpClient.SendHttpGetAndReturnResponseContent("http://parafia.biz/relics/market_show/70");

            HtmlNode.ElementsFlags.Remove("option");

            int value = 35000;
            int counter = 0;
            HtmlNodeCollection optionsNode = HtmlUtils.GetNodesCollectionByXPathExpression(content, "//select[@id='market_id']/option");

            foreach (HtmlNode node in optionsNode)
            {
                String txtValueForOption = node.InnerText;
                if (!String.IsNullOrEmpty(txtValueForOption))
                {
                    int valueForOption = int.Parse(removeAllNotNumberCharacters(txtValueForOption));
                    if (valueForOption == value)
                        counter++;
                }
            }

            Assert.AreEqual(6, counter);
        }

        [TestMethod]
        public void test()
        {
            String openSessionText = "201/00046/O/60/12618566199/2/1/1///0100//////";

            StringBuilder builderSession = new StringBuilder("0201/00046/O/60/12618566199/2/1/1///0100//////");
            builderSession.Append(GenerateChecksum(openSessionText)).Append("03");

            String text = "201/00047/O/30/600097131///1//////68656C6C6F/";

            
            StringBuilder builderMessage = new StringBuilder("0201/00047/O/30/600097131///1//////68656C6C6F/");
            builderMessage.Append(GenerateChecksum(text)).Append("03");

            TcpClient client = new TcpClient("10.236.16.86", 2258);
            try
            {
                Stream s = client.GetStream();

                StreamReader sr = new StreamReader(s);
                StreamWriter sw = new StreamWriter(s);
                sw.AutoFlush = true;

                sw.WriteLine(builderSession.ToString());

                String lol1 = sr.ReadLine();
            }
            finally
            {
                client.Close();
            }
            /*String resultInHex = "";

            resultInHex += String.Format("{0:X}", Convert.ToUInt32(first));
            resultInHex += String.Format("{0:X}", Convert.ToUInt32(last));*/

        }

        private String GenerateChecksum(String value)
        {
            String hexits = "0123456789ABCDEF";

            int checksum = 0;

            for (int i = 1; i < value.Length; i++)
            {
                checksum += value.ToCharArray()[i];
            }

            int result = checksum & 0xff;

            char first = hexits.ToCharArray()[checksum >> 4 & 15];
            char last = hexits.ToCharArray()[checksum & 15];

            return new StringBuilder().Append(first).Append(last).ToString();
        }

        //[TestMethod]
        public void getTest()
        {
            HttpWebResponse response = httpClient.HttpGet("http://parafia.biz/");
            String responseContent = HtmlUtils.GetContentForResponse(response);
            String csrfValue = HtmlUtils.GetStringValueByXPathExpression(responseContent, "//input[@name='login_csrf']");
        }

        private String removeAllNotNumberCharacters(String content)
        {
            content = content.Replace(" ", "");

            StringBuilder builder = new StringBuilder();
            foreach (char character in content.ToCharArray())
            {
                if ((int)character < 48 || (int)character > 57)
                {
                    builder.Append(" ");
                }
                else
                {
                    builder.Append(character);
                }
            }

            String tempString = builder.ToString();

            builder = new StringBuilder();

            foreach (String value in tempString.Split(' '))
            {
                if (!String.IsNullOrEmpty(value))
                {
                    builder.Append(value).Append(",");
                }
            }

            return builder.ToString().TrimEnd(',');
        }
    }
}
