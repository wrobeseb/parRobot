using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;

using HttpUtils;
using HtmlAgilityPack;


namespace PBizBot
{
    using Core;
    using View;
    using Model;
    using log4net;

    public partial class Main : Form
    {
        private static readonly ILog LOG = LogManager.GetLogger(typeof(Main));

        private AccountManager m_accountManager;
        private AppSettings m_appSettings;
        private AttackList m_attackList;
        private AccountList m_accountList;

        public AccountManager AccountManager
        {
            set { this.m_accountManager = value; }
        }

        public AppSettings AppSettings
        {
            set { this.m_appSettings = value; }
        }

        public AttackList AttackList
        {
            set { this.m_attackList = value; }
        }

        public AccountList AccountList
        {
            set { this.m_accountList = value; }
        }

        public Main()
        {
            LOG.Info("Start aplikacji.");
            InitializeComponent();
        }

        private void btON_Click(object sender, EventArgs e)
        {
            m_accountManager.StartAccounts();

            btOFF.Enabled = true;
            btON.Enabled = false;
        }

        private void btOFF_Click(object sender, EventArgs e)
        {
            btOFF.Enabled = false;
            btON.Enabled = true;
        }

        private void btAddUser_Click(object sender, EventArgs e)
        {
            
        }

        private void tbBot_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tbBot.SelectedIndex == 1)
            {
               /* webBrowser.Navigate("http://parafia.biz");

                DefaultHttpClient httpClient = new DefaultHttpClient();
                WebProxy proxy = new WebProxy(Settings.Default.AppSettings.ProxyHost, Settings.Default.AppSettings.ProxyPort);
                proxy.Credentials = new NetworkCredential(Settings.Default.AppSettings.ProxyUser, Settings.Default.AppSettings.ProxyPassword, Settings.Default.AppSettings.ProxyDomain);
                httpClient.SetWebProxy = proxy;

                String responseContent = httpClient.SendHttpGetAndReturnResponseContent("http://parafia.biz/");
                String csrf = HtmlUtils.GetStringValueByXPathExpression(responseContent, "//input[@name='login_csrf']");

                byte[] bytes = Encoding.UTF8.GetBytes("formo_login_form=login_form&login_csrf=" + csrf + "&user_name=sairo&user_pass=sairoroan&login_submit=");

                webBrowser.Navigate("http://parafia.biz/", "_self", bytes, "Content-Type: application/x-www-form-urlencoded");
             
                webBrowser.Focus();
                while (webBrowser.ReadyState != WebBrowserReadyState.Complete) { Application.DoEvents(); }*/
            }
        }

        private void webBrowser_HandleCreated(object sender, EventArgs e)
        {


            /*GeckoPreferences.Default["network.proxy.http"] = Settings.Default.AppSettings.ProxyHost;
            GeckoPreferences.Default["network.proxy.http_port"] = Settings.Default.AppSettings.ProxyPort;
            GeckoPreferences.Default["network.proxy.login"] = "TP\\" + Settings.Default.AppSettings.ProxyUser;
            GeckoPreferences.Default["network.proxy.password"] = Settings.Default.AppSettings.ProxyPassword;
            GeckoPreferences.Default["network.proxy.type"] = 1;*/

            /*DefaultHttpClient httpClient = new DefaultHttpClient();
            WebProxy proxy = new WebProxy(Settings.Default.AppSettings.ProxyHost, Settings.Default.AppSettings.ProxyPort);
            proxy.Credentials = new NetworkCredential(Settings.Default.AppSettings.ProxyUser, Settings.Default.AppSettings.ProxyPassword, Settings.Default.AppSettings.ProxyDomain);
            httpClient.SetWebProxy = proxy;

            String responseContent = httpClient.SendHttpGetAndReturnResponseContent("http://parafia.biz/");
            String csrf = HtmlUtils.GetStringValueByXPathExpression(responseContent, "//input[@name='login_csrf']");

            byte[] bytes = Encoding.UTF8.GetBytes("formo_login_form=login_form&login_csrf=" + csrf + "&user_name=sairo&user_pass=sairoroan&login_submit=");

            string AdditionalHeaders = "Content-Type: application/x-www-form-urlencoded" + Environment.NewLine + "Content-Length: " + bytes.Length + Environment.NewLine;

            webBrowser.Navigate("http://parafia.biz/", GeckoLoadFlags.None, "http://parafia.biz/", bytes, AdditionalHeaders);

            Action<string> action = url => webBrowser.Navigate(url);
            webBrowser.Invoke(action, new object[] { "http://parafia.biz/start/dashboard" });*/

        }

        private void Main_Load(object sender, EventArgs e)
        {
            BotMainPanel botMainPanel = new BotMainPanel();
            botMainPanel.Location = new System.Drawing.Point(2, 8);
            gbBotMainPanel.Controls.Add(botMainPanel);

            
            gbAccounts.Controls.Add(m_accountList);
            gbAttackListSection.Controls.Add(m_attackList);
            //AttackList attackList = new AttackList();
            //attackList.Location = new System.Drawing.Point(12, 12);
            //gbBotMainPanel.Controls.Add(attackList);
        }

        private void btSettings_Click(object sender, EventArgs e)
        {
            m_appSettings.ShowDialog();
        }
    }
}
