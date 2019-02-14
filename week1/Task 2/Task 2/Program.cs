using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Student
    {
        string name; //Объявляем переменные
        string id;
        int year;
        public Student(string name, string id) // Создаем конструктор, который принимает переменные имя и айди
        {
            this.name = name;
            this.id = id;
        }
        public void increment(int year) // Конструктор, который принимает переменную год и сразу же увеличивает его значение на единицу
        {
            year++; // то есть вот тут значение переменной YEAR увеличивается
            this.year = year;
        }
        public override string ToString() // Записать весь стринг в строку IDK
        {
            return name + " " + id + " " + year;   // Команда сиаут
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Student Zhanerke = new Student(Console.ReadLine(), Console.ReadLine());
            string str = Console.ReadLine();
            int year = int.Parse(str);
            Zhanerke.increment(year);
            Console.WriteLine(Zhanerke);
            Console.ReadKey();
        }
    }
}
