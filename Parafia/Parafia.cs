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

        public void buyArmy(ArmyType armyType)
        {
            String urlAttack = "http://parafia.biz/units/buy/1/amount/";
            String urlDefense = "http://parafia.biz/units/buy/4/amount/";

            int maxBelivers = attributes.Beliver.Actual - 10;

            if (maxBelivers != 0)
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
            }
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

                httpClient.SendHttpGetAndReturnResponseContent("http://parafia.biz/units/expeditions");
                httpClient.SendHttpGetAndReturnResponseContent("http://parafia.biz/units/to_holy_land");

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
            ArrayList quests = questContainer.GetQuestByNameTable(selectedNames);

            foreach (Quest quest in quests)
            {
                questContainer.checkQuest(quest);
                if (quest.Progress < 98)
                {
                    foreach (Task task in quest.ListOfTasks)
                    {
                        bool flag = true;
                        while (flag)
                        {
                            flag = false;
                            if (task.Progress != 100)
                            {
                                if (task.Cost.energy < attributes.Energy.Actual)
                                {
                                    if (task.Cost.health < attributes.Health.Actual)
                                    {
                                        if (task.Cost.cash < attributes.Cash.Actual)
                                        {
                                            httpClient.SendHttpGetAndReturnResponseContent(task.Link);
                                            String content = httpClient.SendHttpGetAndReturnResponseContent(quest.Link);
                                            updateAttributes(content);
                                            updateQuestInfo(content, task);
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
