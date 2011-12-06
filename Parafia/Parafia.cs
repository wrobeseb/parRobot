using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;

using HttpUtils;
using HtmlAgilityPack;

using System.Net;
using System.Threading;
using Parafia.Exceptions;
using Parafia.Enums;
using Parafia.Model.Quest;
using Parafia.Properties;

using System.Xml;
using System.Xml.Serialization;

namespace Parafia
{
    using Model.Stat;
    using Model.Bank;
    using Model.Relics;

    public class Parafia
    {
        public ApplicationConfig config;
        public DefaultHttpClient httpClient;
        public Attributes.Attributes attributes;
        public Units.Units units;

        public Units.Units unitsOnExpeditions;

        public String csrf;

        public int riseSafeCost;
        public bool riseSafeButtonActive;

        public  QuestContainer questContainer;

        private List<Quest> newQuests;

        public Relics relics;

        public bool papacyParty;

        private Worker worker;

        public Transfers bank;

        public Parafia(Worker worker)
        {
            this.worker = worker;
        }

        public void initConnection(ApplicationConfig config)
        {
            if (config != null)
            {
                this.config = config;
                WebProxy proxy = null;
                if (config.UseProxy)
                {
                    proxy = new WebProxy(config.ProxyHost, config.ProxyPort);
                    proxy.Credentials = new NetworkCredential(config.ProxyUser, config.ProxyPassword, config.ProxyDomain);
                }
                httpClient = new DefaultHttpClient();
                if (proxy != null)
                    httpClient.SetWebProxy = proxy;
            }
        }

        public TimeSpan getSerwerTime()
        {
            String temp = MainUtils.removeAllNotNumberCharacters(HtmlUtils.GetSingleNodeByXPathExpression(httpClient.SendHttpGetAndReturnResponseContent("http://blog.parafia.biz/czas/", 5000), "//body").InnerText).Replace(" ", String.Empty);
            String[] tempTable = temp.Split(',');
            return new TimeSpan(0, int.Parse(tempTable[0]), int.Parse(tempTable[1]), int.Parse(tempTable[2]), 0);
        }

        public void updateMyRelics()
        {
            relics = new Relics(httpClient.SendHttpGetAndReturnResponseContent("http://parafia.biz/relics/my"));
        }

        public List<String> hideRelicsToSafe()
        {
            String responseContent = httpClient.SendHttpGetAndReturnResponseContent("http://parafia.biz/relics/my");
          
            HtmlNodeCollection relicsNodes = HtmlUtils.GetNodesCollectionByXPathExpression(responseContent, "//ul[@class='relics-small']/li");

            List<String> relics = new List<string>();

            foreach (HtmlNode relicNode in relicsNodes)
            {
                String relicNo = HtmlUtils.GetStringValueByXPathExpression(relicNode.InnerHtml, "//div[@class='right']/span[@class='num_relics']");
                String inSafe = HtmlUtils.GetStringValueByXPathExpression(relicNode.InnerHtml, "//div[@class='right']/span[@class='num_safe']");
                if (String.IsNullOrEmpty(inSafe) || (!relicNo.Equals(inSafe)))
                {
                    String relicId = HtmlUtils.GetAttributeValueFromHtmlNode(relicNode, "rel");
                    String relicName = HtmlUtils.GetAttributeValueFromHtmlNode(relicNode, "title");
                    relics.Add(relicId + ";" + relicName);
                    hideRelic(int.Parse(relicId));
                }
            }

            return relics;
        }

        public bool login()
        {
            String responseContent = httpClient.SendHttpGetAndReturnResponseContent("http://parafia.biz/");
            csrf = HtmlUtils.GetStringValueByXPathExpression(responseContent, "//input[@name='login_csrf']");

            if (checkDependencies(responseContent, new String[] { "formo_login_form", "login_csrf", "user_name", "user_pass", "login_submit" }))
            {
                FormData formData = new FormData();
                formData.addValue("formo_login_form", "login_form");
                formData.addValue("login_csrf", csrf);
                formData.addValue("user_name", config.AccountUser);
                formData.addValue("user_pass", config.AccountPassword);
                formData.addValue("login_submit", "");

                int timeout = 0;
                do
                {
                    try
                    {
                        responseContent = httpClient.SendHttpPostAndReturnResponseContent("http://parafia.biz/", formData);
                        timeout = 0;
                    }
                    catch (WebException we)
                    {
                        worker.printLog("[ERROR] Wystąpił błąd. login!!!");
                        worker.printLog("[ERROR] Treść błędu: " + we.Message);
                        worker.printLog("[ERROR] Ponawiam proces.");
                        timeout++;
                    }
                }
                while ((timeout != 0) && timeout < 5);

                if (timeout == 0)
                {
                    String errorMessage = HtmlUtils.GetStringValueByXPathExpression(responseContent, "//div[@class='form-error']/text()");

                    if (!String.IsNullOrEmpty(errorMessage))
                    {
                        throw new LoginException(errorMessage);
                    }
                    else
                    {
                        attributes = new Attributes.Attributes(responseContent);
                        papacyParty = !checkPapacParty(responseContent);
                    }
                    return true;
                }
            }
            return false;
        }

