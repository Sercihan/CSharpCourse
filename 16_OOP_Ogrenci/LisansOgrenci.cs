using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_OOP_Ogrenci
{
    internal class LisansOgrenci:Ogrenci
    {
        string fakulte;
        int vize;
        int final;

        internal void Kayit(List<Ogrenci> lisansOgrenci)
        {
            base.Kayit();
            Console.WriteLine("Fakültenizi Girin");
            this.fakulte = Console.ReadLine();
            Console.WriteLine("Vize Notunuzu Girin");
            this.vize = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Final Notunuzu Girin");
            this.final = Convert.ToInt32(Console.ReadLine());
            lisansOgrenci.Add(this);
        }

        internal override void NotHesapla()
        {
            double ortalama = this.vize*0.4 + this.final*0.6;
            if (ortalama <= 100 && ortalama > 85)
            {
                Console.WriteLine("Ortalama: " + ortalama + " A");
            }
            else if (ortalama <= 85 && ortalama > 70)
            {
                Console.WriteLine("Ortalama: " + ortalama + " B");
            }
            else if (ortalama <= 70 && ortalama > 60)
            {
                Console.WriteLine("Ortalama: " + ortalama + " C");
            }
            else if (ortalama <= 60 && ortalama > 50)
            {
                Console.WriteLine("Ortalama: " + ortalama + " D");
            }
            else if (ortalama <= 50 && ortalama > 45)
            {
                Console.WriteLine("Ortalama: " + ortalama + " E");
            }
            else if (ortalama <= 45 && ortalama > 0)
            {
                Console.WriteLine("Ortalama: " + ortalama + " F");
            }
            else
            {
                Console.WriteLine("Acilen Okulu Bırakmalısın");
            }
        }
    }
}
