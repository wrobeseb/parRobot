using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParafiaPRO.Controller.Impl
{
    using View;
    using Quartz;
    using Service;
    using Scheduler.Job;

    public class MainControllerImpl : AbstractController, IMainController
    {
        private ISchedulerService m_SchedulerService;

        private IControlPanelView m_ControlPanelView;
        private IAccountListView m_AccountListView;

        private TimerJob m_TimerJobObject;

        public TimerJob TimerJobObject
        {
            set
            {
                this.m_TimerJobObject = value;
                this.m_TimerJobObject.MainController = this;
            }
        }

        public ISchedulerService SchedulerService
        {
            set { this.m_SchedulerService = value; }
        }

        public IAccountListView AccountListView
        {
            set { this.m_AccountListView = value; }
        }

        public IControlPanelView ControlPanelView
        {
            set
            {
                this.m_ControlPanelView = value;
                this.m_ControlPanelView.StartStopEvent += new EventHandler(StartStop);
            }
        }

        public bool Started
        {
            get { return m_ControlPanelView.Started; }
        }

        void StartStop(object sender, EventArgs e)
        {
            if (Started)
                m_SchedulerService.ScheduleAccounts(m_AccountListView.Accounts);
            else
                m_SchedulerService.UnScheduleAccounts(m_AccountListView.Accounts);
        }
    }
}