        public bool loginRoot()
        {
            String responseContent = httpClient.SendHttpGetAndReturnResponseContent("http://parafia.biz/");
            csrf = HtmlUtils.GetStringValueByXPathExpression(responseContent, "//input[@name='login_csrf']");

            if (checkDependencies(responseContent, new String[] { "formo_login_form", "login_csrf", "user_name", "user_pass", "login_submit" }))
            {
                FormData formData = new FormData();
                formData.addValue("formo_login_form", "login_form");
                formData.addValue("login_csrf", csrf);
                formData.addValue("user_name", config.MasterLogin);
                formData.addValue("user_pass", config.MasterPassword);
                formData.addValue("login_submit", "");

                int timeout = 0;
                do
                {
                    try
                    {
                        responseContent = httpClient.SendHttpPostAndReturnResponseContent("http://parafia.biz/", formData);
                        timeout = 0;
                    }
                    catch (WebException we)
                    {
                        worker.printLog("[ERROR] Wystąpił błąd. loginRoot!!!");
                        worker.printLog("[ERROR] Treść błędu: " + we.Message);
                        worker.printLog("[ERROR] Ponawiam proces.");
                        timeout++;
                    }
                }
                while ((timeout != 0) && timeout < 5);

                if (timeout == 0)
                {
                    String errorMessage = HtmlUtils.GetStringValueByXPathExpression(responseContent, "//div[@class='form-error']/text()");

                    if (!String.IsNullOrEmpty(errorMessage))
                    {
                        throw new LoginException(errorMessage);
                    }
                    else
                    {
                        attributes = new Attributes.Attributes(responseContent);
                        papacyParty = !checkPapacParty(responseContent);
                    }
                    return true;
                }
            }
            return false;
        }

        public void updateAttributes()
        {
            int timeout = 0;
            do
            {
                try
                {
                    String content = httpClient.SendHttpGetAndReturnResponseContent("http://parafia.biz/start/dashboard");
                    this.attributes = new Attributes.Attributes(content);
                    timeout = 0;
                }
                catch (WebException we)
                {
                    worker.printLog("[ERROR] Wystąpił błąd. updateAttributes!!!");
                    worker.printLog("[ERROR] Treść błędu: " + we.Message);
                    worker.printLog("[ERROR] Ponawiam proces.");
                    timeout++;
                }
            }
            while ((timeout != 0) && timeout < 5);
            
        }

        public void takeFromProperty() 
        {
            FormData formData = new FormData();
            formData.addValue("formo_property_take", "property_take");
            formData.addValue("property_take_csrf", csrf);
            formData.addValue("property_take_submit", "");

            int timeout = 0;
            String responseContent = String.Empty;
            do
            {
                try
                {
                    httpClient.SendHttpPostAndReturnResponseContent("http://parafia.biz/property", formData);
                    timeout = 0;
                }
                catch (WebException we)
                {
                    worker.printLog("[ERROR] Wystąpił błąd. takeFromProperty!!!");
                    worker.printLog("[ERROR] Treść błędu: " + we.Message);
                    worker.printLog("[ERROR] Ponawiam proces.");
                    timeout++;
                }
            }
            while ((timeout != 0) && timeout < 5);
        }

        /*
         *  Zwraca status operacji
         *  1 - sukces;
         *  0 - wystapil blad
         */
        public int BuyGreatChangeById(int id)
        {
            FormData formData = new FormData();
            formData.addValue("formo_market_show", "market_show");
            formData.addValue("relic_csrf", csrf);
            formData.addValue("market_id", new StringBuilder().Append(id).ToString());
            formData.addValue("kup", "");

            int timeout = 0;
            String responseContent = String.Empty;
            do
            {
                try
                {
                    responseContent = httpClient.SendHttpPostAndReturnResponseContent("http://parafia.biz/relics/market_show/70", formData);
                    timeout = 0;
                }
                catch (WebException we)
                {
                    worker.printLog("[ERROR] Wystąpił błąd. BuyGreatChangeById!!!");
                    worker.printLog("[ERROR] Treść błędu: " + we.Message);
                    worker.printLog("[ERROR] Ponawiam proces.");
                    timeout++;
                }
            }
            while ((timeout != 0) && timeout < 5);

            if (timeout == 0)
            {
                HtmlNode node = HtmlUtils.GetSingleNodeByXPathExpression(responseContent, "//div[@class='flashinfo_message']");

                if (node != null)
                {
                    String message = node.InnerText;
                    if (!String.IsNullOrEmpty(message) && message.Equals("Relikwia została kupiona"))
                    {
                        return 1;
                    }
                }
            }
            return 0;
        }

        public int BuyReturnedGreatChange(string relicCost)
        {
            if (!String.IsNullOrEmpty(relicCost))
            {
                int cost = int.Parse(relicCost);
                if (cost != 0)
                {
                    updateAttributes();

                    if (attributes.Cash.Actual < cost)
                    {
                        if (attributes.Safe.Actual >= cost)
                        {
                            getFromSafe(cost + 100);
                        }
                        else
                        {
                            getFromBank(cost + 100);
                        }
                    }

                    int id = 0;

                    if (countGreatChangeInMarket(cost, ref id) == 1)
                    {
                        if (BuyGreatChangeById(id) == 1)
                        {
                            hideGreatChange();
                            return 1;
                        }
                    }
                    else
                    {
                        worker.printLog("[ERROR] Znaleziono więcej niż jedną lub wcale cudownych zamian na rynku!!!");
                    }
                }
            }
            return 0;
        }

        public void hideGreatChange()
        {
            int timeout = 0;
            do
            {
                try
                {
                    String content = httpClient.SendHttpGetAndReturnResponseContent("http://parafia.biz/relics/hide/70");
                    attributes = new Attributes.Attributes(content);
                    timeout = 0;
                }
                catch (WebException we)
                {
                    worker.printLog("[ERROR] Wystąpił błąd. hideGreatChange!!!");
                    worker.printLog("[ERROR] Treść błędu: " + we.Message);
                    worker.printLog("[ERROR] Ponawiam proces.");
                    timeout++;
                }
            }
            while ((timeout != 0) && timeout < 5);
        }

