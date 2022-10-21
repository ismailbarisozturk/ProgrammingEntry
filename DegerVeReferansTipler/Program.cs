using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DegerVeReferansTipler
{
     class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");


            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            //sayi1 kaç olurdu ? ben 30 dedim

            // array ler referans tiptir.
            int[] sayilar1 = new int[] { 10,20,30};  // new bellekte yeni yer oluştur demek 
            int[] sayilar2 = new int[] { 100,200,300};
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            //sayilar1[0]=999


        }
    }
}
