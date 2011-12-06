using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParafiaPRO.View
{
    public interface ILoggerPanelView : IView
    {
        void PrintLog(String message);
    }
}
