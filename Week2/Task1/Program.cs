using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Solve(string str)   // создаем метод
        {
            bool ok = true;
            for (int i = 0; i < str.Length; i++)    // пробегаем через массив
            {
                if (str[str.Length - 1 - i] != str[i])  // проверка на палиндром
                {
                    ok = false;
                    break;  // если это не палиндром, мы выходим из цикла
                }
            }

            if (ok) // если это палиндром, мы выводим «Yes»
            {
                Console.WriteLine("Yes");
            }
            else    // если это палиндром, мы выводим «Нет»
            {
                Console.WriteLine("No");
            }


        }

        static void Main(string[] args)
        {
            FileStream fs = new FileStream(@"C: \Users\Twins\Desktop\PP2\abba.txt", FileMode.Open, FileAccess.Read); 
            StreamReader sr = new StreamReader(fs);     // создать читатель потока и связать его с потоком файла

            string line = sr.ReadLine();    // создать строковую переменную string, где мы сохраняем строку из файла abba.txt

            Solve(line);    // вызываем метод

            fs.Close(); //закрыть для сохранения данных
            sr.Close(); //закрыть для сохранения данных

            // не закрывая поток, ничего не будет записано в файл

            Console.ReadLine();
        }
    }
}