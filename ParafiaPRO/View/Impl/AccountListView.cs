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
    using Model;
    using View;

    public partial class AccountListView : AbstractView, IAccountListView
    {
        public event EventHandler AddAccountEvent;

        private IAccountController m_accountController;

        #region Getters/Setters

        public UserControl Control
        {
            get { return this; }
        }

        public IAccountController AccountController
        {
            set
            {
                this.m_accountController = value;
                this.m_accountController.AccountListView = this;
            }
        }

        public string Login
        {
            get 
            {
                String value = String.Empty;
                Action(delegate { value = tbLogin.Text; });
                return value;
            }
        }

        public string Passwd
        {
            get 
            {
                String value = String.Empty;
                Action(delegate { value = tbPasswd.Text; });
                return value;
            }
        }

        #endregion

        public AccountListView()
        {
            InitializeComponent();
        }

        public void AddAccountListItemView(IAccountListItemView accountListItemView)
        {
            UserControl item = accountListItemView.Control;
            item.Location = new Point(0, 22 * this.pAccounts.Controls.Count);
            Action(delegate 
            { 
                this.pAccounts.Controls.Add(item);
                this.tbLogin.Text = String.Empty;
                this.tbPasswd.Text = String.Empty;
            });
        }

        public void RemoveAccountListItemView(IAccountListItemView accountListItemView)
        {
            
            if (this.pAccounts.Controls.Contains(accountListItemView.Control))
            {
                Action(delegate { this.pAccounts.Controls.Remove(accountListItemView.Control); });

                int position = 0;
                foreach (UserControl item in this.pAccounts.Controls)
                {
                    Action(delegate { item.Location = new Point(0, position); });
                    position += 22;
                }
            }
        }

        #region Events Handlers

        private void pbAdd_Click(object sender, EventArgs e)
        {
            if (AddAccountEvent != null)
                AddAccountEvent(this, EventArgs.Empty);
        }

        #endregion
    }
}
