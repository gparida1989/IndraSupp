using System;

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


            string displayValue = "";
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



                // need to find out exact position of 0
                // no of 0
                // 30 --> FooBarFoo*
                // 30 --> '3','0'

                char[] ar = s.ToCharArray();

                foreach (char c in ar)
                {
                    if (c == '3')
                    {
                        displayValue += "Foo";
                    }
                    else if (c == '5')
                    {
                        displayValue += "Bar";
                    }
                    else if (c == '7')
                    {
                        displayValue += "Qix";
                    }
                    else if (c == '0')
                    {
                        displayValue += "*";
                    }
                }





            }
            catch (Exception e)
            {
                Console.WriteLine("Invalid Input");
            }



            if (displayValue == "")
            {
                displayValue = s;
            }

            return displayValue;
        }
    }
}

