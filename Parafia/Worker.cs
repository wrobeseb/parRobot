using System;
using System.Collections;
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
        private volatile bool relicsSemafor = false;

        private Object loggedInlockObject = new Object();

        private volatile bool doQuests = false;

        private DateTime nextQuestWorkDt;
        private DateTime lastQuestWorkDt;

        private int upTime = 0;
        private DateTime upTimeStart;

        private int hitCount = 0;

        private DateTime nextLoginDt;

        private TimeSpan serverDt;

        private bool sendMail = false;
        private Enums.ArmyType armyType = Enums.ArmyType.Defense;

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

        public void buyRelics()
        {
            while (mainSemafor)
            {
                if (relicsSemafor)
                {
                    String dtFieldTxt = null;
                    String relicName = null;
                    mainForm.Invoke((Action)(delegate
                    {
                        dtFieldTxt = mainForm.tbHourField.Text;
                        relicName = mainForm.tbRelicName.Text;
                    }));

                    String[] dtTextValues = null;
                    bool flag = false;
                    if (!String.IsNullOrEmpty(dtFieldTxt))
                    {
                        dtTextValues = dtFieldTxt.Split(',');
                        foreach (String dtTextValue in dtTextValues)
                        {
                            DateTime dtValue = DateTime.MinValue;
                            if (dtTextValue.Length == 8)
                                dtValue = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, int.Parse(dtTextValue.Split(':')[0]), int.Parse(dtTextValue.Split(':')[1]), int.Parse(dtTextValue.Split(':')[2]));
                            if (dtTextValue.Length == 19)
                            {
                                String dateText = dtTextValue.Split(' ')[0];
                                String timeText = dtTextValue.Split(' ')[1];
                                dtValue = new DateTime(int.Parse(dateText.Split('-')[0]), int.Parse(dateText.Split('-')[1]), int.Parse(dateText.Split('-')[2]), int.Parse(timeText.Split(':')[0]), int.Parse(timeText.Split(':')[1]), int.Parse(timeText.Split(':')[2]));
                            }
                            if (!dtValue.Equals(DateTime.MinValue))
                            {
                                long interval = (dtValue.Ticks - serverDt.Ticks) / 1000000;
                                if (interval == 0)
                                {
                                    flag = true;
                                }
                            }
                            else
                            {
                                printLog("Niepoprawny format daty dla pola kupowania relikwi!!!");
                            }
                        }
                    }

                    if (flag)
                    {
                        if (!String.IsNullOrEmpty(relicName))
                        {
                            Parafia parafia = getInstance();
                            if (parafia != null)
                            {
                                lock (loggedInlockObject)
                                {
                                    parafia.login(); printLog("RELIKWIE: Zalogowany do portalu...");
                                    int relicNo = 0;
                                    Random rand = new Random();
                                    while (true)
                                    {
                                        relicNo = parafia.buyRelic(relicName);
                                        if (relicNo >= 0) break;
                                        Thread.Sleep(rand.Next(1000,3000));
                                    }
                                    printLog("RELIKWIE: Relikwie zakupione... Ilość: " + relicNo);
                                    parafia.logout(); printLog("RELIKWIE: Wylogowany z portalu...");
                                    if (sendMail)
                                        MailService.sendMail("sairo149240@gmail.com", "App", "Relikwie zakupione... Ilość: " + relicNo);
                                }
                            }
                        }
                        else
                        {
                            printLog("Nie podano nazwy relikwi!!!");
                        }
                    }
                }
                Thread.Sleep(100);
            }
        }

        public void doQuestWork()
        {
            while (mainSemafor)
            {
                if (doQuests)
                {
                    long interval = (nextQuestWorkDt.Ticks - DateTime.Now.Ticks) / 1000000;
                    if (interval == 0)
                    {
                        lastQuestWorkDt = nextQuestWorkDt;
                        nextQuestWorkDt = getNextQuestWorkDt();

                        Parafia parafia = getInstance();
                        if (parafia != null)
                        {
                            lock (loggedInlockObject)
                            {
                                parafia.login(); printLog("QUEST: Zalogowany do portalu...");
                                parafia.doQuestTasks(getListOfCheckedQuests()); printLog("QUEST: Robie questy...");
                                parafia.logout(); printLog("QUEST: Wylogowany z portalu...");
                                if (sendMail)
                                    MailService.sendMail("sairo149240@gmail.com", "App", "Questy wykonane... następne o godzinie: " + this.nextQuestWorkDt.ToString("HH:mm:ss"));
                            }
                        }
                        fillQuestsList();
                        mainForm.Invoke((Action)(delegate
                        {
                            mainForm.tbLastQuestDt.Text = lastQuestWorkDt.ToString("HH:mm:ss");
                            mainForm.tbNextQuestDt.Text = nextQuestWorkDt.ToString("HH:mm:ss");
                        }));
                        
                    }
                }
                Thread.Sleep(100);
            }
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
                                parafia.buyArmy(armyType); printLog("Wojska zakupione. Typ: " + armyType);
                                parafia.getUnitsInfo(); printLog("Informacje o jednostkach zostały pobrane.");
                                // if (config.SendPilgrimage) { parafia.sendPilgrimage(2); printLog("Pielgrzymka została wysłana."); }
                                parafia.logout(); printLog("Pomyślne wylogowanie z portalu.");

                                if (sendMail)
                                     MailService.sendMail("sairo149240@gmail.com", "App", "Zakupy skończone... następne o godzinie: " + this.nextLoginDt.ToString("yyyy-MM-dd HH:mm:ss"));

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
            object obj = Settings.Default["properties"];

            if (obj != null)
            {
                ApplicationConfig config = (ApplicationConfig)obj;
                if (config != null)
                {
                    if (config.ArmyTimeStart != 0 && config.ArmyTimeStop != 0)
                    {
                        return DateTime.Now.AddSeconds(new Random().Next(config.ArmyTimeStart, config.ArmyTimeStop));
                    }
                }
            }
            throw new Exception();
        }

        private DateTime getNextQuestWorkDt()
        {
            object obj = Settings.Default["properties"];

            if (obj != null)
            {
                ApplicationConfig config = (ApplicationConfig)obj;
                if (config != null)
                {
                    if (config.QuestTimeStart != 0 && config.QuestTimeStop != 0)
                    {
                        return DateTime.Now.AddSeconds(new Random().Next(config.QuestTimeStart, config.QuestTimeStop));
                    }
                }
            }
            throw new Exception();
        }

        public void StopAllThreads()
        {
            mainSemafor = false;
        }

        public void StartUpQuests()
        {
            nextQuestWorkDt = DateTime.Now.AddSeconds(10);
            mainForm.tbNextQuestDt.Text = nextQuestWorkDt.ToString("HH:mm:ss");
            doQuests = true;
        }

        public void StopQuests()
        {
            doQuests = false;
            mainForm.tbNextQuestDt.Text = "brak danych";
            mainForm.tbLastQuestDt.Text = "brak danych";
        }

        public void StartRelics()
        {
            relicsSemafor = true;
        }

        public void StopRelics()
        {
            relicsSemafor = false;
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

        public String[] getListOfCheckedQuests()
        {
            List<String> listOfNames = new List<String>();

            mainForm.Invoke((Action)(delegate
            {
                ListView.ListViewItemCollection collection = mainForm.lvQuests.Items;
                foreach (ListViewItem item in collection) {
                    if (item.Checked)
                        listOfNames.Add(item.SubItems[1].Text);
                }
            }));

            return listOfNames.ToArray<String>();
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

                    if (quest.IsChecked)
                        item.Checked = true;

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
            object obj1 = Settings.Default["quests"];

            if (obj != null)
            {
                ApplicationConfig config = (ApplicationConfig)obj;
                if (config != null)
                {
                    sendMail = config.SentMail;
                    armyType = config.ArmyType;
                    Parafia parafia = new Parafia();
                    parafia.initConnection(config);
                    if (obj1 != null)
                    {
                        parafia.questContainer = (QuestContainer)obj1;
                    }
                    return parafia;
                }
            }
            return null;
        }
    }
}
