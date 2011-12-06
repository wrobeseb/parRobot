using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParafiaPRO.Controller.Impl
{
    using View;
    using Core;
    using log4net;

    public class SettingsControllerImpl : AbstractController, ISettingsController
    {
        private static ILog log = LogManager.GetLogger(typeof(SettingsControllerImpl));

        private ISettingsPanelView mSettingsPanelView;
        private Settings mSettings;

        public Settings Settings
        {
            set { this.mSettings = value; }
        }

        public View.ISettingsPanelView SettingsPanelView
        {
            set 
            { 
                this.mSettingsPanelView = value;
                this.mSettingsPanelView.OnSaveEvent += new EventHandler(OnSave);
            }
        }

        void OnSave(object sender, EventArgs args)
        {
            this.mSettings.SaveProperties(mSettingsPanelView.Properties);
        }
    }
}
