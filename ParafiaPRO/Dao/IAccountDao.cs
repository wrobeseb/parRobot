using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParafiaPRO.Dao
{
    using Model.Account;

    public interface IAccountDao
    {
        Account AccountById(int id);
        List<Account> Accounts();
    }
}
