using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_task2
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream(@"C:\Users\Twins\Desktop\PP2\nur.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            string line = sr.ReadLine();
            string[] parts = line.Split();

            int[] arr1 = new int[parts.Length];
            int[] arr2 = new int[parts.Length];
            int sum = 0, m = 0;

            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = int.Parse(parts[i]);
            }

            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] > 0 && arr1[i] > 1)
                {
                    for (int j = 1; j <= arr1[i]; j++)
                    {
                        if (arr1[i] % j == 0)
                            sum++;
                    }
                    if (sum == 2)
                    {
                        arr2[m] = arr1[i];
                        m++;
                    }
                    sum = 0;
                }
            }

            fs.Close();
            sr.Close();

            string[] arr3 = new string[m];
            for (int i = 0; m > i; i++)
            {
                arr3[i] = Convert.ToString(arr2[i]);
            }
            string line2 = arr3[0];
            for (int i = 1; arr3.Length > i; i++)
            {
                line2 = line2 + " " + arr3[i];
            }

            StreamWriter writer = new StreamWriter(@"C:\Users\Twins\Desktop\PP2\nur1.txt");
            writer.Write(line2);

            writer.Close();




            Console.ReadKey();

        }
    }
}