using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_OOP_2_Constructor
{
    internal class Yemek
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public int Fiyat { get; set; }

        internal static void Listele(List<Yemek> list)
        {
            foreach (Yemek item in list)
            {
                Console.WriteLine(item.Id + "-" + item.Ad + ":" + item.Fiyat);
            }
        }
    }
}