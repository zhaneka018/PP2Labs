using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Student
    {
        string name;
        string id;
        int year;
        public Student(string name, string id)
        {
            this.name = name;
            this.id = id;
        }
        public void increment(int year)
        {
            year++;
            this.year = year;
        }
        public override string ToString()
        {
            return name + " " + id + " " + year;
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
