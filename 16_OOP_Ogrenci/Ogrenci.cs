using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _16_OOP_Ogrenci
{
    internal class Ogrenci
    {
        public string adSoyad;
        public string okulNo;
        public string okulAd;
        public string ogretimDuzey;

        internal void Kayit()
        {
            Console.WriteLine("Adınız ve Soyadınız");
            this.adSoyad = Console.ReadLine();
            Console.WriteLine("Okul Numaranız");
            this.okulNo = Console.ReadLine();
            Console.WriteLine("Okulunuzun Adı");
            this.okulAd = Console.ReadLine();
            Console.WriteLine("Öğrenim Düzeyiniz (IlkOgretim,OrtaOgretim,Lise,Lisans)");
            this.ogretimDuzey = Console.ReadLine();
        }
        internal virtual void NotHesapla()
        {
            Console.WriteLine("Not Bilgisi Eksik");
        }

    }
    
}
