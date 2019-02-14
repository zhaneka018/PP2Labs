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
            int n = int.Parse(Console.ReadLine()); // со стринга в интейджер переводим
            int[] arr = new int[n]; // создаем массив
            for(int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine()); // числа в массиве переводим так же со стринга в инт
                arr[i] = num; 
            }
            MyMethod(arr, n); // создание функции или метода
            Console.ReadKey();
        }
        static void MyMethod(int[] arr, int n)
        {
            List<int> vector = new List<int>(); //Создаем новый вектор
            for(int i = 0; i < n; i++)
            {
                vector.Add(arr[i]); // Х2 и сохраняем
                vector.Add(arr[i]);
            }
            //string asd = "123123";
            //int[] massive = new int[20];
            //Console.WriteLine(massive.Length);
            //Console.WriteLine(asd.Length);
            Console.WriteLine(vector.Count()); //Считываем размер нового массива
            for(int i = 0; i < vector.Count(); i++)
            {
                Console.Write(vector[i] + " "); // и выводим ответ:)
            }
        }
    }
}
