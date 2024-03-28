using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_OOP_4_Inheritance_3
{
    internal class Kedi : Hayvan
    {
        public string Turu;

        public Kedi(double _boy, double _agirlik, string _yas, string _turu) : base(_boy, _agirlik, _yas)
        {
            this.Turu = _turu;
        }

        public void TuruGoster()
        {
            Console.WriteLine("Türü:" + Turu);
        }

        public new void OzellikGoster()
        {
            base.OzellikGoster();
            Console.WriteLine("Türü:" + Turu);

        }
    }
}
