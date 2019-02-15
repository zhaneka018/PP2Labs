using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task_3
{
    class Program
    {
        public static void Probely(int lvl)             //функция для вывода названия каждого файла и directory
        {
            for (int i = 0; i < lvl; i++)
            {
                Console.Write("    ");
            }
        }
        public static void Direc(DirectoryInfo dir, int lvl)        //функция для вывода названия каждого файла и directory 
        {
            foreach (FileInfo f in dir.GetFiles())      //взять файлы из directory и показать
            {
                Probely(lvl);
                Console.ForegroundColor = ConsoleColor.Blue;

                Console.WriteLine(f.Name);
            }
            foreach (DirectoryInfo d in dir.GetDirectories())  //взять directories из directory и показать
            {
                Probely(lvl);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(d.Name);
                Direc(d, lvl + 1);        //путем рекурсии вызываем метод Direc, чтобы показать другие файлы и каталоги
            }

        }

        static void Main(string[] args)
        {
            string path = Console.ReadLine();
            DirectoryInfo dirr = new DirectoryInfo(path);
            Direc(dirr, 0);
            Console.ReadKey();
        }
    }
}