        public void hideRelic(int id)
        {
            int timeout = 0;
            do
            {
                try
                {
                    httpClient.SendHttpGetAndReturnResponseContent("http://parafia.biz/relics/hide/" + id);
                    timeout = 0;
                }
                catch (WebException we)
                {
                    worker.printLog("[ERROR] Wystąpił błąd. hideRelic!!!");
                    worker.printLog("[ERROR] Treść błędu: " + we.Message);
                    worker.printLog("[ERROR] Ponawiam proces.");
                    timeout++;
                }
            }
            while ((timeout != 0) && timeout < 5);
        }

        public string ReturnGreatChange()
        {
            string idTxt = "0";

            int valueToPut = GetValueToPutOnMarket(55432);

            if (valueToPut != 0)
            {
                int vat = Convert.ToInt32(valueToPut * 0.08) + 1;

                if (attributes.Cash.Actual < vat)
                    getFromSafe(vat + 10);

                if (SellGreatChange(valueToPut) == 1)
                {
                    idTxt = valueToPut.ToString();
                }
            }

            return idTxt;
        }

        /*
         *  Zwraca status operacji
         *  1 - sukces;
         *  0 - wystapil blad
         */
        public int SellGreatChange(int value)
        {
            FormData formData = new FormData();
            formData.addValue("formo_market_form", "market_form");
            formData.addValue("market_csrf", csrf);
            formData.addValue("market_price", new StringBuilder().Append(value).ToString());
            formData.addValue("market_submit", "");

            int timeout = 0;

            String responseContent = String.Empty;

            do
            {
                try
                {
                    responseContent = httpClient.SendHttpPostAndReturnResponseContent("http://parafia.biz/relics/market_sell/70", formData);
                    timeout = 0;
                }
                catch (Exception we)
                {
                    worker.printLog("[ERROR] Wystąpił błąd. SellGreatChange!!!");
                    worker.printLog("[ERROR] Treść błędu: " + we.Message);
                    worker.printLog("[ERROR] Ponawiam proces.");
                    timeout++;
                }
            }
            while ((timeout != 0) && timeout < 5);

            if (timeout == 0)
            {
                HtmlNode node = HtmlUtils.GetSingleNodeByXPathExpression(responseContent, "//div[@class='flashinfo_message']");

                if (node != null)
                {
                    String message = node.InnerText;
                    if (!String.IsNullOrEmpty(message) && message.Equals("Relikwia została wystawiona na sprzedaż"))
                    {
                        return 1;
                    }
                    else
                    {
                        worker.printLog("[ERROR] Wystąpił błąd. SellGreatChange!!!");
                        worker.printLog("[ERROR] Treść błędu: " + message);
                    }
                }
                else
                {
                    worker.printLog("[ERROR] Wystąpił błąd. SellGreatChange!!!");
                    worker.printLog("[ERROR] Brak okna potwierdzenia sprzedaży...");
                }
            }

            return 0;
        }

        public int countGreatChangeInMarket(int value, ref int id)
        {
            int timeout = 0;

            String content = String.Empty;

            do
            {
                try
                {
                    content = getContentOfGreatChange();
                    timeout = 0;
                }
                catch (WebException we)
                {
                    worker.printLog("[ERROR] Wystąpił błąd. countGreatChangeInMarket!!!");
                    worker.printLog("[ERROR] Treść błędu: " + we.Message);
                    worker.printLog("[ERROR] Ponawiam proces.");
                    timeout++;
                }
            }
            while ((timeout != 0) && timeout < 5);

            int counter = 0;

            if (timeout == 0)
            {
                HtmlNode.ElementsFlags.Remove("option");

                HtmlNodeCollection optionsNode = HtmlUtils.GetNodesCollectionByXPathExpression(content, "//select[@id='market_id']/option");

                foreach (HtmlNode node in optionsNode)
                {
                    String txtValueForOption = node.InnerText;
                    if (!String.IsNullOrEmpty(txtValueForOption))
                    {
                        int valueForOption = int.Parse(MainUtils.removeAllNotNumberCharacters(txtValueForOption));
                        if (valueForOption == value)
                        {
                            String txtValueForIdAttribute = HtmlUtils.GetAttributeValueFromHtmlNode(node, "value");
                            if (!String.IsNullOrEmpty(txtValueForIdAttribute))
                                id = int.Parse(txtValueForIdAttribute);
                            counter++;
                        }
                    }
                }
            }

            return counter;
        }

