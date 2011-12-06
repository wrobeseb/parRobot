using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParafiaPRO.Service
{
    using Model.Account;

    public interface IAccountService
    {
        List<Account> Accounts();
        void AddAccount(String login, String passwd);
        void RemoveAccount(String login);
    }
}
