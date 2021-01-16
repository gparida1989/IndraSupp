using System;
using ClassLibraryDemo;

namespace ConsoleDemo
{
    class Program
    {
        // entry point
        static void Main(string[] args)
        {
            Bird bird1 = new Bird("indra");

            Console.WriteLine(bird1.HasBeak + "  Legs-  " + bird1.NoOfLegs);

            bird1.Fly();

            Bird bird2 = new Bird("Trump");

            Console.WriteLine(bird2.HasBeak + "  Legs-  " + bird2.NoOfLegs);

            bird2.Fly();

            bird1.Fly();

        }
        
    }
}
