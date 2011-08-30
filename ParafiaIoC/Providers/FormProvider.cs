using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParafiaIoC.Providers
{
    public class FormProvider
    {
        private MainForm mainForm;
        private ConfigForm configForm;

        public MainForm MainForm
        {
            set { this.mainForm = value; }
        }

        public ConfigForm ConfigForm
        {
            set { this.configForm = value; }
        }

        public void setNextLoginDate(String nextLoginDt, String hitCount)
        {
            mainForm.Invoke((Action)(delegate
            {
                mainForm.tbHitCount.Text = hitCount;
                mainForm.tbNextLogin.Text = nextLoginDt;
            }));
        }

        public void printLog(String log)
        {
            mainForm.Invoke((Action)(delegate
            {
                mainForm.lbLog.Items.Add(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + " --> " + log);
            }));
        }

        public void refreshSystemTime()
        {
            mainForm.Invoke((Action)(delegate
            {
                mainForm.tbSystemTime.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            }));
        }

        public refreshUpTime(
    }
}
