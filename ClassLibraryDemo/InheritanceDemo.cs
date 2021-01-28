using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryDemo
{
    public class MyBase
    {
        private int a=10;
        public virtual int Prop1 { get; set; } = 5;
        protected int c = 20;
    }
    public class Child1:MyBase
    {
        // all the members are inhrited
        // but private mambers are not visible or accessibly by child class

        //private int a = 10;
        //public int b = 5;
        // we cannot access through object outside a class, but we cn acess directly in a child class
        //protected int c = 20;

        public override int Prop1 { get; set; } = 50;

    }
    public class Child2 : Child1
    {
        public override  int Prop1 { get; set; } = 100;
    }
    public class Child3 : Child2
    {
        public int Prop1 { get; set; } = 200;
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
            // Variable type : MyBase
            // instance type : Child2
            MyBase b = new Child2();
            Console.WriteLine(b.Prop1); 
        }
    }
}
/// rules : always go from variable type to instance type, top down approach
/// call the non-virtual members directly
/// if there are virtul members , then check for ovverrides in the children, 
/// if found call the last override member in the hierarchy
/// If no-overrrides call he base member