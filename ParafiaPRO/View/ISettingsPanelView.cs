using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParafiaPRO.View
{
    using Core.Properties;

    public interface ISettingsPanelView : IView
    {
        event EventHandler OnSaveEvent;

        Properties Properties { set; get; }
    }
}
