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
    using Parafia.Units;
    using Properties;
    using Parafia.Model.Bank;

    [TestClass]
    public class LoginTest
    {
        struct transfer
        {
            int value;
            String url;
        }

        //[TestInitialize]
        public void init()
        { }

        private IDefaultHttpClient getDhcHttpGetMock(String url, String returnValue)
        {
            Mockery mocks = new Mockery();
            IDefaultHttpClient dhcMock = mocks.NewMock<IDefaultHttpClient>();
            Expect.Once.On(dhcMock).Method("SendHttpGetAndReturnResponseContent").With(url).Will(Return.Value(returnValue));
            return dhcMock;
        }


        [TestMethod]
        public void gettingTranfersFormBankTest()
        {
            String url = "http://parafia.biz/bank";

            IDefaultHttpClient dhcMock = getDhcHttpGetMock(url, Resource.ParafiaBizBankEmptyContent);
            String responseContent = dhcMock.SendHttpGetAndReturnResponseContent(url);

            HtmlNodeCollection transfersNodes = HtmlUtils.GetNodesCollectionByXPathExpression(responseContent, "//ul[@class='banks']/li");

            List<Transfer> transfers = new List<Transfer>();

            if (transfersNodes != null)
            {
                foreach (HtmlNode node in transfersNodes)
                {
                    String valueTxt = HtmlUtils.GetStringValueByXPathExpression(node.InnerHtml, "//div[@class='bank_money']/text()");
                    valueTxt = Parafia.MainUtils.removeAllNotNumberCharacters(valueTxt);
                    int value = 0;
                    int.TryParse(valueTxt, out value);
                    String aUrl = HtmlUtils.GetAttributeValueOfElementByXPathExpression(node.InnerHtml, "href", "//a[@class='button']");

                    transfers.Add(new Transfer(value, aUrl));
                }
            }
        }

        //[TestMethod]
        public void gettingSingleUnitValuesTest()
        {
            Mockery mocks = new Mockery();
            IDefaultHttpClient dhcMock = mocks.NewMock<IDefaultHttpClient>();
            Expect.Once.On(dhcMock).Method("SendHttpGetAndReturnResponseContent").With("http://parafia.biz/units").Will(Return.Value(Resource.ParafiaBizUnitsContent));

            String responseContent = dhcMock.SendHttpGetAndReturnResponseContent("http://parafia.biz/units");

            HtmlNodeCollection unitsNodes = HtmlUtils.GetNodesCollectionByXPathExpression(responseContent, "//ul[@class='units-buy']/li");

            for (int i = 0; i < unitsNodes.Count; i++)
            {
                HtmlNode unitNode = unitsNodes[i];
                if (i == 0)
                {
                    getUnitSingleAttack(unitNode);
                    getUnitSingleDefense(unitNode);
                }
            }
        }

        private double getUnitSingleAttack(HtmlNode node)
        {
            HtmlNode pNode = HtmlUtils.GetSingleNodeByXPathExpression(node.InnerHtml, "//div[@class='left']/p[2]");

            String textValue = Parafia.MainUtils.removeAllNotNumberCharactersForDouble(pNode.InnerHtml.Split('<')[0].Split('(')[1]);

            double value = 0;

            Double.TryParse(textValue, out value);

            return value;
        }
        private double getUnitSingleDefense(HtmlNode node)
        {
            HtmlNode pNode = HtmlUtils.GetSingleNodeByXPathExpression(node.InnerHtml, "//div[@class='left']/p[2]");
            String textValue = Parafia.MainUtils.removeAllNotNumberCharactersForDouble(pNode.InnerHtml.Split('>')[1].Split('(')[1]);

            double value = 0;

            Double.TryParse(textValue, out value);

            return value;
        }

        //[TestMethod]
        public void calculateExpeditionsTest()
        {
            Mockery mocks = new Mockery();
            IDefaultHttpClient dhcMock = mocks.NewMock<IDefaultHttpClient>();
            Expect.Once.On(dhcMock).Method("SendHttpGetAndReturnResponseContent").With("http://parafia.biz/units/expeditions").Will(Return.Value(Resource.ParafiaBizExpeditionsContent));

            String responseContent = dhcMock.SendHttpGetAndReturnResponseContent("http://parafia.biz/units/expeditions");

            HtmlNodeCollection expeditionNodes = HtmlUtils.GetNodesCollectionByXPathExpression(responseContent, "//table[@class='expeditions']/tr[@class='expedition']");

            foreach (HtmlNode expeditionNode in expeditionNodes)
            {
                HtmlNodeCollection unitsNodes = HtmlUtils.GetNodesCollectionByXPathExpression(expeditionNode.InnerHtml, "//div[@class='unit']");
                foreach (HtmlNode unitNode in unitsNodes)
                {
                    setUnitAmount(unitNode);
                }
            }
        }

        private void setUnitAmount(HtmlNode unitNode)
        {
            String unit1Id = "_21_";
            String unit2Id = "_651_";
            String unit3Id = "_588_";
            String unit4Id = "_22_";
            String unit5Id = "_24_";
            String unit6Id = "_23_";

            String srcValue = HtmlUtils.GetAttributeValueOfElementByXPathExpression(unitNode.InnerHtml, "src", "//img");
            int amount = HtmlUtils.GetIntValueByXPathExpression(unitNode.InnerHtml, "//div[@class='unit_amount']/text()");
            if (srcValue.Contains(unit1Id))
                Assert.AreEqual(amount, 10);
            if (srcValue.Contains(unit2Id))
                Assert.AreEqual(amount, 10);
            if (srcValue.Contains(unit3Id))
                Assert.AreNotEqual(amount, 0);
            if (srcValue.Contains(unit4Id))
                Assert.AreEqual(amount, 10);
            if (srcValue.Contains(unit5Id))
                Assert.AreEqual(amount, 1);
            if (srcValue.Contains(unit6Id))
                Assert.AreEqual(amount, 0);
        }

        //[TestMethod]
        public void relicsInHouseTest()
        {
            Mockery mocks = new Mockery();
            IDefaultHttpClient dhcMock = mocks.NewMock<IDefaultHttpClient>();

            Expect.Once.On(dhcMock).Method("SendHttpGetAndReturnResponseContent").With("http://parafia.biz/relics/my").Will(Return.Value(TestData.ParafiaBizRelicsInHouseContent));

            String responseContent = dhcMock.SendHttpGetAndReturnResponseContent("http://parafia.biz/relics/my");

            //HtmlNode.ElementsFlags.Remove("option");
            HtmlNodeCollection relicsNodes = HtmlUtils.GetNodesCollectionByXPathExpression(responseContent, "//ul[@class='relics-small']/li");

            List<String> relics = new List<string>();

            foreach (HtmlNode relicNode in relicsNodes)
            {
                String relicNo = HtmlUtils.GetStringValueByXPathExpression(relicNode.InnerHtml, "//div[@class='right']/span[@class='num_relics']");
                String inSafe = HtmlUtils.GetStringValueByXPathExpression(relicNode.InnerHtml, "//div[@class='right']/span[@class='num_safe']");
                if (String.IsNullOrEmpty(inSafe) || (!relicNo.Equals(inSafe)))
                {
                    relics.Add(HtmlUtils.GetAttributeValueFromHtmlNode(relicNode, "rel") + ";" + HtmlUtils.GetAttributeValueFromHtmlNode(relicNode, "title"));
                }
            }
        }

        //[TestMethod]
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
