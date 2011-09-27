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
        private String name;
        private String parafia;
        private String odpusty;

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
            this.name = HtmlUtils.GetStringValueByXPathExpression(responseContent, "//ul[1]/li[1]/text()");
            this.name = this.name.Split(' ')[1];

            this.parafia = HtmlUtils.GetStringValueByXPathExpression(responseContent, "//ul[1]/li[2]/text()");
            this.parafia = this.parafia.Split(' ')[1];

            this.odpusty = HtmlUtils.GetStringValueByXPathExpression(responseContent, "//ul[1]/li[3]/text()");
            this.odpusty = this.odpusty.Split(' ')[1];

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

        private String formatCash(int cash) 
        {
            String cashText = cash.ToString();

            StringBuilder builder = new StringBuilder();

            char[] charArray = cashText.ToCharArray();

            for (int i = 0; i < charArray.Length; i++)
			{
			    char character = charArray[i];
                if ((charArray.Length == 4 || charArray.Length == 7) && (i == 1 || i == 5))
                    builder.Append(" ");
                if (charArray.Length == 5 && i == 2)
                    builder.Append(" ");
                if (charArray.Length == 6 && i == 3)
                    builder.Append(" ");

		        builder.Append(character);
	        }
        
            return builder.ToString();
        }

        public String ToHtml()
        {
            StringBuilder builder = new StringBuilder();

            builder.Append("<ul style=\"line-height: 1.2em;list-style: none;\">");
            builder.Append("	<li><strong>Proboszcz:</strong> ").Append(name).Append("</li>");
            builder.Append("	<li><strong>Parafia:</strong> ").Append(parafia).Append("</li>");
            builder.Append("	<li><strong>Odpusty:</strong> ").Append(odpusty).Append("</li>");
            builder.Append("</ul>");
            builder.Append("<ul style=\"line-height: 1.2em;list-style: none; margin-top: 10px\">");
            builder.Append("	<li><strong>Poziom:</strong> Poziom ").Append(Level.LevelNo).Append(" ( ").Append(Level.ExpActual).Append(" / ").Append(Level.ExpNextLevel).Append(" )</li>");
            builder.Append("	<li><strong>Kasa:</strong> ").Append(formatCash(Cash.Actual)).Append(" C$ / ").Append(formatCash(Cash.Max)).Append(" C$</li>");
            builder.Append("	<li><strong>Sejf:</strong> ").Append(formatCash(Safe.Actual)).Append(" C$ / ").Append(formatCash(Safe.Max)).Append(" C$</li>");
            builder.Append("	<li><strong>Zdrowie:</strong> ").Append(Health.Actual).Append(" / ").Append(Health.Max).Append("</li>");
            builder.Append("	<li><strong>Energia:</strong> ").Append(Energy.Actual).Append(" / ").Append(Energy.Max).Append("</li>");
            builder.Append("	<li><strong>Wierz&#261;cych:</strong> ").Append(Beliver.Actual).Append(" / ").Append(Beliver.Max).Append("</li>");
            builder.Append("	<li><strong>Wikarych:</strong> ").Append(Vicar.Actual).Append(" / ").Append(Vicar.Max).Append("</li>");
            builder.Append("	<li><strong>Relikwie:</strong> ").Append(Relics.Actual).Append(", w sejfie ").Append(Relics.InSafe).Append(" / ").Append(Relics.MaxSafe).Append("</li>");
            builder.Append("</ul>");

            return builder.ToString();
        }
    }
}
