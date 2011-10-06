using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.OleDb;
using System.Data.Linq;
using System.Text;

using System.Windows.Forms;

namespace PBizBot.Providers
{
    using Model;
    using Database;

    public sealed class SqlDataProvider
    {
        private static volatile SqlDataProvider instance;
        private static object syncRoot = new Object();

        private PBizBotDataContext m_dataContext;

        private SqlDataProvider() 
        {
            m_dataContext = new PBizBotDataContext(new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0; data source=" + Application.ExecutablePath + "Parafia.mdb"));
            //m_dataContext = new PBizBotDataContext(new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0; data source=C:\Users\SAO\Workspace\VS2010\HttpUtils\PBizBot\bin\Debug\Parafia.mdb"));
        }

        public Oponent GetOponentById(int id)
        {
            return (Oponent) from oponents in m_dataContext.Oponents
                             where oponents.Id == id
                             select oponents;
        }

        public void InsertOponent(Oponent oponent)
        {
            m_dataContext.Oponents.InsertOnSubmit(oponent);
        }

        public void SubmitChanges()
        {
            m_dataContext.SubmitChanges();
        }

        public static SqlDataProvider Instance
        {
            get 
            {
                if (instance == null) 
                {
                    lock (syncRoot) 
                    {
                        if (instance == null)
                            instance = new SqlDataProvider();
                    }
                }
                return instance;
            }
        }
    }
}
