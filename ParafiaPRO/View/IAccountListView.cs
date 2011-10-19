using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParafiaPRO.View
{
    using View;

    public interface IAccountListView : IView
    {
        event EventHandler AddAccountEvent;

        string Login { get; }
        string Passwd { get; }

        void AddAccountListItemView(IAccountListItemView accountListItemView);
        void RemoveAccountListItemView(IAccountListItemView accountListItemView);
    }
}
