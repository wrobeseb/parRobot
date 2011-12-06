using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParafiaPRO.Controller
{
    using View;

    public interface IMainController
    {
        Shell Shell { set; }

        IControlPanelView ControlPanelView { set; }
        IAccountListView AccountListView { set; }
        bool Started { get; }
    }
}
