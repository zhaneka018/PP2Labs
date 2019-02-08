using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "[*]";
            int n;
            string a = Console.ReadLine();
            n = int.Parse(a);
            int check = 1;
            for(int i=0; i<n; i++)
            {
                for(int j = 0; j < check; j++)
                {
                    Console.Write(str);
                }
                check++;
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