        public int GetValueToPutOnMarket(int maxValue)
        {
            int timeout = 0;

            String content = String.Empty;

            do
            {
                try { content = getContentOfGreatChange(); timeout = 0; }
                catch (Exception we)
                {
                    worker.printLog("[ERROR] Wystąpił błąd. GetValueToPutOnMarket!!!");
                    worker.printLog("[ERROR] Treść błędu: " + we.Message);
                    worker.printLog("[ERROR] Ponawiam proces.");
                    timeout++;
                }
            }
            while ((timeout != 0) && timeout < 5);

            if (timeout == 0)
            {
                HtmlNode.ElementsFlags.Remove("option");
                HtmlNodeCollection optionsNode = HtmlUtils.GetNodesCollectionByXPathExpression(content, "//select[@id='market_id']/option");

                Random rand = new Random();

                int value = maxValue;
                int counter = 0;
                int attemtpsNo = 0;
                do
                {
                    counter = 0;
                    foreach (HtmlNode node in optionsNode)
                    {
                        String txtValueForOption = node.InnerText;
                        if (!String.IsNullOrEmpty(txtValueForOption))
                        {
                            int valueForOption = int.Parse(MainUtils.removeAllNotNumberCharacters(txtValueForOption));
                            if (valueForOption == value)
                            {
                                worker.printLog("[TRANSFER][WARN] Uwaga do. GetValueToPutOnMarket!!!");
                                worker.printLog("[TRANSFER][WARN] Paczka o wartości: " + value + " jest już wystawiona na rynku.");
                                counter++;
                                break;
                            }
                        }
                    }
                    if (counter != 0)
                    {
                        value = rand.Next(maxValue - 100, maxValue);
                        worker.printLog("[TRANSFER][WARN] Wylosowano nową wartość paczki: " + value);
                    }
                    attemtpsNo++;
                }
                while (counter != 0 && attemtpsNo < 100);

                if (attemtpsNo < 100)
                    return value;
                else
                {
                    worker.printLog("[WARN] Uwaga do. GetValueToPutOnMarket!!!");
                    worker.printLog("[WARN] Zwracam 0, Przyczyna: attemtps > 100 ");
                    return 0;
                }
            }
            worker.printLog("[WARN] Uwaga do. GetValueToPutOnMarket!!!");
            worker.printLog("[WARN] Zwracam 0, Przyczyna: attemtps > 100 ");
            return 0;
        }

        public void updateRiseSafeCost(String content)
        {
            String contentPart = HtmlUtils.GetStringValueByXPathExpression(content, "//p[@class='mt10']/span[1]/span/text()");

            if (!String.IsNullOrEmpty(contentPart) && !contentPart.Contains("odpustów"))
            {
                String costTxt = MainUtils.removeAllNotNumberCharacters(contentPart);
                int.TryParse(costTxt, out riseSafeCost);
            }

            contentPart = HtmlUtils.GetStringValueByXPathExpression(content, "//p[@class='mt10']/a/span/text()");
            if (!String.IsNullOrEmpty(contentPart))
            {
                riseSafeButtonActive = true;
            }
            else
            {
                riseSafeButtonActive = false;
            }
        }

        public Boolean getFromBank(int value)
        {
            Transfer trans = bank.GetGt(value);
            int timeout = 0;

            if (trans != null && !String.IsNullOrEmpty(trans.Url))
            {
                do
                {
                    try
                    {
                        httpClient.SendHttpGetAndReturnResponseContent(trans.Url);
                        timeout = 0;
                        return true;
                    }
                    catch (WebException we)
                    {
                        worker.printLog("[ERROR] Wystąpił błąd. getFromBank!!!");
                        worker.printLog("[ERROR] Treść błędu: " + we.Message);
                        worker.printLog("[ERROR] Ponawiam proces.");
                        timeout++;
                    }
                }
                while ((timeout != 0) && timeout < 5);
            }
            else
            {
                worker.printLog("[WARN] Pieniądze nie zostały wypłacone!!!");
            }
            return false;
        }

        public void updateBank()
        {
             int timeout = 0;

                do
                {
                    try
                    {
                        this.bank = new Transfers(httpClient.SendHttpGetAndReturnResponseContent("http://parafia.biz/bank"));
                        timeout = 0;
                    }
                    catch (WebException we)
                    {
                        worker.printLog("[ERROR] Wystąpił błąd. updateBank!!!");
                        worker.printLog("[ERROR] Treść błędu: " + we.Message);
                        worker.printLog("[ERROR] Ponawiam proces.");
                        timeout++;
                    }
                }
                while ((timeout != 0) && timeout < 5);
        }

        public void putIntoSafe()
        {
            int maxValue = attributes.Safe.Max - attributes.Safe.Actual;
            if (maxValue != 0 && attributes.Cash.Actual != 0)
            {
                int value = 0;
                if (attributes.Cash.Actual > maxValue) value = maxValue;
                else value = attributes.Cash.Actual;

                FormData formData = new FormData();
                formData.addValue("formo_safe_deposit", "safe_deposit");
                formData.addValue("safe_deposit_csrf", csrf);
                formData.addValue("deposit_value", new StringBuilder().Append(value).ToString());
                formData.addValue("safe_deposit_submit", "");

                int timeout = 0;

                do
                {
                    try
                    {
                        String responseContent = httpClient.SendHttpPostAndReturnResponseContent("http://parafia.biz/buildings/safe", formData);

                        updateRiseSafeCost(responseContent);

                        attributes = new Attributes.Attributes(responseContent);
                        timeout = 0;
                    }
                    catch (WebException we)
                    {
                        worker.printLog("[ERROR] Wystąpił błąd. putIntoSafe!!!");
                        worker.printLog("[ERROR] Treść błędu: " + we.Message);
                        worker.printLog("[ERROR] Ponawiam proces.");
                        timeout++;
                    }
                }
                while ((timeout != 0) && timeout < 5);
            }
        }

