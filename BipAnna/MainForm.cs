using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BipAnna
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cbSentMails_CheckedChanged(object sender, EventArgs e)
        {
            bool flag = true;
            if (!cbSentMails.Checked)
            {
                flag = false;
            }

            tbMailHost.Enabled = flag;
            tbMailLogin.Enabled = flag;
            tbMailPassword.Enabled = flag;
            tbMailPort.Enabled = flag;
            tbMailSendHits.Enabled = flag;
            tbMailSubject.Enabled = flag;
            tbMailTo.Enabled = flag;
        }

        private void btStart_Click(object sender, EventArgs e)
        {

        }

        private void btStop_Click(object sender, EventArgs e)
        {

        }
    }
}
