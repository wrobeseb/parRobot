using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.IO;

using Parafia.Properties;
using Parafia.Model.Quest;

namespace Parafia
{

    using Model.Stat;

    public partial class MainForm : Form
    {
        private Worker worker;
        private List<Thread> threadList;

        public MainForm()
        {
            InitializeComponent();
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            btStart.Enabled = false;
            btStop.Enabled = true;
            //notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIconEnabled")));
            worker.StartUpTime();
        }

        private void btStop_Click(object sender, EventArgs e)
        {
            btStart.Enabled = true;
            btStop.Enabled = false;
            //notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIconDisabled")));
            worker.StopUpTime();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            worker = new Worker(this);
            worker.setMainWindowTitle();
            worker.fillQuestsList();
            worker.GetServerTime();
            threadList = new List<Thread>();

            Thread systemTimeThread = new Thread(worker.renderSystemTime);
            systemTimeThread.Name = "SystemTimeThread";
            systemTimeThread.Start();

            Thread mainWorkThread = new Thread(worker.startMainWork);
            mainWorkThread.Name = "MainWorkThread";
            mainWorkThread.Start();

            Thread questWorkThread = new Thread(worker.doQuestWork);
            questWorkThread.Name = "QuestWorkThread";
            questWorkThread.Start();

            Thread relicsWorkThread = new Thread(worker.buyRelics);
            relicsWorkThread.Name = "RelicsWorkThread";
            relicsWorkThread.Start();

            Thread onlyAttackThread = new Thread(worker.onlyAttackWork);
            onlyAttackThread.Name = "OnlyAttackThread";
            onlyAttackThread.Start();

            threadList.Add(systemTimeThread);
            threadList.Add(mainWorkThread);
            threadList.Add(questWorkThread);
            threadList.Add(relicsWorkThread);
            threadList.Add(onlyAttackThread);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            worker.StopAllThreads();

            /*foreach (Thread thread in threadList)
            {
                thread.Join();
            }*/
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void bConfig_Click(object sender, EventArgs e)
        {
            ConfigForm configForm = new ConfigForm();
            configForm.ShowDialog();
            worker.setMainWindowTitle();
        }

        private void bQuestRefresh_Click(object sender, EventArgs e)
        {
            pQuestsButtons.Enabled = false;
            lvQuests.Enabled = false;
            Thread questsRefreshThread = new Thread(worker.questRefreshWork);
            questsRefreshThread.Name = "QuestsRefreshThread";
            questsRefreshThread.Start();
        }

        private void bQuestOn_Click(object sender, EventArgs e)
        {
            bQuestOn.Enabled = false;
            bQuestOff.Enabled = true;
            worker.StartUpQuests();
        }

        private void bQuestOff_Click(object sender, EventArgs e)
        {
            bQuestOn.Enabled = true;
            bQuestOff.Enabled = false;
            worker.StopQuests();
        }

        private void btRelicsOn_Click(object sender, EventArgs e)
        {
            btRelicsOff.Enabled = true;
            btRelicsOn.Enabled = false;
            worker.StartRelics();
        }

        private void btRelicsOff_Click(object sender, EventArgs e)
        {
            btRelicsOff.Enabled = false;
            btRelicsOn.Enabled = true;
            worker.StopRelics();
        }

        private void btAttackOFF_Click(object sender, EventArgs e)
        {
            btAttackON.Enabled = true;
            btAttackOFF.Enabled = false;
            worker.StopAttack();
        }

        private void btAttackON_Click(object sender, EventArgs e)
        {
            btAttackON.Enabled = false;
            btAttackOFF.Enabled = true;
            worker.StartAttack();
        }

        private void btAttackFile_Click(object sender, EventArgs e)
        {
            ofdAttackFile.ShowDialog();
            String fileName = ofdAttackFile.FileName;

            TextReader reader = new StreamReader(fileName, Encoding.GetEncoding("Windows-1250"));

            String line;

            lvAttackList.Items.Clear();

            while (!String.IsNullOrEmpty(line = reader.ReadLine()))
            {
                Account account = new Account(line);
                if (account.Id != 0)
                    worker.listOfAccountsInView.Add(account);
            }

            reader.Close();

            worker.listOfAccountsInView.Sort();

            foreach (Account account in worker.listOfAccountsInView)
            {
                if (account.Id != 0)
                {
                    ListViewItem item = new ListViewItem();
                    item.Tag = account;
                    ListViewItem.ListViewSubItem siId = new ListViewItem.ListViewSubItem(item, new StringBuilder().Append(account.Id).ToString());
                    ListViewItem.ListViewSubItem siName = new ListViewItem.ListViewSubItem(item, account.UserName);
                    ListViewItem.ListViewSubItem siCash = new ListViewItem.ListViewSubItem(item, new StringBuilder().Append(account.Cash).ToString());
                    ListViewItem.ListViewSubItem siNo = new ListViewItem.ListViewSubItem(item, new StringBuilder().Append(account.DefeatHits).ToString());

                    item.Checked = account.IsChecked;

                    item.SubItems.Add(siId);
                    item.SubItems.Add(siName);
                    item.SubItems.Add(siCash);
                    item.SubItems.Add(siNo);
                    lvAttackList.Items.Add(item);

                    
                }
            }
        }

        private void btAttackAdd_Click(object sender, EventArgs e)
        {
            ListView.ListViewItemCollection collection = lvAttackList.Items;
            Boolean flag = false;
            foreach (ListViewItem item in collection)
            {
                if (item.SubItems[1].Text.Equals(tbAttackName.Text))
                {
                    flag = true;
                    break;
                }
            }
            if (!flag)
            {
                ListViewItem item = new ListViewItem();
                ListViewItem.ListViewSubItem siName = new ListViewItem.ListViewSubItem(item, tbAttackName.Text);
                ListViewItem.ListViewSubItem siCash = new ListViewItem.ListViewSubItem(item, "0");
                ListViewItem.ListViewSubItem siNo = new ListViewItem.ListViewSubItem(item, "0");

                item.Checked = true;

                item.SubItems.Add(siName);
                item.SubItems.Add(siCash);
                item.SubItems.Add(siNo);
                lvAttackList.Items.Add(item);
            }
            else
            {
                MessageBox.Show("Uzytkownik jest juz na liscie...");
            }
        }

        private void btAttackRemove_Click(object sender, EventArgs e)
        {
            ListView.ListViewItemCollection collection = lvAttackList.Items;
            foreach (ListViewItem item in collection)
            {
                if (item.SubItems[1].Text.Equals(tbAttackName.Text))
                {
                    lvAttackList.Items.Remove(item);
                    break;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            worker.downloadStats();
        }

    }
}
