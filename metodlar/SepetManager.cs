using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodlar
{
    class SepetManager
    {
        private int stokAdedi;

        // anmıng conventıon=
        //syntax


        public void Ekle (Urun urun)
        {
            Console.WriteLine ("Tebrikler. Sepete eklendi : " + urun.Adi);
        }

        public void Ekle2(string urunAdi, string aciklama, double fiyatı, int stokAdedi)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi : " + urunAdi,  stokAdedi);




        }
        

        
    }
}
