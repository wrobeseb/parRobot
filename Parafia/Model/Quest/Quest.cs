using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HtmlAgilityPack;
using HttpUtils;

namespace Parafia.Model.Quest
{
    class Quest
    {
        private String name;
        private String link;
        private int priority;

        public Quest(String name, String link)
        {
            this.name = name;
            this.link = link;
        }
    }
}
