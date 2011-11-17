using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parafia.Model.Relics
{
    public class Relic
    {
        private int id;
        private String name;
        private int inSafe;
        private int count;

        public Relic() {}

        public Relic(int id, String name)
        {
            this.id = id;
            this.name = name;
        }

        public int Id
        {
            get { return this.id; }
        }

        public String Name
        {
            get { return this.name; }
        }

        public int InSafe
        {
            get { return this.inSafe; }
            set { this.inSafe = value; }
        }

        public int Count
        {
            get { return this.count; }
            set { this.count = value; }
        }
    }
}
