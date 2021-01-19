using System;

namespace ClassLibraryDemo
{
    // private, public, protected, 
    // by defaul class members are private
    // internal, protected internal, private protected
    class KeywordDemo
    {
        protected string Name = "indra";
        protected int Amount = 65;
        protected void Test()
        {
            int i = 6;
            var name = true;  // explicit datatype declaration
        }

    }

    public class KClass
    {
        public int a = 10;

        public void Inc()
        {
            a = a + 2;
        }
    }
    class Another: KeywordDemo
    {
        
        void TestA()
        {
           
        }
    }
}
