using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Net;
using Parafia.Properties;
using Parafia.Service;

using System.Windows.Forms;

namespace Parafia
{
    using Model.Quest;

    public class Worker
    {
        private MainForm mainForm;
        private volatile bool mainSemafor = true;
        private volatile bool systemTimeSemafor = true;
        private volatile bool upTimeSemafor = false;
        private volatile bool mainWorkSemafor = false;
        private volatile bool serverTimeSemafor = true;

        private Object loggedInlockObject = new Object();

        private volatile bool doQuests = false;

        private int upTime = 0;
        private DateTime upTimeStart;

        private int hitCount = 0;

        private DateTime nextLoginDt;

        private TimeSpan serverDt;

        public Worker(MainForm mainForm)
        {
            this.mainForm = mainForm;
        }

        public void renderSystemTime()
        {
            while (mainSemafor)
            {
                if (systemTimeSemafor)
                {
                    mainForm.Invoke((Action)(delegate
                    {
                        mainForm.tbSystemTime.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    }));
                }
                if (upTimeSemafor)
                {
                    mainForm.Invoke((Action)(delegate 
                    {
                        mainForm.tbUpTime.Text = DateTime.Now.Subtract(upTimeStart).ToString(@"dd' 'hh\:mm\:ss");
                    }));
                    upTime++;
                }
                if (serverTimeSemafor)
                {
                    mainForm.Invoke((Action)(delegate
                    {
                        mainForm.tbServerTime.Text = serverDt.ToString(@"hh\:mm\:ss");
                    }));
                    serverDt = serverDt.Add(new TimeSpan(0, 0, 0, 1, 0));
                }

                Thread.Sleep(1000);
            }
        }

        public void questRefreshWork()
        {
            Parafia parafia = getInstance();
            if (parafia != null)
            {
                lock (loggedInlockObject)
                {
                    parafia.login();
                    parafia.getQuests();
                    fillQuestsList();
                    parafia.logout();
                }
            }
            mainForm.Invoke((Action)(delegate
            {
                mainForm.pQuestsButtons.Enabled = true;
                mainForm.lvQuests.Enabled = true;
            }));
        }

        public void startMainWork()
        {
            while (mainSemafor) 
            {
                if (mainWorkSemafor)
                {
                    long interval = (nextLoginDt.Ticks - DateTime.Now.Ticks) / 1000000;
                    if (interval == 0)
                    {
                        nextLoginDt = getNextLoginTime();
                        hitCount++;

                        Parafia parafia = getInstance();
                        if (parafia != null)
                        {
                            lock (loggedInlockObject)
                            {
                                parafia.login(); printLog("Zalogowany do portalu...");
                                //parafia.buyArmy(config.ArmyType); printLog("Wojska zakupione. Typ: " + config.ArmyType);
                                parafia.getUnitsInfo(); printLog("Informacje o jednostkach zostały pobrane.");

                                //parafia.getQuests();

                                /*if (doQuests) { 
                                    ListView.SelectedListViewItemCollection selectedItems;
                                    mainForm.Invoke((Action)(delegate
                                    {
                                        selectedItems = mainForm.lvQuests.SelectedItems;
                                    }));

                                }*/
                                // if (config.SendPilgrimage) { parafia.sendPilgrimage(2); printLog("Pielgrzymka została wysłana."); }
                                parafia.logout(); printLog("Pomyślne wylogowanie z portalu.");

                                // if (config.SentMail)
                                //     MailService.sendMail("sairo149240@gmail.com", "App", "Zakupy skończone... następne o godzinie: " + this.nextLoginDt.ToString("yyyy-MM-dd HH:mm:ss"));

                                mainForm.Invoke((Action)(delegate
                                {
                                    mainForm.tbHitCount.Text = this.hitCount.ToString();
                                    mainForm.tbNextLogin.Text = this.nextLoginDt.ToString("yyyy-MM-dd HH:mm:ss");
                                    mainForm.tbAttack.Text = parafia.units.attack.ToString();
                                    mainForm.tbDefense.Text = parafia.units.defense.ToString();
                                    mainForm.tbMinistr.Text = parafia.units.unit1.ToString();
                                    mainForm.tbLektor.Text = parafia.units.unit2.ToString();
                                    mainForm.tbOrgan.Text = parafia.units.unit3.ToString();
                                    mainForm.tbDewot.Text = parafia.units.unit4.ToString();
                                    mainForm.tbMoher.Text = parafia.units.unit5.ToString();
                                    mainForm.tbGospo.Text = parafia.units.unit6.ToString();
                                }));
                            }
                        }
                    }
                }
                Thread.Sleep(100);
            }
        }

        private void printLog(String log)
        {
            mainForm.Invoke((Action)(delegate 
            {
                mainForm.lbLog.Items.Add(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + " --> " + log);
            }));
        }


        private DateTime getNextLoginTime()
        {
            return DateTime.Now.AddSeconds(new Random().Next(8400, 9000));
        }

        public void StopAllThreads()
        {
            mainSemafor = false;
        }

        public void StartUpTime()
        {
            upTimeStart = DateTime.Now;
            nextLoginDt = DateTime.Now.AddSeconds(10);
            mainForm.tbNextLogin.Text = nextLoginDt.ToString("yyyy-MM-dd HH:mm:ss");
            mainWorkSemafor = true;
            upTimeSemafor = true;
        }

        public void StopUpTime()
        {
            mainWorkSemafor = false;
            upTimeSemafor = false;
            mainForm.tbNextLogin.Text = "brak danych";
            this.hitCount = 0;
            mainForm.tbHitCount.Text = hitCount.ToString();
            this.upTime = 0;
            mainForm.tbUpTime.Text = "00 00:00:00";
        }

        public void GetServerTime()
        {
            Parafia parafia = getInstance();
            if (parafia != null)
                serverDt = getInstance().getSerwerTime();
            else
                serverDt = new TimeSpan(0, 0, 0, 0, 0);
        }

        public void fillQuestsList()
        {
            Object obj = Settings.Default["quests"];
            if (obj != null)
            {
                mainForm.Invoke((Action)(delegate
                {
                    mainForm.lvQuests.Items.Clear();
                }));

                QuestContainer container = (QuestContainer)obj;
                foreach (Quest quest in container.GetAllQuests)
                {
                    ListViewItem item = new ListViewItem();
                    ListViewItem.ListViewSubItem siName = new ListViewItem.ListViewSubItem(item, quest.Name);
                    ListViewItem.ListViewSubItem siProgress = new ListViewItem.ListViewSubItem(item, quest.GetProgress().ToString("F2") + " %");

                    item.SubItems.Add(siName);
                    item.SubItems.Add(siProgress);

                    mainForm.Invoke((Action)(delegate
                    {
                        mainForm.lvQuests.Items.Add(item);
                    }));
                }
            }
        }

        public Parafia getInstance()
        {
            object obj = Settings.Default["properties"];

            if (obj != null)
            {
                ApplicationConfig config = (ApplicationConfig)obj;
                if (config != null)
                {
                    Parafia parafia = new Parafia();
                    parafia.initConnection(config);
                    return parafia;
                }
            }
            return null;
        }
    }
}
