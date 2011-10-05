using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Skybound.Gecko;

namespace GeckoFxTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            Xpcom.Initialize(Application.StartupPath + "/xulrunner");
            GeckoPreferences.Default["network.proxy.http"] = "126.179.0.200";
            GeckoPreferences.Default["network.proxy.http_port"] = 3128;
            GeckoPreferences.Default["network.proxy.login"] = "TP/wrobese2";
            GeckoPreferences.Default["network.proxy.password"] = "#Pazdziernik2011#";
            GeckoPreferences.Default["network.proxy.type"] = 1;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            geckoWebBrowser1.Navigate("http://parafia.biz");
        }
    }
}
