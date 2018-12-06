using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiDimeArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //datatype [,] var = new datatype[row,col];

            int[,] arrInt = new int[3, 3];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("\n\n\tEnter val [{0},{1}]:\t",i,j);
                    arrInt[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }


            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("\n\tval [{0},{1}]:\t{2}", i, j,arrInt[i,j]);
                }
            }

            Console.ReadKey();

        }
    }
}
