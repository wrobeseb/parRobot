using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ParafiaPRO.View.Impl
{
    using Controller;
    using Core.Properties;

    public partial class SettingsPanelViewImpl : AbstractView, ISettingsPanelView
    {
        public event EventHandler OnSaveEvent;

        private ISettingsController mSettingsController;

        private Properties mProperties;

        public ISettingsController SettingsController
        {
            set
            {
                this.mSettingsController = value;
                this.mSettingsController.SettingsPanelView = this;
            }
        }

        public Core.Properties.Properties Properties
        {
            get
            {
                Action(delegate
                {
                    this.mProperties.ProxyEnabled = this.cbProxyEnabled.Checked;
                    this.mProperties.ProxyHost = this.tbProxyAddress.Text;
                    if (!String.IsNullOrEmpty(this.tbProxyPort.Text))
                        this.mProperties.ProxyPort = int.Parse(this.tbProxyPort.Text);
                    this.mProperties.ProxyUser = this.tbProxyLogin.Text;
                    this.mProperties.ProxyUserDomain = this.tbProxyDomain.Text;
                    this.mProperties.ProxyPasswd = this.tbProxyPasswd.Text;
                });
                return this.mProperties;
            }
            set
            {
                 this.mProperties = value;
                 Action(delegate
                 {
                     this.cbProxyEnabled.Checked = this.mProperties.ProxyEnabled;
                     this.tbProxyAddress.Text = this.mProperties.ProxyHost;
                     this.tbProxyPort.Text = new StringBuilder().Append(this.mProperties.ProxyPort).ToString();
                     this.tbProxyLogin.Text = this.mProperties.ProxyUser;
                     this.tbProxyDomain.Text = this.mProperties.ProxyUserDomain;
                     this.tbProxyPasswd.Text = this.mProperties.ProxyPasswd;
                 });
            }
        }

        public UserControl Control
        {
            get { return this; }
        }


        public SettingsPanelViewImpl()
        {
            InitializeComponent();
        }


        private void cbProxyEnabled_CheckedChanged(object sender, EventArgs e)
        {
            if (cbProxyEnabled.Checked)
                gbProxy.Enabled = true;
            else
                gbProxy.Enabled = false;
        }

        private void cbSmtpMainSwitch_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSmtpMainSwitch.Checked)
                gbSmtp.Enabled = true;
            else
                gbSmtp.Enabled = false;
        }

        private void cbSyncTimeSwitch_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSyncTimeSwitch.Checked)
                gbSyncAccount.Enabled = true;
            else
                gbSyncAccount.Enabled = false;
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (OnSaveEvent != null)
            {
                this.btSave.Enabled = false;
                OnSaveEvent(this, EventArgs.Empty);
                this.btSave.Enabled = true;
            }
        }
    }
}
