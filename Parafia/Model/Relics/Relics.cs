using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parafia.Model.Relics
{
    using HttpUtils;
    using HtmlAgilityPack;

    public class Relics : Hashtable
    {
        public Relics(String content)
        {
            HtmlNodeCollection relicsNodes = HtmlUtils.GetNodesCollectionByXPathExpression(content, "//ul[@class='relics-small']/li");

            List<String> relics = new List<String>();

            foreach (HtmlNode relicNode in relicsNodes)
            {
                String relicNoTxt = HtmlUtils.GetStringValueByXPathExpression(relicNode.InnerHtml, "//div[@class='right']/span[@class='num_relics']");
                String inSafeTxt = HtmlUtils.GetStringValueByXPathExpression(relicNode.InnerHtml, "//div[@class='right']/span[@class='num_safe']");
                String relicIdTxt = HtmlUtils.GetAttributeValueFromHtmlNode(relicNode, "rel");
                String relicName = HtmlUtils.GetAttributeValueFromHtmlNode(relicNode, "title");

                int relicNo = 0;
                int inSafe = 0;
                int relicId = 0;

                if (!String.IsNullOrEmpty(relicNoTxt))
                    int.TryParse(relicNoTxt, out relicNo);
                if (!String.IsNullOrEmpty(inSafeTxt))
                    int.TryParse(inSafeTxt, out inSafe);
                if (!String.IsNullOrEmpty(relicIdTxt))
                    int.TryParse(relicIdTxt, out relicId);

                if (relicId != 0)
                {
                    Relic relic = new Relic(relicId, relicName);
                    relic.Count = relicNo;
                    relic.InSafe = inSafe;

                    this.Add(relicId, relic);
                }
            }
        }

        public int GetRelicCountById(int id)
        {
            if (this.ContainsKey(id)) {
                Relic relic = (Relic)this[id];
                return relic.Count;
            }

            return 0;
        }

        public bool ContainsRelic(int id)
        {
            return this.ContainsKey(id);
        }
    }
}
