using System;

namespace ClassLibraryDemo
{
    // private, public, protected, 
    // by defaul class members are private
    // internal, protected internal, private protected
    public class KeywordDemo
    {
        // const variiavles cannot be changed by any means
        // const variables are Class variables , [not instance mebrs], means we do not need instance to access const variables
        public readonly string country = "canada";


        public KeywordDemo(string s)
        {
            country = s;
        }
        protected string Name = "indra";
        protected int Amount = 65;
        public  void Test()
        {
            int i = 6;
            var name = true;  // explicit datatype declaration

            Console.WriteLine(country);
        }

    }

    public class KClass
    {
        public int a = 10;
        public static int SI = 10;

        public void Inc()
        {
            a = a + 2;
            SI++;
        }

        public static void SInc()
        {
            SI++;
        }

        
    }
  
}
