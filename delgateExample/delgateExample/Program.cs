using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delgateExample
{
    class Program
    {

        public delegate void methodList();

        public static void method1()
        {
            Console.WriteLine("\n\n\tMethod 1 is called!");
        }
        public static void method2()
        {

            Console.WriteLine("\n\n\tMethod 2 is called!");
        }
        public static void method3()
        {

            Console.WriteLine("\n\n\tMethod 3 is called!");
        }
        static void Main(string[] args)
        {
            methodList obj = new methodList(method1);
            obj += method2;
            obj = obj + method3;

            obj();

            Console.ReadKey();
        }
    }
}
