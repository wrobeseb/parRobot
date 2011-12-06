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
    using Model.Account;
    using View;

    public partial class AccountListView : AbstractView, IAccountListView
    {
        public event EventHandler AddAccountEvent;
        public event EventHandler OnLoadEvent;

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
                 //Action(delegate 
                 //{
                     Account account = item.Account;

                     if (item.cbEnabled.Checked)
                     {
                         account.NextLoginTime = TimeSpan.FromSeconds(account.NextLoginTime.TotalSeconds - 1);
                        /* if (account.NextLoginTime != TimeSpan.Zero)
                         {
                             item.pbLight.Image = global::ParafiaPRO.Properties.Resources.green;
                         }
                         else
                         {

                         }*/
                         //item.tbNextLogin.Text = (DateTime.UtcNow - item.Account.SchedulerTrigger.StartTimeUtc).ToString(@"hh\:mm\:ss");
                     }
                     else
                     {
                         account.NextLoginTime = new TimeSpan(0, 0, 5);
                         //item.tbNextLogin.Text = "00:00:00";
                     }

                     item.Account = account;
                // });
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
            if (ValidateFields())
            {
                if (AddAccountEvent != null)
                    AddAccountEvent(this, EventArgs.Empty);
            }
        }

        private void AccountListView_Load(object sender, EventArgs e)
        {
            if (OnLoadEvent != null)
                OnLoadEvent(this, EventArgs.Empty);
        }

        #endregion

        private bool ValidateFields()
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

        public void OnAccountScheduledActions(Account account)
        {
            SetLightImageForAccount(account, global::ParafiaPRO.Properties.Resources.green);
        }


        public void OnAccountUnScheduledActions(Account account)
        {
            SetLightImageForAccount(account, global::ParafiaPRO.Properties.Resources.grey);
        }


        public void OnAccountJobStartedActions(Account account)
        {
            SetLightImageForAccount(account, global::ParafiaPRO.Properties.Resources.spinner16);
        }

        private void SetLightImageForAccount(Account account, Bitmap image)
        {
            foreach (UserControl control in this.pAccounts.Controls)
            {
                AccountListItemView accountListItem = (AccountListItemView)control;
                if (accountListItem.Account.Login.Equals(account.Login))
                {
                    accountListItem.pbLight.Image = image;
                    break;
                }
            }
        }
    }
}
