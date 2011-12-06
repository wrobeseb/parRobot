using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using HttpUtils;
using HtmlAgilityPack;
using NMock2;

namespace ParafiaTest.Test
{
    using Parafia.Model.Stat;
    using Mock;
    using Parafia.Units;
    using Properties;
    using Parafia.Model.Bank;

    [TestClass]
    public class LoginTest : AbstractTest
    {
        struct transfer
        {
            int value;
            String url;
        }

        //[TestInitialize]
        public void init()
        { }

     

        //[TestMethod]
        public void timeTest()
        {
            DateTime matcher = new DateTime(2011, 11, 21, 10, 0, 0);
            DateTime matcher1 = new DateTime(2011, 11, 14, 10, 0, 0);

            for (int dayOfWeek = 6; dayOfWeek < 10; dayOfWeek++)
            {
                for (int hour = 0; hour < 24; hour++)
                {
                    DateTime actualDateTime = new DateTime(2011, 11, 13 + dayOfWeek, hour, 0, 0);

                    int actualDayOfWeekNo = (int)actualDateTime.DayOfWeek;//(int)DateTime.Now.DayOfWeek;
                    int hours = actualDateTime.Hour;//DateTime.Now.Hour;

                    int daysToMonday = 0;

                    if (actualDayOfWeekNo > 1)
                        daysToMonday = ((int)DayOfWeek.Saturday - actualDayOfWeekNo) + 2;

                    if (actualDayOfWeekNo == 1 && hours >= 10)
                        daysToMonday = 7;

                    if (actualDayOfWeekNo == 0)
                        daysToMonday = 1;

                    int hoursToAdd = 0;

                    if (hours >= 10 && hours <= 24)
                    {
                        daysToMonday--;
                        hoursToAdd = (24 - hours) + 10;
                    }
                    else
                    {
                        hoursToAdd = 10 - hours;
                    }

                    DateTime datetime = actualDateTime.AddDays(daysToMonday);
                    if (hoursToAdd != 24)
                        datetime = datetime.AddHours(hoursToAdd);
                    else
                        datetime = datetime.AddDays(1);
                }
            }



            /* DateTime dateTime = new DateTime(now.Year, now.Month, now.Day, 10, 0, 0);
             if (now.Hour >= 10 && now.Hour <= 24)
             {
                 dateTime = dateTime.AddDays(1);
             }

             TimeSpan span = dateTime - DateTime.Now;*/
        }


        //[TestMethod]
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
        public void oldestAttackTest()
        {
            List<Account> listOfNames = new List<Account>();



            List<Account> collection = new List<Account>();
            for (int i = 1; i < 30; i++)
            {
                Account account = new Account();
                account.LastAttack = DateTime.Now.AddHours((-1) * i);
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
    }
}
