using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classExample
{
    //class is a collection of object
    //class is a colleciton of data member and member  function
    //class is the blueprint that define the form of an object
    //class is template that define the object

    class Program
    {

        class StudentClass
        {

            //data members: 90% of your data member is private to class
            int no;///int no is private to class
            //what do you mean by private?
            //cant be access throught out a class
            //only accessible inside a class
            //variable scope is inside a class

            public string name;
            //public can be access thru-out the class
            //not directly 
            //need to create an instance of the class 
            //that instance is called object or real time variable that access
            //public function or data of class



            //member functions: 90% of your functions of class is pub 
            public void SetData()
            {
                Console.WriteLine("\n\n\tEnter No:\t");
                no = int.Parse(Console.ReadLine());

                Console.WriteLine("\n\tEnter Name:\t");
                name = Console.ReadLine();
            }


            public void Display()
            {
                Console.WriteLine("\n\n\tData:");
                Console.WriteLine("\n\tNo:\t{0}\t\tName:\t{1}", no, name);
            }
        }
        //class end here

        static void Main(string[] args)
        {

            //create an object of class
            StudentClass stdObj1 = new StudentClass();
            StudentClass stdObj2 = new StudentClass();
            StudentClass stdObj3 = new StudentClass();
            StudentClass stdObj4 = new StudentClass();

            stdObj1.SetData();
            stdObj2.SetData();
            stdObj3.SetData();
            stdObj4.SetData();
            Console.ReadKey();
            Console.Clear();

            stdObj1.Display();
            stdObj2.Display();
            stdObj3.Display();
            stdObj4.Display();


            Console.ReadKey();
        }
    }
}
