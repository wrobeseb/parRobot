using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Net;
using Parafia.Properties;
using Parafia.Service;

namespace Parafia
{
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
                Thread.Sleep(1000);
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

                        object obj = Settings.Default["properties"];

                        if (obj != null)
                        {
                            ApplicationConfig config = (ApplicationConfig)obj;
                            if (config != null)
                            {
                                Parafia parafia = new Parafia();

                                WebProxy proxy = null;
                                if (!String.IsNullOrEmpty(config.ProxyHost))
                                {
                                    proxy = new WebProxy(config.ProxyHost, config.ProxyPort);
                                    proxy.Credentials = new NetworkCredential(config.ProxyUser, config.ProxyPassword, config.ProxyDomain);
                                }

                                parafia.initConnection(proxy);
                                parafia.login(config.AccountUser, config.AccountPassword); printLog("Zalogowany do portalu...");
                                parafia.buyArmy(config.ArmyType); printLog("Wojska zakupione. Typ: " + config.ArmyType);
                                parafia.getUnitsInfo(); printLog("Informacje o jednostkach zostały pobrane.");
                               // if (config.SendPilgrimage) { parafia.sendPilgrimage(2); printLog("Pielgrzymka została wysłana."); }
                                parafia.logout(); printLog("Pomyślne wylogowanie z portalu.");
                                
                                if (config.SentMail)
                                    MailService.sendMail("sairo149240@gmail.com", "App", "Zakupy skończone... następne o godzinie: " + this.nextLoginDt.ToString("yyyy-MM-dd HH:mm:ss"));
                               
                                mainForm.Invoke((Action)(delegate
                                {
                                    mainForm.tbHitCount.Text = this.hitCount.ToString();
                                    mainForm.tbNextLogin.Text = this.nextLoginDt.ToString("yyyy-MM-dd HH:mm:ss");
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
            mainForm.tbUpTime.Text = "00 00:00:00";
        }
    }
}
