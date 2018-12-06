using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExample
{
    class Program
    {
        static void Main(string[] args)
        {

            //syntax
            //one dime array
            //dataType [] var = new dataType[size];

            int[] arrInt = new int[5];
            for (int i = 0; i < arrInt.Length; i++)
            {
                Console.Write("\n\tEnter Value at {0}:\t", i);
                arrInt[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Clear();

            Console.WriteLine("\n\n\n");
            foreach (var element in arrInt)
            {
                Console.Write("{0}\t", element);
            }
            Console.WriteLine("\n\n\n");
            for (int i = 0; i < arrInt.Length; i++)
            {
                Console.Write("[{0}]:{1}\t", i, arrInt[i]);
            }

            //clone


            int[] arrClone =(int[]) arrInt.Clone();




            Console.WriteLine("\n\n\nClone values:");
            foreach (var element in arrClone)
            {
                Console.Write("{0}\t", element);
            }
            Console.WriteLine("\n\n\n");
            for (int i = 0; i < arrClone.Length; i++)
            {
                Console.Write("[{0}]:{1}\t", i, arrClone[i]);
            }


            //copy


            int[] arrCopy = new int[4];
            Array.Copy(arrInt, arrCopy, 4);



            Console.WriteLine("\n\n\ncopied values:");
            foreach (var element in arrCopy)
            {
                Console.Write("{0}\t", element);
            }


            Array.Copy(arrInt, 1, arrCopy, 0, 4);

            Console.WriteLine("\n\n\n");
            for (int i = 0; i < arrCopy.Length; i++)
            {
                Console.Write("[{0}]:{1}\t", i, arrCopy[i]);
            }


            Console.WriteLine("\n\n\nSorting:");
            Array.Sort(arrClone);
            for (int i = 0; i < arrClone.Length; i++)
            {
                Console.Write("[{0}]:{1}\t", i, arrClone[i]);
            }
            Console.WriteLine("\n\n\nSorting Reverse:");

            Array.Reverse(arrClone);
            for (int i = 0; i < arrClone.Length; i++)
            {
                Console.Write("[{0}]:{1}\t", i, arrClone[i]);
            }


            for (int i = 0; i < arrCopy.Length; i++)
            {
                for (int j = 0; j < arrCopy.Length; j++)
                {
                    if(arrCopy[i]>arrCopy[j])
                    {
                        int temp = arrCopy[i];
                        arrCopy[i] = arrCopy[j];
                        arrCopy[j] = temp;
                    }
                }
            }

            Console.WriteLine("\n\n\n");
            for (int i = 0; i < arrCopy.Length; i++)
            {
                Console.Write("[{0}]:{1}\t", i, arrCopy[i]);
            }

            Console.ReadKey();

        }
    }
}
