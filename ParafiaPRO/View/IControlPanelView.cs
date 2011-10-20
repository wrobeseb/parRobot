using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParafiaPRO.View
{
    public interface IControlPanelView : IView
    {
        event EventHandler StartStopEvent;

        bool Started { get; set; }
    }
}
