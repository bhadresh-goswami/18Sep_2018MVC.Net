using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverRiding
{
    class Program
    {
        class Parent
        {
            public int a;
            public virtual void cal()
            {
                Console.WriteLine("parent's method!");
            }
        }
        class Child : Parent
        {
            public new int a;
            public override void cal()
            {
                base.cal();
                Console.WriteLine("child's method!");
            }
        }
        static void Main(string[] args)
        {

            Child child = new Child();
            child.cal();
            Console.ReadLine();
        }
    }
}
