using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Emil";
            int yas = 15;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C++";
            kurs1.KursMuellimi = "Emil Safarov";
            kurs1.IzlenmeFaizi = 80;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Python";
            kurs2.KursMuellimi = "Alinur Zamanli";
            kurs2.IzlenmeFaizi = 70;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Java";
            kurs3.KursMuellimi = "Murad Misirxanov";
            kurs3.IzlenmeFaizi = 60;

            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = "Photoshop";
            kurs4.KursMuellimi = "Resul Eliyev";
            kurs4.IzlenmeFaizi = 50;




            //Console.WriteLine(kurs1.KursAdi + " : " + kurs1.KursMuellimi);

            Kurs[] kurslar = new Kurs[] {kurs1, kurs2, kurs3, kurs4 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.KursMuellimi);
            }





          
        }
    }
}
class Kurs
{
    public string KursAdi { get; set; }
    public string KursMuellimi { get; set; }
    public int IzlenmeFaizi { get; set; }

}
