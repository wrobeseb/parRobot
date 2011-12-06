using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParafiaPRO.Controller
{
    using View;

    public interface ISettingsController
    {
        ISettingsPanelView SettingsPanelView { set; }
    }
}
