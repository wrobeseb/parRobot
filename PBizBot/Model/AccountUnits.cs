using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PBizBot.Model
{
    public class AccountUnits
    {
        private double attack;
        private double defense;

        public AccountUnits() { }

        public AccountUnits(String responseContent)
        {

        }

        public double Attack { get { return this.attack; } }
        public double Defense { get { return this.defense; } }
    }
}
