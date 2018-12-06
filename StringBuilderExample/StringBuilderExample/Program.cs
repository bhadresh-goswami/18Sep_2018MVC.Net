using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilderExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            StringBuilder dataString = new StringBuilder();
            dataString.Append("\tLine 1!");
            dataString.Append("\tLine 2!");
            dataString.AppendLine("new line");
            dataString.AppendFormat("\tvalue of a is {0}", a);
            Console.WriteLine(dataString);

            dataString.Remove(0, 10);
            Console.WriteLine(dataString);

            dataString.Replace("a", "A");
            Console.WriteLine(dataString);


            Console.ReadKey();
        }
    }
}
