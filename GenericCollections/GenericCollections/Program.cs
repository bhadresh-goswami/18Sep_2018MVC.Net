using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollections
{
    class Program
    {

        class info
        {
            int id;
            string name;

            public info(int id, string name)
            {
                this.id = id;
                this.name = name;
            }

            public void showdata()
            {
                Console.WriteLine("\n\nId:\t{0}", id);
                Console.WriteLine("Name:\t{0}", name);
            }
        }
        static void Main(string[] args)
        {

            List<int> intList = new List<int>();
            intList.Add(44);//0
            intList.Add(22);//1
            intList.Insert(1, 144);//2
            intList.Add(221);//3



            foreach (var item in intList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\n\n\n\n");
            List<string> nameList = new List<string>();
            nameList.Add("kiran");
            nameList.Add("aditi");

            foreach (var item in nameList)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
            Console.Clear();


            Dictionary<string, info> listdata = new Dictionary<string, info>();
            listdata["student1"] = new info(1, "kiran");



            Dictionary<string, List<info>> listOfStudent = new Dictionary<string, List<info>>();

            listOfStudent["iOS"] = new List<info>() {

                new info(1,"nishit"),

                new info(2,"vikram")

            };



            listOfStudent["MVC.Net"] = new List<info>() {

                new info(1,"aditi"),

                new info(2,"kiran"),

                new info(3,"Other")

            };


            string[] keys = listOfStudent.Keys.ToArray();
            foreach (var k in keys)
            {
                foreach (var std in listOfStudent[k])
                {
                    Console.WriteLine("\n\t\tCourse Name:{0}",k);
                    std.showdata();
                }
            }


            Console.ReadLine();
        }
    }
}
