using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ClassLibraryDemo
{
    public class FileSteamDemo
    {
        public void ReadFile()
        {
            FileStream f = new FileStream("indra.txt", FileMode.Open,FileAccess.Read);

            byte[] content = new byte[f.Length];

            f.Read(content, 0, (int)f.Length);

            var txt=Encoding.UTF8.GetString(content);

            Console.WriteLine(txt);
            
            
            f.Close();

           
        }
       
    }
}
