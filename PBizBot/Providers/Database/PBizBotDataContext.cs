using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Text;
using System.Data.OleDb;

namespace PBizBot.Providers.Database
{
    using Model;

    public class PBizBotDataContext : DataContext
    {
        public Table<Oponent> Oponents;

        public PBizBotDataContext(OleDbConnection connection) : base(connection) { }
    }
}
