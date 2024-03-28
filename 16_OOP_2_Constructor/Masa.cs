using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_OOP_2_Constructor
{
    internal class Masa
    {
        public int Id { get; set; }
        public bool Durum { get; set; }

        internal static void MasaListe(List<Masa> masalar)
        {
            foreach (Masa masa in masalar)
            {
                Console.WriteLine(masa.Id + ":" + (masa.Durum == true ? "Boş" : "Dolu"));
            }
        }
    }
}
