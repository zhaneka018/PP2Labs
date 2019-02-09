using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream CreateFile = new FileStream(@"C:\Users\Zhanerke\Desktop\PP2Labs\outputPrime.txt", FileMode.Create, FileAccess.Write);
            StreamWriter WriteInFile = new StreamWriter(CreateFile); // Благодаря StreamWriter мы можем писать в файле, который создали через FileStream
            string str = File.ReadAllText(@"C:\Users\Zhanerke\Desktop\PP2Labs\inputprime.txt");
            string[] massiveStr = str.Split();
            int size = massiveStr.Count();
            for (int i = 0; i < size; i++)
            {
                int num = int.Parse(massiveStr[i]);
                int count = 0;
                for(int j = 1; j <= num; j++)
                {
                    if(num % j == 0)
                    {
                        count++;
                    }
                }
                if(count == 2 && num != 1)
                {
                    WriteInFile.Write(num + " ");
                }
            }
            WriteInFile.Close();
            CreateFile.Close();
            Console.ReadKey();
        }
    }
}
