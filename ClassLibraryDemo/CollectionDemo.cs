using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryDemo
{
    public class CollectionDemo
    {
        public void Test()
        {
            Hashtable hashtable = new Hashtable();
            hashtable.Add(100, "canada");
            hashtable.Add(101, "india");
            hashtable.Add(102, "US");
            hashtable.Add(103, "malaysia");


            var length = hashtable.Count;

            foreach(var key in hashtable.Keys)
            {
                var value = hashtable[key];

            }
           
        }
    }
}
