using System;
using System.IO;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*      комплексные числа z=x+iy     i^2=-1       */

namespace week5
{   
    [Serializable]
    public class Student
    {   
        public Student() { }

        public string name;

        public string gpa;

        public void PrintInfo()
        {
            Console.WriteLine(string.Format("{0} {1}", name, gpa));
        }
    } 
    
    class Program
    {
        static void Main(string[] args)
        {
            F2();        
        }
        
        private static void F1()
        {
            Student student = new Student();
            student.name = "Dulat";
            student.gpa = "4.0";

            XmlSerializer xs = new XmlSerializer(typeof(Student));

            FileStream fs = new FileStream(@"C:\Users\Twins\Desktop\PP2\pause.txt", FileMode.Create, FileAccess.Write);
            
            xs.Serialize(fs, student);
            fs.Close();
        }

        private static void F2()
        {
            FileStream fs = new FileStream(@"C:\Users\Twins\Desktop\PP2\pause.txt", FileMode.Open, FileAccess.Read);
            
            XmlSerializer xs = new XmlSerializer(typeof(Student));
            
            Student student = xs.Deserialize(fs) as Student;
            
            student.PrintInfo();
            fs.Close();
        }

        private static void F3()
        {
            Student s = new Student();
            s.name = "Dulat";
            s.gpa = "4.0";

            Student s2 = new Student();
            s2.name = "Yerbolat";
            s2.name = "4.5";

            Student s3 = new Student();
            s3.name = "Ali";
            s3.name = "3.6";

            List<Student> students = new List<Student>();
            students.Add(s);
            students.Add(s2);
            students.Add(s3);

            FileStream fs = new FileStream(@"C:\Users\Twins\Desktop\PP2\pause.txt", FileMode.Create, FileAccess.Write);

            XmlSerializer xs = new XmlSerializer(typeof(List<Student>));
            xs.Serialize(fs, students);
            fs.Close();
        }

    }
}
