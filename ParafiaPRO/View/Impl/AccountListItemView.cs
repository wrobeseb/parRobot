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
    using Model.Account;

    public partial class AccountListItemView : AbstractView, IAccountListItemView
    {
        public event EventHandler RemoveAccountEvent;
        public event EventHandler EnabledCheckedChangedEvent;

        private Account m_account;

        public Account Account
        {
            set 
            {
               this.m_account = value;
               Action(delegate
               {
                   this.tbLogin.Text = this.m_account.Login;
                   this.tbPasswd.Text = this.m_account.Passwd;
                   this.cbEnabled.Checked = this.m_account.Enabled;
                   this.cbSentEmail.Checked = m_account.SentMail;
                   this.rbSelectedAccount.Checked = m_account.Selected;
                   this.tbLogin.Text = m_account.Login;
                   this.tbPasswd.Text = m_account.Passwd;
                   this.tbNextLogin.Text = m_account.NextLoginTime.ToString(@"hh\:mm\:ss");
                   this.tbHitCount.Text = m_account.HitCount.ToString();
               });
            }
            get 
            {
                Action(delegate
                {
                    this.m_account.Login = this.tbLogin.Text;
                    this.m_account.Passwd = this.tbPasswd.Text;
                    this.m_account.Enabled = this.cbEnabled.Checked;
                    this.m_account.SentMail = this.cbSentEmail.Checked;
                    this.m_account.Selected = this.rbSelectedAccount.Checked;
                    this.m_account.Login = this.tbLogin.Text;
                    this.m_account.Passwd = this.tbPasswd.Text;
                });
                return this.m_account; 
            }
        }

        public UserControl Control
        {
            get { return this; }
        }

        public AccountListItemView()
        {
            InitializeComponent();
        }

        private void tbPasswd_MouseEnter(object sender, EventArgs e)
        {
           
        }

        private void tbPasswd_MouseLeave(object sender, EventArgs e)
        {

        }

        private void rbSelectedAccount_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void cbTransferToAccount_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void pbMinus_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Czy napewno chcesz usunąć konto \"" + m_account.Login + "\"?", "Potwierdzenie usunięcia", MessageBoxButtons.YesNo);

            if (result.Equals(DialogResult.Yes))
                if (RemoveAccountEvent != null)
                    RemoveAccountEvent(this, EventArgs.Empty);
        }

        private void cbEnabled_CheckedChanged(object sender, EventArgs e)
        {
            if (EnabledCheckedChangedEvent != null)
                EnabledCheckedChangedEvent(this, EventArgs.Empty);
        }
    }
}
