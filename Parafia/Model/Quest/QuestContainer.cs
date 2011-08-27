using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HtmlAgilityPack;
using HttpUtils;

namespace Parafia.Model.Quest
{
    public class QuestContainer
    {
        private List<Quest> listOfQuests;

        public QuestContainer(String responseContent)
        {
            listOfQuests = new List<Quest>();

            HtmlNodeCollection nodeCollection = HtmlUtils.GetNodesCollectionByXPathExpression(responseContent, "//div[@id='quest_sections_inner']/a");

            foreach (HtmlNode node in nodeCollection)
            {
                listOfQuests.Add(new Quest(HtmlUtils.GetAttributeValueFromHtmlNode(node, "title"), HtmlUtils.GetAttributeValueFromHtmlNode(node, "href")));
            }
        }
    }
}
