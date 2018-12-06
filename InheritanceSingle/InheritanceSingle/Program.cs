using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceSingle
{
    class Program
    {
        //a->b
        class Parent
        {
            int gold;
            int silver;
            protected int bankbalance;

            public void setdata(int g, int s, int b)
            {
                gold = g;
                silver = s;
                bankbalance = b;
            }
            public void getdata()
            {
                Console.WriteLine("Value of gold:{0} gm, silver:{1}, bankbal:{2} Rs.", gold, silver, bankbalance);
            }
        }
        class Child1 : Parent
        {
            int balance;

            public void setbal(int b)
            {
                balance = b;
            }
            public int getbal()
            {
                return balance;
            }
            public void combineBal()
            {
                Console.WriteLine("Bal Paernt {0}, child {1} and Total {2}", bankbalance, balance, bankbalance + balance);
            }
        }
        static void Main(string[] args)
        {
            Child1 childObj1 = new Child1();
            childObj1.setbal(120000);//child1 class method
            childObj1.setdata(100, 5, 4500000);

            childObj1.getdata();
            Console.WriteLine("Child have {0} Rs.", childObj1.getbal());

            childObj1.combineBal();
            Console.ReadKey();
        }
    }
}
