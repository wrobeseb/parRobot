using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parafia.Model.Buildings
{
    public class Benefit
    {
        private BenefitType mType;
        private String mValue;

        public Benefit(BenefitType type, String value)
        {
            this.mType = type;
            this.mValue = value;
        }

        public BenefitType Type
        {
            get { return this.mType; }
        }

        public String Value
        {
            get { return this.mValue; }
        }
    }
}
