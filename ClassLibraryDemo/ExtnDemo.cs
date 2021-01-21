using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryDemo
{
    // extending existing DataTypes
    // what r the things that we can extend ? we can add new capabilities/functionalities  (new methods)
    // we can add new functionality to an exiting type
    // sntax -  extension methods should be inside a static class & public  
    // extention mehtod has to be a static method public
    // the first parameter of the function(extn)  has to be the Existing type prefixed with THIS keyword

    /*
     * it will add itself with 1000 and return the new result
     * ex : int a=50; int result = a.Add1K(); resut = 1050;
     * */
    public static class ExtnDemo
    {
        public static float Add1K(this int p,int p1)
        {
            return p + 1000;
        }

        /*
       * ex : string s ="indra"; char m = s.GetMiddleChar(); m='d';
       * */
        public static char GetMiddleChar(this string s)
        {
            var len = s.Length;
            var middleIndex = len / 2;

            var c = s[middleIndex];

            return c;
        }

        /*
         * int[] ar = new int[5]; ar={1,2,3,4,5};
         * ar.IndexSum(); // 50000 + 4000 + 3 * 10 pow 2 + 2 * 10 pow 1+ 1 * 10 pow 0 = 54321
         * Math.Pow(10,2) = 100
         * */


    }
}
