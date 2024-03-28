using System.Collections;

namespace _13_Manav_Otomasyonu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // MANAV OTOMASYONU
            /*
             * Senaryo: Manav hale gidecek. Halden belirli kilolarda meyve,sebze alacak.
             * Almış olduğu ürünleri kendi tezgehınde müşteriye satacak. 
            1-HAL BÖLÜMÜ
                1-meyve mi sebze mi? m/s
                2-5 adet meyve ekrana yazdırılacak
                3-Manav istediği ürünü seçecek.
                4-Kaç kilo diye sorulacak. Halde bir stok olayı yoktur. Manav istediği kadar kiloda ürün alabilir.
                5-Başka bir arzunuz var mı? E/H E=> 1 H=> Manav bölüme geçtik
                    * Aynı ürün iki defa eklenmesin
                    * Aynı üründen birden fazla kez alırsa kilolar toplansın.

            2-MANAV BÖLÜMÜ
                1-meyve mi sebze mi? m/s
                2-Manav müşterinin seçimine göre halden aldığı meyve veya sebzeleri listeleyecek
                3-Müşteri ürün seçtikten sonra kaç kilo diye sorulacak ve alınan kilo kadar satılabilienecek.
                4-Başka bir arzunuz var mı? E/H E=> 1 H=> Müşteri bölümü geçtik
            3-MÜŞTERİ BÖLÜMÜ
                1-Alınan ürünleri yazdır.
             */
            ArrayList sepet = new ArrayList();
            ArrayList sepetKilo = new ArrayList();
            ArrayList musteriSepet = new ArrayList();
            ArrayList musteriSepetKilo = new ArrayList();
            ArrayList meyveler = new ArrayList();
            ArrayList sebzeler = new ArrayList();
            meyveler.Add("elma");
            meyveler.Add("armut");
            meyveler.Add("portakal");
            meyveler.Add("çilek");
            meyveler.Add("muz");
            sebzeler.Add("pırasa");
            sebzeler.Add("marul");
            sebzeler.Add("havuç");
            sebzeler.Add("patates");
            sebzeler.Add("soğan");

            while (true) // MÜŞTERİ
            {
                while (true) // MANAV
                {
                    while (true) // HAL
                    {
                        Console.Clear();
                        Console.WriteLine("Hale Hoşgeldiniz");
                        Console.WriteLine("Meyve Almak İçin M, Sebze Almak İçin S Yazın.");
                        string meyveSebzeSecim = Console.ReadLine().ToLower();
                        if (meyveSebzeSecim == "m")
                        {
                            for (int i = 0; i < meyveler.Count; i++)
                            {
                                Console.WriteLine(meyveler[i] + " İçin " + (i + 1));
                            }
                            int meyveSecim = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Kaç Kilo " + meyveler[meyveSecim - 1] + " Almak İstiyorsunuz ?");
                            int kiloSecim = Convert.ToInt32(Console.ReadLine());
                            if (sepet.Contains(meyveler[meyveSecim - 1]))
                            {
                                int index = sepet.IndexOf(meyveler[meyveSecim - 1]);
                                int urunKilosu = (int)sepetKilo[index];
                                sepetKilo[index] = urunKilosu + kiloSecim;

                                Console.WriteLine("Başka Bir İsteğiniz Var Mı ? (E/H)");
                                string arzu = Console.ReadLine().ToLower();
                                if (arzu == "e")
                                {
                                    continue;
                                }
                                else
                                {
                                    break;
                                }
                            }
                            else
                            {
                                sepet.Add(meyveler[meyveSecim - 1]);
                                sepetKilo.Add(kiloSecim);
                                Console.WriteLine("Başka Bir İsteğiniz Var Mı ? (E/H)");
                                string arzu = Console.ReadLine().ToLower();
                                if (arzu == "e")
                                {
                                    continue;
                                }
                                else
                                {
                                    break;
                                }
                            }

                        }
                        else if (meyveSebzeSecim == "s")
                        {
                            for (int i = 0; i < sebzeler.Count; i++)
                            {
                                Console.WriteLine(sebzeler[i] + " İçin " + (i + 1));
                            }
                            int sebzeSecim = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Kaç Kilo " + sebzeler[sebzeSecim - 1] + " Almak İstiyorsunuz ?");
                            int kiloSecim = Convert.ToInt32(Console.ReadLine());
                            if (sepet.Contains(sebzeler[sebzeSecim - 1]))
                            {
                                int index = sepet.IndexOf(sebzeler[sebzeSecim - 1]);
                                int urunKilosu = (int)sepetKilo[index];
                                sepetKilo[index] = urunKilosu + kiloSecim;

                                Console.WriteLine("Başka Bir İsteğiniz Var Mı ? (E/H)");
                                string arzu = Console.ReadLine().ToLower();
                                if (arzu == "e")
                                {
                                    continue;
                                }
                                else
                                {
                                    break;
                                }
                            }
                            else
                            {
                                sepet.Add(sebzeler[sebzeSecim - 1]);
                                sepetKilo.Add(kiloSecim);
                                Console.WriteLine("Başka Bir İsteğiniz Var Mı ? (E/H)");
                                string arzu = Console.ReadLine().ToLower();
                                if (arzu == "e")
                                {
                                    continue;
                                }
                                else
                                {
                                    break;
                                }
                            }
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Hatalı Seçim\n");
                            continue;
                        }
                    } // HAL
                    while (true)
                    {
                        Console.Clear();
                        Console.WriteLine("Manava Hoşgeldiniz");
                        Console.WriteLine("Meyve Almak İçin M, Sebze Almak İçin S Yazın.");
                        string meyveSebzeSecim2 = Console.ReadLine().ToLower();
                        if (meyveSebzeSecim2 == "m")
                        {
                            for (int i = 0; i < sepet.Count; i++)
                            {
                                if (meyveler.Contains(sepet[i]))
                                {
                                    Console.WriteLine("Ürün: " + sepet[i] + " Stok: " + sepetKilo[i] + " kg");
                                }
                                else
                                {
                                    continue;
                                }
                            }
                            Console.WriteLine("Almak İstediğiniz Ürünü Yazın");
                            string alUrunManav = Console.ReadLine().ToLower();
                            if (sepet.Contains(alUrunManav))
                            {
                                Console.WriteLine("Kaç Kilo Alacağınızı Yazın");
                                int alKilo = Convert.ToInt32(Console.ReadLine());
                                int index = sepet.IndexOf(alUrunManav);
                                if ((int)sepetKilo[index] >= alKilo)
                                {
                                    Console.WriteLine("Ürün Sepetinize Eklendi");
                                    musteriSepet.Add(alUrunManav);
                                    musteriSepetKilo.Add(alKilo);
                                    int urunAzalt = (int)sepetKilo[index];
                                    urunAzalt -= alKilo;
                                    sepetKilo[index] = urunAzalt;
                                    Console.WriteLine("Başka Bir İsteğiniz Var mı ? (E/H)");
                                    string arzu = Console.ReadLine().ToLower();
                                    if (arzu == "e")
                                    {
                                        continue;
                                    }
                                    else
                                    {
                                        break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Stokta Yeterli Ürün Yok");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Yanlış Ürün Seçimi");
                            }
                        }
                        else if (meyveSebzeSecim2 == "s")
                        {
                            for (int i = 0; i < sepet.Count; i++)
                            {
                                if (sebzeler.Contains(sepet[i]))
                                {
                                    Console.WriteLine("Ürün: " + sepet[i] + " Stok: " + sepetKilo[i] + " kg");
                                }
                                else
                                {
                                    continue;
                                }
                            }
                            Console.WriteLine("Almak İstediğiniz Ürünü Yazın");
                            string alUrunManav = Console.ReadLine().ToLower();
                            if (sepet.Contains(alUrunManav))
                            {
                                Console.WriteLine("Kaç Kilo Alacağınızı Yazın");
                                int alKilo = Convert.ToInt32(Console.ReadLine());
                                int index = sepet.IndexOf(alUrunManav);
                                if ((int)sepetKilo[index] >= alKilo)
                                {
                                    Console.WriteLine("Ürün Sepetinize Eklendi");
                                    musteriSepet.Add(alUrunManav);
                                    musteriSepetKilo.Add(alKilo);
                                    int urunAzalt = (int)sepetKilo[index];
                                    urunAzalt -= alKilo;
                                    sepetKilo[index] = urunAzalt;
                                    Console.WriteLine("Başka Bir İsteğiniz Var mı ? (E/H)");
                                    string arzu = Console.ReadLine().ToLower();
                                    if (arzu == "e")
                                    {
                                        continue;
                                    }
                                    else
                                    {
                                        break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Stokta Yeterli Ürün Yok");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Yanlış Ürün Seçimi");
                            }
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Yanlış Seçim");
                            continue;
                        }
                    }
                }//MANAV

                MusteriYazdir(musteriSepet, musteriSepetKilo);
            }  // MÜŞTERİ
        }
        static void MusteriYazdir(ArrayList musteriSepet, ArrayList musteriSepetKilo)
        {
            Console.Clear();
            for (int i = 0; i < musteriSepet.Count; i++)
            {
                Console.WriteLine("Ürün: " + musteriSepet[i] + " Kilo: " + musteriSepetKilo[i]);
            }
        }
    }
}
