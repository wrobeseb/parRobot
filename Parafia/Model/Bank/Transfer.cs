using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parafia.Model.Bank
{
    public class Transfer : IComparable
    {
        private int value;
        private String url;

        public Transfer(int value, String url)
        {
            this.value = value;
            this.url = url;
        }
             
        public int Value
        {
            get { return this.value; }
        }

        public String Url
        {
            get { return this.url; }
        }

        public int CompareTo(object obj)
        {
            Transfer trans = (Transfer)obj;
            if (trans.Value > value) return 1;
            else if (trans.Value < value) return -1;

            return 0;
        }
    }
}
