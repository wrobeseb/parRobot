using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HttpUtils;
using System.Net;
using System.Diagnostics;
using log4net;

namespace ParafiaPRO.Core.Session
{
    using Model;
    using Model.Account;
    using Spring.Objects.Factory;

    public class Session : IInitializingObject
    {
        private static ILog log = LogManager.GetLogger(typeof(Session));

        private Account mAccount;
        private DefaultHttpClient mClient;
        private Settings mSettings;

        private Attributes mAttributes;

        private String mCsrf;

        public DefaultHttpClient HttpClient
        {
            get { return this.mClient; }
        }

        public Account Account
        {
            set { this.mAccount = value; }
            get { return this.mAccount; }
        }

        public String NameLogFormat
        {
            get { return "[ " + this.mAccount.Login + " ] "; }
        }

        public Settings Settings
        {
            set { this.mSettings = value; }
        }

        public Attributes Attributes
        {
            set { this.mAttributes = value; }
            get { return this.mAttributes; }
        }

        public String CSRF
        {
            get { return this.mCsrf; }
            set { this.mCsrf = value; }
        }

        public void  AfterPropertiesSet()
        {
            this.mClient = new DefaultHttpClient();
 	        WebProxy proxy = null;
            if (mSettings.Default.ProxyEnabled)
            {
                proxy = new WebProxy(mSettings.Default.ProxyHost, mSettings.Default.ProxyPort);
                proxy.Credentials = new NetworkCredential(mSettings.Default.ProxyUser, mSettings.Default.ProxyPasswd, mSettings.Default.ProxyUserDomain);
            }
            this.mClient.SetWebProxy = proxy;
        }

        public Session() { }

        public String POST(String url, FormData formData)
        {
            int timeout = 0;
            String content = null;
            do
            {
                try { content = this.mClient.SendHttpPostAndReturnResponseContent(url, formData); timeout = 0; }
                catch (WebException we)
                {
                    StackTrace stackTrace = new StackTrace();
                    log.Error("Wystąpił błąd w metodzie: " + stackTrace.GetFrame(1).GetMethod().Name);
                    log.Error("Treść błędu: " + we.Message);
                    log.Error("Ponawiam krok.");
                }
            }
            while ((timeout != 0) && timeout < 5);
            return content;
        }

        public String GET(String url)
        {
            int timeout = 0;
            String content = null;
            do
            {
                try { content = this.mClient.SendHttpGetAndReturnResponseContent(url); timeout = 0; }
                catch (WebException we)
                {
                    StackTrace stackTrace = new StackTrace();
                    log.Error("Wystąpił błąd w metodzie: " + stackTrace.GetFrame(1).GetMethod().Name);
                    log.Error("Treść błędu: " + we.Message);
                    log.Error("Ponawiam krok.");
                }
            }
            while ((timeout != 0) && timeout < 5);
            return content;
        }
    }
}
