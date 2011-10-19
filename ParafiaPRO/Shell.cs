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
    using View.Impl;

    public partial class Shell : Form
    {
        private AccountListView m_accountListView;

        public AccountListView AccountListView
        {
            set { this.m_accountListView = value; }
        }

        public Shell()
        {
            InitializeComponent();
        }

        private void Shell_Load(object sender, EventArgs e)
        {
            this.Controls.Add(m_accountListView);
        }
    }
}
