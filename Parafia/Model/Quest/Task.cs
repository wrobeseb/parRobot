using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Parafia.Model.Common;
using HtmlAgilityPack;
using HttpUtils;

namespace Parafia.Model.Quest
{
    public struct Cost
    {
        public int energy;
        public int health;
        public int cash;
    }

    public struct Reward
    {
        public int exp;
        public int cash;
    }

    public struct Needs
    {
        public Relic relic;
    }

    public class Task
    {
        private String name;

        private Cost cost;
        private Reward reward;
        private Needs needs;

        private double progress;

        private String link;

        public Task() { }

        public Task(String innerHtml)
        {
            name = HtmlUtils.GetStringValueByXPathExpression(innerHtml, "//h3[@class='pt0']/text()");

            for (int i = 1; i < 4; i++)
            {
                HtmlNode node = HtmlUtils.GetSingleNodeByXPathExpression(innerHtml, "//div[@class='mt10']/div[1]/ul[1]/li[" + i + "]/text()");
                if (node != null) 
                {
                    int value = int.Parse(node.InnerText.Replace(" ", "").Split(':')[1]);

                    if (node.InnerText.Contains("Energia"))
                    {
                        cost.energy = value;
                    }
                    if (node.InnerText.Contains("Zdrowie"))
                    {
                        cost.health = value;
                    }
                    if (node.InnerText.Contains("Kasa"))
                    {
                        cost.cash = value;
                    }
                }
            }

            for (int i = 1; i < 3; i++)
            {
                HtmlNode node = HtmlUtils.GetSingleNodeByXPathExpression(innerHtml, "//div[@class='mt10']/div[2]/ul[1]/li[" + i + "]/text()");
                if (node != null)
                {
                    int value = int.Parse(node.InnerText.Replace(" ", "").Split(':')[1]);

                    if (node.InnerText.Contains("EXP"))
                    {
                        reward.exp = value;
                    }
                    if (node.InnerText.Contains("Kasa"))
                    {
                        reward.cash = value;
                    }
                }
            }

            HtmlNodeCollection needsCollection = HtmlUtils.GetNodesCollectionByXPathExpression(innerHtml, "//div[@class='mt10']/div[3]/ul[1]/img");
            
            if (needsCollection != null)
            {
                foreach (HtmlNode needNode in needsCollection)
                {
                    needs.relic = new Relic(HtmlUtils.GetAttributeValueFromHtmlNode(needNode, "title"));
                }
            }

            HtmlNode progressNode = HtmlUtils.GetSingleNodeByXPathExpression(innerHtml, "//div[@class='progressbar wp-50 left']");

            if (progressNode != null)
                progress = double.Parse(HtmlUtils.GetAttributeValueFromHtmlNode(progressNode, "rel"));

            HtmlNode linkNode = HtmlUtils.GetSingleNodeByXPathExpression(innerHtml, "//a[@class='button']");

            if (linkNode != null)
                link = HtmlUtils.GetAttributeValueFromHtmlNode(linkNode, "href");
        }

        public String Name { get { return this.name; } set { this.name = value; } }
        public Cost Cost { get { return this.cost; } set { this.cost = value; } }
        public Reward Reward { get { return this.reward; } set { this.reward = value; } }
        public Needs Needs { get { return this.needs; } set { this.needs = value; } }
        public double Progress { get { return this.progress; } set { this.progress = value; } }
        public String Link { get { return this.link; } set { this.link = value; } }
    }
}
