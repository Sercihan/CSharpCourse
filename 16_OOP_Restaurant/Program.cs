using System.Collections;
using System.Runtime.CompilerServices;

namespace _16_OOP_Restaurant
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Restaurant Otomasyonu
            * toplam 5 masa olacak
            * Menu=> Çorbalar(3 çeşit) Salatalar(3çeşit) Etler(3çeşit) Makarnalar(3çeşit) İçecekler(3çeşit)
            * 1-Sipariş Al
            * 2-Hesap Al
             */
            List<Musteri> musteriList = new List<Musteri>();
            List<string> corbalar = new List<string>() { "mercimek","tarhana","ezogelin","yayla" };
            List<string> etler = new List<string>() { "pirzola", "dana antrikot", "tavuk şiş", "brisket" };
            List<string> kebaplar = new List<string>() { "adana", "urfa", "beyti", "cağ" };
            List<string> makarnalar = new List<string>() { "fesleğenli", "fırında", "kremalı mantarlı", "peynirli" };
            List<string> salatalar = new List<string>() { "mevsim", "çoban", "piyaz", "brokoli" };
            List<string> icecekler = new List<string>() { "su", "ayran", "kola", "şalgam" };
            List<Masa> masaList = new List<Masa>()
            { new Masa {},new Masa {},new Masa {},new Masa {},new Masa {} };

            while (true)
            {
                Musteri musteri = new Musteri(masaList);
                while (true)
                {
                    if (musteri.getoturdu())
                    {
                        MenuGoster();
                        Console.WriteLine("\nSipariş Vermek İçin 1 - Hesap Ödemek İçin 2");
                        int secim = Convert.ToInt32(Console.ReadLine());
                        if (secim == 1)
                        {
                            SiparisAl(musteri, corbalar, etler, kebaplar, makarnalar, salatalar, icecekler);
                        }
                        else if (secim == 2)
                        {
                            HesapOde(musteri);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Hatalı Seçim");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Müşteri Yoğunluk Nedeniyle Boş Masa Bulamadı, Şuanda Yeni Müşteri Kabul Etmiyoruz");
                        Thread.Sleep(2000);
                        Environment.Exit(0);

                    }
                }
            }
        }
        static void MenuGoster()
        {
            Console.WriteLine("\n***** MENU *****");
            Console.WriteLine("<- ÇORBALAR (90 TL) ->");
            Console.WriteLine("1 Mercimek");
            Console.WriteLine("2 Tarhana");
            Console.WriteLine("3 Ezogelin");
            Console.WriteLine("4 Yayla");
            Console.WriteLine("\n<- ETLER (300 TL) ->");
            Console.WriteLine("1 Pirzola");
            Console.WriteLine("2 Dana Antrikot");
            Console.WriteLine("3 Tavuk Şiş");
            Console.WriteLine("4 Brisket");
            Console.WriteLine("\n<- KEBAPLAR (300 TL) ->");
            Console.WriteLine("1 Adana");
            Console.WriteLine("2 Urfa");
            Console.WriteLine("3 Beyti");
            Console.WriteLine("4 Cağ");
            Console.WriteLine("\n<- MAKARNALAR (130 TL) ->");
            Console.WriteLine("1 Fesleğenli");
            Console.WriteLine("2 Fırında");
            Console.WriteLine("3 Kremalı Mantarlı");
            Console.WriteLine("4 Peynirli");
            Console.WriteLine("\n<- SALATALAR (80 TL) ->");
            Console.WriteLine("1 Mevsim");
            Console.WriteLine("2 Çoban");
            Console.WriteLine("3 Piyaz");
            Console.WriteLine("4 Brokoli");
            Console.WriteLine("\n<- İÇECEKLER (30 TL) ->");
            Console.WriteLine("1 Su");
            Console.WriteLine("2 Ayran");
            Console.WriteLine("3 Kola");
            Console.WriteLine("4 Şalgam");
        } 
        static void SiparisAl(Musteri m,List<string> corbalar, List<string> etler, List<string> kebaplar, List<string> makarnalar, List<string> salatalar, List<string> icecekler)
        {
            Console.WriteLine("Hangi Ürünü Almak İstersiniz");
            string urun = Console.ReadLine().ToLower();
            
            if (corbalar.Contains(urun))
            {
                m.SiparisEkle(urun, 90);
            }
            else if (etler.Contains(urun))
            {
                m.SiparisEkle(urun, 300);
            }
            else if (kebaplar.Contains(urun))
            {
                m.SiparisEkle(urun, 300);
            }
            else if (makarnalar.Contains(urun))
            {
                m.SiparisEkle(urun, 130);
            }
            else if (salatalar.Contains(urun))
            {
                m.SiparisEkle(urun, 80);
            }
            else if (icecekler.Contains(urun))
            {
                m.SiparisEkle(urun, 30);
            }
            else
            {
                Console.WriteLine("Ürün Menüde Bulunmamaktadır");
            }
        }
        static void HesapOde(Musteri m)
        {
            Console.Clear();
            m.HesapAl();
            Thread.Sleep(5000);
            Console.Clear();
        }
    }
}
