using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Programlamaya başlangiç icicn temel kurs";
            string kurs3 = "Java";
            // array= dizi

            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı",  "Programlamaya başlangiç icin temel kurs", "Java","python","C#" };

            for (int i = 0; i<kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("For bitti") ;

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
           
            
            

            }
            Console.WriteLine("sayfa sonu = footer");    

            Console.ReadKey();
                
        }    
             
           





    } 
}
