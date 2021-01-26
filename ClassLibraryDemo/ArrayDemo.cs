using System;
using System.Collections;
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
            //int[] ar = new int[8] { 4,5,8,6,5,2,7,3};

            //PrintArray(ar);
            //string[] ar1 = new string[2] { "india", "cnada" };
            //PrintArray(ar1);

            //int[] d = new int[15];
            //ar.CopyTo(d, 2);

            //object copycat = ar.Clone();

            //Array newAr = (Array)copycat;//type csting 
            //PrintArray(newAr);

            // declare an array
            // size =5
            // ar[0] = "indra"
            // ar[1] = 55
            // ar[2] = 65.3
            // ar[3]=true
            // ar[4]='k'

            // fixed size 
            //object[] oar = new object[5];
            //oar[0] = 63.35f;
            //oar[1] = true;
            //oar[2] = 86;
            //oar[3] = "india";
            //oar[4] = 'y';

            // dynamic size
            //ArrayList al = new ArrayList();
            //al.Add(63.5f);
            //al.Add(false);
            //al.Add(65);

            //Console./*Write*/(al[2]);

            // problem : type safety-- not type safe
            // benefit : dynamic size

            // Generic list

            List<float> al = new List<int>();
            al.Add(5);
            al.Add(6);


            //al.Add("india");

            IncreamentArray(al.ToArray());
            

        }

        void PrintArray(Array array)
        {
            for (int n = 0; n < array.Length; n++)
            {
                Console.WriteLine($"Element at {n} index is : {array.GetValue(n)}");
            }
        }

        void IncreamentArray(Array array)
        {
            // type safety
            // increase each value by 2
            for (int n = 0; n < array.Length; n++)
            {
                var x = (int)array.GetValue(n) + 2;
                array.SetValue(x, n);

                Console.WriteLine($"Element at {n} index is : {array.GetValue(n)}");
            }
        }
    }
}
