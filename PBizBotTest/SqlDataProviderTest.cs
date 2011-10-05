using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PBizBotTest
{
    using PBizBot.Utils;
    using PBizBot.Model;
    using PBizBot.Providers;

    [TestClass]
    public class SqlDataProviderTest
    {
        [TestMethod]
        public void initConnectionTest()
        {
            Oponent oponent = new Oponent();
            oponent.Id = 1;
            oponent.Lp = 1;
            oponent.Name = "sairo";
            oponent.GroupName = "sairo";
            oponent.Exp = 1234;
            oponent.Level = LevelUtils.GetLevelByExp(oponent.Exp);
            oponent.Win = 1;
            oponent.Lose = 0;
            oponent.Relics = 0;

            SqlDataProvider.Instance.InsertOponent(oponent);
            SqlDataProvider.Instance.SubmitChanges();
        }
    }
}
