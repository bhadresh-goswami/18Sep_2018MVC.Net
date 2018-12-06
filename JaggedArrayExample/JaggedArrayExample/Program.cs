using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArrayExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //int [,] data = new int[4,4]; 16
            int[][] jarr = new int[4][];

            jarr[0] = new int[3];
            jarr[1] = new int[2];
            jarr[2] = new int[4];
            jarr[3] = new int[1];

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < jarr[i].Length; j++)
                {
                    Console.Write("\n\n\tEnter Element at {0},{1}:\t",i,j);
                    jarr[i][j] = Convert.ToInt32(Console.ReadLine());
                }
            }


            Console.Clear();

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("\n\n");
                for (int j = 0; j < jarr[i].Length; j++)
                {
                    Console.Write("\t{0}", jarr[i][j]);
                }
            }


            Console.ReadLine();
        }
    }
}
