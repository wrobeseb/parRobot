using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParafiaPRO.Scheduler.Job
{
    using Controller;

    public class TimerJob
    {
        private IAccountController m_accountController;
        private IMainController m_mainController;

        public IAccountController AccountController
        {
            set { this.m_accountController = value; }
        }

        public IMainController MainController
        {
            set { this.m_mainController = value; }
        }

        public void RunProcess()
        {
            if (m_mainController.Started)
                m_accountController.UpdateStartTimeForAccounts();
            //else
                //m_accountController.SetStartTimeForAccountToZero();
        }
    }
}
