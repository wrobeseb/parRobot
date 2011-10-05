using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PBizBot.Model
{
    public partial class Account
    {
        private double attack;
        private double defense;

        public void SetUnitsInfo(String responseContent)
        {
        }

        public double Attack { get { return this.attack; } }
        public double Defense { get { return this.defense; } }
    }
}
