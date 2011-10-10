using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Net;
using Parafia.Properties;
using Parafia.Service;
using System.IO;

using System.Windows.Forms;

using System.Net.Sockets;

namespace Parafia
{
    using Model.Quest;
    using Model.Stat;
    using Exceptions;
    using Enums;

    public class Worker
    {
        private MainForm mainForm;
        private volatile bool mainSemafor = true;
        private volatile bool systemTimeSemafor = true;
        private volatile bool upTimeSemafor = false;
        private volatile bool mainWorkSemafor = false;
        private volatile bool serverTimeSemafor = true;
        private volatile bool relicsSemafor = false;
        private volatile bool attackSemafor = false;

        public volatile bool serverSemafor = false;
        public volatile bool clientSemafor = false;

        private volatile bool holdSessionSemafor = false;

        public List<Account> listOfAccountsInView;

        private Object loggedInlockObject = new Object();

        private volatile bool doQuests = false;

        private DateTime nextQuestWorkDt;
        private DateTime lastQuestWorkDt;

        private volatile bool serverTimeForCashSafeSemafor = false;
        private TimeSpan serverTimeForCashSafe;

        private int upTime = 0;
        private DateTime upTimeStart;

        private int hitCount = 0;

        private DateTime lastLoginDt;
        private DateTime nextLoginDt;

        private TimeSpan serverDt;

        private bool sendMail = false;
        private Enums.ArmyType armyType = Enums.ArmyType.Defense;
        private bool sendPilgrimage = false;

        private String username = String.Empty;

        private int transferResult = 0;
        private int transferNo = 0;

        public Worker(MainForm mainForm)
        {
            this.mainForm = mainForm;
            this.listOfAccountsInView = new List<Account>();
        }

        public void setMainWindowTitle()
        {
            object obj = Settings.Default["properties"];

            if (obj != null)
            {
                ApplicationConfig config = (ApplicationConfig)obj;
                if (config != null)
                {
                    if (config.AccountUser != null)
                    {
                        mainForm.Invoke((Action)(delegate
                        {
                            mainForm.Text = mainForm.Text.Replace("brak danych", config.AccountUser);
                            mainForm.niMain.Text = mainForm.niMain.Text.Replace("brak danych", config.AccountUser);
                            username = config.AccountUser;
                        }));
                    }
                }
            }
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
                        if (mainWorkSemafor)
                        {
                            TimeSpan nextLoginInterval = new TimeSpan(nextLoginDt.Ticks - DateTime.Now.Ticks);
                            mainForm.tbNextLogin.Text = nextLoginInterval.ToString(@"hh\:mm\:ss");
                        }
                        if (DateTime.Now.Minute % 15 == 0)
                        {
                            GetServerTime();
                        }
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
                if (serverTimeForCashSafeSemafor)
                {
                    serverTimeForCashSafe = serverTimeForCashSafe.Add(new TimeSpan(0, 0, 0, 1, 0));
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
                    parafia.login(); printLog("QUEST-REFRESH: Zalogowany do portalu...");
                    printLog("QUEST-REFRESH: Proces pobierania questów rozpoczęty...");
                    parafia.getQuests(); printLog("QUEST-REFRESH: Proces pobierania zakończony...");
                    fillQuestsList();
                    parafia.logout(); printLog("QUEST-REFRESH: Wylogowany z portalu...");
                }
            }

        }

