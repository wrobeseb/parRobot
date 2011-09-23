using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Practices.Prism.Logging;

namespace ParafiaPrism
{
    class CallbackLogger : ILoggerFacade
    {
        private Queue<Tuple<string, Category, Priority>> savedLogs = new Queue<Tuple<string, Category, Priority>>();
        private Action<string, Category, Priority> callback;

        public Action<string, Category, Priority> Callback
        {
            get
            {
                return this.callback;
            }
            set
            {
                this.callback = value;
            }
        }

        public void Log(string message, Category category, Priority priority)
        {
            if (this.Callback != null)
            {
                this.Callback(message, category, priority);

            }
            else
            {
                savedLogs.Enqueue(new Tuple<string, Category, Priority>(message, category, priority));
            }
        }

        public void ReplaySavedLogs()
        {
            if (this.Callback != null)
            {
                while (this.savedLogs.Count > 0)
                {
                    var log = this.savedLogs.Dequeue();
                    this.Callback(log.Item1, log.Item2, log.Item3);
                }
            }
        }
    }
}
