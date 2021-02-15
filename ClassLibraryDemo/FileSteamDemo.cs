using System;
using System.IO;
using System.Text;

namespace ClassLibraryDemo
{
    public class FileSteamDemo
    {
        public void ReadFile()
        {

            var p = @"C:\Users\gopal\source\repos\IndraSupp\ClassLibraryDemo\indra.txt";


            ReadFile(p);
        }

        private void WriteFile(string path)
        {
            FileStream f = new FileStream(path, FileMode.Append, FileAccess.Write);
            var textToBeadded = " I have also cleared Csharp.";

            var content = Encoding.UTF8.GetBytes(textToBeadded);

            f.Write(content, (int)f.Length, textToBeadded.Length);

            f.Close();
        }

        private void ReadFile(string path)
        {
            using (FileStream f = new FileStream(path, FileMode.Open, FileAccess.Read))
                {
                    byte[] content = new byte[f.Length];
                    f.Read(content, 0, (int)f.Length);
                    Console.WriteLine(Encoding.UTF8.GetString(content));
                }
            

        }

    }
}
