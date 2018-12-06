using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsExample
{
    class Program
    {

        class MyDataClass<T,V>
        {
            T t1;
            V v1;


            public MyDataClass(T t1, V v1)
            {
                this.t1 = t1;
                this.v1 = v1;
            }

            public T retT()
            {
                return t1;
            }
            public V retV()
            {
                return v1;
            }
        }

        static void Main(string[] args)
        {

            MyDataClass<int, string> obj1 = new MyDataClass<int, string>(1, "abc");
            MyDataClass<int, int> obj2 = new MyDataClass<int, int>(1, 2);
            MyDataClass<double, int> obj3 = new MyDataClass<double, int>(1.55, 2);

            int a = obj1.retT();

            int b = obj2.retT();

            double c = obj3.retT();


            Console.ReadKey();

        }
    }
}
