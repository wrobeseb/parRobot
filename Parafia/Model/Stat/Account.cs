using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parafia.Model.Stat
{
    public class Account : IComparable
    {


        public Account() { }
        public Account(String value)
        {
            String[] values = value.Split(';');
            if (values.Length == 8 || values.Length == 9)
            {
                IsChecked = true;
                try
                {
                    Id = int.Parse(values[0]);
                    Lp = int.Parse(values[1]);
                    UserName = values[2].Replace("\"", "");
                    GroupName = values[3].Replace("\"", "");
                    Exp = int.Parse(values[4]);
                    Battles = int.Parse(values[5]);
                    Win = int.Parse(values[6]);
                    Relic = int.Parse(values[7]);
                    if (values.Length == 9)
                        Defense = double.Parse(values[8]);
                }
                catch { }
            }
        }

        public int Id
        {
            get;
            set;
        }

        public int Lp
        {
            get;
            set;
        }

        public String UserName
        {
            get;
            set;
        }

        public String GroupName
        {
            get;
            set;
        }

        public int Exp
        {
            get;
            set;
        }

        public int Battles
        {
            get;
            set;
        }

        public int Win
        {
            get;
            set;
        }

        public int Relic
        {
            get;
            set;
        }

        public bool IsChecked
        {
            get;
            set;
        }

        public int WinHits
        {
            get;
            set;
        }

        public int DefeatHits
        {
            get;
            set;
        }

        public int Cash
        {
            get;
            set;
        }

        public double Defense
        {
            get;
            set;
        }

        public DateTime LastAttack
        {
            get;
            set;
        }

        public override String ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(Id).Append(";").Append(Lp).Append(";");
            builder.Append("\"").Append(UserName).Append("\"").Append(";");
            builder.Append("\"").Append(GroupName).Append("\"").Append(";");
            builder.Append(Exp).Append(";");
            builder.Append(Battles).Append(";");
            builder.Append(Win).Append(";");
            builder.Append(Relic);
            builder.Append(";").Append(Defense);
            builder.Append(";").Append(Cash);

            return builder.ToString();
        }

        public int CompareTo(object obj)
        {
            if (obj is Account)
            {
                Account account = (Account)obj;
                if (account.Lp > Lp)
                    return -1;
                if (account.Lp < Lp)
                    return 1;

                return 0;
            }
            throw new NotImplementedException();
        }
    }
}
