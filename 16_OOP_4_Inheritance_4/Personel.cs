using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_OOP_4_Inheritance_4
{
    internal class Personel
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string TC { get; set; }
        public DateTime SGKGirisTarihi { get; set; }

        internal void Kayit()
        {
            Console.WriteLine("Id:");
            this.Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ad:");
            this.Ad = Console.ReadLine();
            Console.WriteLine("Soyad:");
            this.Soyad = Console.ReadLine();
            Console.WriteLine("TC:");
            this.TC = Console.ReadLine();
            this.SGKGirisTarihi = DateTime.Now;
        }

        public static void Listele(Personel item)
        {
            Console.WriteLine("Id:" + item.Id + "\nAdsoyad:" + item.Ad + " " + item.Soyad + "\nTC:" + item.TC + "\nSGK Giriş:" + item.SGKGirisTarihi.ToLongDateString());
        }

    }
}
