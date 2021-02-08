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

    public class AbstractDemo
    {
        // client can read version but cannot edit/modify the version
        // only the searvice provider can change this.

        // solution
        // 1) public readonly
        // 2) using function
        // 3) Properties ( getter, setter, making it writeonly, readonly,private setter

        short major = 1;
        short minor = 0;
        short patch = 0;
        short fix = 0;
        public string Version
        {
            get
            {
                return $"{major}:{minor}:{patch}:{fix}";
            }
            // versio is valid - it sould have 3 colons
            private set
            {
                int ic = 0;
                for(int i = 0; i < value.Length; i++)
                {
                    if (value[i] == ':')
                    {
                        ic++;
                    }
                }

                if(ic == 3)
                {
                    // valid version number
                    // 1:3:6:7
                    var parts = value.Split(':');
                    major = Convert.ToInt16( parts[0]);
                    minor = Convert.ToInt16(parts[1]);
                    patch = Convert.ToInt16(parts[2]);
                }

            }
        }
        public double Calculate(int a,int b)
        {
            int c = (a + b) * 10;
            int temp = b + 8 * a + 15;

            int result = 0;
            result = (c + temp) / 3;

            Version = "indra";
            
            return result;
        }
    }


    public struct MyStruct: IBase
    {
        int g;
        public static string S1;
        public string name;

        public int MyProperty { get; set; }

        public void print()
        {
            Console.Write("in struct");
        }

        public void PrintMe()
        {
            throw new NotImplementedException();
        }
    }

    public interface IBase
    {
        void PrintMe();
    }
    public class MyClass: IBase
    {
        int g;
        public string name;
        public static string S1;

        public int MyProperty { get; set; }

        public void print()
        {
            Console.Write("in struct");
        }

        public void PrintMe()
        {
            throw new NotImplementedException();
        }
    }

    public class Op
    {
        int i;
        public Op(int x)
        {
            i = x;
        }

        public static int operator+(Op o1,Op o2)
        {
            int res = o1.i + o2.i;
            return res;
        }
    }


}
