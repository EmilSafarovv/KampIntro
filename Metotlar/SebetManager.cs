using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SebetManager
    {
        public void Artir(Mehsul mehsul) 
        {
            Console.WriteLine("Tebrikler. Sebete Artirildi : " + mehsul.Adi);
        }

        public void Artir2(string mehsulAdi, string aciqlama, double qiymet, int stokEdedi)
        {
            Console.WriteLine("Tebrikler. Sebete Artirildi : " + mehsulAdi);
        }
    }

}