        public void getFromSafe(int value)
        {
            if (attributes.Safe.Actual != 0 && attributes.Safe.Actual >= value)
            {
                FormData formData = new FormData();
                formData.addValue("formo_safe_take", "safe_take");
                formData.addValue("safe_take_csrf", csrf);
                formData.addValue("take_value", new StringBuilder().Append(value).ToString());
                formData.addValue("safe_take_submit", "");

                int timeout = 0;

                do
                {
                    try
                    {
                        String responseContent = httpClient.SendHttpPostAndReturnResponseContent("http://parafia.biz/buildings/safe", formData);

                        updateRiseSafeCost(responseContent);

                        attributes = new Attributes.Attributes(responseContent);
                        timeout = 0;
                    }
                    catch (WebException we)
                    {
                        worker.printLog("[ERROR] Wystąpił błąd. getFromSafe!!!");
                        worker.printLog("[ERROR] Treść błędu: " + we.Message);
                        worker.printLog("[ERROR] Ponawiam proces.");
                        timeout++;
                    }
                }
                while ((timeout != 0) && timeout < 5);
            }
        }

        public int getLastStatPage()
        {
            String content = httpClient.SendHttpGetAndReturnResponseContent("http://parafia.biz/stats/battle/all/page/24");
            HtmlNodeCollection collection = HtmlUtils.GetNodesCollectionByXPathExpression(content, "//p[@class='pagination']/a");

            HtmlNode node = collection[collection.Count - 2];

            String href = node.GetAttributeValue("href", null);

            if (href != null)
            {
                String[] temp = href.Split('/');

                if (temp.Length == 8)
                {
                    return int.Parse(temp[7]);
                }
            }

            return 0;
        }

        public List<Account> getAccountsFromStatePage(int page)
        {
            List<Account> accounts = new List<Account>();

            if (page != 0)
            {
                int timeout = 0;
                String content = String.Empty;
                do
                {
                    try
                    {
                        content = httpClient.SendHttpGetAndReturnResponseContent("http://parafia.biz/stats/battle/all/page/" + page);
                        timeout = 0;
                    }
                    catch (WebException we)
                    {
                        worker.printLog("[ERROR] Wystąpił błąd. getFromSafe!!!");
                        worker.printLog("[ERROR] Treść błędu: " + we.Message);
                        worker.printLog("[ERROR] Ponawiam proces.");
                        timeout++;
                    }
                }
                while ((timeout != 0) && timeout < 5);

                if (timeout == 0)
                {
                    HtmlNodeCollection collection = HtmlUtils.GetNodesCollectionByXPathExpression(content, "//table[@class='items']/tbody/tr");

                    foreach (HtmlNode node in collection)
                    {
                        Account account = new Account();

                        String idText = node.GetAttributeValue("id", null);
                        if (!String.IsNullOrEmpty(idText))
                        {
                            account.Id = int.Parse(MainUtils.removeAllNotNumberCharacters(idText));
                        }

                        String html = node.InnerHtml;

                        account.Lp = HtmlUtils.GetIntValueByXPathExpression(html, "//td[1]/text()");
                        account.UserName = HtmlUtils.GetStringValueByXPathExpression(html, "//td[2]/div[2]/strong/text()");
                        account.GroupName = HtmlUtils.GetSingleNodeByXPathExpression(html, "//td[2]/div[2]").InnerHtml.Split('\n')[3].Trim();
                        account.Exp = HtmlUtils.GetIntValueByXPathExpression(html, "//td[3]/text()");
                        account.Battles = HtmlUtils.GetIntValueByXPathExpression(html, "//td[4]/text()");
                        account.Win = HtmlUtils.GetIntValueByXPathExpression(html, "//td[5]/text()");
                        account.Relic = HtmlUtils.GetIntValueByXPathExpression(html, "//td[6]/text()");

                        accounts.Add(account);
                    }
                }
            }

            return accounts;
        }

        public void buyMinistr()
        {
            int maxBelivers = attributes.Beliver.Actual - 10;

            if (maxBelivers >= 10)
            {
                int cashNeed = 200;
                if (attributes.Cash.Actual < cashNeed)
                {
                    int value = cashNeed - attributes.Cash.Actual;
                    if (attributes.Safe.Actual < value)
                        value = attributes.Safe.Actual;

                    getFromSafe(value);
                }

                int timeout = 0;
                String content = String.Empty;
                do
                {
                    try
                    {
                        httpClient.SendHttpGetAndReturnResponseContent("http://parafia.biz/units/buy/1/amount/10");
                        timeout = 0;
                    }
                    catch (WebException we)
                    {
                        worker.printLog("[ERROR] Wystąpił błąd. buyMinistr!!!");
                        worker.printLog("[ERROR] Treść błędu: " + we.Message);
                        worker.printLog("[ERROR] Ponawiam proces.");
                        timeout++;
                    }
                }
                while ((timeout != 0) && timeout < 5);

                if (timeout == 0)
                {
                    getUnitsInfo();
                }
            }
        }

        public bool riseSafe()
        {
            if (riseSafeCost != 0) {
                int value = 0;
                if (attributes.Cash.Actual < riseSafeCost)
                {
                    value = riseSafeCost - attributes.Cash.Actual;
                }

                if (value != 0)
                {
                    getFromSafe(value);
                }
                if (riseSafeButtonActive)
                {
                    int timeout = 0;
                    do
                    {
                        try
                        {
                            httpClient.SendHttpGetAndReturnResponseContent("http://parafia.biz/buildings/raise_safe");
                            timeout = 0;
                        }
                        catch (WebException we)
                        {
                            worker.printLog("[ERROR] Wystąpił błąd. riseSafe!!!");
                            worker.printLog("[ERROR] Treść błędu: " + we.Message);
                            worker.printLog("[ERROR] Ponawiam proces.");
                            timeout++;
                        }
                    }
                    while ((timeout != 0) && timeout < 5);

                    if (timeout == 0)
                    {
                        worker.printLog("[SAFE] Sejf podniesiony...");
                        return true;
                    }
                }
            }
            return false;
        }

