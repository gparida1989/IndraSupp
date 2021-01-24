using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryDemo
{
    public class ArrayDemo
    {
        public void Test()
        {
            int[] ar = { 3, 5, 12, 53, 67 };

            // iterate over ar
            // loops 9for,while,do..while
            // foreach

            int firstRN = 0;
            int lastRN = ar.Length - 1;

            //for(int i=firstRN;i<=lastRN;i++)
            //{
            //    Console.WriteLine($"Element at position {i} is {ar[i]}");
            //}

            //foreach(var x in ar)
            //{
            //    Console.WriteLine($"Elements :{x}");
            //}

            string s = "indra";

            char[] sc = { 'i', 'n', 'd', 'r', 'a' };

            Console.Write(s[3]);

            foreach(var s1 in s)
            {
                Console.WriteLine($"charecter in S is :{s1}");
            }

        }

        public void Test1()
        {
            int[] ar = new int[8] { 4,5,8,6,5,2,7,3};

            PrintArray(ar);
            string[] ar1 = new string[2] { "india", "cnada" };
            PrintArray(ar1);

            int[] d = new int[15];
            ar.CopyTo(d, 2);

            object copycat = ar.Clone();

            Array newAr = (Array)copycat;//type csting 
            PrintArray(newAr);

        }

        void PrintArray(Array array)
        {
            for (int n = 0; n < array.Length; n++)
            {
                Console.WriteLine($"Element at {n} index is : {array.GetValue(n)}");
            }
        }
    }
}
