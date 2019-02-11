using System;
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
            int n = Convert.ToInt32(Console.ReadLine());
            string[,] arr1 = new string[n, n];
            int m = 1;
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < m; j++)
                {
                    arr1[i, j] = "[*]";
                    Console.Write(arr1[i, j]);
                }
                m++;
                Console.WriteLine();
            }
        }
    }
}
