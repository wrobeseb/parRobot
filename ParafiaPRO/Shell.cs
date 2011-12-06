using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ParafiaPRO
{
    using View;
    using Controller;
    using Core;

    public partial class Shell : Form
    {
        private Settings mSetting;

        private IAccountListView mAccountListView;
        private IControlPanelView mControlPanelView;
        private ISettingsPanelView mSettingsPanelView;
        private ILoggerPanelView mLoggerPanelView;

        private IMainController mMainController;

        public IAccountListView AccountListView
        {
            set { this.mAccountListView = value; }
        }

        public IControlPanelView ControlPanelView
        {
            set { this.mControlPanelView = value; }
        }

        public ISettingsPanelView SettingsPanelView
        {
            set { this.mSettingsPanelView = value; }
        }

        public ILoggerPanelView LoggerPanelView
        {
            set { this.mLoggerPanelView = value; }
        }

        public Settings Settings
        {
            set { this.mSetting = value; }
        }

        public IMainController MainController
        {
            set 
            { 
                this.mMainController = value;
                this.mMainController.Shell = this;
            }
        }

        public Shell()
        {
            InitializeComponent();
        }

        private void Shell_Load(object sender, EventArgs e)
        {
            this.mSettingsPanelView.Properties = this.mSetting.Default;

            this.AccountRegion.Controls.Add(mAccountListView.Control);
            this.ControlPanelRegion.Controls.Add(mControlPanelView.Control);
            this.SettingsPanelRegion.Controls.Add(mSettingsPanelView.Control);
            this.tpLog.Controls.Add(mLoggerPanelView.Control);
        }
    }
}
