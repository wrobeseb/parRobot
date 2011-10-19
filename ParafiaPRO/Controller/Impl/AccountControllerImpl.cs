using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace ParafiaPRO.Controller.Impl
{
    using View;

    public class AccountControllerImpl : AbstractController, IAccountController
    {
        private IAccountListView m_accountListView;

        public IAccountListView AccountListView
        {
            set 
            {
                this.m_accountListView = value;
                this.m_accountListView.AddAccountEvent += new EventHandler(AddAccount);
            }
        }

        void AddAccount(object sender, EventArgs e)
        {
            Debug.Assert(m_accountListView != null, "view not attached");

        }
    }
}
