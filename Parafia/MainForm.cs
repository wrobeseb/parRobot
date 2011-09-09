using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

using Parafia.Properties;
using Parafia.Model.Quest;
using System.IO;

namespace Parafia
{
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

            threadList.Add(systemTimeThread);
            threadList.Add(mainWorkThread);
            threadList.Add(questWorkThread);
            threadList.Add(relicsWorkThread);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            worker.StopAllThreads();

            foreach (Thread thread in threadList)
            {
                thread.Join();
            }
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void bConfig_Click(object sender, EventArgs e)
        {
            ConfigForm configForm = new ConfigForm();
            configForm.ShowDialog();
            
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

        private void btAttackList_Click(object sender, EventArgs e)
        {
            ofdAttackList.ShowDialog();
            String fileName = ofdAttackList.FileName;

            if (!String.IsNullOrEmpty(fileName))
            {
                TextReader reader = new StreamReader(fileName);

                lvAttackList.Items.Clear();

                String line;
                while (!String.IsNullOrEmpty((line = reader.ReadLine())))
                {
                    ListViewItem item = new ListViewItem();
                    ListViewItem.ListViewSubItem siName = new ListViewItem.ListViewSubItem(item, line);
                    ListViewItem.ListViewSubItem siCash = new ListViewItem.ListViewSubItem(item, "0");

                    item.SubItems.Add(siName);
                    item.SubItems.Add(siCash);

                    item.Checked = true;

                    lvAttackList.Items.Add(item);
                }

                reader.Close();
            }
        }

        private void btAttackOn_Click(object sender, EventArgs e)
        {

        }

        private void btAttackOFF_Click(object sender, EventArgs e)
        {

        }
    }
}
