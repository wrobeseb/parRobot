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
    using System.Net;
    using System.Threading.Tasks;

    public partial class MainForm : Form
    {
        private Worker worker;
        private List<Thread> threadList;
        public QuestContainer questContainer;

        public MainForm()
        {
            InitializeComponent();
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            btStart.Enabled = false;
            btStop.Enabled = true;

            if (cbClient.Checked)
            {
                btAttackON_Click(sender, e);
            }

            //notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIconEnabled")));
            worker.StartUpTime();
        }

        private void btStop_Click(object sender, EventArgs e)
        {
            btStart.Enabled = true;
            btStop.Enabled = false;

            if (cbClient.Checked)
            {
                btAttackOFF_Click(sender, e);
            }

            //notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIconDisabled")));
            worker.StopUpTime();
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            ApplicationConfig config = new ApplicationConfig();

            object obj = Settings.Default["properties"];

            if (obj != null)
            {
                config = (ApplicationConfig)obj;
            }
            if (String.IsNullOrEmpty(config.ProxyUser))
            {
                config.ProxyDomain = "TP";
                config.ProxyHost = "126.179.0.200";
                config.ProxyPort = 3128;
            }

            if (String.IsNullOrEmpty(config.SmtpTo))
            {
                config.SmtpAccount = "TP\\zz_sezam";
                config.SmtpAccountPasswd = "4esz%RDX";
                config.SmtpEnableSSL = true;
                config.SmtpPort = 587;
                config.SmtpHost = "smtp.poczta.tepenet";
            }

            if (String.IsNullOrEmpty(config.ProxyUser) || String.IsNullOrEmpty(config.SmtpTo))
            {
                Settings.Default["properties"] = config;
                Settings.Default.Save();
            }

            worker = new Worker(this);
            worker.setMainWindowTitle();
            Object questsObj = Settings.Default["quests"];
            if (questsObj != null)
            {
                questContainer = (QuestContainer)questsObj;
                fillQuestList(questContainer);
            }
            //worker.fillQuestsList();
            worker.GetServerTime();
            threadList = new List<Thread>();

            Thread systemTimeThread = new Thread(worker.renderSystemTime);
            systemTimeThread.Name = "SystemTimeThread";
            systemTimeThread.Start();

            Thread mainWorkThread = new Thread(worker.startMainWork);
            mainWorkThread.Name = "MainWorkThread";
            mainWorkThread.Start();

           /* Thread questWorkThread = new Thread(worker.doQuestWork);
            questWorkThread.Name = "QuestWorkThread";
            questWorkThread.Start();

            Thread relicsWorkThread = new Thread(worker.buyRelics);
            relicsWorkThread.Name = "RelicsWorkThread";
            relicsWorkThread.Start();
            */
            Thread onlyAttackThread = new Thread(worker.onlyAttackWork);
            onlyAttackThread.Name = "OnlyAttackThread";
            onlyAttackThread.Start();

            /*Thread safeCashActionThread = new Thread(worker.safeCashAction);
            safeCashActionThread.Name = "SafeCashActionThread";
            safeCashActionThread.Start();*/

            threadList.Add(systemTimeThread);
            threadList.Add(mainWorkThread);
            //threadList.Add(questWorkThread);
            //threadList.Add(relicsWorkThread);
            threadList.Add(onlyAttackThread);
            //threadList.Add(safeCashActionThread);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            worker.StopAllThreads();

            /*foreach (Thread thread in threadList)
            {
                thread.
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

            Thread questsRefreshThread = new Thread(worker.questRefreshWork);
            questsRefreshThread.Name = "QuestsRefreshThread";
            questsRefreshThread.Start();
        }

        private void btRelicsOn_Click(object sender, EventArgs e)
        {

            worker.StartRelics();
        }

        private void btRelicsOff_Click(object sender, EventArgs e)
        {

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
                    ListViewItem.ListViewSubItem siWinNo = new ListViewItem.ListViewSubItem(item, new StringBuilder().Append(account.WinHits).ToString());
                    ListViewItem.ListViewSubItem siDefeatNo = new ListViewItem.ListViewSubItem(item, new StringBuilder().Append(account.DefeatHits).ToString());
                    ListViewItem.ListViewSubItem siLastAttack = new ListViewItem.ListViewSubItem(item, "brak danych");

                    item.Checked = account.IsChecked;

                    item.SubItems.Add(siId);
                    item.SubItems.Add(siName);
                    item.SubItems.Add(siCash);
                    item.SubItems.Add(siWinNo);
                    item.SubItems.Add(siDefeatNo);
                    item.SubItems.Add(siLastAttack);
                    lvAttackList.Items.Add(item);

                    
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sfdStatsFile.ShowDialog();
            if (!String.IsNullOrEmpty(sfdStatsFile.FileName))
                worker.downloadStats(sfdStatsFile.FileName);
        }

        private void cbHoldSession_CheckedChanged(object sender, EventArgs e)
        {
            if (cbHoldSession.Checked)
            {
                worker.StartHoldingSession();
            }
            else
            {
                worker.StopHoldingSession();
            }
        }

        private void cbServer_CheckedChanged(object sender, EventArgs e)
        {
            if (cbServer.Checked)
            {
                cbClient.Enabled = false;
                worker.serverSemafor = true;
                niMain.Visible = true;
            }
            else
            {
                cbClient.Enabled = true;
                worker.serverSemafor = false;
                niMain.Visible = false;
            }
        }

        private void cbClient_CheckedChanged(object sender, EventArgs e)
        {
            if (cbClient.Checked)
            {
                cbServer.Enabled = false;
                worker.clientSemafor = true;
            }
            else
            {
                cbServer.Enabled = true;
                worker.clientSemafor = false;
            }
        }

        private void niMain_DoubleClick(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            this.BringToFront();
        }

        private void tssSafe_Click(object sender, EventArgs e)
        {
            tssSafe.ForeColor = Color.Black;
        }

        private void tssCash_Click(object sender, EventArgs e)
        {
            tssCash.ForeColor = Color.Black;
        }

        private void btTransferRun_Click(object sender, EventArgs e)
        {
            btTransferRun.Enabled = false;
            Thread transferMoneyThread = new Thread(worker.transferMoney);
            transferMoneyThread.Name = "TransferMoneyThread";
            transferMoneyThread.Start();
        }


        private void fillQuestList(QuestContainer questContainer)
        {
            List<Quest> listOfSelectedQuest = new List<Quest>();
            foreach (Quest quest in questContainer.GetAllQuests)
            {
                bool flag = false;
                foreach (ListViewItem item in lvSelectedQuests.Items)
                {
                    if (item.Text.Equals(quest.Name))
                    {
                        flag = true;
                        break;
                    }
                }
                foreach (ListViewItem item in lvQuests.Items)
                {
                    if (item.Text.Equals(quest.Name))
                    {
                        flag = true;
                        break;
                    }
                }
                if (!flag)
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = quest.Name;
                    if (!quest.IsChecked)
                        lvQuests.Items.Add(item);
                    else
                    {
                        listOfSelectedQuest.Add(quest);
                    }
                }
            }
            listOfSelectedQuest.Sort();
            //foreach (Quest quest in listOfSelectedQuest)
//lvSelectedQuests.Items.Insert(quest.Priority - 1, new ListViewItem(quest.Name));
        }

        private void pbRefresh_Click(object sender, EventArgs e)
        {
            pbRefresh.Enabled = false;
            new Thread(new ThreadStart(delegate
            {
                Parafia parafia = worker.getInstance();

                worker.printLog("[QUESTS] Rozpoczynam proces pobierania questów.");
                if (parafia.login())
                {
                    worker.printLog("[QUESTS] Zalogowany do portalu.");
                    parafia.getQuests();
                    questContainer = parafia.questContainer;
                    worker.printLog("[QUESTS] Lista pobrana...");
                    parafia.logout();
                    worker.printLog("[QUESTS] Wylogowany z portalu.");
                }

                this.Invoke((Action)(delegate
                {
                    fillQuestList(parafia.questContainer);
                    pbRefresh.Enabled = true;
                }));
            })).Start();
        }

        private void pbArrowLeft_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem selectedItem in lvSelectedQuests.SelectedItems)
            {
                lvSelectedQuests.Items.Remove(selectedItem);
                lvQuests.Items.Add(selectedItem);
                questContainer.unSelect(selectedItem.Text);
            }

            foreach (ListViewItem item1 in lvSelectedQuests.Items)
            {
                questContainer.updatePriority(item1.Index + 1, item1.Text);
            }
        }

        private void pbArrowRight_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem selectedItem in lvQuests.SelectedItems)
            {
                lvQuests.Items.Remove(selectedItem);
                lvSelectedQuests.Items.Add(selectedItem);
                questContainer.select(selectedItem.Text);
            }

            foreach (ListViewItem item1 in lvSelectedQuests.Items)
            {
                questContainer.updatePriority(item1.Index + 1, item1.Text);
            }
        }

        private void pbArrowUp_Click(object sender, EventArgs e)
        {
            if (lvSelectedQuests.SelectedItems.Count == 1)
            {
                ListViewItem item = lvSelectedQuests.SelectedItems[0];
                int index = item.Index;
                if (index != 0)
                {
                    lvSelectedQuests.Items.Remove(item);
                    lvSelectedQuests.Items.Insert(index - 1, item);
                }

                foreach (ListViewItem item1 in lvSelectedQuests.Items)
                {
                    questContainer.updatePriority(item1.Index + 1, item1.Text);
                }
            }
        }

        private void pbArrowDown_Click(object sender, EventArgs e)
        {
            if (lvSelectedQuests.SelectedItems.Count == 1)
            {
                ListViewItem item = lvSelectedQuests.SelectedItems[0];
                int index = item.Index;
                if (index != lvSelectedQuests.Items.Count - 1)
                {
                    lvSelectedQuests.Items.Remove(item);
                    lvSelectedQuests.Items.Insert(index + 1, item);
                }

                foreach (ListViewItem item1 in lvSelectedQuests.Items)
                {
                    questContainer.updatePriority(item1.Index + 1, item1.Text);
                }
            }
        }

        private void btQStart_Click(object sender, EventArgs e)
        {
            btQStop.Enabled = true;
            btQStart.Enabled = false;
            worker.questSemafor = true;
        }

        private void btQStop_Click(object sender, EventArgs e)
        {
            btQStop.Enabled = false;
            btQStart.Enabled = true;
            worker.questSemafor = false;
        }

        private void btQSave_Click(object sender, EventArgs e)
        {
            Settings.Default["quests"] = questContainer;
            Settings.Default.Save();
            worker.printLog("[QUESTS] Zapisane.");
        }

        private void pbClear_Click(object sender, EventArgs e)
        {
            lvQuests.Items.Clear();
            lvSelectedQuests.Items.Clear();
        }

        private void btHit_Click(object sender, EventArgs e)
        {
            Parafia para = worker.getInstance();

            if (para.login())
            {
                List<WaitHandle> handles = new List<WaitHandle>();

                ServicePointManager.DefaultConnectionLimit = 100;//Please test different numbers here

                var tasks = new List<Task<string>>();
                for (int i = 0; i < 45; i++)
                {
                    tasks.Add(Task.Factory.StartNew(() => { return GetWebResponse(para.httpClient.CookieContainer); }));
                    //handles.Add(MakeAsyncRequest(para.httpClient.CookieContainer));
                }

                Task.WaitAll(tasks.ToArray());

                //WaitHandle.WaitAll(handles.ToArray<WaitHandle>());

                para.logout();
            }
        }

        class RequestState
        {
            public RequestState(WebRequest request, ManualResetEvent waitHandle)
            {
                Request = request;
                WaitHandle = waitHandle;
            }
            public Delegate Callback;
            public WebRequest Request;
            public ManualResetEvent WaitHandle;
        }

        private static WaitHandle MakeAsyncRequest(CookieContainer container)
        {
            WebProxy proxy = null;
            proxy = new WebProxy("126.179.0.200", 3128);
            proxy.Credentials = new NetworkCredential("wrobese2", "#Listopad2011#", "TP");

            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create("http://parafia.biz/start/use_point/believers");
            request.Proxy = proxy;
            request.Method = "GET";
            request.Headers.Add("Accept-Charset", "ISO-8859-2,utf-8;q=0.7,*;q=0.7");
            request.Headers.Add("Accept-Language", "pl-PL,pl;q=0.8,en-US;q=0.6,en;q=0.4");
            request.Headers.Add("Accept-Encoding", "gzip,deflate,sdch");
            request.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8";
            request.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/535.1 (KHTML, like Gecko) Chrome/13.0.782.215 Safari/535.1";
            request.AutomaticDecompression = DecompressionMethods.Deflate | DecompressionMethods.GZip;

            request.CookieContainer = container;

            ManualResetEvent waitHandle = new ManualResetEvent(false);
            RequestState state = new RequestState(request, waitHandle);
            IAsyncResult result = request.BeginGetResponse(GetResponseComplete, state);
            return waitHandle;
        }

        private static void GetResponseComplete(IAsyncResult result)
        {
            RequestState state = (RequestState)result.AsyncState;
            WebResponse response = state.Request.EndGetResponse(result);
            state.WaitHandle.Set();
        }

        static string GetWebResponse(CookieContainer container)
        {
            WebProxy proxy = null;
            proxy = new WebProxy("126.179.0.200", 3128);
            proxy.Credentials = new NetworkCredential("wrobese2", "#Listopad2011#", "TP");

            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create("http://parafia.biz/start/use_point/believers");
            request.Proxy = proxy;
            request.Method = "GET";
            request.Headers.Add("Accept-Charset", "ISO-8859-2,utf-8;q=0.7,*;q=0.7");
            request.Headers.Add("Accept-Language", "pl-PL,pl;q=0.8,en-US;q=0.6,en;q=0.4");
            request.Headers.Add("Accept-Encoding", "gzip,deflate,sdch");
            request.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8";
            request.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/535.1 (KHTML, like Gecko) Chrome/13.0.782.215 Safari/535.1";
            request.AutomaticDecompression = DecompressionMethods.Deflate | DecompressionMethods.GZip;

            request.CookieContainer = container;

            Task<WebResponse> responseTask = Task.Factory.FromAsync<WebResponse>(request.BeginGetResponse, request.EndGetResponse, null);
            using (var responseStream = responseTask.Result.GetResponseStream())
            {
                var reader = new StreamReader(responseStream);
                return reader.ReadToEnd();
            }
        }
    }
}
