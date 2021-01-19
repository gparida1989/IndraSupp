using System;
using ClassLibraryDemo;

namespace ConsoleDemo
{
    class Program
    {
        // entry point
        static void Main(string[] args)
        {
            //Bird bird1 = new Bird("indra");

            //Console.WriteLine(bird1.HasBeak + "  Legs-  " + bird1.NoOfLegs);

            //bird1.Fly();

            //Bird bird2 = new Bird("Trump");

            //Console.WriteLine(bird2.HasBeak + "  Legs-  " + bird2.NoOfLegs);

            //bird2.Fly();

            //bird1.Fly();

            //AbstractDemo obj = new AbstractDemo();


            //Console.WriteLine("The version is : " + obj.Version);

            //var result = obj.Calculate(5, 8);
            //Console.WriteLine("The version is : " + obj.Version);

            //Console.WriteLine($"the result is : {result}");

            //ArrayDemo o = new ArrayDemo();
            //o.Test();



            //var obj = new MethodDemo();
            //var res= obj.Add(4,6.9f);

            //Console.WriteLine(res);


            var obj1 = new KClass();  //a=12// instantiation , object == instance ,, a, inc() is called instance member
            Console.WriteLine($" value 1: {obj1.a}");//10
            obj1.Inc();//12
            Console.WriteLine($" value 1: {obj1.a}");//12
            obj1.Inc();//14

            var obj2 = new KClass();//a=10
            obj2.Inc();//12
            Console.WriteLine($" value 2 : {obj2.a}");//12


            Console.WriteLine($" value : {obj1.a}");// 14
            //obj1.Inc();

            Console.WriteLine($" value : {obj2.a}"); // 10












        }
        
    }
}
