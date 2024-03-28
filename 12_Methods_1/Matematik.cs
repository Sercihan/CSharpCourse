using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Methods_1
{
    public class Matemetik
    {
        //her method tanımlandığında default PRIVATE özelliğine sahiptir.
        public static void Toplama(int sayi1, int sayi2)
        {
            Console.WriteLine("Toplam:" + (sayi1 + sayi2));
        }

        internal void Cikarma(int sayi1, int sayi2)
        {
            Console.WriteLine("Çıkarma:" + (sayi1 - sayi2));
        }
    }
}
