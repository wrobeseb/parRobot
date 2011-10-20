using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParafiaPRO.View
{
    using Model;

    public interface IAccountListItemView : IView
    {
        event EventHandler RemoveAccountEvent;
        event EventHandler EnabledCheckedChangedEvent;

        Account Account { set; get; }
    }
}
