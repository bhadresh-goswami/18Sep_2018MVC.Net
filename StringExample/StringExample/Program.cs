using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, tech;

            Console.Write("\n\tEnter Name:\t");
            name = Console.ReadLine();

            Console.Write("\n\tEnter Technologies:\t");
            tech = Console.ReadLine();

            Console.WriteLine("\n\n\tName:{0}\tTechnology:{1}!",name,tech);

            //following will change the value of name and tech variables
            Console.Write("\n\tEnter Name:\t");
            name = Console.ReadLine();

            Console.Write("\n\tEnter Technologies:\t");
            tech = Console.ReadLine();

            Console.WriteLine("\n\n\tName:{0}\tTechnology:{1}!", name, tech);

            Console.ReadLine();
        }
    }
}