        public void buyRelics()
        {
            while (mainSemafor)
            {
                if (relicsSemafor)
                {
                    String dtFieldTxt = null;
                    String relicName = null;

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
                                        MailService.sendMail("Relikwie zakupione... Ilość: " + relicNo);
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
                    int timeouts = 0;
                    long interval = (nextQuestWorkDt.Ticks - DateTime.Now.Ticks) / 1000000;
                    if (interval == 0)
                    {
                        Boolean timeoutFlag = false;
                        do
                        {
                            timeoutFlag = false;
                            try
                            {
                                lastQuestWorkDt = nextQuestWorkDt;
                                nextQuestWorkDt = getNextQuestWorkDt();

                                Parafia parafia = getInstance();
                                if (parafia != null)
                                {
                                    lock (loggedInlockObject)
                                    {
                                        parafia.login(); printLog("QUEST: Zalogowany do portalu...");
                                        parafia.putIntoSafe(); printLog("QUEST: Pakuje kase do sejfu...");
                                        parafia.doQuestTasks(getListOfCheckedQuests()); printLog("QUEST: Robie questy...");
                                        parafia.logout(); printLog("QUEST: Wylogowany z portalu...");
                                    }
                                }
                                fillQuestsList();

                                if (sendMail)
                                    MailService.sendMail("Questy wykonane... następne o godzinie: " + this.nextQuestWorkDt.ToString("HH:mm:ss"));
                            }
                            catch (WebException ex)
                            {
                                timeoutFlag = true;
                                timeouts++;
                                printLog("Wystąpił timeout... ponawiam!");
                                printLog(ex.Message);
                            }
                        }
                        while (timeoutFlag && (timeouts < 5));
                    }
                }
                Thread.Sleep(100);
            }
        }

        public void downloadStats(String fileName)
        {
            Parafia parafia = getInstance();
            if (parafia != null)
            {
                parafia.login();
                int lastpage = parafia.getLastStatPage();

                if (lastpage != 0)
                {
                    mainForm.Invoke((Action)(delegate
                    {
                        mainForm.pbStatDownload.Maximum = lastpage + 1;
                    }));

                    new StreamWriter(fileName).Close();
                    for (int i = 1; i < lastpage + 1; i++)
                    {
                        List<Account> accountsFromPage = parafia.getAccountsFromStatePage(i);
                        StreamWriter writer = new StreamWriter(fileName, true, Encoding.GetEncoding("ISO-8859-2"));
                        foreach (Account account in accountsFromPage)
                        {
                            writer.WriteLine(account.ToString());
                        }
                        writer.Close();
                        mainForm.Invoke((Action)(delegate
                        {
                            mainForm.pbStatDownload.Value = i;
                        }));
                    }
                }
                parafia.logout();
                mainForm.Invoke((Action)(delegate
                {
                    mainForm.pbStatDownload.Value = 0;
                }));
            }
        }

        public void onlyAttackWork()
        {
            while (mainSemafor)
            {
                if (attackSemafor && !mainWorkSemafor)
                {
                    int timeouts = 0;
                    long interval = (nextLoginDt.Ticks - DateTime.Now.Ticks) / 1000000;
                    if (interval == 0)
                    {
                        Boolean timeoutFlag = false;
                        do
                        {
                            timeoutFlag = false;
                            try
                            {
                                lastLoginDt = nextLoginDt;
                                nextLoginDt = getNextLoginTime();

                                hitCount++;
                                Parafia parafia = getInstance();
                                if (parafia != null)
                                {
                                    int result = 0;
                                    lock (loggedInlockObject)
                                    {
                                        parafia.login(); printLog("Zalogowany do portalu...");
                                        attackJob(parafia, ref result);
                                        parafia.logout(); printLog("Pomyślne wylogowanie z portalu.");
                                    }
                                    
                                    mainForm.Invoke((Action)(delegate
                                    {
                                        mainForm.tbAttackCash.Text = new StringBuilder().Append(int.Parse(mainForm.tbAttackCash.Text) + result).ToString();
                                        mainForm.tbAttackLast.Text = this.lastLoginDt.ToString("HH:mm:ss");
                                        mainForm.tbAttackNext.Text = this.nextLoginDt.ToString("HH:mm:ss");
                                    }));
                                }
                            }
                            catch
                            {
                                printLog("Wystąpił timeout... ponawiam!");
                                timeouts++;
                                timeoutFlag = true;
                            }
                        }
                        while (timeoutFlag && (timeouts < 5));
                    }
                }
                Thread.Sleep(100);
            }
        }

