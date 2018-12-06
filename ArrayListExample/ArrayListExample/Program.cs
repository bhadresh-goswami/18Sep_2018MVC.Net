using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListExample
{
    class Program
    {
        static void Main(string[] args)
        {

            //array list
            //arr = new int[3][];
            //arr[0] = [3,4,5,6]
            //arr[1] = [3,4]
            //arr[3] = [2]

            ArrayList arrayList = new ArrayList();
            arrayList.Add(4);
            arrayList.Add(55);
            arrayList.Add("kiran");
            //object
            arrayList.Insert(1, "new val");
            arrayList.Remove(55);//by value
            arrayList.RemoveAt(0);//by index

            foreach (var element in arrayList)
            {
                Console.WriteLine(element);
            }

            Console.ReadKey();
        }
    }
}
