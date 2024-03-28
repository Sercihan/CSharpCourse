using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Methods_1
{
    internal class KDVK
    {
        internal static void KdvUygula()
        {
            Console.WriteLine("Ürün Fiyatı");
            double fiyat = Convert.ToDouble(Console.ReadLine());

            fiyat = fiyat * 1.20;
            Console.WriteLine("Yeni Fiyat:" + fiyat);
        }
    }
}
