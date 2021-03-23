using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryDemo
{
    public class CollectionDemo : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public void Test()
        {
            Hashtable hashtable = new Hashtable();
            hashtable.Add(100, "canada");
            hashtable.Add(101, "india");
            hashtable.Add(102, "US");
            hashtable.Add(103, "malaysia");


            var length = hashtable.Count;
            // the value india is at key 101
            // the value US is at key 102..
            foreach(var key in hashtable.Keys)
            {
                var value = hashtable[key];

            }
           
        }
    }

    public class MyColl
    {
        public List<int> GetList()
        {
            List<int> ls = new List<int>();

            Random random = new Random(10);

            for(int i = 0; i <= 500; i += 2)
            {
                ls.Add((11 * (i+3) - random.Next(111)) + random.Next(500));
            }

            return ls;
        }
    }
}
