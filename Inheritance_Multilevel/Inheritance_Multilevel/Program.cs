using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Multilevel
{
    class Program
    {
        class ClassA
        {
            public int a;
        }
        class ClassB : ClassA
        {
            public int b;
        }
        class ClassC : ClassB
        {
            public int c;
        }
        static void Main(string[] args)
        {
            ClassC obj = new ClassC();
            obj.a = 9;
            obj.b = 2;
            obj.c = 21;
            Console.ReadKey();
        }
    }
}
