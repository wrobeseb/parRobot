using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using HttpUtils;
using HtmlAgilityPack;

namespace PBizBot
{
    using View;
    using Model;

    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btON_Click(object sender, EventArgs e)
        {
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
                webBrowser.Document.Cookie = null;

                DefaultHttpClient httpClient = new DefaultHttpClient();

                String responseContent = httpClient.SendHttpGetAndReturnResponseContent("http://parafia.biz/");
                String csrf = HtmlUtils.GetStringValueByXPathExpression(responseContent, "//input[@name='login_csrf']");

                byte[] bytes = Encoding.UTF8.GetBytes("formo_login_form=login_form&login_csrf=" + csrf + "&user_name=sairo&user_pass=sairoroan&login_submit=");

                webBrowser.Navigate("http://parafia.biz/", "_self", bytes, "Content-Type: application/x-www-form-urlencoded");

                webBrowser.Focus();
               // while (webBrowser.ReadyState != WebBrowserReadyState.Complete) { Application.DoEvents(); }
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Account account1 = new Account(true);
            Account account2 = new Account(false);
            account1.Login = "sairo";
            account1.Passwd = "sairoroan";
            account1.Selected = true;
            account2.Login = "mortar";
            account2.Passwd = "mojehaslo";

            this.SuspendLayout();
            AccountDetailsControl accountDetailsControl = new AccountDetailsControl(account1);
            AccountDetailsControl accountDetailsControl1 = new AccountDetailsControl(account2);
            accountDetailsControl1.SuspendLayout();
            accountDetailsControl.SuspendLayout();
            accountDetailsControl.Location = new System.Drawing.Point(12, 12);
            accountDetailsControl1.Location = new System.Drawing.Point(12, 31);
            gbAccounts.Controls.Add(accountDetailsControl);
            gbAccounts.Controls.Add(accountDetailsControl1);
            accountDetailsControl.ResumeLayout(false);
            accountDetailsControl1.ResumeLayout(false);

            BotMainPanel botMainPanel = new BotMainPanel();
            botMainPanel.Location = new System.Drawing.Point(2, 8);
            gbBotMainPanel.Controls.Add(botMainPanel);

            //AttackList attackList = new AttackList();
            //attackList.Location = new System.Drawing.Point(12, 12);
            //gbBotMainPanel.Controls.Add(attackList);

            this.ResumeLayout(true);
        }

    }
}
