using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KampIntroNew
{
    class Program
    {
        static void Main(string[] args)
        {
            // Type safety=tip guvenliği
            //Do not repeat yor self= kendini tekrarlama
            //deger tutucu  alias

            string kategoriEtiketi = "Kategoriler";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = false;

            double dolarDun = 7.55;
            double dolarBugun = 7.55;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalıs butonu");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artıs butonu");
            }
            else 
            {
                Console.WriteLine("degışmedı butonu");
            }

            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }

            else
            {
                Console.WriteLine("Giriş yap butonu");
            }
            Console.WriteLine(kategoriEtiketi);

            Console.ReadKey();

        }
    }
}
