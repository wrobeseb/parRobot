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

        private IAccountController m_AccountController;
        private IMainController m_MainController;

        #region Getters/Setters

        public UserControl Control
        {
            get { return this; }
        }

        public IAccountController AccountController
        {
            set
            {
                this.m_AccountController = value;
                this.m_AccountController.AccountListView = this;
            }
        }

        public IMainController MainController
        {
            set
            {
                this.m_MainController = value;
                this.m_MainController.AccountListView = this;
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

        public List<Account> Accounts
        {
            get
            {
                List<Account> accounts = new List<Account>();

                foreach (AccountListItemView item in this.pAccounts.Controls)
                    accounts.Add(item.Account);

                return accounts;
            }
        }

        public void UpdateStartTimeForAccounts()
        {
            foreach (AccountListItemView item in this.pAccounts.Controls)
            {
                 Action(delegate 
                 {
                     if (item.cbEnabled.Checked)
                         item.tbNextLogin.Text = (DateTime.UtcNow - item.Account.SchedulerTrigger.StartTimeUtc).ToString(@"hh\:mm\:ss");
                     else
                         item.tbNextLogin.Text = "00:00:00";
                 });
            }
        }

        public void SetStartTimeForAccountToZero()
        {
            foreach (AccountListItemView item in this.pAccounts.Controls)
            {
                if (!item.tbNextLogin.Text.Equals("00:00:00"))
                    Action(delegate { item.tbNextLogin.Text = "00:00:00"; });
            }
        }

        #region Events Handlers

        private void pbAdd_Click(object sender, EventArgs e)
        {
            if (Validate())
            {
                if (AddAccountEvent != null)
                    AddAccountEvent(this, EventArgs.Empty);
            }
        }

        #endregion

        private bool Validate()
        {
            if (String.IsNullOrEmpty(tbLogin.Text) || String.IsNullOrEmpty(tbPasswd.Text))
            {
                MessageBox.Show("Pola \"login\" oraz \"hasło\" nie mogą być puste.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else
            {
                foreach (AccountListItemView item in this.pAccounts.Controls)
                {
                    if (item.tbLogin.Text.Equals(tbLogin.Text))
                    {
                        MessageBox.Show("Konto o podanym loginie istnieje już na liście.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
