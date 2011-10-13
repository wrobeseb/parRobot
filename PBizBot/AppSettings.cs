using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace PBizBot
{
    using PBizBot.Settings;


    public partial class AppSettings : Form
    {
        public AppSettings()
        {
            InitializeComponent();
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            Settings.Settings config = new Settings.Settings();

            config.UseProxy = cbProxyYesOrNo.SelectedItem.Equals("Tak") ? true : false;
            config.ProxyHost = tbProxyHost.Text;
            if (!String.IsNullOrEmpty(tbProxyPort.Text))
                config.ProxyPort = int.Parse(tbProxyPort.Text);
            config.ProxyUser = tbProxyUser.Text;
            config.ProxyDomain = tbProxyDomain.Text;
            config.ProxyPassword = tbProxyPassword.Text;

            config.SentMail = cbSentMail.SelectedItem.Equals("Tak") ? true : false;
            config.SmtpHost = tbSmtpHost.Text;
            if (!String.IsNullOrEmpty(tbSmtpPort.Text))
                config.SmtpPort = int.Parse(tbSmtpPort.Text);
            config.SmtpAccount = tbSmtpAccount.Text;
            config.SmtpAccountPasswd = tbSmtpAccountPasswd.Text;
            config.SmtpTo = tbMailTo.Text;
            config.SmtpSubject = tbMailSubject.Text;
            config.SmtpEnableSSL = cbEnableSSL.Checked;

            this.Close();
        }

        private void bReset_Click(object sender, EventArgs e)
        {
            cbProxyYesOrNo.SelectedItem = "Nie";
            tbProxyHost.Text = String.Empty;
            gbProxyConfig.Enabled = false;
            tbProxyHost.Text = String.Empty;
            tbProxyPort.Text = String.Empty;
            tbProxyUser.Text = String.Empty;
            tbProxyDomain.Text = String.Empty;
            tbProxyPassword.Text = String.Empty;

            cbSentMail.SelectedItem = "Nie";
            cbEnableSSL.Checked = false;

            gbMailConfig.Enabled = false;

            tbSmtpAccount.Text = String.Empty;
            tbSmtpAccountPasswd.Text = String.Empty;
            tbSmtpHost.Text = String.Empty;
            tbSmtpPort.Text = String.Empty;
            tbMailTo.Text = String.Empty;
            tbMailSubject.Text = String.Empty;
        }

        private void cbProxyYesOrNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbProxyYesOrNo.SelectedItem.Equals("Tak"))
            {
                gbProxyConfig.Enabled = true;
            }
            else
            {
                gbProxyConfig.Enabled = false;
            }
        }

        private void cbSentMail_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSentMail.SelectedItem.Equals("Tak"))
            {
                gbMailConfig.Enabled = true;
            }
            else
            {
                gbMailConfig.Enabled = false;
            }
        }

        private void AppSettings_Load(object sender, EventArgs e)
        {
           /* Object obj = Settings.Default["AppSettings"];
            if (obj != null)
            {
                Settings config = (Settings)obj;

                if (config != null)
                {
                    cbProxyYesOrNo.SelectedItem = config.UseProxy ? "Tak" : "Nie";
                    if (cbProxyYesOrNo.SelectedItem.Equals("Tak")) gbProxyConfig.Enabled = true;
                    tbProxyHost.Text = config.ProxyHost;
                    tbProxyPort.Text = new StringBuilder().Append(config.ProxyPort).ToString();
                    tbProxyUser.Text = config.ProxyUser;
                    tbProxyDomain.Text = config.ProxyDomain;
                    tbProxyPassword.Text = config.ProxyPassword;

                    cbSentMail.SelectedItem = config.SentMail ? "Tak" : "Nie";
                    if (cbSentMail.SelectedItem.Equals("Tak")) gbMailConfig.Enabled = true;
                    tbSmtpHost.Text = config.SmtpHost;
                    tbSmtpPort.Text = new StringBuilder().Append(config.SmtpPort).ToString();
                    tbSmtpAccount.Text = config.SmtpAccount;
                    tbSmtpAccountPasswd.Text = config.SmtpAccountPasswd;
                    tbMailTo.Text = config.SmtpTo;
                    tbMailSubject.Text = config.SmtpSubject;
                    cbEnableSSL.Checked = config.SmtpEnableSSL;
                }
            }*/
        }
    }
}
