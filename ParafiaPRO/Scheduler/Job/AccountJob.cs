using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ParafiaPRO.Scheduler.Job
{
    using Model.Account;
    using Service;
    using Core;
    using log4net;
    using ParafiaPRO.Core.Session;
    using Spring.Context;
    using Spring.Objects.Factory;

    public class AccountJob : IInitializingObject
    {
        private static ILog log = LogManager.GetLogger(typeof(AccountJob));

        private Account mAccount;
        private ISchedulerService mSchedulerService;
        private IHttpService mHttpService;
        private Session mSession;

        public Account Account
        {
            set { this.mAccount = value; }
        }

        public ISchedulerService SchedulerService
        {
            set { this.mSchedulerService = value; }
        }

        public IHttpService HttpService
        {
            set { this.mHttpService = value; }
        }

        public Session Session
        {
            set { this.mSession = value; }
        }

        public void RunProcess()
        {
            // TODO
            log.Info("Start akcji dla: " + mAccount.Login);

            mSchedulerService.JobStarted(mAccount);

            mHttpService.Login(mSession);

            mHttpService.UpdateAttributes(mSession);

            mHttpService.Logout(mSession);
           
            //Thread.Sleep(10000);

            this.mAccount.NextLoginTime = TimeSpan.FromSeconds(new Random().Next(400, 500));

            mSchedulerService.ReScheduleAccount(this.mAccount, DateTime.UtcNow.AddTicks(this.mAccount.NextLoginTime.Ticks));
            log.Info("Koniec akcji dla: " + mAccount.Login);
        }
    
        public void AfterPropertiesSet()
        {
            this.mSession.Account = this.mAccount;
        }
    }
}
