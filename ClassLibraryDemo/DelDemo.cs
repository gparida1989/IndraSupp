using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryDemo
{
    public class DelDemo
    {
        // declaring delegte, function signature must match
        // return type, data type of parameter
        // no of parameter
        public delegate void indra(int y);

        public void Fun()
        {
            Console.WriteLine("Hii");
        }
        public void Funtus(int s)
        {
            Console.WriteLine("Hi hello");
            Console.Write(s);//5
        }

        public void test()
        {
            indra i = new indra(Funtus);
            i(23);
        }


        public void Test1(indra k)
        {
            k(43333);
        }
    }
}
