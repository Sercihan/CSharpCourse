using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_OOP_4_Inheritance_4
{
    internal class Muhasebe : Personel
    {
        public int HesapSayisi { get; set; }

        internal new void Kayit(List<Personel> Muhasebes)
        {
            base.Kayit();

            Console.WriteLine("Hesap Sayisi:");
            this.HesapSayisi = Convert.ToInt32(Console.ReadLine());

            Muhasebes.Add(this);
        }
    }
}