        public void buyArmy(ArmyType armyType)
        {
            String urlAttack = "http://parafia.biz/units/buy/1/amount/";
            String urlDefense = "http://parafia.biz/units/buy/4/amount/";

            int maxBelivers = attributes.Beliver.Actual - 10;

            if (maxBelivers != 0)
            {
                int cashNeed = maxBelivers * 20;
                if (attributes.Cash.Actual < cashNeed)
                {
                    int value = cashNeed - attributes.Cash.Actual;
                    if (attributes.Safe.Actual < value)
                    {
                        worker.printLog("Wyplacam z banku na jednostki...");
                        if (getFromBank(value))
                        {
                            worker.printLog("Wyplacone");
                            putIntoSafe();
                        }
                        else
                        {
                            worker.printLog("[ERROR] Brak kasy na jednostki w banku...");
                        }
                        //value = attributes.Safe.Actual;
                    }

                    getFromSafe(value);
                }

                if (cashNeed > attributes.Cash.Actual)
                    maxBelivers = attributes.Cash.Actual / 20;

                int timeout = 0;
                String content = String.Empty;
                do
                {
                    try
                    {
                        switch (armyType)
                        {
                            case ArmyType.Attack:
                                httpClient.SendHttpGetAndReturnResponseContent(urlAttack + maxBelivers);
                                break;
                            case ArmyType.Defense:
                                httpClient.SendHttpGetAndReturnResponseContent(urlDefense + maxBelivers);
                                break;
                        }
                        timeout = 0;
                    }
                    catch (WebException we)
                    {
                        worker.printLog("[ERROR] Wystąpił błąd. buyArmy!!!");
                        worker.printLog("[ERROR] Treść błędu: " + we.Message);
                        worker.printLog("[ERROR] Ponawiam proces.");
                        timeout++;
                    }
                }
                while ((timeout != 0) && timeout < 5);
            }
        }

        public String getUserUrl(String name)
        {
            if (attributes.Energy.Actual >= 10 && attributes.Health.Actual >= 10)
            {
                String url = null;

                FormData formData = new FormData();
                formData.addValue("formo_battle_search", "battle_search");
                formData.addValue("battle_csrf", csrf);
                formData.addValue("opponent_name", name);
                formData.addValue("search_submit", "");

                HttpWebResponse response = httpClient.HttpPostWithoutRedirection("http://parafia.biz/battle/players", formData);

                if (response.StatusCode == HttpStatusCode.Found)
                {
                    url = response.Headers["Location"];
                }
                response.Close();

                return url;
            }
            return null;
        }

        public Boolean attack(ref Account account)
        {
            Boolean flag = false;
            if (attributes.Energy.Actual >= 10 && attributes.Health.Actual >= 10)
            {
                getUnitsInfo();
                if (!units.hasUnits())
                {
                    buyMinistr();
                }
                if (units.hasUnits())
                {
                    int timeout = 0;
                    String content = String.Empty;
                    do
                    {
                        try
                        {
                            content = httpClient.SendHttpGetAndReturnResponseContent("http://parafia.biz/battle/attack/" + account.Id);
                            timeout = 0;
                        }
                        catch (WebException we)
                        {
                            worker.printLog("[ERROR] Wystąpił błąd. attack!!!");
                            worker.printLog("[ERROR] Treść błędu: " + we.Message);
                            worker.printLog("[ERROR] Ponawiam proces.");
                            timeout++;
                        }
                    }
                    while ((timeout != 0) && timeout < 5);

                    if (timeout == 0)
                    {
                        String errorMessage = HtmlUtils.GetStringValueByXPathExpression(content, "//div[@class='flashinfo_message']/text()");

                        updateAttributes(content);

                        if (String.IsNullOrEmpty(errorMessage))
                        {
                            String battleResult = HtmlUtils.GetStringValueByXPathExpression(content, "//div[@class='content']/h2/text()");
                            if (!String.IsNullOrEmpty(battleResult))
                            {
                                if (battleResult.Equals("Wygrałeś"))
                                {
                                    String cashText = HtmlUtils.GetStringValueByXPathExpression(content, "//table[@class='items']/tr[4]/td[2]/ul/li[1]/text()");
                                    cashText = MainUtils.removeAllNotNumberCharacters(cashText).Replace(" ", "");
                                    int cash;
                                    int.TryParse(cashText, out cash);
                                    account.Cash += cash;
                                    account.WinHits++;
                                    flag = true;
                                }
                                else
                                    if (battleResult.Equals("Przegrałeś"))
                                    {
                                        account.DefeatHits++;
                                        //flag = false;
                                        flag = true;
                                    }

                                HtmlNode defenseNode = HtmlUtils.GetSingleNodeByXPathExpression(content, "//div[@class='content']/div[@class='left ml50 wp-45']/div[2]");

                                String defenseText = defenseNode.InnerText;
                                defenseText = MainUtils.removeAllNotNumberCharactersForDouble(defenseText);

                                double temp;

                                double.TryParse(defenseText, out temp);

                                account.Defense = temp;
                            }
                        }
                        else
                        {
                            if (errorMessage.Contains("Poziom przeciwnika"))
                            {
                                account.Cash = -1;
                                account.IsChecked = false;
                            }
                            else
                            {
                                account.Cash = -2;
                            }
                            flag = true;
                        }
                        account.LastAttack = DateTime.Now;
                    }
                }
            }

            return flag;
        }

