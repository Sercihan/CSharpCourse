using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_OOP_4_Inheritance_3
{
    internal class Hayvan : Memeli
    {
        public string Yas;

        public Hayvan(double _boy, double _agirlik, string _yas) : base(_boy, _agirlik)
        {
            this.Yas = _yas;
        }

        public new void OzellikGoster()
        {
            base.OzellikGoster();
            Console.WriteLine("Yaş:" + Yas);

        }
    }
}