        public class StateObject
        {
            public Socket workSocket = null;
            public const int BufferSize = 256;
            public byte[] buffer = new byte[BufferSize];
            public StringBuilder sb = new StringBuilder();
        }

        private void ClientIsConnected(IAsyncResult asyn)
        {
            TcpListener listener = (TcpListener)asyn.AsyncState;
            Socket client = listener.EndAcceptSocket(asyn);

            StateObject state = new StateObject();
            state.workSocket = client;

            client.BeginReceive(state.buffer, 0, StateObject.BufferSize, 0,
            new AsyncCallback(ReceiveCallback), state);

            listener.BeginAcceptSocket(new AsyncCallback(ClientIsConnected), listener);
        }

        private void ReceiveCallback(IAsyncResult ar)
        {
            try
            {
                printLog("[TRANSFER] Otrzymałem komunikat. Proces wystawiania paczki rozpoczęty.");
                StateObject state = (StateObject)ar.AsyncState;
                Socket client = state.workSocket;
                int bytesRead = client.EndReceive(ar);
                if (bytesRead > 0)
                {
                    state.sb.Append(Encoding.ASCII.GetString(state.buffer, 0, bytesRead));

                    String idTxt = String.Empty;

                    Parafia parafia = getInstance();

                    lock (loggedInlockObject)
                    {
                        if (parafia != null)
                        {
                            if (!String.IsNullOrEmpty(state.sb.ToString()))
                            {
                                printLog("[TRANSFER] Treść komunikatu: " + state.sb.ToString());
                                parafia.login(); printLog("[TRANSFER] Zalogowany do portalu...");
                                int valueToPut = parafia.GetValueToPutOnMarket(int.Parse(state.sb.ToString())); printLog("[TRANSFER] Paczka zostanie wystawiona za: " + valueToPut);

                                int vat = Convert.ToInt32(valueToPut * 0.08) + 1;

                                if (parafia.attributes.Cash.Actual < vat)
                                {
                                    printLog("[TRANSFER] Pobieram kase z sejfu na podatek: " + vat);
                                    parafia.getFromSafe(vat + 1000);
                                    printLog("[TRANSFER] Kasa pobrana.");
                                }
                                printLog("[TRANSFER] Wystawiam paczke.");
                                if (parafia.SellGreatChange(valueToPut) == 1)
                                {
                                    printLog("[TRANSFER] Paczka została wystawiona za: " + valueToPut);
                                    idTxt = valueToPut.ToString();
                                    transferResult += valueToPut;
                                    transferNo++;
                                    showBalloonTip("Paczka wystawiona za: " + valueToPut + " C$\n" +
                                                   "W sumie wystawiono za: " + transferResult + " C$\n" +
                                                   "Ilość transferów: " + transferNo, "TRANSFER", ToolTipIcon.Info);
                                    printLog("[TRANSFER] Wysyłam wartosc paczki do kupienia przez klienta: " + idTxt);
                                }
                                else
                                {
                                    printLog("[TRANSFER] Błąd podczas wystawiania paczki: " + valueToPut);
                                }
                            }
                        }

                        ASCIIEncoding asen = new ASCIIEncoding();
                        byte[] ba = asen.GetBytes(idTxt);
                                
                        client.Send(ba);
                        printLog("[TRANSFER] Wartość paczki wysłana.");
                        byte[] rc = new byte[100];
                        printLog("[TRANSFER] Oczekuje na komunikat z ceną zwracanej paczki.");
                        int rcLength = client.Receive(rc);
                        printLog("[TRANSFER] Wartość paczki otrzymana.");
                        String returnedCost = Encoding.ASCII.GetString(rc, 0, rcLength);
                        printLog("[TRANSFER] Kupuje zwróconą paczkę: " + returnedCost);
                        parafia.BuyReturnedGreatChange(returnedCost);
                        printLog("[TRANSFER] Paczka zakupiona: " + returnedCost);
                        parafia.logout(); printLog("[TRANSFER] Wylogowany z portalu...");
                    }

                    client.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        private bool serwerStartedFlag = false;

        public void startMainWork()
        {
            while (mainSemafor) 
            {
                if (mainWorkSemafor)
                {
                    if (serverSemafor && !serwerStartedFlag)
                    {
                        IPAddress ipAd = IPAddress.Parse("127.0.0.1");

                        new Thread((ThreadStart)delegate
                        {
                            TcpListener listener = new TcpListener(ipAd, 8001);
                            listener.Start();

                            listener.BeginAcceptSocket(new AsyncCallback(ClientIsConnected), listener);
                        }).Start();

                        serwerStartedFlag = true;
                    }

                    int timeouts = 0;
                    long interval = (nextLoginDt.Ticks - DateTime.Now.Ticks) / 1000000;
                    if (interval == 0)
                    {
                        Boolean timeoutFlag = false;
                        Boolean overflowFlag = false;
                        int result = 0;

                        lastLoginDt = nextLoginDt;
                        hitCount++;

                        do
                        {
                            timeoutFlag = false;
                            try
                            {
                                Parafia parafia = getInstance();
                                if (parafia != null)
                                {
                                    lock (loggedInlockObject)
                                    {
                                        parafia.login(); printLog("Zalogowany do portalu...");
                                        parafia.buyArmy(armyType); printLog("Wojska zakupione. Typ: " + armyType);
                                        parafia.getUnitsInfo(); printLog("Informacje o jednostkach zostały pobrane.");

                                        if (!clientSemafor)
                                        {
                                            parafia.takeFromProperty(); printLog("Dewocjonalnik...");
                                        }

                                        parafia.putIntoSafe(); printLog("Pakuje do sejfu...");

                                        if (attackSemafor)
                                        {
                                            do
                                            {
                                                timeoutFlag = false;
                                                try
                                                {
                                                    overflowFlag = attackJob(parafia, ref result);
                                                }
                                                catch
                                                {
                                                    printLog("Wystąpił timeout... ponawiam!");
                                                    timeouts++;
                                                    timeoutFlag = true;
                                                }
                                            }
                                            while (timeoutFlag && (timeouts < 5));
                                        }

                                        if (sendPilgrimage) 
                                        {
                                            int cost = parafia.units.cashForPilgrimage();
                                            parafia.getFromSafe(cost);
                                            if (cost <= parafia.attributes.Cash.Actual)
                                            {
                                                int hours = (nextLoginDt - DateTime.Now).Hours;
                                                parafia.sendPilgrimage(hours != 0 ? hours : 1);
                                                printLog("Pielgrzymka została wysłana.");
                                            }
                                            else
                                            {
                                                printLog("Pielgrzymka nie została wysłana. Brak kasy!!!");
                                            }
                                        }

                                        nextLoginDt = getNextLoginTime();
                                        
                                        parafia.logout(); printLog("Pomyślne wylogowanie z portalu.");
                                        
                                        mainForm.Invoke((Action)(delegate
                                        {
                                            mainForm.tbAttackCash.Text = new StringBuilder().Append(int.Parse(mainForm.tbAttackCash.Text) + result).ToString();
                                            mainForm.tbAttackLast.Text = this.lastLoginDt.ToString("HH:mm:ss");
                                            mainForm.tbAttackNext.Text = this.nextLoginDt.ToString("HH:mm:ss");

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
                                    if (sendMail)
                                    {
                                        StringBuilder builder = new StringBuilder();
                                        if (attackSemafor)
                                        {
                                            builder.Append("Atak wykonany. Rezultat: ").Append(result).Append("\n");

                                            builder.Append("Kasa: ").Append(parafia.attributes.Cash.Actual).Append(" / ").Append(parafia.attributes.Cash.Max).Append("\n");
                                            builder.Append("Sejf: ").Append(parafia.attributes.Safe.Actual).Append(" / ").Append(parafia.attributes.Safe.Max).Append("\n");
                                        }

                                        builder.Append("Zakupy skończone... następne o godzinie: " + this.nextLoginDt.ToString("yyyy-MM-dd HH:mm:ss"));
                                        //MailService.sendMail(builder.ToString());
                                        MailService.sendMail(parafia.attributes, parafia.units, nextLoginDt, result, overflowFlag);
                                    }
                                }
                         }
                         catch
                         {
                             printLog("Wystąpił timeout... ponawiam!");
                             timeouts++;
                             timeoutFlag = true;
                         }
                     }
                     while (timeoutFlag && (timeouts < 5));
                    }
                }
                Thread.Sleep(100);
            }
        }

        private Thread holdSessionThread;

        public void StartHoldingSession()
        {
            holdSessionSemafor = true;
            holdSessionThread = new Thread(safeCashAction);
            holdSessionThread.Start();
        }

        public void StopHoldingSession()
        {
            holdSessionSemafor = false;
            //holdSessionThread.Join();
        }

        public void safeCashAction()
        {
            Parafia parafia = getInstance();

            parafia.login(); printLog("[SAFE CASH ACTION] Zalogowany.");

            parafia.putIntoSafe(); printLog("[SAFE CASH ACTION] Wstępne pakowanie do sejfu.");

            printLog("[SAFE CASH ACTION] Synchronizacja z czasem serwera.");
            lock (loggedInlockObject)
            {
                while (true)
                {
                    try
                    {
                        parafia.updateAttributes();
                        if (parafia.attributes.Cash.Actual > 0)
                        {
                            if (parafia.attributes.Safe.Actual < parafia.attributes.Safe.Max)
                            {
                                serverTimeForCashSafe = new TimeSpan(0, 0, 0, 0, 0);
                                serverTimeForCashSafeSemafor = true;
                                parafia.putIntoSafe(); printLog("[SAFE CASH ACTION] Pakuje do sejfu.");
                            }
                            break;
                        }
                    }
                    catch
                    {
                        printLog("[SAFE CASH ACTION] Wystąpił timeout... Brak synchronizacji!");
                        break;
                    }
                    Thread.Sleep(1000);
                }
            }

            printLog("[SAFE CASH ACTION] Synchronizacja zakończona.");
            while (holdSessionSemafor)
            {
                if (mainWorkSemafor)
                {
                    long interval = serverTimeForCashSafe.Ticks / 10000000;
                    if ((interval % 300) == 0)
                    {
                        lock (loggedInlockObject)
                        {
                            try
                            {
                                parafia.updateAttributes();
                                if (parafia.attributes.Cash.Actual > 0)
                                {
                                    if (parafia.attributes.Safe.Actual < parafia.attributes.Safe.Max)
                                    {
                                        parafia.putIntoSafe();
                                        printLog("[SAFE CASH ACTION] Pakuje do sejfu.");
                                    }
                                }
                            }
                            catch
                            {
                                printLog("[SAFE CASH ACTION] Wystąpił timeout... Kasa nie przelana do sejfu!");
                            }
                        }
                    }
                }
                Thread.Sleep(100);
            }

            parafia.logout(); printLog("[SAFE CASH ACTION] wylogowany.");
        }


        private bool buyRelic(Parafia parafia, int cashValue)
        {
            int id = 0;
            int count = parafia.countGreatChangeInMarket(cashValue, ref id);

            if (count == 1)
            {

            }
            else
            {
                throw new MoreThenOneGreatChange(count);
            }

            return false;
        }

        private bool attackJob(Parafia parafia, ref int result)
        {
            bool flag = false;

            do
            {
                if (parafia.attributes.Cash.Actual != parafia.attributes.Cash.Max)
                {
                    List<Account> accounts = getListOfCheckedAttack();

                    if (accounts != null && accounts.Count != 0)
                    {
                        Account account = accounts[new Random().Next(0, accounts.Count - 1)];
                        printLog(account.UserName + ": Atakowanie w trakcie...");
                        int value = 0;
                        if (parafia.attack(ref account))
                        {
                            //account.IsChecked = false;
                            if (account.Cash != -1)
                            {
                                if (account.Cash != 0)
                                {
                                    parafia.putIntoSafe();
                                    value = account.Cash;
                                    printLog(account.UserName + ": Wygrałeś... Pakuje do sejfu... " + value);
                                }
                                else
                                {
                                    account.IsChecked = false;
                                    printLog(account.UserName + ": Przegrałeś... ");
                                }
                            }
                            else
                            {
                                printLog(account.UserName + ": Poza zasięgiem...");
                                //account.IsChecked = false;
                                account.Cash = -1;
                            }
                        }
                        writeAccountToFile(account);
                        updateAttackList(account); 
                        result += value;
                    }
                    else
                    {
                        printLog("Lista jest pusta!!!");
                        break;
                    }
                }
                else
                {
                    flag = true;
                    break;
                }

                if (clientSemafor)
                {
                    String relicCost = String.Empty;
                    if (parafia.attributes.Safe.Actual == parafia.attributes.Safe.Max)
                    {
                        int value = parafia.attributes.Safe.Actual;

                        if (parafia.attributes.Safe.Actual > parafia.attributes.Cash.Max)
                        {
                            value = parafia.attributes.Cash.Max;
                        }

                        value -= 1000;

                        TcpClient client = SocketUtils.ConnectToSrv();

                        printLog("[TRANSFER] Wysyłanie wiadomości do serwera o wartaści paczki.");
                        relicCost = SocketUtils.RequestRelicID(value, client);
                        printLog("[TRANSFER] Wiadomość przyjęta, paczka została wystawiona przez serwer i jest gotowa do zakupienia.");
                        if (!String.IsNullOrEmpty(relicCost))
                        {
                            int cost = int.Parse(relicCost);
                            if (cost != 0) {
                                parafia.getFromSafe(value); printLog("[TRANSFER] Kasa na pake pobrana z sejfu: " + value);

                                int id = 0;

                                if (parafia.countGreatChangeInMarket(cost, ref id) == 1)
                                {
                                    printLog("[TRANSFER] Warunki konieczne do zakupu paczki spełnione. Przechodze do procesu zakupu.");
                                    if (parafia.BuyGreatChangeById(id) == 1)
                                    {
                                        printLog("[TRANSFER] Transfer wykonany!");
                                        parafia.hideGreatChange();
                                        printLog("[TRANSFER] Relikwia schowana do sejfu.");
                                        printLog("[TRANSFER] Rozpoczynam proces zwrotu paczki do serwera.");
                                        string returnedRelicCost = parafia.ReturnGreatChange();
                                        printLog("[TRANSFER] Wysyłam koszt paczki do serwera: " + returnedRelicCost);
                                        SocketUtils.SendGreatChangeReturningCost(returnedRelicCost, client);
                                        printLog("[TRANSFER] Komunikat został wysłany.");
                                        parafia.putIntoSafe();
                                    }
                                    else
                                    {
                                        parafia.putIntoSafe();
                                        printLog("[TRANSFER] Błąd podczas transferu! Nie wykonany!!!");
                                    }
                                }
                                else
                                {
                                    parafia.putIntoSafe();
                                    printLog("[TRANSFER] Znaleziono więcej niż jedno relikwie/bądź wcale na rynku!!!");
                                }
                            }
                        }

                        SocketUtils.CloseConnectToSrv(client);
                    }
                }

            }
            while (parafia.attributes.Energy.Actual > 10 && parafia.attributes.Health.Actual > 10);
            printLog("Zakończona atakowanie... resultat: " + result);

            return flag;
        }

        public void printLog(String log)
        {
            mainForm.Invoke((Action)(delegate 
            {
                mainForm.lbLog.Items.Add(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + " --> " + log);

                if (mainForm.lbLog.Items.Count > 8)
                    mainForm.lbLog.TopIndex = mainForm.lbLog.Items.Count - 1;
            }));
        }

        public void showBalloonTip(String body, String title, ToolTipIcon toolTipIcon)
        {
            mainForm.Invoke((Action)(delegate
            {
                mainForm.niMain.ShowBalloonTip(0, "User: " + username + ", Proces: [" + title + "]", "Data: " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "\n" + body, toolTipIcon);
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

        public void StartRelics()
        {
            relicsSemafor = true;
        }

        public void StopRelics()
        {
            relicsSemafor = false;
        }

        public void StartAttack()
        {
            attackSemafor = true;
            if (!mainWorkSemafor)
            {
                nextLoginDt = DateTime.Now.AddSeconds(5);
                mainForm.tbAttackNext.Text = nextLoginDt.ToString("HH:mm:ss");
            }
        }

        public void StopAttack()
        {
            attackSemafor = false;
            if (!mainWorkSemafor)
            {
                mainForm.tbAttackLast.Text = "00:00:00";
                mainForm.tbAttackNext.Text = "00:00:00";
            }
        }

        public void StartUpTime()
        {
            upTimeStart = DateTime.Now;
            nextLoginDt = DateTime.Now.AddSeconds(5);
            //mainForm.tbNextLogin.Text = nextLoginDt.ToString("yyyy-MM-dd HH:mm:ss");
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
            try
            {
               // Parafia parafia = getInstance();
                //if (parafia != null)
                //    serverDt = getInstance().getSerwerTime();
               // else
                    serverDt = new TimeSpan(0, 0, 0, 0, 0);
            }
            catch
            {
                serverDt = new TimeSpan(0, 0, 0, 0, 0);
            }
        }

        public String[] getListOfCheckedQuests()
        {
            List<String> listOfNames = new List<String>();

            return listOfNames.ToArray<String>();
        }


        public List<Account> getListOfCheckedAttack()
        {
            List<Account> listOfNames = new List<Account>();

            mainForm.Invoke((Action)(delegate
            {
                ListView.ListViewItemCollection collection = mainForm.lvAttackList.Items;
                foreach (ListViewItem item in collection)
                {
                    if (item.Checked)
                    {
                        Account account = (Account)item.Tag;
                        if (DateTime.Equals(account.LastAttack, DateTime.MinValue) || (DateTime.Now - account.LastAttack).Hours >= 5)
                            listOfNames.Add(account);
                    }
                }
            }));

            return listOfNames;
        }

        public void updateAttackList(Account account)
        {
            mainForm.Invoke((Action)(delegate
            {
                ListView.ListViewItemCollection collection = mainForm.lvAttackList.Items;
                foreach (ListViewItem item in collection)
                {
                    if (account.Id == ((Account)item.Tag).Id)
                    {
                        item.SubItems[3].Text = new StringBuilder().Append(account.Cash + int.Parse(item.SubItems[3].Text)).ToString();
                        item.SubItems[4].Text = new StringBuilder().Append(account.WinHits).ToString();
                        item.SubItems[5].Text = new StringBuilder().Append(account.DefeatHits).ToString();
                        item.SubItems[6].Text = account.LastAttack.ToString("yyyy-MM-dd HH:mm:ss");
                        item.Checked = account.IsChecked;
                        account.Cash = 0;
                        item.Tag = account;
                        break;
                    }
                }
            }));
        }

        public void fillQuestsList()
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

                    if (quest.IsChecked)
                        item.Checked = true;

                    item.SubItems.Add(siName);
                    item.SubItems.Add(siProgress);
                }
            }
        }

        public void writeAccountToFile(Account account)
        {
            StreamWriter writer = new StreamWriter("attack_result.txt", true, Encoding.GetEncoding("ISO-8859-2"));
            writer.WriteLine(DateTime.Now + ";" + account.ToString());
            writer.Close();
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
                    sendPilgrimage = config.SendPilgrimage;
                    armyType = config.ArmyType;
                    Parafia parafia = new Parafia(this);
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
