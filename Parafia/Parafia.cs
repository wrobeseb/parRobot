using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using HttpUtils;
using System.Net;
using Parafia.Exceptions;
using Parafia.Enums;
using Parafia.Model.Quest;

namespace Parafia
{
    public class Parafia
    {
        public static DefaultHttpClient httpClient;
        public static Attributes.Attributes attributes;
        public static Units.Units units;
        public static String csrf;

        public static QuestContainer questContainer;

        public static bool papacyParty;

        public static void initConnection(WebProxy webProxy)
        {
            httpClient = new DefaultHttpClient();
            if (webProxy != null)
                httpClient.SetWebProxy = webProxy;
        }

        public static void login(String user, String passwd)
        {
            String responseContent = httpClient.SendHttpGetAndReturnResponseContent("http://parafia.biz/");
            csrf = HtmlUtils.GetStringValueByXPathExpression(responseContent, "//input[@name='login_csrf']");

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
        }

        public static void buyArmy(ArmyType armyType)
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

        public static void getUnitsInfo()
        {
            units = new Units.Units(httpClient.SendHttpGetAndReturnResponseContent("http://parafia.biz/units"));
        }

        public static void sendPilgrimage(int hours)
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

                httpClient.SendHttpPostAndReturnResponseContent("http://parafia.biz/units/to_holy_land", formData);
            }
        }

        public static void getQuests()
        {
            questContainer = new QuestContainer(httpClient.SendHttpGetAndReturnResponseContent("http://parafia.biz/quests"));
        }

        public static void goToPapacyParty()
        {
            httpClient.SendHttpGetAndReturnResponseContent("http://parafia.biz/papacy/party");
        }

        public static void logout()
        {
            httpClient.SendHttpGetAndReturnResponseContent("http://parafia.biz/auth/logout");
        }

        private static bool checkPapacParty(String responseContent)
        {
            return MainUtils.hasNumbers(HtmlUtils.GetStringValueByXPathExpression(responseContent, "//div[@class='mt20']/text()"));
        }
    }
}
