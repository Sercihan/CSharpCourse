using System.Security.Cryptography.X509Certificates;

namespace _05_If_Elseif_Else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ornek1
            //Console.WriteLine("Bir Sayı Giriniz");
            //int sayi = Convert.ToInt32(Console.ReadLine());

            //if (sayi == 1)
            //{
            //    Console.WriteLine("Pazartesi");
            //}
            //else if (sayi == 2)
            //{
            //    Console.WriteLine("Salı");
            //}
            //else if (sayi == 3)
            //{
            //    Console.WriteLine("Çarşamba");
            //}
            //else if (sayi == 4)
            //{
            //    Console.WriteLine("Perşembe");
            //}
            //else if (sayi == 5)
            //{
            //    Console.WriteLine("Cuma");
            //}
            //else if (sayi == 6)
            //{
            //    Console.WriteLine("Cumartesi");
            //}
            //else if (sayi == 7)
            //{
            //    Console.WriteLine("Pazar");
            //}
            //else
            //{
            //    Console.WriteLine("Hatalı Giriş");
            //}
            #endregion
            #region ornek2

            //Console.WriteLine("Bir Sayı Giriniz");
            //int sayi = Convert.ToInt32(Console.ReadLine());

            //if(sayi == 0)
            //{
            //    Console.WriteLine("Sayı Sıfırdır");
            //}
            //else if (sayi < 0)
            //{
            //    Console.WriteLine("Negatif");
            //}
            //else
            //{
            //    Console.WriteLine("Pozitif");
            //}

            #endregion
            #region ornek3

            //Console.WriteLine("İlk Ürün Fiyatı");
            //int urun1 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("İkinci Ürün Fiyatı");
            //int urun2 = Convert.ToInt32(Console.ReadLine());

            //if((urun1 + urun2) < 2500)
            //{
            //    Console.WriteLine("Tutar = "+(urun1+urun2));
            //}
            //else
            //{
            //    if(urun1 < urun2)
            //    {
            //        urun1 = (urun1 * 3) / 4;
            //        Console.WriteLine("Tutar = "+(urun1+urun2));
            //    }
            //    else
            //    {
            //        urun2 = (urun2 * 3) / 4;
            //        Console.WriteLine("Tutar = " + (urun1 + urun2));
            //    }
            //}

            #endregion
            #region ornek4

            //Console.WriteLine("Geliriniz");
            //double gelir = Convert.ToDouble(Console.ReadLine());
            //double netGelir;

            //if (gelir > 40000)
            //{
            //    netGelir = gelir * 0.88;
            //    Console.WriteLine("Net Geliriniz: "+netGelir);
            //}
            //else
            //{
            //    netGelir = gelir * 0.91;
            //    Console.WriteLine("Net Geliriniz: " + netGelir);
            //}

            #endregion
            #region ornek5

            Console.WriteLine("Harcadığınız Elektrik");
            double elektrik = Convert.ToDouble(Console.ReadLine());

            if (elektrik >= 0 && elektrik <= 100)
            {
                Console.WriteLine("Tutar = " + (0.35 * elektrik));
            }
            else if (elektrik > 100 && elektrik <= 250)
            {
                Console.WriteLine("Tutar = " + (0.38 * elektrik));
            }
            else if (elektrik > 250 && elektrik <= 400)
            {
                Console.WriteLine("Tutar = " + (0.41 * elektrik));
            }
            else if (elektrik > 400 && elektrik <= 600)
            {
                Console.WriteLine("Tutar = " + (0.42 * elektrik));
            }
            else if (elektrik > 600)
            {
                Console.WriteLine("Tutar = " + ((0.43 * elektrik) - 120));
            }
            else
            {
                Console.WriteLine("Hatalı Giriş");
            }

        #endregion

        #region Sayi 5 den küçük ise Ekrana Küçük değilse ise BÜYÜK yazılsın
        //int sayi = 10;

        //if (sayi < 5)
        //{
        //    Console.WriteLine("Küçük");
        //}
        //else
        //{
        //    Console.WriteLine("BÜYÜK");
        //}
        #endregion

        #region Verilen sayının  0-10 11-20 21-30 aralıklarından hangisinde olduğunu yazdırınız.
        //Console.WriteLine("Bir sayı giriniz:");
        //int sayi = Convert.ToInt32(Console.ReadLine());

        //if (sayi < 11)
        //{
        //    Console.WriteLine("0-10 aralığı");
        //}
        //else if (sayi > 10 && sayi < 21)
        //{
        //    Console.WriteLine("11-20 aralığı");
        //}

        //else if (sayi > 20 && sayi < 31)
        //{
        //    Console.WriteLine("21-30 aralığı");
        //}
        //else
        //{
        //    Console.WriteLine("Belirlenmemiş aralık");
        //}
        #endregion

        #region Kullanıcıdan haftanın kaçıncı gününde olduğunu sayıyal değer olarak alın
        //ve aloınan sayıya göre hafatanın gün adını yazdırınız.

        #region 1.Yol
        //Console.WriteLine("Haftanın kaçıncı günü?");
        //int gun = Convert.ToInt32(Console.ReadLine());

        //if (gun == 1)
        //{
        //    Console.WriteLine("Pazartesi");
        //}
        //else if (gun == 2)
        //{
        //    Console.WriteLine("Salı");
        //}
        //else if (gun == 3)
        //{
        //    Console.WriteLine("Çarşamba");
        //}
        //else if (gun == 4)
        //{
        //    Console.WriteLine("Perşembe");
        //}
        //else if (gun == 5)
        //{
        //    Console.WriteLine("Cuma");
        //}
        //else if (gun == 6)
        //{
        //    Console.WriteLine("Cumartesi");
        //}
        //else if (gun == 7)
        //{
        //    Console.WriteLine("Pazar");
        //}
        //else
        //{
        //    Console.WriteLine("Hatalı Gün Bilgisi!!");
        //}
        #endregion

        #region 2.Yol

        //Console.WriteLine("Haftanın kaçıncı günü?");
        //int gun = Convert.ToInt32(Console.ReadLine());

        //if (gun>7 || gun < 1)
        //{
        //    Console.WriteLine("Hatalı gün bilgisi!!");
        //}
        //else if(gun==1)
        //{
        //    Console.WriteLine("Pazartesi");
        //}
        //else if (gun == 2)
        //{
        //    Console.WriteLine("Salı");
        //}
        //else if (gun == 3)
        //{
        //    Console.WriteLine("Çarşamba");
        //}
        //else if (gun == 4)
        //{
        //    Console.WriteLine("Perşembe");
        //}
        //else if (gun == 5)
        //{
        //    Console.WriteLine("Cuma");
        //}
        //else if (gun == 6)
        //{
        //    Console.WriteLine("Cumartesi");
        //}
        //else
        //{
        //    Console.WriteLine("Pazar");
        //}


        #endregion
        #endregion

        #region kullanıcıdan bir sayı isteyelim negatif mi pozitif mi olduğunu bulalım
        //Console.WriteLine("klavyeden bir sayı giriniz");
        //int sayi = Convert.ToInt32(Console.ReadLine());

        //if (sayi > 0)
        //{
        //    Console.WriteLine("sayı pozitif");
        //}
        //else if (sayi == 0)
        //{
        //    Console.WriteLine("sayı sıfırdır.");
        //}
        //else
        //{
        //    Console.WriteLine("sayi negatif");
        //}



        #endregion

        #region Kullanıcıdan iki ürün fiyatı isteyin, ürün fiyat toplamları 2500 tl geçerse ucuz ürüne  %25 indirim uygulayınız

        #region BAYRAM
        //Console.WriteLine("lütfen 1. fiyatı giriniz:");
        //int fiyat1 = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("lütfen 2. fiyatı giriniz:");
        //int fiyat2 = Convert.ToInt32(Console.ReadLine());

        //int toplam = fiyat1 + fiyat2;

        //if (toplam > 2500)
        //{
        //    if (fiyat1 > fiyat2)
        //    {
        //        fiyat2 = fiyat2 - fiyat2 * 25 / 100;

        //        Console.WriteLine("fiyat 2'ye indirim uygulandı. Yeni Fiyat : ");
        //        Console.WriteLine(fiyat2);


        //    }

        //    else
        //    {
        //        fiyat1 = fiyat1 - fiyat1 * 25 / 100;
        //        Console.WriteLine("fiyat 1'e indirim uygulandı. Yeni Fiyat : ");
        //        Console.WriteLine(fiyat1);
        //    }

        //}
        //else

        //    Console.WriteLine("fiyatlar gayet makul :P ");

        #endregion

        //Console.WriteLine("lütfen 1. fiyatı giriniz:");
        //double fiyat1 = Convert.ToDouble(Console.ReadLine());
        //Console.WriteLine("lütfen 2. fiyatı giriniz:");
        //double fiyat2 = Convert.ToDouble(Console.ReadLine());

        ////int toplam = (int)(fiyat1 + fiyat2);

        ////if (toplam > 2500)
        //if ((fiyat1 + fiyat2) > 2500)
        //{
        //    if (fiyat1 > fiyat2)
        //    {
        //         fiyat2 = fiyat2 * 0.75;
        //    }
        //    else
        //    {
        //        fiyat1 = fiyat1 * 0.75;
        //    }                
        //}

        //Console.WriteLine("Ödeme:" + (fiyat1 + fiyat2));


        #endregion

        #region  Kullanıcıdan aylık gelirini isteyin. 
        // Aylık geliri 40000 üstünde ise %12 vergi kesilecek,
        // 40000 ve altında ise %9 vergi kesimi yapılarak 
        // kullanıcıya yeni gelirini bu hesaplamalar sonucunda gösteriniz

        #region Ali Eren

        //Console.WriteLine("Aylık gelirinizi yazınız?");
        //int aylikGelir = Convert.ToInt32(Console.ReadLine());

        //if (aylikGelir > 40000)
        //{
        //    double Vergi = aylikGelir * 0.12;
        //    Console.WriteLine("Ödemeniz gereken vergi: " + Vergi);
        //    double Kalan = aylikGelir - Vergi;
        //    Console.WriteLine("Kalan: " + Kalan);
        //}
        //else
        //{
        //    double Vergi = aylikGelir * 0.09;
        //    Console.WriteLine("Ödemeniz gereken vergi: " + Vergi);
        //    double Kalan = aylikGelir - Vergi;
        //    Console.WriteLine("Kalan: " + Kalan);
        //}
        #endregion


        //Console.WriteLine("Aylık Geliriniz:");
        //double gelir = Convert.ToDouble(Console.ReadLine());

        //if (gelir > 40000) 
        //{
        //    gelir = gelir * 0.88;
        //}
        //else
        //{
        //    gelir = gelir * 0.91;
        //}

        //Console.WriteLine("Geliriniz:"+gelir);

        #endregion

        #region Kullanıcıdan harcadığı elektrik değerini alarak 
        /* 
         0-100 harcamışsa 0.35 ile fiyatlandırılacak
         101-250=> 0.38 üzerinde hesaplandırılacak
         251-400=> 0.41 üzerinde 
         401-600=> 0.42
         600 üstü ise 120 tl indirim yapılacak ve fiyatlandırma 0.43 üzerinde verilecek
         */

        #region BAYRAM
        //Console.WriteLine("Lütfen Elektrik Tüketiminizi Giriniz:");
        //double Tuketim = Convert.ToDouble(Console.ReadLine());

        //double fiyat;

        //if (Tuketim <= 100)

        //{
        //    fiyat = Tuketim * 0.35;
        //}
        //else if (Tuketim >= 101 && Tuketim <= 250)
        //{
        //    fiyat = Tuketim * 0.35;

        //}

        //else if (Tuketim >= 251 && Tuketim <= 400)
        //{
        //    fiyat = Tuketim * 0.41;

        //}
        //else if (Tuketim >= 401 && Tuketim <= 600)
        //{
        //    fiyat = Tuketim * 0.42;
        //}
        //else
        //    fiyat = (Tuketim * 0.43) - 120;

        //Console.WriteLine("Ödenecek Tutar:" + fiyat);

        #endregion

        #region BUSE
        //Console.WriteLine("Lütfen harcadığınız elektrik değerini giriniz:");
        //double deger = Convert.ToDouble(Console.ReadLine());

        //if (deger > 0 && deger < 100)
        //{
        //    double fiyat = deger * 0.35;

        //    Console.WriteLine("Elektrik fiyatlandırmanız" + (fiyat));
        //}
        //else if (deger > 101 && deger < 250)
        //{
        //    double fiyat = deger * 0.38;

        //    Console.WriteLine("Elektrik fiyatlandırmanız" + (fiyat));
        //}
        //else if (deger > 251 && deger < 400)
        //{
        //    double fiyat = deger * 0.41;

        //    Console.WriteLine("Elektrik fiyatlandırmanız" + (fiyat));
        //}
        //else if (deger > 401 && deger < 600)
        //{
        //    double fiyat = deger * 0.42;

        //    Console.WriteLine("Elektrik fiyatlandırmanız" + (fiyat));
        //}
        //else if (deger > 600)
        //{
        //    double fiyat = deger * 0.43;
        //    Console.WriteLine("Elektrik fiyatlandırmanız" + (fiyat));
        //}
        #endregion




        #endregion

        #region  kullanıcıdan alınacak yaş değerine göre
        /*  
         0-3 arasında ise bebek
         4-10 arasında çocuk
         11-18 ergen
         19-28 genç
         29-35 orta yaç
         36-45 olgun
         46-55 emekli adayı
         56 ve üstü ise emekliliğin tadını çıkarın
         */
        //DESTPE:
        //    Console.WriteLine("yaş giriniz");
        //    byte yas = Convert.ToByte(Console.ReadLine());
        //    short yas = Convert.ToInt16(Console.ReadLine());

        //    string cevap;
        //    if (yas >= 0 && yas <= 3)
        //    {
        //        Console.WriteLine("Bebek:");
        //        cevap = "Bebek";
        //    }
        //    else if (yas <= 10)
        //    {
        //        Console.WriteLine("Çocuk");
        //    }
        //    else if (yas >= 11 && yas <= 18)
        //    else if (yas <= 18)
        //            {
        //                Console.WriteLine("Ergen");
        //            }
        //            else if (yas <= 28)
        //            {
        //                Console.WriteLine("Genç");
        //            }
        //            else if (yas <= 35)
        //            {
        //                Console.WriteLine("Orta Yaş");
        //            }
        //            else if (yas <= 45)
        //            {
        //                Console.WriteLine("Olgun");
        //            }
        //            else if (yas <= 55)
        //            {
        //                Console.WriteLine("Emekli Adayı");
        //            }
        //            else
        //            {
        //                Console.WriteLine("Tadını Çıkarın");
        //            }


        //    if (yas >= 56)
        //    {
        //        Console.WriteLine("Tadını Çıkarın");
        //    }
        //    else if (yas >= 46)
        //    {
        //        Console.WriteLine("Aday");
        //    }
        //    else if (yas >= 36)
        //    {
        //        Console.WriteLine("Olgun");
        //    }
        //    else if (yas >= 29)
        //    {
        //        Console.WriteLine("Orta yaş");
        //    }
        //    else if (yas >= 19)
        //    {
        //        Console.WriteLine("Genç");
        //    }
        //    else if (yas >= 11)
        //    {
        //        Console.WriteLine("Ergen");
        //    }
        //    else if (yas >= 4)
        //    {
        //        Console.WriteLine("Çocuk");
        //    }
        //    else if (yas >= 0)
        //    {
        //        Console.WriteLine("Bebek");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Hatalı giriş");
        //    }

        //    goto DESTPE;

        #endregion

        #region GO TO KOMUTU

        DON:
            Console.WriteLine("Haftanın kaçıncı günü?");
            int gun = Convert.ToInt32(Console.ReadLine());

            if (gun > 7 || gun < 1)
            {
                Console.WriteLine("Hatalı gün bilgisi!!");
                goto DON;
            }
            else if (gun == 1)
            {
                Console.WriteLine("Pazartesi");
            }
            else if (gun == 2)
            {
                Console.WriteLine("Salı");
            }
            else if (gun == 3)
            {
                Console.WriteLine("Çarşamba");
            }
            else if (gun == 4)
            {
                Console.WriteLine("Perşembe");
            }
            else if (gun == 5)
            {
                Console.WriteLine("Cuma");
            }
            else if (gun == 6)
            {
                Console.WriteLine("Cumartesi");
            }
            else
            {
                Console.WriteLine("Pazar");
            }

            #endregion

        }
    }
}