        public int attack(String url)
        {
            if (attributes.Energy.Actual >= 10 && attributes.Health.Actual >= 10)
            {
                if (!String.IsNullOrEmpty(url))
                {
                    int timeout = 0;
                    String content = String.Empty;
                    do
                    {
                        try
                        {
                            content = httpClient.SendHttpGetAndReturnResponseContent(url);
                            timeout = 0;
                        }
                        catch (WebException we)
                        {
                            worker.printLog("[ERROR] Wystąpił błąd. attack!!!");
                            worker.printLog("[ERROR] Treść błędu: " + we.Message);
                            worker.printLog("[ERROR] Ponawiam proces.");
                            timeout++;
                        }
                    }
                    while ((timeout != 0) && timeout < 5);

                    if (timeout == 0)
                    {
                        updateAttributes(content);
                        String battleResult = HtmlUtils.GetStringValueByXPathExpression(content, "//div[@class='content']/h2/text()");
                        if (!String.IsNullOrEmpty(battleResult) && battleResult.Equals("Wygrałeś"))
                        {
                            String cashText = HtmlUtils.GetStringValueByXPathExpression(content, "//table[@class='items']/tr[4]/td[2]/ul/li[1]/text()");
                            cashText = MainUtils.removeAllNotNumberCharacters(cashText).Replace(" ", "");
                            int cash;
                            if (int.TryParse(cashText, out cash))
                                return cash;
                            else
                                return -1;
                        }
                        else
                        {
                            return -2;
                        }
                    }
                }
            }
            
            return -1;
        }

        public void getUnitsInfo()
        {
            int timeout = 0;

            do
            {
                try
                {
                    units = new Units.Units(httpClient.SendHttpGetAndReturnResponseContent("http://parafia.biz/units"));
                    timeout = 0;
                }
                catch (WebException we)
                {
                    worker.printLog("[ERROR] Wystąpił błąd. getUnitsInfo!!!");
                    worker.printLog("[ERROR] Treść błędu: " + we.Message);
                    worker.printLog("[ERROR] Ponawiam proces.");
                    timeout++;
                }
            }
            while ((timeout != 0) && timeout < 5);
            
        }

        public void getUnitsOnExpeditionsInfo()
        {
            String unitsPage = httpClient.SendHttpGetAndReturnResponseContent("http://parafia.biz/units");
            String expeditionsPage = httpClient.SendHttpGetAndReturnResponseContent("http://parafia.biz/units/expeditions");

            unitsOnExpeditions = new Units.Units(expeditionsPage, true);
            unitsOnExpeditions.setSingleAttackAndDefenseForUnits(unitsPage);

            unitsOnExpeditions.calculateStrength();

            Units.Units allUnits = units.mergeWithExpeditions(unitsOnExpeditions);
        }

        public void sendPilgrimage()
        {
            if (units.hasUnits(config.ArmyType))
            {
                FormData formData = new FormData();
                formData.addValue("formo_to_holy_land", "to_holy_land");
                formData.addValue("holy_land", csrf);

                int days = 0;
                int hours = 0;

               /* DateTime now = DateTime.Now;
                DateTime dateTime = new DateTime(now.Year, now.Month, now.Day, 10, 0, 0);
                if (now.Hour >= 10 && now.Hour <= 24)
                {
                    dateTime = dateTime.AddDays(1);
                }

                TimeSpan span = dateTime - DateTime.Now;*/

                estimateDaysAndHours(ref days, ref hours);

                formData.addValue("time_days", days.ToString());
                formData.addValue("time_hours", hours.ToString());

                units.putIntoFormData(formData, config.ArmyType);
                formData.addValue("holy_submit", "");

                int timeout = 0;

                do
                {
                    try
                    {
                        httpClient.SendHttpPostAndReturnResponseContent("http://parafia.biz/units/to_holy_land", formData);
                        timeout = 0;
                    }
                    catch (WebException we)
                    {
                        worker.printLog("[ERROR] Wystąpił błąd. sendPilgrimage!!!");
                        worker.printLog("[ERROR] Treść błędu: " + we.Message);
                        worker.printLog("[ERROR] Ponawiam proces.");
                        timeout++;
                    }
                }
                while ((timeout != 0) && timeout < 5);
            }
        }

        public bool checkDependencies(String content, String[] values)
        {
            foreach (String value in values)
            {
                HtmlNode node = HtmlUtils.GetSingleNodeByXPathExpression(content, "//*[@id='" + value + "']");
                if (node == null)
                {
                    node = HtmlUtils.GetSingleNodeByXPathExpression(content, "//*[@name='" + value + "']");
                    if (node == null) 
                        return false;
                }
            }
            return true;
        }

        public int buyRelic(String name)
        {
            String content = httpClient.SendHttpGetAndReturnResponseContent("http://parafia.biz/relics");

            attributes = new Attributes.Attributes(content);

            HtmlNodeCollection nodes = HtmlUtils.GetNodesCollectionByXPathExpression(content, "//ul[@class='relics-buy']/li/div[@class='info']");

            int relicsNo = -1;

            foreach (HtmlNode node in nodes)
            {
                String h3NodeText = HtmlUtils.GetStringValueByXPathExpression(node.InnerHtml, "//h3/text()");

                if (h3NodeText.ToLower().Equals(name.ToLower()))
                {
                    HtmlNode linkAndCostNode = HtmlUtils.GetSingleNodeByXPathExpression(node.InnerHtml, "//a[@class='button']");

                    if (linkAndCostNode != null)
                    {
                        String link = HtmlUtils.GetAttributeValueFromHtmlNode(linkAndCostNode, "href");
                        String costTxt = HtmlUtils.GetAttributeValueFromHtmlNode(linkAndCostNode, "title");

                        costTxt = MainUtils.removeAllNotNumberCharacters(costTxt).Replace(" ", "");

                        int cost = int.Parse(costTxt);

                        relicsNo = attributes.Cash.Actual / cost;

                        for (int i = 0; i < relicsNo; i++)
                        {
                            Thread thread = new Thread((ThreadStart)delegate
                            {
                                httpClient.SendHttpGetAndReturnResponseContent(link);
                            });
                            thread.Start();
                        }
                    }
                    else
                    {
                        relicsNo = 0;
                        break;
                    }
                }
            }

            return relicsNo;
        }

