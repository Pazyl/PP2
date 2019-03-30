using System;
using System.IO;
using System.Xml.Serialization;

namespace W5_task2
{
    public class Mark
    {
        public int point;
        public char symbol;

        public void GetLetter()
        {
            symbol = (char)point;
        }

        public override string ToString()
        {
            return string.Format("{0}   ||   {1}", point, symbol);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Mark m = new Mark();
            m.point = 65;
            m.GetLetter();

            Mark m2 = new Mark();
            m2.point = 68;
            m2.GetLetter();

            Mark m3 = new Mark();
            m3.point = 83;
            m3.GetLetter();
       

            Mark[] marks = new Mark[] { m, m2, m3 };

            FileStream fs = new FileStream(@"C:\Users\Twins\Desktop\PP2\pause.txt", FileMode.Create, FileAccess.Write);
            XmlSerializer xs = new XmlSerializer(typeof(Mark[]));
            xs.Serialize(fs, marks);
            fs.Close();



            FileStream fs2 = new FileStream(@"C:\Users\Twins\Desktop\PP2\pause.txt", FileMode.Open, FileAccess.Read);
            XmlSerializer xs2 = new XmlSerializer(typeof(Mark[]));
            Mark[] newMarks = xs2.Deserialize(fs2) as Mark[];
            fs2.Close();

            foreach (Mark i in newMarks)
            {
                Console.WriteLine("{0}   ||   {1}", i.point, i.symbol);
            }
                //Console.WriteLine(m.ToString());

            Console.ReadLine();
        }
    }
}