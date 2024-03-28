using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_OOP_4_Inheritance_4
{
    internal class InsanKaynaklari : Personel
    {
        public int PersonelSayisi { get; set; }

        internal void Kayit(List<Personel> InsanKaynaklaris)
        {
            base.Kayit();

            Console.WriteLine("Personel Sayisi:");
            this.PersonelSayisi = Convert.ToInt32(Console.ReadLine());

            InsanKaynaklaris.Add(this);
        }

        public static void Listele(List<Personel> InsanKaynaklaris)
        {
            foreach (InsanKaynaklari item in InsanKaynaklaris)
            {
                Personel.Listele(item);
                Console.WriteLine("Personel Sayisi:" + item.PersonelSayisi);
            }
        }

        public static void Guncelle(List<Personel> InsanKaynaklaris)
        {
            Listele(InsanKaynaklaris);
            Console.WriteLine("Güncellenecek Id:");
            int id = Convert.ToInt32(Console.ReadLine());

            foreach (InsanKaynaklari item in InsanKaynaklaris)
            {
                if (item.Id == id)
                {
                    item.Kayit();
                    Console.WriteLine("Personel Sayisi:");
                    item.PersonelSayisi = Convert.ToInt32(Console.ReadLine());
                }
            }
        }

        public static void Silme(List<Personel> InsanKaynaklaris)
        {
            Listele(InsanKaynaklaris);
            Console.WriteLine("Silinecek Id:");
            int id = Convert.ToInt32(Console.ReadLine());

            foreach (InsanKaynaklari item in InsanKaynaklaris)
            {
                if (item.Id == id)
                {
                    InsanKaynaklaris.Remove(item);
                }
            }
        }
    }
}
