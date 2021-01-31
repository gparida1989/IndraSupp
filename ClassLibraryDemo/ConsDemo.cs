using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryDemo
{
    /// <summary>
    ///  invoking constructor of different class
    ///  invoking ctor of base class
    /// </summary>
    public class ConsDemo2
    {
        protected readonly string myVar;
        public ConsDemo2():this(6,"Canada")
        {
            myVar = "india";
            Console.WriteLine("in consdemo2 default");//2
        }
        public ConsDemo2(string v):this()
        {
            myVar = v;
            Console.WriteLine($"in consdemo2  string , val of myVar = {myVar}");//3
        }
        public ConsDemo2(int d,string v)
        {
            myVar = $"{d} times of { v}";
            Console.WriteLine($"in consdemo2 int string , val of myVar = {myVar}");//1
        }

    }
    public class ConsDemo3
    {
        // return type
        // datatype of parameters
        // no of params
        private int i;
        public ConsDemo3(int x):this("india",x)
        {
            Console.WriteLine($"in consdemo3 , val of i ={i}");//66
        }
        public ConsDemo3(string indra,int x)
        {
            i = x;
            Console.WriteLine($"in consdemo3 srting with field ={i}");//55
        }
    }
    public class ConsDemo4: ConsDemo2
    {
        public ConsDemo4()
        {
            Console.WriteLine("in ConsDemo4");
        }
        public ConsDemo4(short a)
        {
            Console.WriteLine($"in ConsDemo4 with short {a}");
        }
        public ConsDemo4(int a): this(5,6)
        {
            ConsDemo3 d = new ConsDemo3(5);
            Console.WriteLine($"in ConsDemo4 with {a}");//77
            Console.WriteLine($"the base class member value is {myVar}");//8
        }
        public ConsDemo4(long a)
        {
            Console.WriteLine($"in ConsDemo4 with long {a}");
        }
        public ConsDemo4(int b, int c):base("us")
        {
            Console.WriteLine($"in ConsDemo4 with {b} & {c}");//44
        }
        public ConsDemo4(double t)
        {
            Console.WriteLine($"in ConsDemo4 with double {t}");
        }
        // long > int > short
    }

}
