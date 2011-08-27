using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HtmlAgilityPack;
using HttpUtils;

namespace Parafia.Units
{
    public class Units
    {
        private int unit1;
        private int unit2;
        private int unit3;
        private int unit4;
        private int unit5;
        private int unit6;

        public Units(String responseContent)
        {
            HtmlNodeCollection nodes = HtmlUtils.GetNodesCollectionByXPathExpression(responseContent, "//table[@class='items']");

            HtmlNode attackNode = HtmlUtils.GetSingleNodeByXPathExpression(responseContent, "//table[2]");
            HtmlNode defenseNode = HtmlUtils.GetSingleNodeByXPathExpression(responseContent, "//table[3]");

            this.unit1 = HtmlUtils.GetIntValueByXPathExpression(responseContent, "//table[2]/tbody/tr[1]/td[2]/text()");
            this.unit2 = HtmlUtils.GetIntValueByXPathExpression(responseContent, "//table[2]/tbody/tr[2]/td[2]/text()");
            this.unit3 = HtmlUtils.GetIntValueByXPathExpression(responseContent, "//table[2]/tbody/tr[3]/td[2]/text()");
            this.unit4 = HtmlUtils.GetIntValueByXPathExpression(responseContent, "//table[3]/tbody/tr[1]/td[2]/text()");
            this.unit5 = HtmlUtils.GetIntValueByXPathExpression(responseContent, "//table[3]/tbody/tr[2]/td[2]/text()");
            this.unit6 = HtmlUtils.GetIntValueByXPathExpression(responseContent, "//table[3]/tbody/tr[3]/td[2]/text()");
        }

        public void putIntoFormData(FormData formData)
        {
            if (this.unit1 != 0) formData.addValue("unit_1", this.unit1.ToString());
            if (this.unit2 != 0) formData.addValue("unit_2", this.unit2.ToString());
            if (this.unit3 != 0) formData.addValue("unit_3", this.unit3.ToString());
            if (this.unit4 != 0) formData.addValue("unit_4", this.unit4.ToString());
            if (this.unit5 != 0) formData.addValue("unit_5", this.unit5.ToString());
            if (this.unit6 != 0) formData.addValue("unit_6", this.unit6.ToString());
        }

        public bool hasUnits()
        {
            if (unit1 > 10) return true;
            if (unit2 > 10) return true;
            if (unit3 > 10) return true;
            if (unit4 > 10) return true;
            if (unit5 > 10) return true;
            if (unit6 > 10) return true;
            return false;
        }
    }
}
