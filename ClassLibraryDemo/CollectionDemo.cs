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
}
