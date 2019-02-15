using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string isPalindrome = File.ReadAllText(@"C:\Users\Zhanerke\Desktop\PP2Labs\inputpalindrome.txt");//Указываем откуда считывать стринг
            int size = isPalindrome.Count();//Размер нашего стринга
            bool ok = true;
            for (int i = 0; i < size / 2; i++)
            {
                if (isPalindrome[i] != isPalindrome[size - i - 1])
                {
                    ok = false;
                    break; // Проверяем на палиндромность и если !палиндром, то останавливаем цикл
                }
            }
            if (ok == true) // Если палиндром, то выводим соотвестственно "YES"
            {
                Console.WriteLine("This word is Palindrome word -> " + isPalindrome);
            }
            else
            {
                Console.WriteLine("This word is not Palidrome");
            }
            Console.ReadKey();
        }
    }
}
