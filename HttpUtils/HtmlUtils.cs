using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Net;
using HtmlAgilityPack;

namespace HttpUtils
{
    public class HtmlUtils
    {
        public static HtmlNode GetHtmlNodeFromHtml(String html)
        {
            HtmlDocument doc = new HtmlDocument();
            doc.LoadHtml(html);
            return doc.DocumentNode;
        }

        public static String GetContentForResponse(HttpWebResponse response)
        {
            Stream stream = response.GetResponseStream();

            String characterSet = String.IsNullOrEmpty(response.CharacterSet) ? "UTF-8" : response.CharacterSet;
            Encoding encoding = Encoding.GetEncoding(characterSet);

            StreamReader reader = new StreamReader(stream, encoding);
            String htmlContent = reader.ReadToEnd();

            stream.Close();
            response.Close();

            return htmlContent;
        }

        public static int GetIntValueByXPathExpression(String html, String xPathExpression)
        {
            return int.Parse(GetStringValueByXPathExpression(html, xPathExpression));
        }

        public static String GetAttributeValueFromHtmlNode(HtmlNode node, String attributeName)
        {
            return node.GetAttributeValue(attributeName, null);
        }

        public static String GetAttributeValueOfElementByXPathExpression(String html, String attributeName, String xPathExpression)
        {
            return GetSingleNodeByXPathExpression(html, xPathExpression).GetAttributeValue(attributeName, null);
        }

        public static String GetStringValueByXPathExpression(String html, String xPathExpression)
        {
            String value = null;
            HtmlNode node = GetSingleNodeByXPathExpression(html, xPathExpression);
            if (node != null)
            {
                if (!node.HasChildNodes)
                {
                    if (String.IsNullOrEmpty(node.InnerText))
                    {
                        return node.GetAttributeValue("value", null);
                    }
                    return node.InnerText;
                }
                else
                    if (node.ChildNodes.Count == 1)
                    {
                        return node.FirstChild.InnerText;
                    }
            }

            return value;
        }

        public static HtmlNodeCollection GetNodesCollectionByXPathExpression(String html, String xPathExpression)
        {
            HtmlDocument doc = new HtmlDocument();
            doc.LoadHtml(html);
            return doc.DocumentNode.SelectNodes(xPathExpression);
        }

        public static HtmlNode GetSingleNodeByXPathExpression(String html, String xPathExpression)
        {
            HtmlDocument doc = new HtmlDocument();
            doc.LoadHtml(html);
            return doc.DocumentNode.SelectSingleNode(xPathExpression);
        }
    }
}
