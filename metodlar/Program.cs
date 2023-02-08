using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya elması";

            string[] meyveler = new string[] { };

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.fiyati = 15;
            urun1.aciklama = "Amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.fiyati = 80;
            urun2.aciklama = "Diyarbakır karpuzu";






            Urun[] urunler = new Urun[] { urun1, urun2 };

            // type-safe=tip guvenli

            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.fiyati);
                Console.WriteLine(urun.aciklama);
                Console.WriteLine("------------");


                
            
            }
            Console.WriteLine("-------- Metodlar------");

            //ınstance =öernek(class örnegi)
            //encupsulation=kapsülleme
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);


            sepetManager.Ekle2("Armut", "Yesil armut", 12,10);
            sepetManager.Ekle2("Elma", "Yesil elma", 12,9);
            sepetManager.Ekle2("Karpuz", "Diyarbakır karpuzu", 12,8);
            
            



            Console.ReadKey();





        }
    }
}
// Do not repeat your self=kendini tekrar etme(DRY)-Clean code-Best practice