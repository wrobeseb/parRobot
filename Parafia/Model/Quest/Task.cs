using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Parafia.Model.Common;
using HtmlAgilityPack;
using HttpUtils;

namespace Parafia.Model.Quest
{
    struct Cost
    {
        public int energy;
        public int health;
        public int cash;
    }

    struct Reward
    {
        int exp;
        int cash;
    }

    struct Needs
    {
        Relic relic;
    }

    class Task
    {
        private String name;

        private Cost cost;
        private Reward reward;
        private Needs needs;

        private int progress;

        private String link;

        public Task(String innerHtml)
        {
            HtmlNode costNode = HtmlUtils.GetSingleNodeByXPathExpression(innerHtml, "//ul[1]");
            HtmlNode rewardNode = HtmlUtils.GetSingleNodeByXPathExpression(innerHtml, "//ul[2]");
            HtmlNode needsNode = HtmlUtils.GetSingleNodeByXPathExpression(innerHtml, "//ul[3]");


            
        }

        public String Name { get { return this.name; } }
        public Cost Cost { get { return this.cost; } }
        public Reward Reward { get { return this.reward; } }
        public Needs Needs { get { return this.needs; } }
        public int Progress { get { return this.progress; } }
        public String Link { get { return this.link; } }
    }
}
