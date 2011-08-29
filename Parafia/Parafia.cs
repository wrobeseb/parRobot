using System;
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

namespace Parafia
{
    public class Parafia
    {
        public DefaultHttpClient httpClient;
        public Attributes.Attributes attributes;
        public Units.Units units;
        public String csrf;

        public  QuestContainer questContainer;

        public bool papacyParty;

        public void initConnection(WebProxy webProxy)
        {
            httpClient = new DefaultHttpClient();
            if (webProxy != null)
                httpClient.SetWebProxy = webProxy;
        }

        public bool login(String user, String passwd)
        {
            String responseContent = httpClient.SendHttpGetAndReturnResponseContent("http://parafia.biz/");
            csrf = HtmlUtils.GetStringValueByXPathExpression(responseContent, "//input[@name='login_csrf']");

            if (checkDependencies(responseContent, new String[] { "formo_login_form", "login_csrf", "user_name", "user_pass", "login_submit" }))
            {
                FormData formData = new FormData();
                formData.addValue("formo_login_form", "login_form");
                formData.addValue("login_csrf", csrf);
                formData.addValue("user_name", user);
                formData.addValue("user_pass", passwd);
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

        public void getQuests()
        {
            questContainer = new QuestContainer(httpClient.SendHttpGetAndReturnResponseContent("http://parafia.biz/quests"));
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
