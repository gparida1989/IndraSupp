using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryDemo
{
    public class IndexerDemo
    {
        string country;
        string name;

        public IndexerDemo(string a, string b)
        {
            country = a;
            name = b;
        }

        public string this[int i]
        {
            get
            {
                if (i == 0) return country;
                else return name;
            }
        }
    }
}
