using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for(int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                arr[i] = num;
            }
            MyMethod(arr, n);
            Console.ReadKey();
        }
        static void MyMethod(int[] arr, int n)
        {
            List<int> vector = new List<int>();
            for(int i = 0; i < n; i++)
            {
                vector.Add(arr[i]);
                vector.Add(arr[i]);
            }
            //string asd = "123123";
            //int[] massive = new int[20];
            //Console.WriteLine(massive.Length);
            //Console.WriteLine(asd.Length);
            Console.WriteLine(vector.Count());
            for(int i = 0; i < vector.Count(); i++)
            {
                Console.Write(vector[i] + " ");
            }
        }
    }
}
