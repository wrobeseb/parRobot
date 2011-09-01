using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parafia.Model.Common
{
    public class Relic
    {
        private String name;

        public Relic() {}

        public Relic(String name)
        {
            this.name = name;
        }

        public String Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
    }
}
