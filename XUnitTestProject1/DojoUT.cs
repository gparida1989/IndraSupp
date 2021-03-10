using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using ClassLibraryDemo;

namespace XUnitTestDemo
{
    public class DojoUT
    {
        [Theory]
        [InlineData("FooBarBar", "15")]
        [InlineData("8", "8")]
        [InlineData("FooFoo", "3")]
        [InlineData("FooBarFoo*", "30")]
        [InlineData("FooBarQix*Bar","105")]
        [InlineData("FooBar","51")]
        public void TestDojo(string exp,string input)
        {
            // arrange
            Dojo dojo = new Dojo();

            //act
            string actual = dojo.Compute(input);

            //asserting
            Assert.Equal(exp,actual);
            
        }
    }
}
