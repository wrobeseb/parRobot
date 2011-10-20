using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParafiaPRO.Controller.Impl
{
    public abstract class AbstractController
    {
        public delegate void AsyncDelegate();

        protected void EndInvoke(IAsyncResult ar)
        {
            AsyncDelegate del = (AsyncDelegate)ar.AsyncState;
            try { del.EndInvoke(ar); }
            catch (Exception ex) { OnException(ex); }
        }

        protected void BeginInvoke(AsyncDelegate del)
        {
            del.BeginInvoke(EndInvoke, del);
        }

        protected virtual void OnException(Exception ex) { }
    }
}
