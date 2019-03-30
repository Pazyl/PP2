using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz1
{

    class Program
    {
        static void Main(string[] args)
        {
            FileStream input = new FileStream(@"C: \Users\Twins\Desktop\PP2\nur.txt", FileMode.Open, FileAccess.Read);
            StreamReader output = new StreamReader(input);

            string line = output.ReadLine();    
            string[] parts = line.Split();      

            int[] arr = new int[parts.Length];  
            int[] arr2 = new int[arr.Length];   
            int res = 0, m = 0;

            for (int i = 0; arr.Length > i; i++)  
            {
                arr[i] = int.Parse(parts[i]);
            }

            input.Close();   
            output.Close();

            for (int i = 0; arr.Length > i; i++) 
            {
                if (arr[i] % 2 == 1)
                {
                    arr2[m] = arr[i];
                    m++;
                }

            }

            for (int i = 0; m > i; i++)
            {
                res = res + arr2[i];
            }

            string[] arr3 = new string[m]; 
            for (int i = 0; m > i; i++)
            {
                arr3[i] = Convert.ToString(arr2[i]); 
            }
            StreamWriter writer = new StreamWriter(@"C:\Users\Twins\Desktop\PP2\nur1.txt");
            writer.Write(res);

            writer.Close();

            

            Console.ReadLine();
        }
    }
}