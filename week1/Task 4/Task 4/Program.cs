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
            int n = int.Parse(Console.ReadLine()); //Считываем и записываем со стринга в интейджер
            for(int i=0; i<n; i++) //Пробегаемся по 2D array
            {
                for(int j=0; j<n; j++)
                {
                    if (i >= j) Console.Write("[*]"); //Если условие выполняется, то выводим звездочку
                    {
                        Console.WriteLine();
                    }
                }
            }
            }
            Console.ReadKey();
        }
    }
}
