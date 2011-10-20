using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ParafiaPRO
{
    using View;

    public partial class Shell : Form
    {
        private IAccountListView m_AccountListView;
        private IControlPanelView m_ControlPanelView;

        public IAccountListView AccountListView
        {
            set { this.m_AccountListView = value; }
        }

        public IControlPanelView ControlPanelView
        {
            set { this.m_ControlPanelView = value; }
        }

        public Shell()
        {
            InitializeComponent();
        }

        private void Shell_Load(object sender, EventArgs e)
        {
            this.AccountRegion.Controls.Add(m_AccountListView.Control);
            this.ControlPanelRegion.Controls.Add(m_ControlPanelView.Control);
        }
    }
}
