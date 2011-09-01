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
            Object obj = Settings.Default["quests"];
            if (obj != null)
            {
                QuestContainer container = (QuestContainer)obj;
                foreach (Quest quest in container.GetAllQuests)
                {
                    ListViewItem item = new ListViewItem();
                    ListViewItem.ListViewSubItem siName = new ListViewItem.ListViewSubItem(item, quest.Name);
                    ListViewItem.ListViewSubItem siProgress = new ListViewItem.ListViewSubItem(item, quest.GetProgress().ToString("F2") + " %");

                    item.SubItems.Add(siName);
                    item.SubItems.Add(siProgress);

                    lvQuests.Items.Add(item);
                }
            }

            worker = new Worker(this);
            threadList = new List<Thread>();

            Thread systemTimeThread = new Thread(worker.renderSystemTime);
            systemTimeThread.Name = "SystemTimeThread";
            systemTimeThread.Start();

            Thread mainWorkThread = new Thread(worker.startMainWork);
            mainWorkThread.Name = "MainWorkThread";
            mainWorkThread.Start();

            threadList.Add(systemTimeThread);
            threadList.Add(mainWorkThread);
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
    }
}
