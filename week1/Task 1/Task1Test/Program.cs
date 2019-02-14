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
            string str = Console.ReadLine(); // Считываем наш string
            int x = int.Parse(str); //String сохраняем в integers
            int counter = 0; // Создаем счетчик каунтер для считывания делителей наших чисел
            //List<int> Massive = new List<int>();
            int[] n = new int[x]; // Создаем массив
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
                if(counter == 2) //Прайм число - это число имеющее ровно два различных натуральных делителя — единицу и самого себя
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
