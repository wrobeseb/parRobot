using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PBizBot.Model
{
    using Common;

    public partial class Oponent
    {
        private int m_id;
        private int m_lp;
        private int m_exp;
        
        private int m_lvl;

        private String m_name;
        private String m_groupName;
        private int m_win;
        private int m_lose;
        private int m_relics;

        private int m_defeated;
        private int m_victorious;

        public Oponent() { this.m_expHistory = new List<History>();
                           this.m_loseHistory = new List<History>(); 
                           this.m_lpHistory = new List<History>();
                           this.m_winHistory = new List<History>(); }

        public int Id { get { return this.m_id; } }
        public int Lp
        {
            get { return this.m_lp; }
            set
            {
                if (this.m_lp != 0) 
                    m_lpHistory.Add(new History(this.m_lp));
                this.m_lp = value;
            }
        }

        public int Exp
        {
            get { return this.m_exp; }
            set
            {
                if (this.m_exp != 0)
                    m_expHistory.Add(new History(this.m_exp));
                this.m_exp = value;
            }
        }



    }
}
