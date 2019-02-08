using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            int x = int.Parse(line);
            // int k = int.Parse(Console.ReadLine());
            List<int> Vector = new List<int>();
            int[] a = new int[x * 2];
            for(int i = 0; i < x; i++)
            {
                string num = Console.ReadLine();
                int k = int.Parse(num);
                Vector.Add(k);
                Vector.Add(k);
                // 1
                // 1 1 
                // 2
                // 1 1 2 2 
                // 3
                // 1 1 2 2 3 3
            }
            Vector.CopyTo(a);
            /* for(int i = 0; i < Vector.Count(); i++)
            {
                Console.Write(Vector[i] + " ");
            } */
            for(int i = 0; i < x * 2; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
