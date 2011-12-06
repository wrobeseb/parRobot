using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParafiaPRO.Controller.Impl
{
    using View;
    using Model.Account;
    using Quartz;
    using Service;
    using Scheduler.Job;

    public class MainControllerImpl : AbstractController, IMainController
    {
        private ISchedulerService m_SchedulerService;

        private IControlPanelView m_ControlPanelView;
        private IAccountListView m_AccountListView;

        private Shell mShell;

        private TimerJob m_TimerJobObject;

        public Shell Shell
        {
            set { this.mShell = value; }
        }

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
            set 
            { 
                this.m_SchedulerService = value;
                this.m_SchedulerService.OnSchedule += new EventHandler(OnSchedule);
                this.m_SchedulerService.OnReSchedule += new EventHandler(OnReSchedule);
                this.m_SchedulerService.OnUnSchedule += new EventHandler(OnUnSchedule);
                this.m_SchedulerService.OnJobStarted += new EventHandler(OnJobStarted);
            }
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

        public void OnSchedule(object sender, EventArgs args)
        {
            m_AccountListView.OnAccountScheduledActions((Account)sender);
        }

        public void OnReSchedule(object sender, EventArgs args)
        {
            m_AccountListView.OnAccountScheduledActions((Account)sender);
        }

        public void OnUnSchedule(object sender, EventArgs args)
        {
            m_AccountListView.OnAccountUnScheduledActions((Account)sender);
        }

        public void OnJobStarted(object sender, EventArgs args)
        {
            m_AccountListView.OnAccountJobStartedActions((Account)sender);
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
