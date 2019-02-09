using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string triangle = "[*]";
            int k = int.Parse(Console.ReadLine());
            int x = 1;
            for(int i = 0; i < k; i++)
            {
                for(int j = 0; j < x; j++)
                {
                    Console.Write(triangle);
                }
                Console.WriteLine();
                x++;
            }
            Console.ReadKey();
        }
    }
}
