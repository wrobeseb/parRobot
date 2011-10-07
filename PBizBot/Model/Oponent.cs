using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Text;

namespace PBizBot.Model
{
    using Common;

    [Table(Name="oponent")]
    public class Oponent
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

        private DateTime m_lastAttack;

        private int m_attacker;

        private EntitySet<OponentHistory> m_history;

        //IsDbGenerated = true, DbType = "int NOT NULL IDENTITY"

        [Column(Name = "id", Storage = "m_id", IsPrimaryKey = true, DbType = "int NOT NULL", CanBeNull = false)]
        public int Id 
        { 
            get { return this.m_id; }
            set { this.m_id = value; }
        }

        [Column(Name = "lp", Storage = "m_lp", DbType = "int NOT NULL", CanBeNull = false)]
        public int Lp
        {
            get { return this.m_lp; }
            set { this.m_lp = value; }
        }

        [Column(Name = "exp", Storage = "m_exp", DbType = "int NOT NULL", CanBeNull = false)]
        public int Exp
        {
            get { return this.m_exp; }
            set { this.m_exp = value; }
        }

        [Column(Name = "level", Storage = "m_lvl", DbType = "int NOT NULL", CanBeNull = false)]
        public int Level
        {
            get { return this.m_lvl; }
            set { this.m_lvl = value; }
        }

        [Column(Name = "name", Storage = "m_name", DbType = "NVARCHAR(255) NOT NULL", CanBeNull = false)]
        public String Name 
        { 
            get { return this.m_name; }
            set { this.m_name = value; }
        }

        [Column(Name = "group_name", Storage = "m_groupName", DbType = "NVARCHAR(255) NOT NULL", CanBeNull = false)]
        public String GroupName
        { 
            get { return this.m_groupName; }
            set { this.m_groupName = value; }
        }

        [Column(Name = "battle", Storage = "m_battles", DbType = "int NOT NULL", CanBeNull = false)]
        public int Battles
        {
            get { return this.m_battles; }
            set { this.m_battles = value; }
        }


        [Column(Name = "win", Storage = "m_win", DbType = "int NOT NULL", CanBeNull = false)]
        public int Win
        {
            get { return this.m_win; }
            set { this.m_win = value; }
        }


        [Column(Name = "relics", Storage = "m_relics", DbType = "int NOT NULL", CanBeNull = false)]
        public int Relics
        {
            get { return this.m_relics; }
            set { this.m_relics = value; }
        }

        [Column(Name = "defeated", Storage = "m_defeated", DbType = "int NOT NULL", CanBeNull = false)]
        public int Defeated
        {
            get { return this.m_defeated; }
            set { this.m_defeated = value; }
        }

        [Column(Name = "victorious", Storage = "m_victorious", DbType = "int NOT NULL", CanBeNull = false)]
        public int Victorious
        {
            get { return this.m_victorious; }
            set { this.m_victorious = value; }
        }

        [Column(Name = "defense", Storage = "m_defense", DbType = "float NOT NULL", CanBeNull = false)]
        public double Defense
        {
            get { return this.m_defense; }
            set { this.m_defense = value; }
        }

        [Column(Name = "last_attack", Storage = "m_lastAttack", DbType = "DATE")]
        public DateTime LastAttack
        {
            get { return this.m_lastAttack ; }
            set { this.m_lastAttack = value; }
        }

        [Column(Name = "attacker", Storage = "m_attacker", DbType = "int")]
        public int Attacker
        {
            get { return this.m_attacker; }
            set { this.m_attacker = value; }
        }

        [Association(Storage = "m_history", ThisKey = "Id", OtherKey = "OponentId")]
        public EntitySet<OponentHistory> History
        {
            get { return this.m_history; }
            set { this.m_history = value; }
        }
    }
}
