using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

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
            worker.StartWorker();
        }
    }
}
