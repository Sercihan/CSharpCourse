namespace _12_Methods_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ornek1

            //hesapla();

            #endregion
            #region ornek2

            //urunAlkdvUygula();

            #endregion
            #region ornek3

            //kampanya();

            #endregion
            #region ornek4

            //diziAyristir(diziOlustur());

            #endregion
            #region ornek5

            //Console.WriteLine(FarkBol(5, 3));
            //Console.WriteLine(FarkBol(8.8, 3.2));

            #endregion
            #region kurs

            /* *********** METOTLAR ************

            Belirli bir işlemi bir başlık altında tanımlayarak, ihtiyaç duyulduğunda tanımlanan başlık ile çağırıp kullandığımız yazılım yapılarıdır.
           Metotlar sayesinde tanımlı işlemi ne zaman istersek metot ismini yazarak çağırabilir ve işlemi yapmasını sağlarız.
           Clean Code yazmak için en önemli yapılardandır. Kodlamanın okunabilirliğini muazzam arttırır.

           Metotlaarı () işaretleri tanımlar.  
           Metotlar iç içe tanımlanmazlar. SOLID prensipleri =>  Single

           Metotlar çağrılmadıkları sürece çalışmazlar.

           Metotlar 2'ye ayrılır.
               * Değer Döndürmeyen Metotlar (void)
                   *parametreli,parametresiz
               * Değer Döndüren Metotlar (return)
                   *parametreli,parametresiz    


           ****** DEGER DONDURMEYEN METOTLAR *******

           *** METOT TANIMLAMA

           static void MetotAd(optional params)
           {
               //Metot işlem kodları
           }

           *** METOT KULLANIMI

           MetotAd(params)

            */

            #region Tanım
            //Console.WriteLine("---------");
            //Console.WriteLine("---------");
            //Console.WriteLine("---------");
            //Console.WriteLine("---------");

            ////Toplama();
            ////Toplama();
            ////Toplama();
            ////Toplama();



            //Console.WriteLine("1.Sayı:");
            //int s1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("2.Sayı:");
            //int s2 = Convert.ToInt32(Console.ReadLine());

            //ToplamaParametreli(s1, s2);
            #endregion

            #region 1 Örnek Kullanıcıdan 2 sayı bir işlem alınız ve alınan sayılara istenilen işlemi uygulayarak ekran yazdıran metot
            //#region Buse
            //Console.WriteLine("1.sayıyı giriniz");
            //int sayi1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("2.sayıyı giriniz");
            //int sayi2 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Toplama-1\nÇıkarma-2\nÇarpma-3\nBölme-4");
            //int secim = Convert.ToInt32(Console.ReadLine());

            //if (secim == 1)
            //{
            //    Toplama(sayi1, sayi2);
            //}
            //else if (secim == 2)
            //{
            //    Cikarma(sayi1, sayi2);
            //}
            //else if (secim == 3)
            //{
            //    Carpma(sayi1, sayi2);
            //}
            //else if (secim == 4)
            //{
            //    Bolme(sayi1, sayi2);
            //}
            //else
            //{
            //    Console.WriteLine("Hatalı seçim");
            //}
            //#endregion




            #endregion

            #endregion

        }
        #region ornek1 metot

        static void hesapla()
        {
            Console.WriteLine("ilk Sayıyı Girin");
            double s1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("ikinci Sayıyı Girin");
            double s2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Yapmak İstediğiniz İşlemi Seçin (+ - * /)");
            string islem = Console.ReadLine();

            if (islem == "+")
            {
                Console.WriteLine("Toplamanın Sonucu: " + (s1 + s2));
            }
            else if (islem == "-")
            {
                Console.WriteLine("Çıkarmanın Sonucu: " + (s1 - s2));
            }
            else if (islem == "*")
            {
                Console.WriteLine("Çarpmanın Sonucu: " + (s1 * s2));
            }
            else if (islem == "/")
            {
                if (s2 == 0)
                {
                    Console.WriteLine("Sayı 0 a Bölünemez\n");
                }
                else
                {
                    Console.WriteLine("Bölmenin Sonucu: " + (s1 / s2));
                }
            }
            else
            {
                Console.WriteLine("Hatalı İşlem Seçimi");
            }
        }

        #endregion
        #region ornek2 metot
        static void urunAlkdvUygula()
        {
            Console.WriteLine("Ürünün Fiyatını Girin");
            double fiyat = Convert.ToDouble(Console.ReadLine());
            KDV.kdvUygula(fiyat);
        }

        #endregion
        #region ornek3 metot

        static void kampanya()
        {
            Console.WriteLine("Birinci Ürünün Fiyatını Girin");
            double u1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("İkinci Ürünün Fiyatını Girin");
            double u2 = Convert.ToDouble(Console.ReadLine());
            if (u1 >= u2)
            {
                u1 *= 0.7;
            }
            else
            {
                u2 *= 0.7;
            }
            ucuncuUrun(u1, u2);
        }
        static void ucuncuUrun(double u1, double u2)
        {
            Console.WriteLine("3. Ürün Almak İstiyor Musunuz ? (E/H)");
            string u3Secim = Console.ReadLine().ToLower();
            if (u3Secim == "e")
            {
                Console.WriteLine("Ürün Fiyatı Girin");
                double u3 = (Convert.ToDouble(Console.ReadLine()) / 2);
                Console.WriteLine("Ödemeniz Gereken Tutar = " + (u1 + u2 + u3));
            }
            else
            {
                Console.WriteLine("Ödemeniz Gereken Tutar = " + (u1 + u2));
            }
        }

        #endregion
        #region ornek4 metot
        static int[] diziOlustur()
        {
            Random r = new Random();
            int[] dizi = new int[100];
            for (int i = 0; i < 100; i++)
            {
                dizi[i] = r.Next(1, 100);
            }
            return dizi;
        }
        static void diziAyristir(int[] dizi)
        {
            int[] diziTek = new int[dizi.Length];
            int[] diziCift = new int[dizi.Length];
            for (int i = 0; i < dizi.Length; i++)
            {
                if (dizi[i] % 2 == 0)
                {
                    diziCift[i] = i;
                }
                else
                {
                    diziTek[i] = i;
                }
            }

            Console.WriteLine("Tekli Dizi: ");
            foreach (int item in diziTek)
            {
                if (item == 0)
                {
                    continue;
                }
                else
                {
                    Console.Write(item + " ");
                }
            }
            Console.WriteLine();
            Console.WriteLine("Çift Dizi: ");
            foreach (int item in diziCift)
            {
                if (item == 0)
                {
                    continue;
                }
                else
                {
                    Console.Write(item + " ");
                }
            }
        }


        #endregion
        #region ornek5 metot
        static int FarkBol(int s1, int s2)
        {
            int sonuc = s1 - s2;
            return sonuc;
        }
        static double FarkBol(double s1, double s2)
        {
            double sonuc = s1 / s2;
            return sonuc;
        }


        #endregion
        #region Tanım
        //Parametresiz Metot
        //static void Toplama()
        //{
        //    Console.WriteLine("1.Sayı:");
        //    int s1 = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("2.Sayı:");
        //    int s2 = Convert.ToInt32(Console.ReadLine());

        //    Console.WriteLine("Toplam:" + (s1 + s2));
        //}

        //Parametreli Metot
        /// <summary>
        /// Bu verilen 2 int değeri toplar
        /// </summary>
        /// <param name="sayi1">toplanacak 1.sayı</param>
        /// <param name="sayi2">toplanacak 2.sayı</param>

        //static void ToplamaParametreli(int sayi1, int sayi2)
        //{
        //    Console.WriteLine("Toplam:" + (sayi1 + sayi2));
        //}
        #endregion
        #region Örnek
        #region  Buse
        //static void Toplama(int sayi1, int sayi2)
        //{
        //    Console.WriteLine("Toplam:" + (sayi1 + sayi2));
        //}
        //static void Cikarma(int sayi1, int sayi2)
        //{
        //    Console.WriteLine("Fark:" + (sayi1 - sayi2));
        //}
        //static void Carpma(int sayi1, int sayi2)
        //{
        //    Console.WriteLine("Carpim:" + (sayi1 * sayi2));
        //}
        //static void Bolme(int sayi1, int sayi2)
        //{
        //    Console.WriteLine("Bölüm:" + (sayi1 / sayi2));
        //}
        #endregion


        #endregion

    }
    internal class KDV
    {
        public static void kdvUygula(double s1)
        {
            s1 *= 1.20;
            Console.WriteLine("Ürünün KDVli Fiyatı: " + s1);
        }
    }
}
