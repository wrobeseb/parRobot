using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Text;

namespace PBizBot.Model
{
    using Common;

    [Table(Name="oponent")]
    public partial class Oponent
    {
        private int m_id;
        private int m_lp;
        private int m_exp;
        
        private int m_lvl;

        private String m_name;
        private String m_groupName;
        private int m_battles;
        private int m_win;
        private int m_relics;

        private int m_defeated;
        private int m_victorious;

        private double m_defense;

        private int m_cashCaptured;

        private DateTime m_lastAttack;

        public Oponent() 
        { 
            this.m_expHistory = new List<History>();
            this.m_loseHistory = new List<History>(); 
            this.m_lpHistory = new List<History>();
            this.m_winHistory = new List<History>(); 
        }

        //IsDbGenerated = true, DbType = "int NOT NULL IDENTITY"

        [Column(Storage="m_id", IsPrimaryKey = true, Name = "id")]
        public int Id 
        { 
            get { return this.m_id; }
            set { this.m_id = value; }
        }

        [Column(Name="lp")]
        public int Lp
        {
            get { return this.m_lp; }
            set { this.m_lp = value; }
        }

        [Column(Name="exp")]
        public int Exp
        {
            get { return this.m_exp; }
            set { this.m_exp = value; }
        }

        [Column(Name="level")]
        public int Level
        {
            get { return this.m_lvl; }
            set { this.m_lvl = value; }
        }

        [Column(Name="name")]
        public String Name 
        { 
            get { return this.m_name; }
            set { this.m_name = value; }
        }

        [Column(Name="group_name")]
        public String GroupName
        { 
            get { return this.m_groupName; }
            set { this.m_groupName = value; }
        }

        [Column(Name = "battle")]
        public int Battles
        {
            get { return this.m_battles; }
            set { this.m_battles = value; }
        }


        [Column(Name="win")]
        public int Win
        {
            get { return this.m_win; }
            set { this.m_win = value; }
        }

       
        [Column(Name = "relics")]
        public int Relics
        {
            get { return this.m_relics; }
            set { this.m_relics = value; }
        }

        [Column(Name = "defeated")]
        public int Defeated
        {
            get { return this.m_defeated; }
            set { this.m_defeated = value; }
        }

        [Column(Name = "victorious")]
        public int Victorious
        {
            get { return this.m_victorious; }
            set { this.m_victorious = value; }
        }

        [Column(Name = "defense")]
        public double Defense
        {
            get { return this.m_defense; }
            set { this.m_defense = value; }
        }

        [Column(Name = "cash_captured")]
        public int CashCaptured
        {
            get { return this.m_cashCaptured; }
            set { this.m_cashCaptured = value; }
        }

        [Column(Name = "last_attack")]
        public DateTime LastAttack
        {
            get { return this.m_lastAttack ; }
            set { this.m_lastAttack = value; }
        }
    }
}
