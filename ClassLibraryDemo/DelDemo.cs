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
        // always is a class member , can only be accessed using class name. like static members.
        public delegate void indra(int y);

        public void Fun()
        {
            Console.WriteLine("Hii");
        }
        public void Funtus(int s)
        {
            Console.WriteLine("Hi hello");
            Console.WriteLine(s);//5
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

/* int - 3,5,....
 * string  - "india","canadaa"
 * float - 1.5,3.4...
 * bool - true,false
 * Delegate(indra) - function having same signature as of delegate -{ xxx provided  void xxx(int c) exists. }
 */
