using System;

namespace ConsoleDemo
{
    class Program
    {
        // entry point
        static void Main(string[] args)
        {
            int i = 10;
            Console.Write("Please input a number : ");
            string input = Console.ReadLine();

            i = Convert.ToInt32(input); // conversion from one data type to another =  TypeCasting

            if (CheckEven(i))
            {
                Console.WriteLine("U have entered an even number");
            }
            else
            {
                Console.WriteLine("U have entered an odd number");
            }


            // we will print only even numbers staring from 2 to the input number
            // ex- input = 10, output = 2,4,6,8,10

            for (int a = 2; a <= 10; a++)
            {
                // below block is a repeatative block or logic
                // print here
                if(CheckEven(a))
                    Console.Write(a + "  ");
            }

            Console.WriteLine();

        }
        static bool CheckEven(int a)
        {
            // a % 3 == 0 && a >= 6 , what will be return type of this statement ?
           
                return (a % 3 == 0 && a >= 6);

           
        }
    }
}
