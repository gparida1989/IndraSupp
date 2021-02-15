using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryDemo
{
    public class DisposeDemo:IDisposable
    {
        FileSteamDemo f = new FileSteamDemo();

        public void Dispose()
        {
            f = null;// release memory
            Console.WriteLine("disposed");
        }

        public void Test()
        {
            f.ReadFile();
            
        }
    }
}
