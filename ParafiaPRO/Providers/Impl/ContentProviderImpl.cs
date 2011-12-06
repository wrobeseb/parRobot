using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ParafiaPRO.Model.Content;

namespace ParafiaPRO.Providers.Impl
{
    public class ContentProviderImpl : IContentProvider
    {
        public string CSRFContent(Core.Session.Session session)
        {
            return session.GET("http://parafia.biz");
        }

        public string UnitsContent(Core.Session.Session session)
        {
            return session.GET("http://parafia.biz/units");
        }

        public string RelicsContent(Core.Session.Session session)
        {
            return session.GET("http://parafia.biz/relics");
        }

        public string MarketContent(Core.Session.Session session)
        {
            return session.GET("http://parafia.biz/relics/my");
        }

        public string BankContent(Core.Session.Session session)
        {
            return session.GET("http://parafia.biz/bank");
        }

        public string HolyLandContent(Core.Session.Session session)
        {
            return session.GET("http://parafia.biz/units/expeditions");
        }

        public string MailBoxContent(Core.Session.Session session, int pageNo)
        {
            return session.GET("http://parafia.biz/mailbox/index/page/" + pageNo);
        }

        public string QuestContent(Core.Session.Session session)
        {
            return session.GET("http://parafia.biz/quests");
        }

        public string ConcretQuestContent(Core.Session.Session session, string url)
        {
            return session.GET(url);
        }

        public string StatContent(Core.Session.Session session, int pageNo)
        {
            return session.GET("http://parafia.biz/stats/battle/all/page/" + pageNo);
        }

        public string RouletteContent(Core.Session.Session session)
        {
            return session.GET("http://parafia.biz/roulette");
        }

        public string BuildingsContent(Core.Session.Session session)
        {
            return session.GET("http://parafia.biz/buildings");
        }

        public string DashboardContent(Core.Session.Session session)
        {
            return session.GET("http://parafia.biz/dashboard");
        }

        public string GetFromBank(Core.Session.Session session, Transfer transfer)
        {
            return session.GET(transfer.Url);
        }

        public string Logout(Core.Session.Session session)
        {
            return session.GET("http://parafia.biz/auth/logout");
        }

        public string GetFromSafe(Core.Session.Session session, HttpUtils.FormData formData)
        {
            return session.POST("http://parafia.biz/buildings/safe", formData);
        }

        public string PutIntoSafe(Core.Session.Session session, HttpUtils.FormData formData)
        {
            return session.POST("http://parafia.biz/buildings/safe", formData);
        }

        public string SendToHolyLand(Core.Session.Session session, HttpUtils.FormData formData)
        {
            return session.POST("http://parafia.biz/units/to_holy_land", formData);
        }

        public string Login(Core.Session.Session session, HttpUtils.FormData formData)
        {
            return session.POST("http://parafia.biz/", formData);
        }
    }
}
