using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream Create = new FileStream(@"C:\Users\Zhanerke\Desktop\PP2Labs\path1.txt", FileMode.OpenOrCreate, FileAccess.Write);//Создаем первый файл
            StreamWriter toWrite = new StreamWriter(Create); 
            toWrite.Write("random text alallalalalal"); //написать рандомный текст 
            toWrite.Close();
            Create.Close();
            string path1 = @"C:\Users\Zhanerke\Desktop\PP2Labs\path1.txt";//указываем адрес первого файла
            string path2 = @"C:\Users\Zhanerke\Desktop\PP2Labs\week2\syuda.txt";//указываем где сохранить новый файл
            File.Copy(path1, path2);//копируем с одного файла на другой
            File.Delete(path1);//удаляем оригинал, т.е.первый файл
        }
    }
}
