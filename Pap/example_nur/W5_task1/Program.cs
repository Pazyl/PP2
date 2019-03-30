using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

                                    /*      комплексные числа z=x+yi     i^2=-1       */

namespace W5_task1
{
    [Serializable]
    public class ComplexNumber
    {
        public ComplexNumber() { }

        public string x;
        public string y;
        public string z;

        public void ZZ()
        {
            z = x + "+" + y + "i";
        }
        public void PrintInfo()
        {
            Console.WriteLine(string.Format(z));
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            ComplexNumber cn = new ComplexNumber();
            cn.x = "4";
            cn.y = "5";
            cn.ZZ();

            ComplexNumber cn2 = new ComplexNumber();
            cn2.x = "8";
            cn2.y = "3";
            cn2.ZZ();


            ComplexNumber cn3 = new ComplexNumber();
            cn3.x = "7";
            cn3.y = "6";
            cn3.ZZ();

            ComplexNumber[] numbers = new ComplexNumber[] { cn, cn2, cn3 };

            FileStream fs = new FileStream(@"C:\Users\Twins\Desktop\PP2\pause.txt", FileMode.Create, FileAccess.Write);

            XmlSerializer xs = new XmlSerializer(typeof(ComplexNumber[]));

            xs.Serialize(fs, numbers);
            fs.Close();



            FileStream fs2 = new FileStream(@"C:\Users\Twins\Desktop\PP2\pause.txt", FileMode.Open, FileAccess.Read);

            XmlSerializer xs2 = new XmlSerializer(typeof(ComplexNumber[]));

            ComplexNumber[] newnumbers = xs2.Deserialize(fs2) as ComplexNumber[];

            foreach (ComplexNumber i in newnumbers)
            {
                Console.WriteLine("X: {0}       Y: {1}      Z: {2}", i.x, i.y, i.z);
            }
            fs.Close();

            Console.ReadKey();
        }
    }
}
