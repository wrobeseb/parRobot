using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using HttpUtils;
using HtmlAgilityPack;
using NMock2;

namespace ParafiaTest.ParafiaTest
{
    using Parafia.Model.Stat;
    using Mock;
    using TestData;

    [TestClass]
    public class LoginTest
    {
        //[TestInitialize]
        public void init()
        { }


        [TestMethod]
        public void oldestAttackTest()
        {
            List<Account> listOfNames = new List<Account>();

            

            List<Account> collection = new List<Account>();
            for (int i = 1; i < 30; i++)
            {
                Account account = new Account();
                account.LastAttack = DateTime.Now.AddHours((-1)*i);
                collection.Add(account);
            }

            int max = 30;
            Account oldest;
            do
            {
                oldest = null;
                foreach (Account item in collection)
                {
                    // if (item.Checked)
                    //  {
                    Account account = item;
                    if (oldest != null)
                    {
                        if (oldest.LastAttack.CompareTo(account.LastAttack) == 1)
                        {
                            if (!listOfNames.Contains(account))
                            {
                                if ((DateTime.Now - account.LastAttack).Hours >= 5)
                                {
                                    oldest = account;
                                }
                            }
                        }
                    }
                    else
                    {
                        if ((DateTime.Now - account.LastAttack).Hours >= 5)
                        {
                            if (!listOfNames.Contains(account))
                                oldest = account;
                        }
                    }
                    // }
                }
                if (oldest != null)
                    listOfNames.Add(oldest);
            }
            while (listOfNames.Count < max && oldest != null);
        }

        //[TestMethod]
        public void greatChangePriceChooserTest()
        {
            Mockery mocks = new Mockery();
            IDefaultHttpClient dhcMock = mocks.NewMock<IDefaultHttpClient>();

            Expect.Once.On(dhcMock).Method("SendHttpGetAndReturnResponseContent").With("http://parafia.biz/relics/market_show/70").Will(Return.Value(TestData.ParafiaBizMarketGreatChangeContent));

            String responseContent = dhcMock.SendHttpGetAndReturnResponseContent("http://parafia.biz/relics/market_show/70");

            
            HtmlNode.ElementsFlags.Remove("option");
            HtmlNodeCollection optionsNode = HtmlUtils.GetNodesCollectionByXPathExpression(responseContent, "//select[@id='market_id']/option");

            Random rand = new Random();
            int value = 10000;
            int counter;
            do
            {
                counter = 0;
                foreach (HtmlNode node in optionsNode)
                {
                    String txtValueForOption = node.InnerText;
                    if (!String.IsNullOrEmpty(txtValueForOption))
                    {
                        int valueForOption = int.Parse(Parafia.MainUtils.removeAllNotNumberCharacters(txtValueForOption));
                        if (valueForOption == value)
                            counter++;
                    }
                }
                if (counter != 0)
                    value = rand.Next(11642 - 100, 11642);
            }
            while (counter != 0);
        }

        //[TestMethod]
        public void bankTest()
        {
            Mockery mocks = new Mockery();
            IDefaultHttpClient dhcMock = mocks.NewMock<IDefaultHttpClient>();

            Expect.Once.On(dhcMock).Method("SendHttpGetAndReturnResponseContent").With("http://parafia.biz/buildings/safe").Will(Return.Value(TestData.ParafiaBizRiseSafeDisabledContent));

            String responseContent = dhcMock.SendHttpGetAndReturnResponseContent("http://parafia.biz/buildings/safe");

            String contentPart = HtmlUtils.GetStringValueByXPathExpression(responseContent, "//p[@class='mt10']/span[1]/span/text()");

            Assert.AreEqual(contentPart, "Rozbuduj za 455000 C$");

            String costTxt = Parafia.MainUtils.removeAllNotNumberCharacters(contentPart);

            Assert.AreEqual(costTxt, "455000");

            int cost = int.Parse(costTxt);

            Assert.AreEqual(cost, 455000);

            mocks.VerifyAllExpectationsHaveBeenMet();
        }

        //[TestMethod]
        public void loginTest()
        {
            Mockery mocks = new Mockery();
            IDefaultHttpClient dhcMock = mocks.NewMock<IDefaultHttpClient>();

            Expect.Once.On(dhcMock).Method("SendHttpGetAndReturnResponseContent").With("http://parafia.biz/").Will(Return.Value(TestData.ParafiBizContent));

            String responseContent = dhcMock.SendHttpGetAndReturnResponseContent("http://parafia.biz/");

            String csrf = HtmlUtils.GetStringValueByXPathExpression(responseContent, "//input[@name='login_csrf']");

            Assert.AreEqual("1c026e4b0653ed33858cad04a073fe7b", csrf);

            Expect.Once.On(dhcMock).Method("SendHttpGetAndReturnResponseContent").With("http://parafia.biz/").Will(Throw.Exception(new WebException("", WebExceptionStatus.Timeout)));

            try
            {
                responseContent = dhcMock.SendHttpGetAndReturnResponseContent("http://parafia.biz/");
            }
            catch (WebException webException)
            {
                Assert.AreEqual(webException.Status, WebExceptionStatus.Timeout);
            }

        }
    }
}
