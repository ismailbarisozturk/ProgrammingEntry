using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
   class Program
    {
        static void Main(string[] args)
        {
            string UrunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya Elması";

            string[] meyveler = new string[] { };

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";


            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 75;
            urun2.Aciklama = "Güzel karpuz";


            Urun[] urunler = new Urun[] {urun1,urun2 };

            foreach (Urun urun in urunler)
            {


                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);

            }

            Console.WriteLine("...............Metotlar.........");

            
            //instance -örnek
            //encapsulation
            SepetManager sepetManager = new SepetManager(); //
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);


            sepetManager.Ekle2("Armut " , "Yeşil " ,12 ,10);
            sepetManager.Ekle2("elma " , "Yeşil " ,12, 8);
            sepetManager.Ekle2("karpuz " , "mavi " ,12 ,7);




        }
    }
}
