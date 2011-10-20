using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ParafiaPRO.View.Impl
{
    public class AbstractView : UserControl
    {
        protected void Action(MethodInvoker actionDelegate)
        {
            try
            {
                if (InvokeRequired)
                    this.Invoke(actionDelegate);
                else
                    actionDelegate();
            }
            catch { }
        }
    }
}
