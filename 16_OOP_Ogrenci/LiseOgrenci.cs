using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_OOP_Ogrenci
{
    internal class LiseOgrenci:Ogrenci
    {
        public int not1;
        public int not2;

        internal void Kayit(List<Ogrenci> liseOgrenci)
        {
            base.Kayit();
            Console.WriteLine("1.Notunuzu Girin");
            this.not1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2.Notunuzu Girin");
            this.not2 = Convert.ToInt32(Console.ReadLine());
            liseOgrenci.Add(this);
        }

        internal override void NotHesapla()
        {
            double ortalama = (this.not1 + this.not2)/2;
            if (ortalama <= 100 && ortalama > 85)
            {
                Console.WriteLine("Ortalama: " + ortalama+" Pekiyi");
            }
            else if (ortalama <= 85 && ortalama > 70)
            {
                Console.WriteLine("Ortalama: " + ortalama + " İyi");
            }
            else if (ortalama <= 70 && ortalama > 60)
            {
                Console.WriteLine("Ortalama: " + ortalama + " Orta");
            }
            else if (ortalama <= 60 && ortalama > 50)
            {
                Console.WriteLine("Ortalama: " + ortalama + " Geçer");
            }
            else if (ortalama <= 50 && ortalama > 0)
            {
                Console.WriteLine("Ortalama: " + ortalama + " Tekrar");
            }
            else
            {
                Console.WriteLine("Acilen Okulu Bırakmalısın");
            }
        }
    }
}
