using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Net;
using Parafia.Properties;

namespace Parafia
{
    public delegate void renderSystemTimeDelegate();
    public delegate void startRenderUpTimeDelegate();
    public delegate void startMainWorkDelegate(String proxyHost, int proxyPort, String proxyUser, String proxyDomain, String proxyPassword, String parafiaUser, String parafiaPassword, Enums.ArmyType armyType, bool sendPilgrimage);
    public delegate void addLog(String log);

    public class Worker
    {
        private MainForm mainForm;
        private volatile bool mainSemafor = true;
        private volatile bool systemTimeSemafor = true;
        private volatile bool upTimeSemafor = false;
        private volatile bool mainWorkSemafor = false;

        private int upTime = 0;
        private DateTime upTimeStart;

        private int hitCount = 0;

        private DateTime nextLoginDt;

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
                    mainForm.Invoke(new renderSystemTimeDelegate(setSystemTimeText));
                }
                if (upTimeSemafor)
                {
                    mainForm.Invoke(new startRenderUpTimeDelegate(setUpTimeText));
                    upTime++;
                }
                mainForm.Invoke(new addLog(printLog), "Czas: " + Thread.CurrentThread.Name);
                Thread.Sleep(1000);
            }
        }

        public void startMainWork(/*String proxyHost, String proxyPort, String proxyUser, String proxyDomain, String proxyPassword, String parafiaUser, String parafiaPassword, Enums.ArmyType armyType, bool sendPilgrimage*/)
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

                        Parafia parafia = new Parafia();

                       /* WebProxy proxy = null;
                        if (!String.IsNullOrEmpty(proxyHost))
                        {
                            proxy = new WebProxy(proxyHost, proxyPort);
                            proxy.Credentials = new NetworkCredential(proxyUser, proxyPassword, proxyDomain);
                        }

                        parafia.initConnection(proxy);
                        parafia.login(parafiaUser, parafiaPassword);
                       // Parafia.buyArmy(armyType);
                        parafia.getUnitsInfo();
                        if (sendPilgrimage) parafia.sendPilgrimage(2);
                        parafia.logout();*/

                        mainForm.Invoke(new startMainWorkDelegate(mainWork), getSettings()); 
                    }
                }
                mainForm.Invoke(new addLog(printLog), "Main: " + Thread.CurrentThread.Name);
                Thread.Sleep(100);
            }
        }

        private void printLog(String log)
        {
            mainForm.lbLog.Items.Add(log);
        }

        private object[] getSettings()
        {
            object useProxyObj = Settings.Default["useProxy"];

            object[] objects = new object[] {
                Settings.Default["proxyHost"],
                Settings.Default["proxyPort"],
                Settings.Default["proxyUser"],
                Settings.Default["proxyDomain"],
                Settings.Default["proxyPassword"],
                Settings.Default["parafiaUser"],
                Settings.Default["parafiaPassword"],
                Settings.Default["armyType"],
                Settings.Default["sendPilgrimage"]
            };

            return objects;
        }

        private void mainWork(String proxyHost, int proxyPort, String proxyUser, String proxyDomain, String proxyPassword, String parafiaUser, String parafiaPassword, Enums.ArmyType armyType, bool sendPilgrimage)
        {
            mainForm.tbHitCount.Text = this.hitCount.ToString();
            mainForm.tbNextLogin.Text = this.nextLoginDt.ToString("yyyy-MM-dd HH:mm:ss");

            /*WebProxy proxy = new WebProxy("126.179.0.200", 3128);
            proxy.Credentials = new NetworkCredential("wrobese2", "#Sierpien2011#", "TP");

            Parafia.initConnection(proxy);
            Parafia.login("sairo", "sairoroan");
            Parafia.buyArmy(Enums.ArmyType.Defense);
            Parafia.getUnitsInfo();
            Parafia.sendPilgrimage(2);
            Parafia.logout();*/
        }

        private void setUpTimeText()
        {
            mainForm.tbUpTime.Text = DateTime.Now.Subtract(upTimeStart).ToString(@"hh\:mm\:ss");
        }

        private void setSystemTimeText()
        {
            mainForm.tbSystemTime.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        private DateTime getNextLoginTime()
        {
            return DateTime.Now.AddSeconds(new Random().Next(6200, 9800));
        }

        public void StopSystemTime()
        {
            systemTimeSemafor = false;
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
            mainForm.tbUpTime.Text = "00:00:00";
        }
    }
}
