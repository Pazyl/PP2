﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Example3
{
    [Serializable]
    class Student
    {
        public string name;
        public string gpa;
        public Student()
        {

        }
        public void PrintInfo()
        {
            Console.WriteLine(string.Format("{0} {1}", name, gpa));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            F1();
            F2();
            Console.ReadLine();
        }
        private static void F1()
        {
            Student s = new Student();
            s.gpa = "4.0";
            s.name = "Dulat";

            FileStream fs = new FileStream(@"C:\Users\Twins\Desktop\PP2\pause.txt", FileMode.Create, FileAccess.Write);

            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, s);
            fs.Close();
        }

        private static void F2()
        {
            FileStream fs = new FileStream(@"C:\Users\Twins\Desktop\PP2\pause.txt", FileMode.Open, FileAccess.Read);

            BinaryFormatter bf = new BinaryFormatter();

            Student s = bf.Deserialize(fs) as Student;
            s.PrintInfo();
            fs.Close();

            
        }
    }
}