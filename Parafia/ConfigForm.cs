using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Parafia.Properties;
using Parafia.Enums;

namespace Parafia
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
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            Settings.Default["useProxy"] = cbProxyYesOrNo.SelectedItem.Equals("Tak") ? true : false;
            Settings.Default["proxyHost"] = tbProxyHost.Text;
            if (!String.IsNullOrEmpty(tbProxyPort.Text)) 
                Settings.Default["proxyPort"] = int.Parse(tbProxyPort.Text);
            Settings.Default["proxyUser"] = tbProxyUser.Text;
            Settings.Default["proxyDomain"] = tbProxyDomain.Text;
            Settings.Default["proxyPassword"] = tbProxyPassword.Text;
            Settings.Default["parafiaUser"] = tbAccountUser.Text;
            Settings.Default["parafiaPassword"] = tbAccountUserPasswd.Text;
            Settings.Default["armyType"] = cbUnitType.SelectedItem.Equals("Obrona") ? ArmyType.Defense : ArmyType.Attack;
            Settings.Default["sendPilgrimage"] = cbSendPilgrimage.Checked;
            Settings.Default.Save();
            this.Close();
        }

        private void ConfigForm_Load(object sender, EventArgs e)
        {
            cbProxyYesOrNo.SelectedItem = Settings.Default["useProxy"].Equals(true) ? "Tak" : "Nie";
            if (cbProxyYesOrNo.SelectedItem.Equals("Tak")) gbProxyConfig.Enabled = true;
            tbProxyHost.Text = new StringBuilder().Append(Settings.Default["proxyHost"]).ToString();
            tbProxyPort.Text = new StringBuilder().Append(Settings.Default["proxyPort"]).ToString(); 
            tbProxyUser.Text = new StringBuilder().Append(Settings.Default["proxyUser"]).ToString();
            tbProxyDomain.Text = new StringBuilder().Append(Settings.Default["proxyDomain"]).ToString();
            tbProxyPassword.Text = new StringBuilder().Append(Settings.Default["proxyPassword"]).ToString();
            tbAccountUser.Text = new StringBuilder().Append(Settings.Default["parafiaUser"]).ToString();
            tbAccountUserPasswd.Text = new StringBuilder().Append(Settings.Default["parafiaPassword"]).ToString();
            cbUnitType.SelectedItem = Settings.Default["armyType"];
            cbSendPilgrimage.Checked = (bool)Settings.Default["sendPilgrimage"];
        }
    }
}
