using System;

namespace Metotlar
{
class Program
    {
        static void Main(string[] args)
        { 
            String mehsulAdi = "Qulaqliq";
            double qiymeti = 250;
            string aciqlama = "HyperX Qulaqliq";

            

            Mehsul mehsul1 = new Mehsul();
            mehsul1.Adi = "Qulaqliq";
            mehsul1.Qiymeti = 250;
            mehsul1.Aciqlama = "HyperX Qulaqliq";

            Mehsul mehsul2 = new Mehsul();
            mehsul2.Adi = "Mikrofon";
            mehsul2.Qiymeti = 60;
            mehsul2.Aciqlama = "BM-800";

            Mehsul[] mehsullar = new Mehsul[] {mehsul1,mehsul2 };

            foreach (Mehsul mehsul in mehsullar)
            {
                Console.WriteLine(mehsul.Adi);
                Console.WriteLine(mehsul.Qiymeti);
                Console.WriteLine(mehsul.Aciqlama);
                Console.WriteLine("--------------------------------");

            }


            Console.WriteLine("-------------Metotlar---------------");

            SebetManager sebetManager = new SebetManager();
            sebetManager.Artir(mehsul1);
            sebetManager.Artir(mehsul2);

            sebetManager.Artir2("Earbuds", "Xiaomi", 30, 10);
            sebetManager.Artir2("Airpods", "Apple", 300, 20);
            sebetManager.Artir2("MateBuds", "Huawei", 100, 5);
           


            //Qulaqliq

           
        }
    }
}
