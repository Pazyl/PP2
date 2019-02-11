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
            int n = Convert.ToInt32(Console.ReadLine());


            string line = Console.ReadLine();
            string[] parts = line.Split();
            int[] arr1 = new int[n];

            for(int i = 0; i < n; i++)
            {
                //arr1[i] = Convert.ToInt32(Console.ReadLine());
                arr1[i] = int.Parse(parts[i]);       
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write(arr1[i] + " ");
                Console.Write(arr1[i] + " ");
          
            }
        }
    }
}
