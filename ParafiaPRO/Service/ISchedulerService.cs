using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParafiaPRO.Service
{
    using Model;

    public interface ISchedulerService
    {
        void ReScheduleAccount(Account account, DateTime nextLoginTime);
        void ScheduleAccounts(List<Account> accounts);
        void ScheduleAccount(Account account, DateTime nextLoginTime);
        void UnScheduleAccounts(List<Account> accounts);
        void UnScheduleAccount(Account account);
    }
}
