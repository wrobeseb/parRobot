using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HtmlAgilityPack;

namespace PBizBot.Model.Common
{
    using Utils;

    public class Field
    {
        private int actual;
        private int max;

        public Field() { }

        public Field(HtmlNode node)
        {
            String fieldInnerText = Utils.RemoveAllNotNumberCharacters(node.InnerText);
            String[] tempArray = fieldInnerText.Split(',');
            this.actual = int.Parse(tempArray[0]);
            this.max = int.Parse(tempArray[1]);
        }

        public Field(int actual, int max)
        {
            this.actual = actual;
            this.max = max;
        }

        public int Actual { get { return this.actual; } }
        public int Max { get { return this.max; } }
    }
}
