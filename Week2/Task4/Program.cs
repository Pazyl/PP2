using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter file = new StreamWriter(@"C: \Users\Twins\Desktop\PP2\path\textfile.txt"); // получить доступ к  существующему либо создать новый
            file.WriteLine("Hello World!"); //записать в него
            file.WriteLine("And goodbye");
            file.Close(); // //закрыть для сохранения данных

            string fileName = "textfile.txt";
            string sourcePath = @"C: \Users\Twins\Desktop\PP2\path";              // исходни путь
            string targetPath = @"C: \Users\Twins\Desktop\PP2\path2";             // целевой путь

            // Используем класс Path для управления путями к файлам
            string sourceFile = Path.Combine(sourcePath, fileName);
            string destFile = Path.Combine(targetPath, fileName);

            // Чтобы скопировать файл в другое место и перезаписать файл назначения
            File.Copy(sourceFile, destFile, true);

            if (File.Exists(sourceFile))
            {
                File.Delete(sourceFile); // удалить файл
            }
            else
            {
                Console.WriteLine("файл не найден");
            }
        }
    }
}