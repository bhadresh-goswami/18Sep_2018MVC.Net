using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyMorphisum
{
    class Program
    {

        class Calculation
        {
            public void process()
            {
                int a;
                int b;
                Console.Write("\n\tEnter a:\t");
                a = int.Parse(Console.ReadLine());
                Console.Write("\n\tEnter b:\t");
                b = int.Parse(Console.ReadLine());


                Console.WriteLine("\n\n\tAns:{0}", a + b);
            }
            public void process(int a, int b)
            {


                Console.WriteLine("\n\n\tAns:{0}", a + b);
            }
            public void process(double a, double b)
            {


                Console.WriteLine("\n\n\tAns:{0}", a + b);
            }
        }


        static void Main(string[] args)
        {

            Calculation calculation = new Calculation();
            calculation.process();
            calculation.process(3,4);
            calculation.process(4.5,6.7);

            Console.ReadKey();
        }
    }
}
