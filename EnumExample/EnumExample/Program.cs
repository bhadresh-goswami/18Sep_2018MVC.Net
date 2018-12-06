using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumExample
{
    class Program
    {

        //declaration of enum
        //the collection of fix value that can't be change run time
        enum Course
        {
            MVC,
            iPhone,
            Angular,
            NodeJs,
            AngularJs
        }
        static void Main(string[] args)
        {
            Course c1 = Course.iPhone;
            Course c2 = Course.MVC;

            Console.WriteLine("\n\n\tC1:\t{0}", c1);
            Console.WriteLine("\n\n\tC2:\t{0}", c2);

            Console.ReadLine();
        }
    }
}
