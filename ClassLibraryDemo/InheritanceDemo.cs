using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryDemo
{
    //abstract
    public class ABSDemo
    {

    }
    // 
    //
    public abstract class MyBase
    {
        private int a=10;
        public abstract int Prop1 { get; set; }
        protected int c = 20;

        public void PrintLtr()
        {
            Console.WriteLine("i am in MyBase");
        }
    }
    public class Child1:MyBase
    {
        // all the members are inhrited
        // but private mambers are not visible or accessibly by child class

        //private int a = 10;
        //public int b = 5;
        // we cannot access through object outside a class, but we cn acess directly in a child class
        //protected int c = 20;

        public override int Prop1 { get; set; } = 56;
        public new void PrintLtr()
        {
            Console.WriteLine("i am in child1");
        }

    }
    public class Child2 : Child1
    {
        public override  int Prop1 { get; set; } = 200;
        public void PrintLtr()
        {
            Console.WriteLine("i am in child2");
        }
    }
    public class Child3 : Child2
    {
        public virtual int Prop1 { get; set; } = 300;
        public void PrintLtr()
        {
            Console.WriteLine("i am in child3");
        }
    }
    public class Child4 : Child3
    {
        public virtual int Prop1 { get; set; } = 400;
        public void PrintLtr()
        {
            Console.WriteLine("i am in child5");
        }
    }
    public class Child5 : Child2
    {
        public override int Prop1 { get; set; } = 500;
    }
    public class Child6 : Child2
    {
        public override int Prop1 { get; set; } = 600;
    }
    public class Child7 : Child1
    {
        public override int Prop1 { get; set; } = 700;
    }
    public class Child8 : MyBase
    {
        public override int Prop1 { get; set; } = 800;
    }

}
namespace ClassLibraryDemo.Child
{
    class MyChild
    {

    }

    public class Demo
    {
        //polymorphism
        public void Test()
        {
            //MyBase b = new Child7();
            //b.PrintLtr(); 

            IPrint p = new IndraPrint();
            p.PrintLtr("indra");
            
        }
        public void PP(IPrint p)
        {
            p.PrintLtr("in pp");
        }
    }
}
/// rules : always go from variable type to instance type, top down approach
/// call the non-virtual members directly
/// if there are virtul members , then check for ovverrides in the children, 
/// if found call the last override member in the hierarchy
/// If no-overrrides call he base member