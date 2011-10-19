using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParafiaPRO.Service
{
    public interface IAccountService
    {
        void AddAccount(String login, String passwd);
        void RemoveAccount(String login);
    }
}
