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
            get { return this.m_account; }
        }

        public AccountDetailsControl(Account account)
        {
            this.m_account = account;
            InitializeComponent();
        }

        private void rbRootAccount_CheckedChanged(object sender, EventArgs e)
        {
            if (rbRootAccount.Checked)
            {
                ControlCollection allAccounts = rbRootAccount.Parent.Parent.Parent.Controls;

                foreach (Control control in allAccounts)
                {
                    AccountDetailsControl accountDetailsControl = (AccountDetailsControl)control;
                    if (!accountDetailsControl.rbRootAccount.Equals(sender))
                    {
                        accountDetailsControl.rbRootAccount.Checked = false;
                    }
                }
            }
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
            this.cbAttack.Checked = m_account.Attacker;
            this.rbSelectedAccount.Checked = m_account.Selected;
            this.rbRootAccount.Checked = m_account.RootAccount;
          
        }
    }
}
