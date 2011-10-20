using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ParafiaPRO.View.Impl
{
    using Controller;

    public partial class ControlPanelView : AbstractView, IControlPanelView
    {
        public event EventHandler StartStopEvent;

        private IMainController m_MainController;

        public IMainController MainController
        {
            set
            {
                this.m_MainController = value;
                this.m_MainController.ControlPanelView = this;
            }
        }

        public new UserControl Control
        {
            get { return this; }
        }

        public bool Started
        {
            get
            {
                bool started = false;
                Action(delegate
                {
                    started = !btStart.Enabled;
                });
                return started;
            }
            set
            {
                Action(delegate
                {
                    if (value)
                    {
                        btStart.Enabled = false;
                        btStop.Enabled = true;
                    }
                    else
                    {
                        btStart.Enabled = true;
                        btStop.Enabled = false;
                    }
                });
            }
        }

        public ControlPanelView()
        {
            InitializeComponent();
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            Started = true;
            InvokeStartStopEvent();
        }

        private void btStop_Click(object sender, EventArgs e)
        {
            Started = false;
            InvokeStartStopEvent();
        }

        private void InvokeStartStopEvent()
        {
            if (StartStopEvent != null)
                StartStopEvent(this, EventArgs.Empty);
        }
    }
}
