using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int x = int.Parse(str);
            int counter = 0;
            //List<int> Massive = new List<int>();
            int[] n = new int[x];
            //string[] text = str.Split();
            for (int i = 0; i < x; i++)
            {
                counter = 0;
                // int isPrime = int.Parse(Console.ReadLine());
                string line = Console.ReadLine();
                int number = int.Parse(line);
                for(int j = 1; j <= number; j++)
                {
                    if(number % j == 0)
                    {
                        counter++;
                    }
                }
                if(counter == 2)
                {
                    n[i] = number;
                }
            }
            for(int i = 0; i < x; i++)
            {
                if(n[i] != 0)
                {
                    Console.Write(n[i] + " ");
                }
            }
            Console.ReadKey();
        }
    }
}
