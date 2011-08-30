using System;
using System.Collections.Generic;
using System.ComponentModel;
//using System.Data;
//using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//using Parafia.Enums;
//using Parafia.Properties;

namespace ParafiaIoC
{
    public partial class ConfigForm : Form
    {
        public ConfigForm()
        {
            InitializeComponent();
        }

        private void cbProxyYesOrNo_SelectedValueChanged(object sender, EventArgs e)
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
            tbAccountUser.Text = String.Empty;
            tbAccountUserPasswd.Text = String.Empty;
            cbUnitType.SelectedItem = "Obrona";
            cbSendPilgrimage.Checked = false;

            cbSentMail.SelectedItem = "Nie";
            cbEnableSSL.Checked = false;

            gbMailConfig.Enabled = false;

            tbSmtpAccount.Text = String.Empty;
            tbSmtpAccountPasswd.Text = String.Empty;
            tbSmtpHost.Text = String.Empty;
            tbSmtpPort.Text = String.Empty;
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            /*ApplicationConfig config = new ApplicationConfig();

            config.UseProxy = cbProxyYesOrNo.SelectedItem.Equals("Tak") ? true : false;
            config.ProxyHost = tbProxyHost.Text;
            if (!String.IsNullOrEmpty(tbProxyPort.Text))
                config.ProxyPort = int.Parse(tbProxyPort.Text);
            config.ProxyUser = tbProxyUser.Text;
            config.ProxyDomain = tbProxyDomain.Text;
            config.ProxyPassword = tbProxyPassword.Text;
            config.AccountUser = tbAccountUser.Text;
            config.AccountPassword = tbAccountUserPasswd.Text;
            config.ArmyType = cbUnitType.SelectedItem.Equals("Obrona") ? ArmyType.Defense : ArmyType.Attack;
            config.SendPilgrimage = cbSendPilgrimage.Checked;

            config.SentMail = cbSentMail.SelectedItem.Equals("Tak") ? true : false;
            config.SmtpHost = tbSmtpHost.Text;
            if (!String.IsNullOrEmpty(tbSmtpPort.Text))
                config.SmtpPort = int.Parse(tbSmtpPort.Text);
            config.SmtpAccount = tbSmtpAccount.Text;
            config.SmtpAccountPasswd = tbSmtpAccountPasswd.Text;
            config.SmtpEnableSSL = cbEnableSSL.Checked;

            Settings.Default["properties"] = config;
            Settings.Default.Save();*/
            this.Close();
        }

        private void ConfigForm_Load(object sender, EventArgs e)
        {
            /*Object obj = Settings.Default["properties"];
            if (obj != null)
            {
                ApplicationConfig config = (ApplicationConfig)obj;

                if (config != null)
                {
                    cbProxyYesOrNo.SelectedItem = config.UseProxy ? "Tak" : "Nie";
                    if (cbProxyYesOrNo.SelectedItem.Equals("Tak")) gbProxyConfig.Enabled = true;
                    tbProxyHost.Text = config.ProxyHost;
                    tbProxyPort.Text = new StringBuilder().Append(config.ProxyPort).ToString();
                    tbProxyUser.Text = config.ProxyUser;
                    tbProxyDomain.Text = config.ProxyDomain;
                    tbProxyPassword.Text = config.ProxyPassword;
                    tbAccountUser.Text = config.AccountUser;
                    tbAccountUserPasswd.Text = config.AccountPassword;
                    cbUnitType.SelectedItem = config.ArmyType;
                    cbSendPilgrimage.Checked = config.SendPilgrimage;
                    
                    cbSentMail.SelectedItem = config.SentMail ? "Tak" : "Nie";
                    if (cbSentMail.SelectedItem.Equals("Tak")) gbMailConfig.Enabled = true;
                    tbSmtpHost.Text = config.SmtpHost;
                    tbSmtpPort.Text = new StringBuilder().Append(config.SmtpPort).ToString();
                    tbSmtpAccount.Text = config.SmtpAccount;
                    tbSmtpAccountPasswd.Text = config.SmtpAccountPasswd;
                    cbEnableSSL.Checked = config.SmtpEnableSSL;
                }
            }*/
        }


    }
}
