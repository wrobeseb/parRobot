using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParafiaPRO.View
{
    using View;
    using Model.Account;

    public interface IAccountListView : IView
    {
        event EventHandler AddAccountEvent;
        event EventHandler OnLoadEvent;

        string Login { get; }
        string Passwd { get; }

        List<Account> Accounts { get; }

        void UpdateStartTimeForAccounts();
        void SetStartTimeForAccountToZero();

        void AddAccountListItemView(IAccountListItemView accountListItemView);
        void RemoveAccountListItemView(IAccountListItemView accountListItemView);

        void OnAccountScheduledActions(Account account);
        void OnAccountUnScheduledActions(Account account);
        void OnAccountJobStartedActions(Account account);
    }
}
