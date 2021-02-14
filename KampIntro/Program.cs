using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety = tip guvenliyi
            //Do not repeat yourself - Ozunu tekrarlama
            //Deyer tutucu, alias

            string kateqoriyaEtiketi = "Kateqoriya";
            int telebeSayisi = 5000;
            double faizQiymeti = 2.35;
            bool SistemeGirisEdibMi = true;
            double dollarDunen = 1.60;
            double dollarBugun = 1.70;

            if (dollarDunen>dollarBugun)
            {
                Console.WriteLine("Azalis isareti");

            }
            else if (dollarDunen<dollarBugun)
            {

                Console.WriteLine("Artis isareti");
            }

            {
                Console.WriteLine("Deyismedi duymesi");
            }
                if (SistemeGirisEdibMi == true)

            {
                Console.WriteLine("Istifadeci Paneli duymesi");
            }
            else
            {
                Console.WriteLine("Sisteme giris et butonu");
            }
            
            Console.WriteLine(kateqoriyaEtiketi);

             

        }
    }
}
