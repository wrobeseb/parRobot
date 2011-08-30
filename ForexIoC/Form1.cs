using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

using System.Net;
using System.Web;
using HttpUtils;

namespace ForexIoC
{
    public partial class Form1 : Form
    {
        private Worker worker;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            worker = new Worker();
            Thread workerThread = new Thread(worker.run);
            workerThread.Name = "WorkerThread";
            workerThread.Start();
        }

        private void pChart_Layout(object sender, LayoutEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DefaultHttpClient httpClient = new DefaultHttpClient();

            HttpWebResponse response2 = httpClient.HttpGet("https://trade.plus500.com/");

            String MachineId = "";
            Random rand = new Random();
            for (int i = 0; i < 32; i++)
            {
                MachineId += "0123456789abcdef".Substring((int)Math.Floor(rand.NextDouble() * 16), 1);
            }

            String base64String = Convert.ToBase64String(Encoding.UTF8.GetBytes("sairoroan".ToCharArray()));

            httpClient.AddCookie(new Cookie("MachineID", MachineId, "/", "trade.plus500.com"));
            httpClient.AddCookie(new Cookie("IsRealMode", "False", "/", "trade.plus500.com"));
            httpClient.AddCookie(new Cookie("UserName", HttpUtility.UrlEncode("sairo149240@gmail.com"), "/", "trade.plus500.com"));
            httpClient.AddCookie(new Cookie("ChoseAccountModeActively", "True", "/", "trade.plus500.com"));
            httpClient.AddCookie(new Cookie("Password", base64String, "/", "trade.plus500.com"));
            httpClient.AddCookie(new Cookie("PasswordHidden" , "1", "/", "trade.plus500.com"));
            httpClient.AddCookie(new Cookie("PasswordDontPersist", "1", "/", "trade.plus500.com"));

            CookieCollection cookies = httpClient.CookieContainer.GetCookies(new Uri("http://trade.plus500.com"));

            String cookieString = "";

            foreach (Cookie cookie in cookies)
            {
                cookieString += cookie.ToString() + ";";
            }

            WebBrowser wb = new WebBrowser();
            wb.ScrollBarsEnabled = false;
            wb.ScriptErrorsSuppressed = true;
            wb.Navigate("https://trade.plus500.com/"); 
            while (wb.ReadyState != WebBrowserReadyState.Complete) { Application.DoEvents(); }
            wb.Document.Cookie = cookieString;

            byte[] bytes = Encoding.UTF8.GetBytes("isRealMode=False&userName=sairo149240@gmail.com&password=sairoroan&savePassword=false");

            wb.Navigate("https://trade.plus500.com/Login?IsRealMode=False", "_self", bytes, "Content-Type: application/x-www-form-urlencoded");
            while (wb.ReadyState != WebBrowserReadyState.Complete) { Application.DoEvents(); }

            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(textBox1.Text);
        }

        private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {

        }

        private void webBrowser1_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {

        }
    }
}
