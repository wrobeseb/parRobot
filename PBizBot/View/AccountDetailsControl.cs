using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PBizBot.View
{
    using Model;

    public partial class AccountDetailsControl : UserControl
    {
        private Account m_account;

        public Account Account
        {
            get 
            {
                bindForm();
                return this.m_account; 
            }
        }

        private void bindForm()
        {
            m_account.Passwd = tbPasswd.Text;
            m_account.SentMail = cbSentEmail.Checked;
            m_account.Selected = rbSelectedAccount.Checked;
            m_account.Enabled = cbEnabled.Checked;
        }

        public AccountDetailsControl(Account account)
        {
            this.m_account = account;
            InitializeComponent();
        }

        private void tbPasswd_MouseEnter(object sender, EventArgs e)
        {
            tbPasswd.ReadOnly = false;
        }

        private void tbPasswd_MouseLeave(object sender, EventArgs e)
        {
            tbPasswd.ReadOnly = true;
        }

        private void rbSelectedAccount_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSelectedAccount.Checked)
            {
                ControlCollection allAccounts = rbSelectedAccount.Parent.Parent.Controls;

                foreach (Control control in allAccounts)
                {
                    AccountDetailsControl accountDetailsControl = (AccountDetailsControl)control;
                    if (!accountDetailsControl.rbSelectedAccount.Equals(sender))
                    {
                        accountDetailsControl.rbSelectedAccount.Checked = false;
                    }
                }
            }
        }

        private void AccountDetailsControl_Load(object sender, EventArgs e)
        {
            this.cbEnabled.Checked = m_account.Enabled;
            this.cbSentEmail.Checked = m_account.SentMail;
            this.rbSelectedAccount.Checked = m_account.Selected;
            this.tbLogin.Text = m_account.Login;
            this.tbPasswd.Text = m_account.Passwd;
            this.tbCash.Text = m_account.CashAsString;
            this.tbSafe.Text = m_account.SafeAsString;
            this.tbNextLogin.Text = m_account.NextLoginTime.ToString(@"hh\:mm\:ss");
            this.tbMailMessages.Text = m_account.NewMailNo.ToString();
            this.tbHitCount.Text = m_account.HitCount.ToString();
            this.tbAttack.Text = m_account.Attack.ToString();
            this.tbDefense.Text = m_account.Defense.ToString();
        }

        private void cbTransferToAccount_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void lbSettings_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void pbMinus_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Czy napewno chcesz usunąć konto \"" + m_account.Login + "\"?", "Potwierdzenie usunięcia", MessageBoxButtons.YesNo);

            if (result.Equals(DialogResult.Yes))
            {
                this.Parent.Controls.Remove(this);
                this.Dispose();
            }
        }
    }
}
