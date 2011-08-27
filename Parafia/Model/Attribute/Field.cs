using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HtmlAgilityPack;

namespace Parafia.Attributes
{
    public class Field
    {
        private int actual;
        private int max;

        public Field(HtmlNode node)
        {
            String fieldInnerText = MainUtils.removeAllNotNumberCharacters(node.InnerText);
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
