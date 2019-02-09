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
            string isPalindrome = File.ReadAllText(@"C:\Users\Zhanerke\Desktop\PP2Labs\inputpalindrome.txt");
            int size = isPalindrome.Count();
            bool ok = true;
            for (int i = 0; i < size / 2; i++)
            {
                if (isPalindrome[i] != isPalindrome[size - i - 1])
                {
                    ok = false;
                    break;
                }
            }
            if (ok == true)
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
