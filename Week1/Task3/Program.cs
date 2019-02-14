using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine()); // массивке размер беру
            int[] arr = new int[n];                // 2 массив создать ету
            int[] arr1 = new int[n];
            int sum = 0, m = 0;         // жай сан есептеуге керек - sum, m - 2ші массивке жай санды беру үшін қолданамыз

            string line = Console.ReadLine();
            string[] parts = line.Split();

            for(int i=0; n>i; i++)      // цикл - 1ші массивтін элементтерін беру үшін консоль арқылы
            {
                arr[i] = int.Parse(parts[i]);
            }

            for(int i=0; n>i; i++)      // цикл - жай санды тауып 2ші массивке беру үшін
            {
                if(arr[i]>0)
                {
                    for(int j=1; j<=arr[i]; j++)    // цикл - жай санды іздеуге қолданамыз
                    {
                        if (arr[i] % j == 0)
                            sum++;
                    }

                    if (sum == 2)   // жай сан ба?! әлде жоқ?!
                    {
                        arr1[m] = arr[i];      
                        m++;        // келесі жай санды 2ші массивтін келесі элементі ретінде орналастыру үшін
                    }

                    if (sum == 1)   // массив элементі 1 болган жагдайда
                    {
                        arr1[m] = arr[i];
                        m++;
                    }
                    sum = 0;        // неге = 0? себебі 0 теңестірмесек, келесі жай санды таба алмай қаламыз
                }
                
            }

            for (int i=0; m>i; i++)
            {
                Console.Write(arr1[i] + " " + arr1[i] + " ");
            }

            Console.ReadLine();
        }
    }
}

