using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_OOP_4_Inheritance_3
{
    internal class Memeli
    {
        protected double Boy;
        protected double Agirlik;

        public double mBoy
        {
            get { return Boy; }
            set { Boy = value; }
        }
        public double mAgirlik
        {
            get { return Agirlik; }
            set { Agirlik = value; }
        }



        public Memeli(double boy, double agirlik)
        {
            this.mBoy = boy;
            this.mAgirlik = agirlik;
        }

        internal void OzellikGoster()
        {
            Console.WriteLine("Boy:" + Boy);
            Console.WriteLine("Ağırlık:" + Agirlik);
        }
    }
}
