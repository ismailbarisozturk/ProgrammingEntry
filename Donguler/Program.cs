using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Programlamaya başlangıç için temel kurs";
            string kurs3 = "Java";

            //array-dizi


            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı",
                "Programlamaya başlangıç için temel kurs" ,
                "Java",
                "Python" };


            for (int i = 0; i < kurslar.Length; i++)  //i=i+2 olursa ikişer arttır demek.Dizi için 4 de yazabiliriz
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("for bitti");
            foreach(string kurs in kurslar )  //seçip tab tab yap .foreach dizi temelli yapıları tek tek dönmeye yarar.Kursları tek tek dolaş dizilere uygulanır.kurs yerine ne yazarsan yaz çalışır bu aliasdır.
            {
                Console.WriteLine(kurs);
            }





            Console.WriteLine("Sayfa sonu");
        }
    }
}
