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
    public partial class AttackList : UserControl
    {
        public AttackList()
        {
            InitializeComponent();
        }

        private void AttackList_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 50; i++)
			{
                AttackListItem listItem = new AttackListItem();
                listItem.Location = new System.Drawing.Point(0, i*19);
                pAttackItems.Controls.Add(listItem);
			}
        }

        private void pbList_Click(object sender, EventArgs e)
        {
            ofdList.ShowDialog();

            if (!String.IsNullOrEmpty(ofdList.FileName))
            {
            }
        }

        private void pbAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
