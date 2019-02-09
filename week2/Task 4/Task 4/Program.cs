using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream Create = new FileStream(@"C:\Users\Zhanerke\Desktop\PP2Labs\path1.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter toWrite = new StreamWriter(Create);
            toWrite.Write("random text alallalalalal");
            toWrite.Close();
            Create.Close();
            string path1 = @"C:\Users\Zhanerke\Desktop\PP2Labs\path1.txt";
            string path2 = @"C:\Users\Zhanerke\Desktop\PP2Labs\week2\syuda.txt";
            File.Copy(path1, path2);
            File.Delete(path1);
        }
    }
}
