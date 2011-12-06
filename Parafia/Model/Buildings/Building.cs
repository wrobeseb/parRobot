using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parafia.Model.Buildings
{
    public partial class Building
    {
        private String mName;
        private int mLevel;
        private List<Benefit> mBenefits;
        private List<Benefit> mNextLevelBenefits;
        private int mCashCost;
        private int mEnergyCost;
        private String mBuildTime;

        public Building(String name, int level)
        {
            this.mName = name;
            this.mLevel = level;
        }

        public String Name
        {
            get { return this.mName; }
        }

        public int Level
        {
            get { return this.mLevel; }
        }

        public List<Benefit> Benefits
        {
            get { return this.mBenefits; }
        }

        public List<Benefit> NextLevelBenefits
        {
            get { return this.mNextLevelBenefits; }
        }

        public int CashCost
        {
            get { return this.mCashCost; }
        }

        public int EnergyCost
        {
            get { return this.mEnergyCost; }
        }

        public String BuildTime
        {
            get { return this.mBuildTime; }
        }
    }
}
