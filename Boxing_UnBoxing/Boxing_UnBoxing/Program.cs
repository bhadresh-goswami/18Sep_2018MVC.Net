using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boxing_UnBoxing
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;

            /*
             * boxing: 
             * process of converting value type data to reference type
             */
            object IntToObject = (object)a;
            Console.WriteLine("\n\n\tObject {0}",IntToObject);
            //IntToObject++;//error


            /*
             * unboxing: 
             * process of converting reference type data to value type
             */
            int b = (int)IntToObject;
            Console.WriteLine("\n\n\tvariable b {0}",b);
            b++;//success!

            Console.ReadLine();
        }
    }
}
