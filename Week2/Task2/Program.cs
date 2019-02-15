using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream input = new FileStream(@"C: \Users\Twins\Desktop\PP2\nur.txt", FileMode.Open, FileAccess.Read);
            StreamReader output = new StreamReader(input);  // создать читатель потока и связать его с потоком файла

            //Console.WriteLine(output.ReadToEnd());
            string line = output.ReadLine();    // создать строковую переменную string, где мы сохраняем строку из файла nur.txt
            string[] parts = line.Split();      // создаем массив, где мы сохраняем каждый символ

            int[] arr = new int[parts.Length];  // массив arr - где будет уже сохраняться цифры
            int[] arr2 = new int[arr.Length];   // arr2 - нужен для prime numbers
            int sum = 0, m = 0;

            for (int i = 0; arr.Length > i; i++) // от string к  int 
            {
                arr[i] = int.Parse(parts[i]);
            }

            input.Close();   //закрыть для сохранения данных
            output.Close();  //закрыть для сохранения данных

            //File.Create(@"C: \Users\Twins\Desktop\PP2\nur1.txt");

            for(int i = 0; arr.Length > i; i++) // цикл -  для того чтобы найти prime nurber
            {
                if(arr[i]>1 && arr[i] > 0)
                {
                    for(int j=1; j<=arr[i]; j++)
                    {
                        if (arr[i] % j == 0)
                            sum++;
                    }
                    if (sum == 2)
                    {
                        arr2[m] = arr[i];
                        m++;
                    }
                    sum = 0;
                }
            }
            string[] arr3 = new string[m]; // arr3 - нужен чтобы prime nurbers-тарды int-ден string-ке ауыстыру үшін
            for (int i = 0; m > i; i++)
            {
                arr3[i] = Convert.ToString(arr2[i]); // int-тен string-ке ауысу үрдісінде
            }

            //File.WriteAllLines(@"C: \Users\Twins\Desktop\PP2\nur1.txt", arr3);

            using (StreamWriter writer = new StreamWriter(@"C: \Users\Twins\Desktop\PP2\nur1.txt")) // nur1.txt-ке ақпаратты жазу үшін, бір жолдын бойында
            {
                foreach (string str in arr3)
                {
                    writer.Write(str + " ");
                }
            }


            Console.ReadLine();
        }
    }
}
