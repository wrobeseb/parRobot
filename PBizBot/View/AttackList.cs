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
    using Providers;
    using Model;

    public partial class AttackList : UserControl
    {
        private SqlDataProvider m_sqlDataProvider;

        private List<AttackListItem> m_attackListItems;

        private Boolean m_attackerSortAsc = true;
        private Boolean m_nameSortAsc = true;
        private Boolean m_cashSortAsc = true;
        private Boolean m_winSortAsc = true;
        private Boolean m_loseSortAsc = true;
        private Boolean m_lastAttackSortAsc = true;

        public SqlDataProvider SqlDataProvider
        {
            set { m_sqlDataProvider = value; }
        }

        public AttackList()
        {
            m_attackListItems = new List<AttackListItem>();
            InitializeComponent();
        }

        private void AttackList_Load(object sender, EventArgs e)
        {
            List<Oponent> oponents = m_sqlDataProvider.GetOponents();
            foreach (Oponent oponent in oponents)
	        {
                m_attackListItems.Add(new AttackListItem(oponent));
            }
        }

        private void pbAdd_Click(object sender, EventArgs e)
        {
            renderItems();
        }

        private void pbAttackerSort_Click(object sender, EventArgs e)
        {
            if (m_attackerSortAsc)
            {
                m_attackListItems.Sort(delegate(AttackListItem o1, AttackListItem o2) { return o1.Oponent.Attacker.CompareTo(o2.Oponent.Attacker); });
                m_attackerSortAsc = false;
            }
            else
            {
                m_attackListItems.Sort(delegate(AttackListItem o1, AttackListItem o2) { return o2.Oponent.Attacker.CompareTo(o1.Oponent.Attacker); });
                m_attackerSortAsc = true;
            }

            renderItems();
        }

        private void pbNameSort_Click(object sender, EventArgs e)
        {
            if (m_nameSortAsc)
            {
                m_attackListItems.Sort(delegate(AttackListItem o1, AttackListItem o2) { return o1.Oponent.Name.CompareTo(o2.Oponent.Name); });
                m_nameSortAsc = false;
            }
            else
            {
                m_attackListItems.Sort(delegate(AttackListItem o1, AttackListItem o2) { return o2.Oponent.Name.CompareTo(o1.Oponent.Name); });
                m_nameSortAsc = true;
            }

            renderItems();
        }

        private void pbCashSort_Click(object sender, EventArgs e)
        {

        }

        private void pbWinSort_Click(object sender, EventArgs e)
        {

        }

        private void pbLoseSort_Click(object sender, EventArgs e)
        {

        }

        private void pbLastAttackSort_Click(object sender, EventArgs e)
        {

        }

        public void renderItems()
        {
            pAttackItems.Controls.Clear();
            int index = 0;
            foreach (AttackListItem item in m_attackListItems)
	        {
                item.Location = new Point(0, index * 14);
                pAttackItems.Controls.Add(item);
                index++;
	        }
        }
    }
}
