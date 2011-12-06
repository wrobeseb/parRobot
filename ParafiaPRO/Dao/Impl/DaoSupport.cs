using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Spring.Objects.Factory;
using System.Data;
using System.Data.Common;

namespace ParafiaPRO.Dao.Impl
{
    using ParafiaPRO.Core;
    using ParafiaPRO.Dao.Core;
    using System.Data.OleDb;

    public abstract class DaoSupport : IInitializingObject
    {
        private Settings mSettings;
        private ParafiaDataContext mSession;

        public ParafiaDataContext Session
        {
            get 
            {
                if (this.mSession.Connection.State == ConnectionState.Closed)
                    this.mSession.Connection.Open();
                return this.mSession; 
            }
        }

        public Settings Settings
        {
            set { this.mSettings = value; }
        }

        public void AfterPropertiesSet()
        {
            mSession = new ParafiaDataContext(new OleDbConnection(mSettings.Default.ConnectionString));
        }
    }
}
