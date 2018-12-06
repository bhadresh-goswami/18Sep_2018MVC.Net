using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using myNewNameSpace;

namespace NameSpaceExample
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass obj = new MyClass();
            obj.mymethod();
            Console.ReadKey();
        }
    }
}
