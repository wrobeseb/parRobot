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

    public class Parafia
    {
        public ApplicationConfig config;
        public DefaultHttpClient httpClient;
        public Attributes.Attributes attributes;
        public Units.Units units;
        public String csrf;

        public  QuestContainer questContainer;

        private List<Quest> newQuests;

        public bool papacyParty;

        public void initConnection(ApplicationConfig config)
        {
            if (config != null)
            {
                this.config = config;
                WebProxy proxy = null;
                if (!String.IsNullOrEmpty(config.ProxyHost))
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
            String temp = MainUtils.removeAllNotNumberCharacters(HtmlUtils.GetSingleNodeByXPathExpression(httpClient.SendHttpGetAndReturnResponseContent("http://blog.parafia.biz/czas/"), "//body").InnerText).Replace(" ", String.Empty);
            String[] tempTable = temp.Split(',');
            return new TimeSpan(0, int.Parse(tempTable[0]), int.Parse(tempTable[1]), int.Parse(tempTable[2]), 0);
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

                responseContent = httpClient.SendHttpPostAndReturnResponseContent("http://parafia.biz/", formData);

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
            else
            {
                return false;
            }
        }

        public void putIntoSafe()
        {
            int maxValue = attributes.Safe.Max - attributes.Safe.Actual;
            if (maxValue != 0)
            {
                int value = 0;
                if (attributes.Cash.Actual > maxValue) value = maxValue;
                else value = attributes.Cash.Actual;

                FormData formData = new FormData();
                formData.addValue("formo_safe_deposit", "safe_deposit");
                formData.addValue("safe_deposit_csrf", csrf);
                formData.addValue("deposit_value", new StringBuilder().Append(value).ToString());
                formData.addValue("safe_deposit_submit", "");

                String responseContent = httpClient.SendHttpPostAndReturnResponseContent("http://parafia.biz/buildings/safe", formData);
                attributes = new Attributes.Attributes(responseContent);
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

                String responseContent = httpClient.SendHttpPostAndReturnResponseContent("http://parafia.biz/buildings/safe", formData);
                attributes = new Attributes.Attributes(responseContent);
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
                String content = httpClient.SendHttpGetAndReturnResponseContent("http://parafia.biz/stats/battle/all/page/" + page);
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

            return accounts;
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
                        value = attributes.Safe.Actual;

                    getFromSafe(value);
                }

                if (cashNeed > attributes.Cash.Actual)
                    maxBelivers = attributes.Cash.Actual / 20;

                switch (armyType)
                {
                    case ArmyType.Attack:
                        httpClient.SendHttpGetAndReturnResponseContent(urlAttack + maxBelivers);
                        break;
                    case ArmyType.Defense:
                        httpClient.SendHttpGetAndReturnResponseContent(urlDefense + maxBelivers);
                        break;
                }
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
                String content = httpClient.SendHttpGetAndReturnResponseContent("http://parafia.biz/battle/attack/" + account.Id);
                updateAttributes(content);
                String battleResult = HtmlUtils.GetStringValueByXPathExpression(content, "//div[@class='content']/h2/text()");
                if (!String.IsNullOrEmpty(battleResult) && battleResult.Equals("Wygrałeś"))
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
                        flag = false;
                    }

                String defenseText = HtmlUtils.GetStringValueByXPathExpression(content, "//div[@class='content']/div[@class='left ml50 wp-45']/div[2]/text()");
                defenseText = MainUtils.removeAllNotNumberCharactersForDouble(defenseText);

                double temp;

                double.TryParse(defenseText, out temp);

                account.Defense = temp;
            }

            return flag;
        }

        public int attack(String url)
        {
            if (attributes.Energy.Actual >= 10 && attributes.Health.Actual >= 10)
            {
                if (!String.IsNullOrEmpty(url))
                {
                    String content = httpClient.SendHttpGetAndReturnResponseContent(url);

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
            
            return -1;
        }

        public void getUnitsInfo()
        {
            units = new Units.Units(httpClient.SendHttpGetAndReturnResponseContent("http://parafia.biz/units"));
        }

        public void sendPilgrimage(int hours)
        {
            if (units.hasUnits())
            {
                FormData formData = new FormData();
                formData.addValue("formo_to_holy_land", "to_holy_land");
                formData.addValue("holy_land", csrf);
                formData.addValue("time_days", "0");
                formData.addValue("time_hours", hours.ToString());
                units.putIntoFormData(formData);
                formData.addValue("holy_submit", "");

                String content = httpClient.SendHttpPostAndReturnResponseContent("http://parafia.biz/units/to_holy_land", formData);
            }
        }

        public String attack(String name)
        {
            FormData formData = new FormData();
            formData.addValue("formo_battle_search", "battle_search");
            formData.addValue("battle_csrf", csrf);
            formData.addValue("opponent_name", name.ToLower());
            formData.addValue("search_submit", "");
            
            httpClient.SendHttpGetAndReturnResponseContent("http://parafia.biz/start/dashboard");
            httpClient.SendHttpGetAndReturnResponseContent("http://parafia.biz/battle/players");
            //HttpWebResponse response = httpClient.HttpPost("http://parafia.biz/battle/players", formData);
            String content = httpClient.SendHttpPostAndReturnResponseContent("http://parafia.biz/battle/players", formData);

            return "success";
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

        public void doQuestTasks(String[] selectedNames)
        {
            ArrayList quests = questContainer.GetQuestsByNameList(selectedNames);

            foreach (Quest quest in quests)
            {
                questContainer.checkQuest(quest);
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
                                        if (task.Cost.cash <= attributes.Cash.Actual)
                                        {
                                            String questResult = httpClient.SendHttpGetAndReturnResponseContent(task.Link);
                                            String content = httpClient.SendHttpGetAndReturnResponseContent(quest.Link);
                                            updateQuestInfo(content, task);
                                            
                                            if (HtmlUtils.GetSingleNodeByXPathExpression(questResult, "//div[@class='flashinfo error']") != null)
                                                break;

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
    }
}
