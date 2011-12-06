using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ParafiaPRO.Model.Content;
using ParafiaPRO.Core.Session;
using HttpUtils;

namespace ParafiaPRO.Providers
{
    public interface IContentProvider
    {
        String CSRFContent(Session session);
        String UnitsContent(Session session);
        String RelicsContent(Session session);
        String MarketContent(Session session);
        String BankContent(Session session);
        String HolyLandContent(Session session);
        String MailBoxContent(Session session, int pageNo);
        String QuestContent(Session session);
        String ConcretQuestContent(Session session, String url);
        String StatContent(Session session, int pageNo);
        String RouletteContent(Session session);
        String BuildingsContent(Session session);
        String DashboardContent(Session session);
        String GetFromBank(Session session, Transfer transfer);
        String Logout(Session session);

        String GetFromSafe(Session session, FormData formData);
        String PutIntoSafe(Session session, FormData formData);
        String SendToHolyLand(Session session, FormData formData);
        String Login(Session session, FormData formData);
    }
}
