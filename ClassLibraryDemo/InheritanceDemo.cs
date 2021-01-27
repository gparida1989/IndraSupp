using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryDemo
{
    public class MyBase
    {
        private int a=10;
        public virtual int VirB { get; set; } = 5;
        protected int c = 20;
    }
    public class Child1 : MyBase
    {
        // all the members are inhrited
        // but private mambers are not visible or accessibly by child class

        //private int a = 10;
        //public int b = 5;
        // we cannot access through object outside a class, but we cn acess directly in a child class
        //protected int c = 20;

        public override int VirB { get; set; } = 50;

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
            MyBase b = new Child1();
            Console.WriteLine(b.VirB);
        }
    }
}