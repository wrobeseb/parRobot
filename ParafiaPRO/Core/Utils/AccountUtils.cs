using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HtmlAgilityPack;
using HttpUtils;

namespace ParafiaPRO.Core.Utils
{
    public class AccountUtils : Utils
    {
        public static void ExtractField(out int valueActual, out int valueMax, HtmlNode node)
        {
            String fieldInnerText = FieldExtractor(node.InnerText);
            String[] tempArray = fieldInnerText.Split('/');
            valueActual = int.Parse(tempArray[0].Replace(" ", ""));
            valueMax = int.Parse(tempArray[1].Replace(" ", ""));
        }

        public static void ExtractFieldWithGrow(out int valueActual, out int valueMax, out int valueGrow, HtmlNode node)
        {
            String fieldInnerText = FieldExtractor(node.InnerText);
            String[] tempArray = fieldInnerText.Split('/');
            valueActual = int.Parse(tempArray[0].Replace(" ", ""));
            valueMax = int.Parse(tempArray[1].Replace(" ", ""));
            String growText = HtmlUtils.GetAttributeValueFromHtmlNode(node, "title");

            tempArray = growText.Split(' ');
            String growValueTxt = tempArray[0];

            int.TryParse(growValueTxt.Substring(1), out valueGrow);

            if (growValueTxt.StartsWith("-"))
                valueGrow = (-1) * valueGrow;
        }

        public static void ExtractLevel(out int levelNo, out int expActual, out int expNextLevel, HtmlNode node)
        {
            String levelInnerText = FieldExtractor(node.InnerText);
            String[] tempArray = levelInnerText.Split('(');
            levelNo = int.Parse(tempArray[0]);
            tempArray = tempArray[1].Split('/');
            expActual = int.Parse(tempArray[0]);
            expNextLevel = int.Parse(tempArray[1]);
        }

        public static void ExtractRelics(out int relicNo, out int relicInSafe, out int relicMaxSafe, HtmlNode node)
        {
            String levelInnerText = FieldExtractor(node.InnerText);
            String[] tempArray = levelInnerText.Split(',');
            relicNo = int.Parse(tempArray[0]);
            tempArray = tempArray[1].Split('/');
            relicInSafe = int.Parse(tempArray[0]);
            relicMaxSafe = int.Parse(tempArray[1]);
        }

        private static String FieldExtractor(String innerHtml)
        {
            StringBuilder builder = new StringBuilder();
            foreach (char character in innerHtml.ToCharArray())
            {
                if (((int)character < 48 || (int)character > 57) && (int)character != 44 && (int)character != 43 && (int)character != 45 && (int)character != 40 && (int)character != 47)
                {
                    builder.Append(" ");
                }
                else
                {
                    builder.Append(character);
                }
            }

            return builder.ToString();
        }
    }
}
