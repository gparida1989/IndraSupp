using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryDemo
{
    // static ctor

    // sttic class cannot be instatiated
    // this can never contain non-static members
    public static class StaticDemo
    {
        // static variables/fields
        // they can accespt acess specifier
        // static members are class members not instance members. So no need of instance to access them.
        // has to be accessed directly through the class name

        public static int i=100;
        public static int j=50;
        public static int Sum;



        public static int A
        {
            get
            { 
                return i; 
            }
            set { 
                i = value; 
            }
            
        }
            
          
        // static keyword
        // they cannoot acccept parameters
        // no need to speify access specifiers
        // called by compiler
        static StaticDemo()
        {
            Sum = i + j;
            Console.WriteLine("in static ctor ");

        }
      
      

        // static methods can accept access specifier
        // can only access static fields/variables
        // accessed using className
        // can accept parameters also
        // they can be overloaded too..thay can have return type too
        public static void PPStat()
        {
            
            Console.WriteLine("in static PP");
        }
        public static void PPStat(string nae)
        {

            Console.WriteLine($"in static PP - {nae}");
        }
    }
    public class StaticTest
    {
        public void Test()
        {
            
            Console.WriteLine(StaticDemo.A);
            StaticDemo.A = 10;
            Console.WriteLine(StaticDemo.A);//???10


            //StaticDemo.PPStat("indra");

            //Console.WriteLine($"sum is {StaticDemo.Sum} and Mul is {o.Mul}");
        }
    }
}
