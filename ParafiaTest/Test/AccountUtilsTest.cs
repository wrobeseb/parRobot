using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ParafiaTest.Mock;
using HtmlAgilityPack;
using HttpUtils;

namespace ParafiaTest.Test
{
    [TestClass]
    public class AccountUtilsTest : AbstractTest
    {
        public IDefaultHttpClient mDhcMock;

        [TestInitialize]
        public void init()
        {
            this.mDhcMock = getDhcHttpGetMock("http://parafia.biz/dashboard", Properties.Resource.ParafiaBizDashboardContent);
        }

        [TestMethod]
        public void ExtractFieldTest()//(out int valueActual, out int valueMax, HtmlNode node)
        {
            String fieldInnerText = FieldExtractor(NodeExtractor("//ul[2]/li[7]").InnerText);
            String[] tempArray = fieldInnerText.Split('/');
            int valueActual = int.Parse(tempArray[0]);
            int valueMax = int.Parse(tempArray[1]);
        }
        [TestMethod]
        public void ExtractFieldWithGrowTest()//(out int valueActual, out int valueMax, out int valueGrow, HtmlNode node)
        {
            HtmlNode node = NodeExtractor("//ul[2]/li[5]");
            String fieldInnerText = FieldExtractor(node.InnerText);
            String[] tempArray = fieldInnerText.Split('/');
            int valueActual = int.Parse(tempArray[0]);
            int valueMax = int.Parse(tempArray[1]);
            String growText = HtmlUtils.GetAttributeValueFromHtmlNode(node, "title");

            tempArray = growText.Split(' ');
            String growValueTxt = tempArray[0];

            int valueGrow;

            int.TryParse(growValueTxt.Substring(1), out valueGrow);

            if (growValueTxt.StartsWith("-"))
                valueGrow = (-1) * valueGrow;
        }

        [TestMethod]
        public void ExtractLevelTest()//(out int levelNo, out int expActual, out int expNextLevel, HtmlNode node)
        {
            String levelInnerText = FieldExtractor(NodeExtractor("//ul[2]/li[1]").InnerText);
            String[] tempArray = levelInnerText.Split('(');
            int levelNo = int.Parse(tempArray[0]);
            tempArray = tempArray[1].Split('/');
            int expActual = int.Parse(tempArray[0]);
            int expNextLevel = int.Parse(tempArray[1]);
        }

        private String FieldExtractor(String innerHtml)
        {
            StringBuilder builder = new StringBuilder();
            foreach (char character in innerHtml.ToCharArray())
            {
                if (((int)character < 48 || (int)character > 57) && (int)character != 44 && (int)character != 43 && (int)character != 45 && (int)character != 40 && (int)character != 47)
                {
                    builder.Append(" ");
                }
                else
                {
                    builder.Append(character);
                }
            }

            return builder.ToString();
        }

        private HtmlNode NodeExtractor(String xPathExpr)
        {
            return HtmlUtils.GetSingleNodeByXPathExpression(this.mDhcMock.SendHttpGetAndReturnResponseContent("http://parafia.biz/dashboard"), xPathExpr);
        }
    }
}
