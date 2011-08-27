using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HttpUtils;
using HtmlAgilityPack;

namespace Parafia.Attributes
{
    public class Attributes
    {
        private Level level;
        private Field cash;
        private Field safe;
        private Field health;
        private Field energy;
        private Field believer;
        private Field vicar;
        private Relics relics;

        public Attributes(String responseContent)
        {
            this.level = new Level(HtmlUtils.GetSingleNodeByXPathExpression(responseContent, "//ul[2]/li[1]"));
            this.cash = new Field(HtmlUtils.GetSingleNodeByXPathExpression(responseContent, "//ul[2]/li[2]"));
            this.safe = new Field(HtmlUtils.GetSingleNodeByXPathExpression(responseContent, "//ul[2]/li[3]"));
            this.health = new Field(HtmlUtils.GetSingleNodeByXPathExpression(responseContent, "//ul[2]/li[4]"));
            this.energy = new Field(HtmlUtils.GetSingleNodeByXPathExpression(responseContent, "//ul[2]/li[5]"));
            this.believer = new Field(HtmlUtils.GetSingleNodeByXPathExpression(responseContent, "//ul[2]/li[6]"));
            this.vicar = new Field(HtmlUtils.GetSingleNodeByXPathExpression(responseContent, "//ul[2]/li[7]"));
            this.relics = new Relics(HtmlUtils.GetSingleNodeByXPathExpression(responseContent, "//ul[2]/li[8]"));
        }

        public Level Level { get { return this.level; } }
        public Field Cash { get { return this.cash; } }
        public Field Safe { get { return this.safe; } }
        public Field Health { get { return this.health; } }
        public Field Energy { get { return this.energy; } }
        public Field Beliver { get { return this.believer; } }
        public Field Vicar { get { return this.vicar; } }
        public Relics Relics { get { return this.relics; } }
    }
}
