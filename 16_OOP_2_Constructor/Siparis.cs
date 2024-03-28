using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_OOP_2_Constructor
{
    internal class Siparis
    {
        public int MasaNo { get; set; }
        public List<Yemek> Yemekler { get; set; }

        public Siparis()
        {
            Yemekler = new List<Yemek>();
        }

        internal static void SiparisAl(List<Yemek> menu, Siparis siparis)
        {
            Yemek.Listele(menu);
            Console.WriteLine("Seçilen yemek numarası:");
            int no = Convert.ToInt32(Console.ReadLine());

            if (no <= menu.Count && no > 0)
            {
                siparis.Yemekler.Add(menu[no - 1]);
            }
            else
            {
                Console.WriteLine("Hatalı yemek seçimi!");
            }
        }

        private static void SiparisListe(List<Siparis> siparisler)
        {
            foreach (Siparis siparis in siparisler)
            {
                Console.WriteLine("Masa-" + siparis.MasaNo);
                foreach (Yemek yemek in siparis.Yemekler)
                {
                    Console.WriteLine(yemek.Ad + ":" + yemek.Fiyat);
                }
            }
        }

        internal static int SiparisOdeme(List<Siparis> siparisler)
        {
            SiparisListe(siparisler);

            Console.WriteLine("Masa Numarası:");
            int masaNo = Convert.ToInt32(Console.ReadLine());

            foreach (Siparis siparis in siparisler)
            {
                if (masaNo == siparis.MasaNo)
                {
                    int odeme = 0;
                    foreach (Yemek yemek in siparis.Yemekler)
                    {
                        Console.WriteLine(yemek.Ad + ":" + yemek.Fiyat);
                        odeme += yemek.Fiyat;
                    }

                    Console.WriteLine("Ödeme:" + odeme);

                    Console.WriteLine("Ödendi Mi(E/H)?");
                    string cevap = Console.ReadLine().ToLower();
                    if (cevap == "e")
                    {
                        return masaNo;
                    }
                    break;
                }
            }

            return 0;
        }
    }
}
