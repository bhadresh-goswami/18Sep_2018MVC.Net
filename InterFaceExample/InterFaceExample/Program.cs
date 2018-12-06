using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterFaceExample
{
    class Program
    {
        interface IMethods
        {
            void method1();
            void method2(int a, int b);
            void method3(string name);
        }

        class ClassA
        {

        }
        class ClassB : ClassA, IMethods
        {
            public void method1()
            {
            }

            public void method2(int a, int b)
            {
            }

            public void method3(string name)
            {
            }
        }

        abstract class class2
        {
            //simple
            public void sum()
            {

            }
            public abstract void calc();
        }

        class ClassC : class2
        {
            public override void calc()
            {
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
