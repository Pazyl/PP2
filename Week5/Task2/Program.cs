using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace Task2
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

            List<Mark> marks = new List<Mark>();
            marks.Add(m);
            marks.Add(m2);
            marks.Add(m3);


            FileStream fs = new FileStream(@"C:\Users\Twins\Desktop\PP2\pause.txt", FileMode.Create, FileAccess.Write);
            XmlSerializer xs = new XmlSerializer(typeof(List<Mark>));
            xs.Serialize(fs, marks);
            fs.Close();

  
            FileStream fs2 = new FileStream(@"C:\Users\Twins\Desktop\PP2\pause.txt", FileMode.Open, FileAccess.Read);
            XmlSerializer xs2 = new XmlSerializer(typeof(List<Mark>));
            List<Mark> newMarks = xs2.Deserialize(fs2) as List<Mark>;
            fs.Close();

            foreach (Mark i in newMarks)
            {
                //Console.WriteLine("{0}   ||   {1}", i.point, i.symbol);
                Console.WriteLine("{0}", i.ToString());
            }


            Console.ReadLine();
        }
    }
}
