using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parafia.Exceptions
{
    class MoreThenOneGreatChange : Exception
    {
        private int count;

        public MoreThenOneGreatChange() { }

        public MoreThenOneGreatChange(string message) : base(message) { }

        public MoreThenOneGreatChange(int count) { this.count = count; }
    }
}
