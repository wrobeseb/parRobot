﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HtmlAgilityPack;
using HttpUtils;
using ParafiaPRO.Core.Utils;

namespace ParafiaPRO.Model.Content
{
    public class Bank : List<Transfer>
    {
        public Bank(String bankContent)
        {
            HtmlNodeCollection transfersNodes = HtmlUtils.GetNodesCollectionByXPathExpression(bankContent, "//ul[@class='banks']/li");
            if (transfersNodes != null)
            {
                foreach (HtmlNode node in transfersNodes)
                {
                    String valueTxt = HtmlUtils.GetStringValueByXPathExpression(node.InnerHtml, "//div[@class='bank_money']/text()");
                    int value = Utils.ConvertToInt(valueTxt);
                    String aUrl = HtmlUtils.GetAttributeValueOfElementByXPathExpression(node.InnerHtml, "href", "//a[@class='button']");
                    AddTransfer(value, aUrl);
                }
            }
        }

        public void AddTransfer(int value, String url)
        {
            AddTransfer(new Transfer(value, url));
        }

        public void AddTransfer(Transfer transfer)
        {
            this.Add(transfer);
        }

        public Transfer GetExact(int value)
        {
            foreach (Transfer trans in this)
            {
                if (trans.Value == value)
                    return trans;
            }

            return null;
        }

        public Transfer GetLt(int value)
        {
            foreach (Transfer trans in this)
            {
                if (trans.Value < value)
                    return trans;
            }

            return null;
        }

        public Transfer GetGt(int value)
        {
            foreach (Transfer trans in this)
            {
                if (trans.Value > value)
                    return trans;
            }

            return null;
        }
    }
}
