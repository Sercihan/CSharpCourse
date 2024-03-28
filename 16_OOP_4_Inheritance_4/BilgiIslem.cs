using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_OOP_4_Inheritance_4
{
    internal class BilgiIslem : Personel
    {
        public int ProgramSayisi { get; set; }

        internal new void Kayit(List<Personel> BilgiIslems)
        {
            base.Kayit();

            Console.WriteLine("Program Sayisi:");
            this.ProgramSayisi = Convert.ToInt32(Console.ReadLine());

            BilgiIslems.Add(this);
        }
    }
}
