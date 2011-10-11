﻿using System;
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
    using Mock;
    using TestData;

    [TestClass]
    public class LoginTest
    {
        //[TestInitialize]
        public void init()
        { }

        [TestMethod]
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