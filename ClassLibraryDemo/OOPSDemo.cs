using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryDemo
{
    class OOPSDemo
    {
    }
    // Class/struct - used to define templates fo objects
    public class Bird
    {
        // 4 properties - Wings, body, 2-legs, Beak
        public bool HasWings;
        public bool HasBody;
        public int NoOfLegs;
        public bool HasBeak;

        string Name;

        public Bird(string birdName)
        {
            HasBeak = true;
            HasBody = true;
            HasWings = true;
            NoOfLegs = 2;
            Name = birdName;
        }

      
        // ternary operator

        // 1 behaviour - FLY
        public void Fly()
        {
            if(Name==null)
            {
                Name = "No Name";
            }
           
            Console.WriteLine("I am flying. & my name is " + Name);
        }
    }
}
