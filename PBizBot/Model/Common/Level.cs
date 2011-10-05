using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HtmlAgilityPack;

namespace PBizBot.Model.Common
{
    using Utils;

    public class Level
    {
        private int levelNo;
        private int expActual;
        private int expNextLevel;

        public Level() { }

        public Level(HtmlNode node)
        {
            String levelInnerText = Utils.RemoveAllNotNumberCharacters(node.InnerText);
            String[] tempArray = levelInnerText.Split(',');
            this.levelNo = int.Parse(tempArray[0]);
            this.expActual = int.Parse(tempArray[1]);
            this.expNextLevel = int.Parse(tempArray[2]);
        }

        public Level(int levelNo, int expActual, int expNextLevel)
        {
            this.levelNo = levelNo;
            this.expActual = expActual;
            this.expNextLevel = expNextLevel;
        }

        public int LevelNo { get { return this.levelNo; } }
        public int ExpActual { get { return this.expActual; } }
        public int ExpNextLevel { get { return this.expNextLevel; } }
    }
}
