using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using ClassLibraryDemo;

namespace XUnitTestDemo
{
    // every class has to be public , if iy contains test methods
    // test methods also has to be public
    public class MethodDemoUT
    {
        // AAA -- arrrange , act, assert

        // test methods should have Fact /Theory decorator
        [Fact]
        public void Add2Integer()
        {
            // arrange
            int a = 4;
            int b = 7;
            int expected = 11;

            var obj = new MethodDemo();
            // ACT
            var actual = obj.Add(a,b);

            // asssert
            Assert.Equal(expected, actual);
        }
    }
}