        public void doQuestTasks()
        {
            Queue<Quest> quests = questContainer.GetSelectedQuests();

            foreach (Quest quest in quests)
            {
                //questContainer.checkQuest(quest);
                if (quest.GetProgress() < 99)
                {
                    foreach (Task task in quest.ListOfTasks)
                    {
                        bool flag = true;
                        while (flag)
                        {
                            flag = false;
                            if (task.Progress != 100)
                            {
                                if (task.Cost.energy <= attributes.Energy.Actual)
                                {
                                    if (task.Cost.health <= attributes.Health.Actual)
                                    {
                                        bool cashFlag = true;

                                        if (task.Cost.cash > attributes.Cash.Actual)
                                        {
                                            worker.printLog("[QUESTS] Brak kasy...");
                                            if (attributes.Safe.Actual > task.Cost.cash)
                                            {
                                                worker.printLog("[QUESTS] Pobieram z sejfu...");
                                                getFromSafe(task.Cost.cash + 100);
                                            }
                                            else 
                                            {
                                                worker.printLog("[QUESTS] Brak kasy w sejfie... Pobieram z banku.");
                                                if (!getFromBank(task.Cost.cash))
                                                {
                                                    worker.printLog("[QUESTS][WARN] Brak kasy w banku... Przerywam proces.");
                                                    cashFlag = false;
                                                }
                                            }
                                        }

                                        if (cashFlag)
                                        {
                                            String questResult = httpClient.SendHttpGetAndReturnResponseContent(task.Link);
                                            String content = httpClient.SendHttpGetAndReturnResponseContent(quest.Link);
                                            updateQuestInfo(content, task);

                                            HtmlNode errorNode = HtmlUtils.GetSingleNodeByXPathExpression(questResult, "//div[@class='flashinfo error']");

                                            if (errorNode != null)
                                            {
                                                String errorMsg = HtmlUtils.GetStringValueByXPathExpression(questResult, "//div[@class='flashinfo_message']/text()");
                                                worker.printLog("[QUESTS][ERROR] Wystąpił błąd.");
                                                worker.printLog("[QUESTS][ERROR] Tresc. " + errorMsg);
                                                break;
                                            }
                                            else 
                                            {
                                                 worker.printLog("[QUESTS] Zadanie \"" + task.Name + "\" w quescie \"" + quest.Name + "\" na etapie " + task.Progress + " %");
                                            }

                                            updateAttributes(content);
                                            flag = true;
                                        }
                                    }
                                }
                            }
                            if (!flag)
                                break;
                        }
                    }
                }
            }

            Settings.Default["quests"] = questContainer;
            Settings.Default.Save();
        }

        public void updateAttributes(String content)
        {
            attributes = new Attributes.Attributes(content);
        }

        public void updateQuestInfo(String content, Task task)
        {
            questContainer.updateTaskProgress(content, task);
        }

        public void getQuests()
        {
            QuestContainer savedQuestContainer = null;
            Object obj = Settings.Default["quests"];
            if (obj != null) {
                savedQuestContainer = (QuestContainer)obj;
            }

            questContainer = new QuestContainer(httpClient, httpClient.SendHttpGetAndReturnResponseContent("http://parafia.biz/quests"));

            if (savedQuestContainer != null)
                newQuests = savedQuestContainer.compare(questContainer);

            if (questContainer != null)
            {
                Settings.Default["quests"] = questContainer;
                Settings.Default.Save();
            }
        }

        public String getContentOfGreatChange()
        {
            return httpClient.SendHttpGetAndReturnResponseContent("http://parafia.biz/relics/market_show/70");
        }

        public void goToPapacyParty()
        {
            httpClient.SendHttpGetAndReturnResponseContent("http://parafia.biz/papacy/party");
        }

        public void logout()
        {
            httpClient.SendHttpGetAndReturnResponseContent("http://parafia.biz/auth/logout");
        }

        private bool checkPapacParty(String responseContent)
        {
            return MainUtils.hasNumbers(HtmlUtils.GetStringValueByXPathExpression(responseContent, "//div[@class='mt20']/text()"));
        }

        private void estimateDaysAndHours(ref int days, ref int hoursToAdd)
        {
            DateTime actualDateTime = DateTime.Now;

            int actualDayOfWeekNo = (int)actualDateTime.DayOfWeek;
            int hours = actualDateTime.Hour;

            days = 0;

            if (actualDayOfWeekNo > 1)
                days = ((int)DayOfWeek.Saturday - actualDayOfWeekNo) + 2;

            if (actualDayOfWeekNo == 1 && hours >= 10)
                days = 7;

            if (actualDayOfWeekNo == 0)
                days = 1;

            hoursToAdd = 0;

            if (hours >= 10 && hours <= 24)
            {
                days--;
                hoursToAdd = (24 - hours) + 10;
            }
            else
            {
                hoursToAdd = 10 - hours;
            }
        }
    }
}
