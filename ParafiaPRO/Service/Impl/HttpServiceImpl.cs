using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParafiaPRO.Service.Impl
{
    using Providers;
    using Model.Account;
    using HttpUtils;
    using HtmlAgilityPack;
    using ParafiaPRO.Core.Exceptions;
    using log4net;

    public class HttpServiceImpl : IHttpService
    {
        private static ILog log = LogManager.GetLogger(typeof(Attributes));

        private IContentProvider mContentProvider;

        public IContentProvider ContentProvider
        {
            set { this.mContentProvider = value; }
        }

        public bool Login(Core.Session.Session session)
        {
            String responseContent = mContentProvider.CSRFContent(session);
            session.CSRF = HtmlUtils.GetStringValueByXPathExpression(responseContent, "//input[@name='login_csrf']");

            if (checkDependencies(responseContent, new String[] { "formo_login_form", "login_csrf", "user_name", "user_pass", "login_submit" }))
            {
                FormData formData = new FormData();
                formData.addValue("formo_login_form", "login_form");
                formData.addValue("login_csrf", session.CSRF);
                formData.addValue("user_name", session.Account.Login);
                formData.addValue("user_pass", session.Account.Passwd);
                formData.addValue("login_submit", "");

                responseContent = mContentProvider.Login(session, formData);

                String errorMessage = HtmlUtils.GetStringValueByXPathExpression(responseContent, "//div[@class='form-error']/text()");

                if (!String.IsNullOrEmpty(errorMessage))
                {
                    throw new LoginException(errorMessage);
                }
                else
                {
                    // Login success...
                }
                return true;
            }
            return false;
        }


        public bool Logout(Core.Session.Session session)
        {
            mContentProvider.Logout(session);
            return true;
        }

        public void UpdateAttributes(Core.Session.Session session)
        {
            log.Info(session.NameLogFormat + "Pobieram atrybuty dla konta...");
            session.Attributes = new Attributes(mContentProvider.DashboardContent(session));
        }

        #region Private Methods

        private bool checkDependencies(String content, String[] values)
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

        #endregion
    }
}
