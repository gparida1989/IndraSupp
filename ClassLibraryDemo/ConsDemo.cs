using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryDemo
{
    /// <summary>
    ///  invoking constructor of different class
    ///  invoking ctor of base class
    /// </summary>
    public class ConsDemo1
    {
    }
    public class ConsDemo2
    {
    }
    public class ConsDemo3
    {
    }
    public class ConsDemo4
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
            Console.WriteLine($"in ConsDemo4 with {a}");
        }
        public ConsDemo4(long a)
        {
            Console.WriteLine($"in ConsDemo4 with long {a}");
        }
        public ConsDemo4(int b, int c)
        {
            Console.WriteLine($"in ConsDemo4 with {b} & {c}");
        }
        public ConsDemo4(double t)
        {
            Console.WriteLine($"in ConsDemo4 with double {t}");
        }
        // long > int > short
    }

}
