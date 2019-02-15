using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Student
    {
        public string name; // поля name
        public int id;      // поля id
        public int year;    // поля year

        public Student(string name, int id) // Конструктор student - принимает два типовых параметра
        {
            this.name = name; 
            this.id = id;
        }

        public void SetName(string name)    // метод, который может изменить значение переменной «имя»
        {
            this.name = name;
        }
        public void SetId(int id)   // метод, который может изменить значение переменной «id»
        {
            this.id = id;
        }

        public void GetInfoName()   // метод, который показывает имя студента
        {
            Console.WriteLine("Имя: " + name);
        }
        public void GetInfoId()     // метод, который показывает id студента
        {
            Console.WriteLine("ID студента: " + id);
        }

        public void GetInfoYear(int year)   // метод, который показывает инкрементную переменную "year"
        {
            this.year = year++;     // инкрементная переменная "year"
            Console.WriteLine("Год обучения: " + year);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student("Dulat", 18111264); // создать new object для class Student

            s.GetInfoName();    // output name
            s.GetInfoId();      // output id

            s.GetInfoYear(2019);    // output year of study

            Console.ReadLine();
        }
    }
}