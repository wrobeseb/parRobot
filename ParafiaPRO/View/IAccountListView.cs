using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParafiaPRO.View
{
    public interface IAccountListView
    {
        event EventHandler AddAccountEvent;

        string login { get; }
        string passwd { get; }

    }
}
