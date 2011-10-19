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
    using View;

    public partial class AccountListView : AbstractView, IAccountListView
    {
        public event EventHandler AddAccountEvent;

        private IAccountController m_accountController;

        #region Getters/Setters

        public IAccountController AccountController
        {
            set
            {
                this.m_accountController = value;
            }
        }

        public string login
        {
            get 
            {
                String value = String.Empty;
                Action(delegate
                {
                    value = tbLogin.Text; 
                });
                return value;
            }
        }

        public string passwd
        {
            get 
            {
                String value = String.Empty;
                Action(delegate
                {
                    value = tbPasswd.Text;
                });
                return value;
            }
        }

        #endregion

        public AccountListView()
        {
            InitializeComponent();
        }

        #region Events Handlers

        private void pbAdd_Click(object sender, EventArgs e)
        {
            if (AddAccountEvent != null)
                AddAccountEvent(this, EventArgs.Empty);
        }

        private void pAccounts_ControlAdded(object sender, ControlEventArgs e)
        {
            
        }

        private void pAccounts_ControlRemoved(object sender, ControlEventArgs e)
        {

        }

        #endregion
    }
}
