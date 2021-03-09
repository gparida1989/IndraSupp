using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryDemo
{
    public class Dojo
    {
        public string Compute(string s)
        {
            //If the number is divisible by 3, write “Foo” instead of the number
            //If the number is divisible by 5, add “Bar”
            //If the number is divisible by 7, add “Qix”

            //For each digit 3, 5, 7, add “Foo”, “Bar”, “Qix” in the digits order.


            // check 1) Divisibility check
            // contanins 3,5,7 check


            string displayValue= "";
            try
            {
                int i = Convert.ToInt32(s);
                if (i % 3 == 0)
                {
                    displayValue += "Foo";
                }
                if (i % 5 == 0)
                {
                    displayValue += "Bar";
                }
                if (i % 7 == 0)
                {
                    displayValue += "Qix";
                }



                if (s.Contains("3"))
                {
                    displayValue += "Foo";
                }
                if (s.Contains("5"))
                {
                    displayValue +=  "Bar";
                }
                if (s.Contains("7"))
                {
                    displayValue += "Qix";
                }


               

            }
            catch (Exception e)
            {
                Console.WriteLine("Invalid Input");
            }



            if (displayValue == "") displayValue = s;
            // heck 3 -- checking 0
            if (displayValue.Contains("0"))
            {
                displayValue.Replace("0", "*");
            }
            return displayValue;
        }
    }
}

