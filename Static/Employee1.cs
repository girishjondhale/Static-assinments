using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static
{
    public enum Dept { hr,admin,development,testing};
    public class Employee1
    {
        protected string name;
        protected int empid;
        protected double basicsal, hra, ta, da, pf, gs, ts;
        private static int count;
        private Dept dept;

        public Employee1(string name, double basicsal, Dept dept)
        {
            count++;
            this.basicsal = basicsal;
            this.name = name;
            this.empid = count;
            this.dept = dept;
        }
        public static int GetCount()
        {
            return count;
        }
        public virtual void Calculatesal()
        {
            hra = basicsal * 40 / 100;
            ta = basicsal * 20 / 100;
            da = basicsal * 15 / 100;
            pf = basicsal * 12 / 100;
            ts = basicsal + hra + ta + da;
            gs = ts - pf;
        }
        public override string ToString()
        {
            return $"id={empid}\nemployee name -{name}\nbasic salary -{basicsal}\ntotalsal -{ts}\ngrosssal -{gs}";
        }

        public class Salesmanager : Employee1
        {
            private double comm;

            public Salesmanager(string name, double basicsal, double comm) : base(name, basicsal,Dept.testing )
            {
                this.comm = comm;
            }
            public override void Calculatesal()
            {
                hra = basicsal * 40 / 100;
                ta = basicsal * 20 / 100;
                da = basicsal * 15 / 100;
                pf = basicsal * 12 / 100;
                ts = basicsal + hra + ta + da;
                gs = ts + comm - pf;
            }
            public override string ToString()
            {
                return $"id ={empid}\n employee name -{name}\nbasic salary -{basicsal}\ntotalsal -{ts}\ngrosssal -{gs}";
            }
        }
            public class Ceo : Employee1
            {
                private double profit;

                public Ceo(string name, double basicsal, double profit) : base(name, basicsal, Dept.testing)
                {
                    this.profit = profit;
                }
                public override void Calculatesal()
                {
                    hra = basicsal * 40 / 100;
                    ta = basicsal * 20 / 100;
                    da = basicsal * 15 / 100;
                    pf = basicsal * 12 / 100;
                    ts = basicsal + hra + ta + da;
                    gs = ts + profit - pf;
                }
                public override string ToString()
                {
                    return $"id ={empid}\n employee name -{name}\nbasic salary -{basicsal}\ntotalsal -{ts}\ngrosssal -{gs}";
                }





            }

        }
    }

