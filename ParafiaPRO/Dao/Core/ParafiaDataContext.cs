using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq;
using System.Data.OleDb;

namespace ParafiaPRO.Dao.Core
{
    using Model.Account;

    public partial class ParafiaDataContext : DataContext
    {
        public Table<Account> Accounts;



        public ParafiaDataContext(OleDbConnection connection) : base(connection) { }
    }
}
