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
    public partial class LoggerPanelViewImpl : AbstractView, ILoggerPanelView
    {
        public LoggerPanelViewImpl()
        {
            InitializeComponent();
        }

        public UserControl Control
        {
            get { return this; }
        }

        public void PrintLog(string message)
        {
            Action(delegate
            {
                this.rtbMainLog.AppendText(message);
            });
        }
    }
}
