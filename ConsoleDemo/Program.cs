using System;
using System.Collections;
using ClassLibraryDemo;
using ClassLibraryDemo.Child;
using ClassLibraryDemo.Kata;

namespace ConsoleDemo
{
    class Program
    {

        // entry point
        static void Main(string[] args)
        {


            MyColl coll = new MyColl();


            var lst = coll.GetList();


            // print only numbers which are less than 200 fromthe list

            // print only prime number  from the list
            for ( int i = 0; i <= 250; i++) 
           {
                if (lst[i] < 200)
                {       
                    Console.WriteLine($"value at index {i} == {lst[i]}");
                }
           }
            

            //Console.WriteLine(lst[4]);


        }

    }

    
}
