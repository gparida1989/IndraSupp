using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryDemo
{
    public class MethodDemo
    {
        public int Add(int a,int b)
        {
            return a + b;
        }
        public float Add(float a, float b)
        {
            return a+b;
        }
        public double Add(int a, int b,int c)
        {
            return a + b+c;
        }
        public string Add(string a, char b)
        {
            return a + b;
        }
    }
}
