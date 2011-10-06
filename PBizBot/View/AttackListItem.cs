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

    public partial class AttackListItem : UserControl
    {
        private Oponent m_oponent;

        public AttackListItem(Oponent oponent)
        {
            this.m_oponent = oponent;
            InitializeComponent();
        }

        public Oponent Oponent
        {
            get { return this.m_oponent; }
        }

        private void AttackListItem_Load(object sender, EventArgs e)
        {
            this.tbName.Text = m_oponent.Name;
            this.tbAttacker.Text = m_oponent.Attacker.ToString();
        }
    }
}
