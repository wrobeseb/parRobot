using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HttpUtils;

namespace ParafiaPRO.Model.Account
{
    using HtmlAgilityPack;
    using Core.Utils;
    using log4net;

    public partial class Attributes
    {
        private static ILog log = LogManager.GetLogger(typeof(Attributes));

        private String mName;
        private String mParafia;
        private String mOdpusty;

        private int mLevelNo;
        private int mExpActual;
        private int mExpNextLevel;

        private int mCashActual;
        private int mCashMax;
        private int mCashGrow;
        private int mSafeActual;
        private int mSafeMax;
        private int mHealthActual;
        private int mHealthMax;
        private int mHealthGrow;
        private int mEnergyActual;
        private int mEnergyMax;
        private int mEnergyGrow;
        private int mBeliversActual;
        private int mBeliversMax;
        private int mBeliversGrow;
        private int mVicarActual;
        private int mVicarMax;
        private int mRelicsActual;
        private int mRelicsInSafe;
        private int mRelicsMaxSafe;

        public Attributes(String responseContent)
        {
            this.mName = HtmlUtils.GetStringValueByXPathExpression(responseContent, "//ul[1]/li[1]/text()");
            this.mName = this.mName.Split(' ')[1];

            this.mParafia = HtmlUtils.GetStringValueByXPathExpression(responseContent, "//ul[1]/li[2]/text()");
            this.mParafia = this.mParafia.Split(' ')[1];

            this.mOdpusty = HtmlUtils.GetStringValueByXPathExpression(responseContent, "//ul[1]/li[3]/text()");
            this.mOdpusty = this.mOdpusty.Split(' ')[1];

            AccountUtils.ExtractLevel(out this.mLevelNo, out this.mExpActual, out this.mExpNextLevel, HtmlUtils.GetSingleNodeByXPathExpression(responseContent, "//ul[2]/li[1]"));
            AccountUtils.ExtractFieldWithGrow(out this.mCashActual, out this.mCashMax, out this.mCashGrow, HtmlUtils.GetSingleNodeByXPathExpression(responseContent, "//ul[2]/li[2]"));
            AccountUtils.ExtractField(out this.mSafeActual, out this.mSafeMax, HtmlUtils.GetSingleNodeByXPathExpression(responseContent, "//ul[2]/li[3]"));
            AccountUtils.ExtractFieldWithGrow(out this.mHealthActual, out this.mHealthMax, out this.mHealthGrow, HtmlUtils.GetSingleNodeByXPathExpression(responseContent, "//ul[2]/li[4]"));
            AccountUtils.ExtractFieldWithGrow(out this.mEnergyActual, out this.mEnergyMax, out this.mEnergyGrow, HtmlUtils.GetSingleNodeByXPathExpression(responseContent, "//ul[2]/li[5]"));
            AccountUtils.ExtractFieldWithGrow(out this.mBeliversActual, out this.mBeliversMax, out this.mBeliversGrow, HtmlUtils.GetSingleNodeByXPathExpression(responseContent, "//ul[2]/li[6]"));
            AccountUtils.ExtractField(out this.mVicarActual, out this.mVicarMax, HtmlUtils.GetSingleNodeByXPathExpression(responseContent, "//ul[2]/li[7]"));
            AccountUtils.ExtractRelics(out this.mRelicsActual, out this.mRelicsInSafe, out this.mRelicsMaxSafe, HtmlUtils.GetSingleNodeByXPathExpression(responseContent, "//ul[2]/li[8]"));
            log.Info("Atrybuty dla konta zostały zaczytane...");
        }

        public String Name { get { return this.mName; } }
        public String Parafia { get { return this.mParafia; } }
        public String Odpusty { get { return this.mOdpusty; } }

        public int LevelNo { get { return this.mLevelNo; } }
        public int ExpActual { get { return this.mExpActual; } }
        public int ExpNextLevel { get { return this.mExpNextLevel; } }
        public int CashActual { get { return this.mCashActual; } }
        public int CashMax { get { return this.mCashMax; } }
        public int CashGrow { get { return this.mCashGrow; } }
        public int SafeActual { get { return this.mSafeActual; } }
        public int SafeMax { get { return this.mSafeMax; } }
        public int HealthActual { get { return this.mHealthActual; } }
        public int HealthMax { get { return this.mHealthMax; } }
        public int HealthGrow { get { return this.mHealthGrow; } }
        public int EnergyActual { get { return this.mEnergyActual; } }
        public int EnergyMax { get { return this.mEnergyMax; } }
        public int EnergyGrow { get { return this.mEnergyGrow; } }
        public int BeliversActual { get { return this.mBeliversActual; } }
        public int BeliversMax { get { return this.mBeliversMax; } }
        public int BeliversGrow { get { return this.mBeliversGrow; } }
        public int VicarActual { get { return this.mVicarActual; } }
        public int VicarMax { get { return this.mVicarMax; } }
        public int RelicsActual { get { return this.mRelicsActual; } }
        public int RelicsInSafe { get { return this.mRelicsInSafe; } }
        public int RelicsMaxSafe { get { return this.mRelicsMaxSafe; } }
    }
}
