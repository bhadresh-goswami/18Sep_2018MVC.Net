using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFunctionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string data = "Tops_technologies";

            string cloneString = (string)data.Clone();//it returns a referece type object


            Console.WriteLine("\n\n\tObject Clone:{1} and string : {0}", cloneString, data);

            char[] copyString = new char[10];

            data.CopyTo(4, copyString, 5, 3);
            Console.WriteLine("\n\n");
            for (int i = 0; i < copyString.Length; i++)
            {
                Console.Write("{1}:[{0}]\t", copyString[i],i);
            }



            Console.WriteLine("\n\n\nCompare to function...");
            //cloneString = "abc";
            Console.WriteLine(cloneString.CompareTo(data));

            Console.WriteLine("\n\n\nequals to function...");
            //cloneString = "abc";
            Console.WriteLine(cloneString.Equals(data));


            Console.WriteLine("\n\n\nContains function...");
            //cloneString = "abc";
            Console.WriteLine(cloneString.Contains("Tops"));


            Console.WriteLine("\n\n\nEnd with function...");
            //cloneString = "abc";
            Console.WriteLine(cloneString.EndsWith("ogies"));




            Console.WriteLine("\n\n\nGetHashCode with function...");
            //cloneString = "abc";
            Console.WriteLine(cloneString.GetHashCode());


            Console.WriteLine("\n\n\nIsNormalized with function...");
            cloneString = "◌̣+◌̇";
            Console.WriteLine(cloneString.IsNormalized());


            Console.WriteLine("\n\n\nIsNormalized with function...");
            cloneString = "123";
            int a = 123;
            Console.WriteLine(a.GetType());
            Console.WriteLine("\n\n\nIsNormalized with function...");
            cloneString = "123";
            a = 123;
            Console.WriteLine(a.GetTypeCode());


            /*
             Insert()	Insert the string or character in the string at the specified position.
IsNormalized()	This method checks whether this string is in Unicode normalization form C.
LastIndexOf()	Returns the index position of last occurrence of specified character.
Length	It is a string property that returns length of string.
Remove()	This method deletes all the characters from beginning to specified index position.
Replace()	This method replaces the character.
Split()	This method splits the string based on specified value.
StartsWith()	It checks whether the first character of string is same as specified character.
Substring()	This method returns substring.
ToCharArray()	Converts string into char array.
Trim()	It removes extra whitespaces from beginning and ending of string.
             
             */

            StringBuilder str123 = new StringBuilder();
            str123.Append("tops tech");
            str123.Insert(5, "ooo");

            Console.WriteLine("\n\n\tValue inserted {0}", str123);


            str123.Replace("o", "_");
            Console.WriteLine("\n\n\tValue inserted {0}", str123);


            str123.Remove(5, 3);
            Console.WriteLine("\n\n\tValue inserted {0}", str123);

            Console.WriteLine("\n\n\n");

            string emailid = "bhadresh@tops-int.com";
            Console.WriteLine(emailid);
            string[] arr = emailid.Split('@');
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n\n\n");
            string hobbies = "cricket,music,story book, cartoon, toon";
            string[] arr1 = hobbies.Split(',');
            foreach (var item in arr1)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n\n\n");

            char[] chs = hobbies.ToCharArray();
            for (int i = 0; i < chs.Length; i++)
            {
                Console.Write("{0}:{1}\t", i, chs[i]);
            }
            Console.ReadKey();

        }
    }
}
