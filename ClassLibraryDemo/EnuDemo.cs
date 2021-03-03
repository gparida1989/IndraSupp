using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryDemo
{
    public class EnuDemo : IEnumerator, IEnumerable
    {
        int id = 10;
        string name = "indra";
        string country = "canada";
        double salary = 100.32;

        object _c;
        int pointer = -1;
        public object Current 
        {
            get
            {
                return _c;
            }
        }

        public IEnumerator GetEnumerator()
        {
            return this;
        }

        public bool MoveNext()
        {
            if (pointer == 0)
            {
                pointer = 1;
                _c = name;
                return true;
            }
            else if (pointer == -1)
            {
                pointer = 0;
                _c = id;
                return true;
            }
            else if (pointer == 1)
            {
                pointer = 2;
                _c = country;
                return true;

            }
            else if (pointer == 2)
            {
                pointer = 3;
                _c = salary;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Reset()
        {
            _c = id;
            pointer = 0;
        }
    }
}
