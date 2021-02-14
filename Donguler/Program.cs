using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Programlama Python";
            string kurs2 = "Programlama Java";
            string kurs3 = "Photoshop Programi oyrenme";
            string kurs4 = "Video montaj oyrenme";
            string kurs5 = "C++";
            
            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);
            Console.WriteLine(kurs3);
            Console.WriteLine(kurs4);
            Console.WriteLine(kurs5);

            string[] kurslar = new string[] { "Programlama Python", "Programlama Java", "Photoshop Programi oyrenme" , 
                "Video Montaj oyrenme" , "C#" };




            for (int i = 0; i<kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
             }
            Console.WriteLine("For bitti");
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
            Console.WriteLine("sehife sonu - footor");


        }
    }
}
