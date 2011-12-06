using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParafiaPRO.Service.Impl
{
    using Dao;
    using System.Transactions;
    using Model.Account;

    public class AccountServiceImpl : IAccountService
    {
        private IAccountDao mAccountDao;

        public IAccountDao AccountDao
        {
            set { this.mAccountDao = value; }
        }

        public List<Account> Accounts()
        {
            return mAccountDao.Accounts();
        }

        public void AddAccount(string login, string passwd)
        {
            throw new NotImplementedException();
        }

        public void RemoveAccount(string login)
        {
            throw new NotImplementedException();
        }
    }
}
