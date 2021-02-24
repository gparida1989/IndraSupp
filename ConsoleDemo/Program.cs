using System;
using ClassLibraryDemo;
using ClassLibraryDemo.Child;

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


            //var obj1 = new KClass();  //a=12// instantiation , object == instance ,, a, inc() is called instance member
            //Console.WriteLine($" value 1: {obj1.a}");//10
            //obj1.Inc();//12
            //Console.WriteLine($" value 1: {obj1.a}");//12
            //obj1.Inc();//14

            //var obj2 = new KClass();//a=10
            //obj2.Inc();//12
            //Console.WriteLine($" value 2 : {obj2.a}");//12


            //Console.WriteLine($" value : {obj1.a}");// 14
            ////obj1.Inc();

            //Console.WriteLine($" value : {obj2.a}"); // 10

            //var obj = new KClass();



            //Console.WriteLine(KClass.SI);//10

            //KClass.SInc();//11
            //var o = new KeywordDemo();
            //o.Test();//11
            //obj.Inc();//a= 12,si =11
            //KClass.SInc(); KClass.SInc(); KClass.SInc();//14
            //Console.WriteLine(KClass.SI);//14
            //o.Test();//14
            //obj.Inc();//a=14,si=12
            //obj.Inc();//a=16,si=13
            //KClass.SInc(); KClass.SInc(); KClass.SInc();//16
            //Console.WriteLine(KClass.SI);//16


            //int a = 50;
            //var res = a.Add1K(10);
            //Console.WriteLine(res);

            //string s = "indraa";
            //char m = s.GetMiddleChar();

            //Console.WriteLine(m);
            //int[] ar = { 1,2,3,4,5};
            //int sm = ar.IndexSum();
            //Console.WriteLine(sm);

            //var obj = new ArrayDemo();
            //obj.Test1();

            // (MyBase)b --> obj of mybase
            //Demo b = new Demo();
            //b.Test();


            //var o = new IndraPrint();
            //b.PP(o);

            // Variable type : different than Instance type
            // instance wuld be child of vaiable type
            //Animal d1 = new Dog();
            //d1.eat();
            // d1.bark();

            //Tabletop t = new Tabletop(4.5, 7.5);
            //t.Display();

            //StaticTest d = new StaticTest();

            //d.Test();


            //Console.Write("enter string : ");
            //string s = Console.ReadLine();

            //Console.Write("enter the charecter to search  :");
            //char c = Convert.ToChar( Console.ReadLine());

            //bool found = s.FindLtr(c);

            //if (found == true) Console.WriteLine("found");
            //else Console.WriteLine("not found");


            // count the no of times the letter occurs in the  string
            // function name : CountNumber
            // extn against datatype : string
            // parameter : char
            // return type : int

            // signature ???

            //int r = s.CountNumber(c);

            //Console.Write(r);


            //var k = new KeywordDemo("canada");
            //k.Test();

            //var k1 = new KeywordDemo("mexico");

            //k1.Test();
            //typeof()
            //sizeof()

            //ternary op  -->   ?:

            //is
            //as

            //int i = 100;

            //if(i > 100)
            //{
            //    s="hiiii";
            //}
            //else
            //{
            //    s="hello";

            //}

            // s = (i>100) ? "hiiii" : "hello";

            //if(i is int)
            //{
            //    Console.Write("yes it is string");
            //}

            //Console.Write(s);

            //int e = Convert.ToInt32( Weeks.Friday);
            //Console.WriteLine(e);

            //MyClass k = new MyClass();
            //MyClass.S1 = "hgh";


            //MyStruct myStruct=new MyStruct();
            //myStruct.print();
            //MyStruct.S1 = "ddfddfd";


            //FileSteamDemo o = new FileSteamDemo();
            //o.ReadFile();

            ADODemo aDO = new ADODemo();
            aDO.InsertRow();



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


            //Console.WriteLine(result);

        }

    }
}
