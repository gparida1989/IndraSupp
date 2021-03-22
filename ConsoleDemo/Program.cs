using System;
using System.Collections;
using ClassLibraryDemo;
using ClassLibraryDemo.Child;
using ClassLibraryDemo.Kata;

namespace ConsoleDemo
{
    class Program
    {
        delegate int MyDel(int a, int b);

        static int Sum(MyDel del)
        {
            return del(10, 100);
        }
        // entry point
        static void Main(string[] args)
        {
           

            MyCass c = new MyCass();

            DelDemo d = new DelDemo();

            d.Test1(a => Console.Write("I am being passed as a param"));


            int result = Sum(delegate (int a, int b)
            {
                return a+b;
            });

            Console.Write("resut ins " + result);

            //DelDemo.indra mydel = c.Sing;
            //mydel += d.Funtus;
            //mydel += c.Sing1;
            //mydel += c.Sing2;
            //mydel += c.Sing3;
            //mydel += c.Sing4;

            //Delegate[] result =  mydel.GetInvocationList();

            //for(int i = 0; i < result.Length; i++)
            //{
            //    Console.WriteLine(result[i].Method.Name);
            //}

            //Random random = new Random(0);

            //for (int j = 0; j <= 5; j++)
            //{

            //    int i = random.Next(5);

            //    DelDemo.indra h = (DelDemo.indra)result[i];
            //    h(5355);
            //}

            //Console.WriteLine(result.Length);



            //Dojo d = new Dojo();

            //for(int i = 1; i <= 20; i++)
            //{
            //    Console.Write($"{i} => ");
            //    Console.WriteLine(d.Compute($"{i}"));
            //}






            // d.Test1(c.Sing);



            //Console.Write("h");
            //Console.Write("\n");
            //Console.Write("indra");





            //IMathOps m = new ValidationDemo();

            //try
            //{
            //    var result = m.Devide(12, 0);
            //}
            //catch (Exception exc)
            //{
            //    Console.WriteLine(exc.Message);
            //}

            //ClassLibraryDemo.Kata.Rectangle rectangle= new ClassLibraryDemo.Kata.Rectangle(10, 56);
            //Circle circle = new Circle(20);

            //Shape shape = circle;






            //IShape shape1 = shape;

            //Validator validator = new Validator();

            //bool valid = validator.ValidateShape(shape);


            //if (valid == true)
            //{
            //    // calculate area
            //    AreaCalculator areaCalculator = new AreaCalculator((s) =>
            //        {
            //            var v = (Circle)s;

            //            return Math.PI * v.radius * v.radius;
            //        });



            //    areaCalculator.Area(shape);
            //}
            //else
            //{
            //    Console.WriteLine("In valid shape");
            //}

            //Console.WriteLine(result);

        }

    }

    class MyCass
    {
        public void Sing(int g)
        {
            Console.WriteLine($"singing0 {g} times");
        }
        public void Sing1(int g)
        {
            Console.WriteLine($"singing1 {g} times");
        }
        public void Sing2(int g)
        {
            Console.WriteLine($"singing2 {g} times");
        }
        public void Sing3(int g)
        {
            Console.WriteLine($"singing3 {g} times");
        }
        public void Sing4(int g)
        {
            Console.WriteLine($"singing4 {g} times");
        }

    }
}
