using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryDemo
{
    public interface IMathOps
    {
        double Devide(double num1, double num2);
    }
    public class ValidationDemo : IMathOps
    {
        public double Devide(double num1, double num2)
        {
            if(num2 == 0)
            {
                // invalid devisor
                IndraExc e = new IndraExc("invalid devisor");
                throw e;
            }
            var r = num1 / num2;
            return r;
        }
    }
    public class IndraExc: Exception
    {
        public IndraExc()
        {

        }
        public IndraExc(string msg)
        {

        }
    }
}
