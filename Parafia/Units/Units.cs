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
        public double attack;
        public double defense;

        public int unit1; public double unit1Attack, unit1Defense;
        public int unit2; public double unit2Attack, unit2Defense;
        public int unit3; public double unit3Attack, unit3Defense;
        public int unit4; public double unit4Attack, unit4Defense;
        public int unit5; public double unit5Attack, unit5Defense;
        public int unit6; public double unit6Attack, unit6Defense;

        public Units(String responseContent)
        {
            HtmlNodeCollection nodes = HtmlUtils.GetNodesCollectionByXPathExpression(responseContent, "//table[@class='items']");

            String attackTxt = HtmlUtils.GetStringValueByXPathExpression(responseContent, "//table[1]/tbody/tr[1]/td[2]/text()").Split(' ')[0];
            String defenseTxt = HtmlUtils.GetStringValueByXPathExpression(responseContent, "//table[1]/tbody/tr[2]/td[2]/text()").Split(' ')[0];

            attack = Double.Parse(attackTxt);
            defense = Double.Parse(defenseTxt);

            this.unit1 = HtmlUtils.GetIntValueByXPathExpression(responseContent, "//table[2]/tbody/tr[1]/td[2]/text()");
            this.unit1Attack = double.Parse(HtmlUtils.GetStringValueByXPathExpression(responseContent, "//table[2]/tbody/tr[1]/td[3]/text()"));
            this.unit1Defense = double.Parse(HtmlUtils.GetStringValueByXPathExpression(responseContent, "//table[2]/tbody/tr[1]/td[4]/text()"));
            this.unit2 = HtmlUtils.GetIntValueByXPathExpression(responseContent, "//table[2]/tbody/tr[2]/td[2]/text()");
            this.unit2Attack = double.Parse(HtmlUtils.GetStringValueByXPathExpression(responseContent, "//table[2]/tbody/tr[2]/td[3]/text()"));
            this.unit2Defense = double.Parse(HtmlUtils.GetStringValueByXPathExpression(responseContent, "//table[2]/tbody/tr[2]/td[4]/text()"));
            this.unit3 = HtmlUtils.GetIntValueByXPathExpression(responseContent, "//table[2]/tbody/tr[3]/td[2]/text()");
            this.unit3Attack = double.Parse(HtmlUtils.GetStringValueByXPathExpression(responseContent, "//table[2]/tbody/tr[3]/td[3]/text()"));
            this.unit3Defense = double.Parse(HtmlUtils.GetStringValueByXPathExpression(responseContent, "//table[2]/tbody/tr[3]/td[4]/text()"));
            this.unit4 = HtmlUtils.GetIntValueByXPathExpression(responseContent, "//table[3]/tbody/tr[1]/td[2]/text()");
            this.unit4Attack = double.Parse(HtmlUtils.GetStringValueByXPathExpression(responseContent, "//table[3]/tbody/tr[1]/td[3]/text()"));
            this.unit4Defense = double.Parse(HtmlUtils.GetStringValueByXPathExpression(responseContent, "//table[3]/tbody/tr[1]/td[4]/text()"));
            this.unit5 = HtmlUtils.GetIntValueByXPathExpression(responseContent, "//table[3]/tbody/tr[2]/td[2]/text()");
            this.unit5Attack = double.Parse(HtmlUtils.GetStringValueByXPathExpression(responseContent, "//table[3]/tbody/tr[2]/td[3]/text()"));
            this.unit5Defense = double.Parse(HtmlUtils.GetStringValueByXPathExpression(responseContent, "//table[3]/tbody/tr[2]/td[4]/text()"));
            this.unit6 = HtmlUtils.GetIntValueByXPathExpression(responseContent, "//table[3]/tbody/tr[3]/td[2]/text()");
            this.unit6Attack = double.Parse(HtmlUtils.GetStringValueByXPathExpression(responseContent, "//table[3]/tbody/tr[3]/td[3]/text()"));
            this.unit6Defense = double.Parse(HtmlUtils.GetStringValueByXPathExpression(responseContent, "//table[3]/tbody/tr[3]/td[4]/text()"));
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
            if (unit1 > 0) return true;
            if (unit2 > 0) return true;
            if (unit3 > 0) return true;
            if (unit4 > 0) return true;
            if (unit5 > 0) return true;
            if (unit6 > 0) return true;
            return false;
        }

        public int cashForPilgrimage()
        {
            int cash = 0;

            if (unit1 > 0) cash += doubleToInt(0.02 * unit1 * 20);
            if (unit2 > 0) cash += doubleToInt(0.02 * unit2 * 150);
            if (unit3 > 0) cash += doubleToInt(0.02 * unit3 * 1000);
            if (unit4 > 0) cash += doubleToInt(0.02 * unit4 * 20);
            if (unit5 > 0) cash += doubleToInt(0.02 * unit5 * 150);
            if (unit6 > 0) cash += doubleToInt(0.02 * unit6 * 1000);

            return cash;
        }

        private int doubleToInt(double value)
        {
            return Convert.ToInt32(value) + 1;
        }

        public string ToHtml()
        {
            StringBuilder builder = new StringBuilder();

            builder.Append("<div style=\"line-height: 1.5em;padding: 10px;width: 700px;\">");
            builder.Append("	<h2 style=\"color: #4a2c5c;font: normal 20px/1em 'Lucida Sans Unicode', Arial, Helvetica, Tahoma, sans-serif;padding: 0;border-bottom: 1px solid #e7e7e7;\">Twoja pot&#281;ga</h2>");
            builder.Append("	<table style=\"border: 1px solid #e0e0e0; empty-cells: show; margin-bottom: 0; width: 100%;\" cellspacing=\"0\" cellpadding=\"0\">");
            builder.Append("		<tbody>");
            builder.Append("			<tr>");
            builder.Append("				<td style=\"text-align: center;border: 1px solid #e0e0e0;border-width: 0 1px 1px 0;background: #f2f2f2;color: #222;font-size: 14px;vertical-align: middle;width: 25%;\"><strong>Si&#322;a ataku</strong></td>");
            builder.Append("				<td style=\"border: 1px solid #e0e0e0;border-width: 0 0 1px 0;padding: 5px 15px;font-size: 12px;\">").Append(attack).Append("</td>");
            builder.Append("			</tr>");
            builder.Append("			<tr>");
            builder.Append("				<td style=\"text-align: center;border: 1px solid #e0e0e0;border-width: 0 1px 0 0;background: #f2f2f2;color: #222;font-size: 14px;vertical-align: middle;width: 25%;\"><strong>Si&#322;a obrony</strong></td>");
            builder.Append("				<td style=\"padding: 5px 15px;font-size: 12px;\">").Append(defense).Append("</td>");
            builder.Append("			</tr>");
            builder.Append("		</tbody>");
            builder.Append("	</table>");
            builder.Append("");
            builder.Append("	<h2 style=\"color: #4a2c5c;font: normal 20px/1em 'Lucida Sans Unicode', Arial, Helvetica, Tahoma, sans-serif;padding: 0;border-bottom: 1px solid #e7e7e7;\">Pierwsze szeregi</h2>");
            builder.Append("	<table style=\"border: 1px solid #e0e0e0; empty-cells: show; margin-bottom: 0px; width: 100%;\" cellspacing=\"0\" cellpadding=\"0\">");
            builder.Append("		<thead>");
            builder.Append("			<tr>");
            builder.Append("				<th style=\"text-align: center;border: 1px solid #e0e0e0;border-width: 0 1px 1px 0;background: #f2f2f2;color: #222;font-size: 14px;padding: 2px 5px;vertical-align: middle;margin-bottom: 10px;width: 40%;\">Jednostka</th>");
            builder.Append("				<th style=\"text-align: center;border: 1px solid #e0e0e0;border-width: 0 1px 1px 0;background: #f2f2f2;color: #222;font-size: 14px;padding: 2px 5px;vertical-align: middle;margin-bottom: 10px;width: 20%;\">Ilo&#347;&#263;</th>");
            builder.Append("				<th style=\"text-align: center;border: 1px solid #e0e0e0;border-width: 0 1px 1px 0;background: #f2f2f2;color: #222;font-size: 14px;padding: 2px 5px;vertical-align: middle;margin-bottom: 10px;width: 20%;\">Si&#322;a ataku</th>");
            builder.Append("				<th style=\"text-align: center;border: 1px solid #e0e0e0;border-width: 0 0 1px 0;background: #f2f2f2;color: #222;font-size: 14px;padding: 2px 5px;vertical-align: middle;margin-bottom: 10px;width: 20%;\">Si&#322;a obrony</th>");
            builder.Append("			</tr>");
            builder.Append("		</thead>");
            builder.Append("		<tbody>");
            builder.Append("			<tr>");
            builder.Append("				<td style=\"border: 1px solid #e0e0e0;border-width: 0 1px 1px 0;background: #fbfbfb;color: #222;font-size: 12px;padding: 2px 5px;vertical-align: middle;margin-bottom: 10px;\"><strong>Ministranci</strong></td>");
            builder.Append("				<td style=\"text-align: center; vertical-align: middle; background: #fbfbfb;border: 1px solid #e0e0e0;font-size: 12px;border-width: 0 1px 1px 0;line-height: 20px;padding: 2px;\">").Append(unit1).Append("</td>");
            builder.Append("				<td style=\"text-align: center; vertical-align: middle; background: #fbfbfb;border: 1px solid #e0e0e0;font-size: 12px;border-width: 0 1px 1px 0;line-height: 20px;padding: 2px;\">").Append(unit1Attack).Append("</td>");
            builder.Append("				<td style=\"text-align: center; vertical-align: middle; background: #fbfbfb;border: 1px solid #e0e0e0;font-size: 12px;border-width: 0 0 1px 0;line-height: 20px;padding: 2px;\">").Append(unit1Defense).Append("</td>");
            builder.Append("			</tr>");
            builder.Append("			<tr>");
            builder.Append("				<td style=\"border: 1px solid #e0e0e0;border-width: 0 1px 1px 0;background: #fbfbfb;color: #222;font-size: 12px;padding: 2px 5px;vertical-align: middle;margin-bottom: 10px;\"><strong>Lektorzy</strong></td>");
            builder.Append("				<td style=\"text-align: center; vertical-align: middle; background: #fbfbfb;font-size: 12px;border: 1px solid #e0e0e0;border-width: 0 1px 1px 0;line-height: 20px;padding: 2px;\">").Append(unit2).Append("</td>");
            builder.Append("				<td style=\"text-align: center; vertical-align: middle; background: #fbfbfb;font-size: 12px;border: 1px solid #e0e0e0;border-width: 0 1px 1px 0;line-height: 20px;padding: 2px;\">").Append(unit2Attack).Append("</td>");
            builder.Append("				<td style=\"text-align: center; vertical-align: middle; background: #fbfbfb;font-size: 12px;border: 1px solid #e0e0e0;border-width: 0 0 1px 0;line-height: 20px;padding: 2px;\">").Append(unit2Defense).Append("</td>");
            builder.Append("			</tr>");
            builder.Append("			<tr>");
            builder.Append("				<td style=\"border: 1px solid #e0e0e0;border-width: 0 1px 0 0;background: #fbfbfb;color: #222;font-size: 12px;padding: 2px 5px;vertical-align: middle;margin-bottom: 10px;\"><strong>Organi&#347;ci</strong></td>");
            builder.Append("				<td style=\"text-align: center; vertical-align: middle; background: #fbfbfb;font-size: 12px;border: 1px solid #e0e0e0;border-width: 0 1px 0 0;line-height: 20px;padding: 2px;\">").Append(unit3).Append("</td>");
            builder.Append("				<td style=\"text-align: center; vertical-align: middle; background: #fbfbfb;font-size: 12px;border: 1px solid #e0e0e0;border-width: 0 1px 0 0;line-height: 20px;padding: 2px;\">").Append(unit3Attack).Append("</td>");
            builder.Append("				<td style=\"text-align: center; vertical-align: middle; background: #fbfbfb;font-size: 12px;border: 1px solid #e0e0e0;border-width: 0;line-height: 20px;padding: 2px;\">").Append(unit3Defense).Append("</td>");
            builder.Append("			</tr>");
            builder.Append("		</tbody>");
            builder.Append("	</table>");
            builder.Append("	<h2 style=\"color: #4a2c5c;font: normal 20px/1em 'Lucida Sans Unicode', Arial, Helvetica, Tahoma, sans-serif;padding: 0;border-bottom: 1px solid #e7e7e7;\">Zawsze wierni</h2>");
            builder.Append("	<table  style=\"border: 1px solid #e0e0e0; empty-cells: show; margin-bottom: 10px; width: 100%;\" cellspacing=\"0\" cellpadding=\"0\">");
            builder.Append("		<thead>");
            builder.Append("			<tr>");
            builder.Append("				<th style=\"text-align: center;border: 1px solid #e0e0e0;border-width: 0 1px 1px 0;background: #f2f2f2;color: #222;font-size: 14px;padding: 2px 5px;vertical-align: middle;margin-bottom: 10px;width: 40%;\">Jednostka</th>");
            builder.Append("				<th style=\"text-align: center;border: 1px solid #e0e0e0;border-width: 0 1px 1px 0;background: #f2f2f2;color: #222;font-size: 14px;padding: 2px 5px;vertical-align: middle;margin-bottom: 10px;width: 20%;\">Ilo&#347;&#263;</th>");
            builder.Append("				<th style=\"text-align: center;border: 1px solid #e0e0e0;border-width: 0 1px 1px 0;background: #f2f2f2;color: #222;font-size: 14px;padding: 2px 5px;vertical-align: middle;margin-bottom: 10px;width: 20%;\">Si&#322;a ataku</th>");
            builder.Append("				<th style=\"text-align: center;border: 1px solid #e0e0e0;border-width: 0 0 1px 0;background: #f2f2f2;color: #222;font-size: 14px;padding: 2px 5px;vertical-align: middle;margin-bottom: 10px;width: 20%;\">Si&#322;a obrony</th>			");
            builder.Append("			</tr>");
            builder.Append("		</thead>");
            builder.Append("		<tbody>");
            builder.Append("			<tr>");
            builder.Append("				<td style=\"border: 1px solid #e0e0e0;border-width: 0 1px 1px 0;background: #fbfbfb;color: #222;font-size: 12px;padding: 2px 5px;vertical-align: middle;margin-bottom: 10px;\"><strong>Ma&#322;e Dewotki</strong></td>");
            builder.Append("				<td style=\"text-align: center; vertical-align: middle; background: #fbfbfb;font-size: 12px;border: 1px solid #e0e0e0;border-width: 0 1px 1px 0;line-height: 20px;padding: 2px;\">").Append(unit4).Append("</td>");
            builder.Append("				<td style=\"text-align: center; vertical-align: middle; background: #fbfbfb;font-size: 12px;border: 1px solid #e0e0e0;border-width: 0 1px 1px 0;line-height: 20px;padding: 2px;\">").Append(unit4Attack).Append("</td>");
            builder.Append("				<td style=\"text-align: center; vertical-align: middle; background: #fbfbfb;font-size: 12px;border: 1px solid #e0e0e0;border-width: 0 0 1px 0;line-height: 20px;padding: 2px;\">").Append(unit4Defense).Append("</td>");
            builder.Append("			</tr>");
            builder.Append("			<tr>");
            builder.Append("				<td style=\"border: 1px solid #e0e0e0;border-width: 0 1px 1px 0;background: #fbfbfb;color: #222;font-size: 12px;padding: 2px 5px;vertical-align: middle;margin-bottom: 10px;\"><strong>Babcie Moherowe</strong></td>");
            builder.Append("				<td style=\"text-align: center; vertical-align: middle; background: #fbfbfb;font-size: 12px;border: 1px solid #e0e0e0;border-width: 0 1px 1px 0;line-height: 20px;padding: 2px;\">").Append(unit5).Append("</td>");
            builder.Append("				<td style=\"text-align: center; vertical-align: middle; background: #fbfbfb;font-size: 12px;border: 1px solid #e0e0e0;border-width: 0 1px 1px 0;line-height: 20px;padding: 2px;\">").Append(unit5Attack).Append("</td>");
            builder.Append("				<td style=\"text-align: center; vertical-align: middle; background: #fbfbfb;font-size: 12px;border: 1px solid #e0e0e0;border-width: 0 0 1px 0;line-height: 20px;padding: 2px;\">").Append(unit5Defense).Append("</td>");
            builder.Append("			</tr>");
            builder.Append("			<tr>");
            builder.Append("				<td style=\"border: 1px solid #e0e0e0;border-width: 0 1px 0 0;background: #fbfbfb;color: #222;font-size: 12px;padding: 2px 5px;vertical-align: middle;margin-bottom: 10px;\"><strong>Gospodynie Proboszcza</strong></td>");
            builder.Append("				<td style=\"text-align: center; vertical-align: middle; background: #fbfbfb;font-size: 12px;border: 1px solid #e0e0e0;border-width: 0 1px 0 0;line-height: 20px;padding: 2px;\">").Append(unit6).Append("</td>");
            builder.Append("				<td style=\"text-align: center; vertical-align: middle; background: #fbfbfb;font-size: 12px;border: 1px solid #e0e0e0;border-width: 0 1px 0 0;line-height: 20px;padding: 2px;\">").Append(unit6Attack).Append("</td>");
            builder.Append("				<td style=\"text-align: center; vertical-align: middle; background: #fbfbfb;font-size: 12px;border: 1px solid #e0e0e0;border-width: 0;line-height: 20px;padding: 2px;\">").Append(unit6Defense).Append("</td>");
            builder.Append("			</tr>");
            builder.Append("		</tbody>");
            builder.Append("	</table>");
            builder.Append("</div>");

            return builder.ToString();
        }
    }
}
