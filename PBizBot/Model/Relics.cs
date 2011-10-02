using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HtmlAgilityPack;

namespace PBizBot.Model
{
    using Utils;

    public class Relics
    {
        private int actual;
        private int inSafe;
        private int maxSafe;

        public Relics(HtmlNode node)
        {
            String relicsInnerText = Utils.RemoveAllNotNumberCharacters(node.InnerText);
            String[] tempArray = relicsInnerText.Split(',');
            this.actual = int.Parse(tempArray[0]);
            this.inSafe = int.Parse(tempArray[1]);
            this.maxSafe = int.Parse(tempArray[2]);
        }

        public Relics(int actual, int inSafe, int maxSafe)
        {
            this.actual = actual;
            this.inSafe = inSafe;
            this.maxSafe = maxSafe;
        }

        public int Actual { get { return this.actual; } }
        public int InSafe { get { return this.inSafe; } }
        public int MaxSafe { get { return this.maxSafe; } }
    }
}
