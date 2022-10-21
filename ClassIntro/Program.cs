using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1=new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "ıso";
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "java";
            kurs2.Egitmen = "murat";
            kurs2.IzlenmeOrani = 74;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "autocad";
            kurs3.Egitmen = "gursel";
            kurs3.IzlenmeOrani = 43;




            Console.WriteLine(kurs1.KursAdi+ ":" +kurs1.Egitmen);  //"" boşluk bıraktı

            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.IzlenmeOrani);
            }
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; } //prop tab tab
        public int IzlenmeOrani { get; set; }
    }
}
