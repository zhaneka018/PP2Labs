using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            int x = int.Parse(line);
            string treugolnik = "[*]";
            int cnt = 1;
            for(int i = 0; i < x; i++)
            {
                for(int j = 0; j < cnt; j++)
                {
                    Console.Write(treugolnik + " ");
                }
                cnt++;
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
