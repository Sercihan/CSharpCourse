using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_OOP_4_Inheritance_4
{
    internal class Pazarlama : Personel
    {
        public int TeklifSayisi { get; set; }

        internal new void Kayit(List<Personel> Pazarlamas)
        {
            base.Kayit();

            Console.WriteLine("Teklif Sayisi:");
            this.TeklifSayisi = Convert.ToInt32(Console.ReadLine());

            Pazarlamas.Add(this);
        }
    }
}
