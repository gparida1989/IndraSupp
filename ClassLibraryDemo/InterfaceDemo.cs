using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryDemo
{
    public interface IPrint
    {
        // bydefault public, abstract
        void PrintLtr(string s);
    }


    public class IndraPrint: IPrint
    {
        public void PrintLtr(string s)
        {
            Console.Write(s);
        }
        public void test()
        {
            Console.WriteLine("in print class");
        }
    }
}
