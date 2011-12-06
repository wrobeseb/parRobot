using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParafiaPRO.Dao.Impl
{
    using Model.Account;

    public class AccountDaoImpl : DaoSupport, IAccountDao
    {
        public Account AccountById(int id)
        {
            return Session.Accounts.Single(account => account.Id == id);
        }

        public List<Account> Accounts()
        {


            return Session.Accounts.ToList();
        }
    }
}
