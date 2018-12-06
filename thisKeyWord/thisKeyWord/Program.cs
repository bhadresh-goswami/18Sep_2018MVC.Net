using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thisKeyWord
{
    class Program
    {

        //precap 
        //what is class?
        //what is an object?
        //what is data member and member function of class?
        //use of public and private
        //acceess the public member of class using object

        #region This Key Word

        class MyClassDemo
        {
            int a;//scope inside a class
            int b;

            //here a is argument or param of function
            public void setData(int a,int b)//a has scope inside only function
            {
                //we cant use this directly => a = a;
                this.a = a;
                this.b = b;

                //this.a is a member of class
                //means this is an active object of class
            }
        }
        #endregion

        #region Static Key Word
        class MyVariables
        {
            //simple public or private member of class can store the memory
            //for an object
            //means as per object the member is diff
            public int m_a;

            //static pub or private can only access by class itself
            //static member allocate memory for once for class
            public static int s_a;

        }
        #endregion

        static void Main(string[] args)
        {
            MyVariables varObj1 = new MyVariables();
            MyVariables varObj2 = new MyVariables();
            MyVariables varObj3 = new MyVariables();
            MyVariables varObj4 = new MyVariables();


            Console.WriteLine("\n\n");
            varObj1.m_a++;//?? why s_a is not appear in object
            varObj2.m_a++;
            varObj3.m_a++;
            varObj4.m_a++;


            Console.WriteLine("\t\tVarObj 1 m_a:{0}", varObj1.m_a);
            Console.WriteLine("\t\tVarObj 2 m_a:{0}", varObj2.m_a);
            Console.WriteLine("\t\tVarObj 3 m_a:{0}", varObj3.m_a);
            Console.WriteLine("\t\tVarObj 4 m_a:{0}", varObj4.m_a);



            Console.WriteLine("\n\n");
            MyVariables.s_a++;//?? why s_a is appear in class because it is static and only create for class
            MyVariables.s_a++;
            MyVariables.s_a++;
            MyVariables.s_a++;


            Console.WriteLine("\t\tMyVariables s_a:{0}", MyVariables.s_a++);
            Console.ReadKey();


        }
    }
}
