

namespace _07_While_Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ornek1

            //int i = 200;
            //while(i >= 0)
            //{
            //    Console.WriteLine(i);
            //    i--;
            //}

            #endregion
            #region ornek2

            //int j = 200;
            //while (j>=0)
            //{
            //    if(j % 3 == 0)
            //    {
            //        Console.WriteLine(j);
            //        j--;
            //    }
            //    else
            //    {
            //        j--;
            //    }
            //}
            #endregion
            #region ornek3

            //int i = 1;
            //int toplam = 0;
            //while (i <= 200)
            //{
            //    if(i % 7 == 0)
            //    {
            //        toplam += i;
            //    }
            //    i++;
            //}
            //Console.WriteLine(toplam);

            #endregion
            #region ornek4

            //Console.WriteLine("Başlangıç Değeri");
            //int s1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Bitiş Değeri");
            //int s2 = Convert.ToInt32(Console.ReadLine());

            //int toplam = 1;

            //while(s1 <= s2)
            //{
            //    toplam *= s1;
            //    s1++;
            //}
            //Console.WriteLine(toplam);

            #endregion
            #region ornek5

            //Console.WriteLine("Kaç Ürün Aldınız?");
            //int urunSayisi = Convert.ToInt32(Console.ReadLine());
            //int sayac = 1;
            //int tutar = 0;

            //Console.WriteLine("Ürün Fiyatlarını Sırayla Giriniz");
            //while (sayac <= urunSayisi)
            //{
            //    tutar += Convert.ToInt32(Console.ReadLine());
            //    sayac++;
            //}
            //Console.WriteLine("Toplam Tutar: "+tutar);

            #endregion
            #region Random

            //int hak = 3;
            //while (hak > 0)
            //{
            //    Console.WriteLine("Kullanıcı Adınızı Giriniz");
            //    string id = Console.ReadLine();
            //    Console.WriteLine("Şifrenizi Giriniz");
            //    string pw = Console.ReadLine();
            //    if(id == "admin" && pw == "123")
            //    {
            //        Console.WriteLine("Başarıyla Giriş Yaptınız");
            //        break;
            //    }
            //    else
            //    {
            //        hak--;
            //        if (hak == 0)
            //        {
            //            Console.WriteLine("Başarısız Giriş. Tekrar Deneme Hakkınız Kalmadı");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Kullanıcı Adı veya Şifre Hatalı. Tekrar Deneyiniz.");
            //        }
            //    }
            //}

            #endregion
            #region ornek6

            //Random r = new Random();
            //int rastgeleSayi = r.Next(1, 20);
            //int hak = 5;
            //int tahmin = 0;
            //while (hak > 0)
            //{
            //    Console.WriteLine("Tahmin Giriniz");
            //    tahmin = Convert.ToInt32(Console.ReadLine());
            //    if (tahmin < rastgeleSayi)
            //    {
            //        Console.WriteLine("Tahminin Küçük, Sayınızı Yükseltin");
            //        hak--;
            //    }
            //    else if (tahmin > rastgeleSayi)
            //    {
            //        Console.WriteLine("Tahminin Büyük, Sayınızı Düşürün");
            //        hak--;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Tebrikler Bildiniz. Sayı: " + rastgeleSayi);
            //        break;
            //    }
            //}
            //if (hak == 0)
            //{
            //    Console.WriteLine("Tahmin Hakkınız Bitti");
            //}

            #endregion

            /* LOOPS => 
                * While
                * For
                * Do While
                * Foreach
             
            Belirli bir iş tanımlayan kod bloklarını tekrar tekrar yazmaktan bizi kurtartır.

             
             */

            // 1-10 arasındaki sayıları ekran yazdırınız

            //Console.WriteLine(1);
            //Console.WriteLine(2);
            //Console.WriteLine(3);
            //Console.WriteLine(4);
            //Console.WriteLine(5);
            //Console.WriteLine(6);
            //Console.WriteLine(7);
            //Console.WriteLine(8);
            //Console.WriteLine(9);
            //Console.WriteLine(10);

            //int i = 1;

            //while (i < 21)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}


            // *** BREAK : Okunduğu an kendi içinde bulunduğu döngüyü kırar. 
            // *** CONTİNUE: Okunduğu satırdan direk koşul satırına geri döner.


            #region 200 den başlayarak 0 a kadar olan ve 3'ün katı olan sayıları ekrana yazdırınız.

            //int i = 200;

            //while (i >= 0)
            //{
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i--;
            //}

            #endregion


            #region 1 ile 5 arasındaki sayıların toplamını ekrana yazdırınız

            //int i = 1;

            //int toplam = 0;

            //while (i < 6)
            //{
            //    toplam = toplam + i;
            //    i++;
            //}

            #endregion


            #region 0 den başlayarak 200 a kadar olan ve 7'ün katı olan sayıların toplamını yazdırınız.
            //int i = 0;
            //int toplam = 0;

            //while (i < 200)
            //{
            //    if (i % 7 == 0)
            //    {
            //        toplam = toplam + i;                  
            //    }
            //    i++;
            //}

            //Console.WriteLine(toplam);
            #endregion


            #region Kullanıcıdan alınan başlangıç ve bitiş değerleri arasındaki sayıların çarpımını ekrana yazdırınız.

            //Console.WriteLine("Lütfen bir baslangic değeri giriniz.");
            //int baslangic = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Lütfen bir bitis değeri giriniz.");
            //int bitis = Convert.ToInt32(Console.ReadLine());

            //if (baslangic > bitis)
            //{
            //    int a = baslangic;
            //    baslangic = bitis;
            //    bitis = a;
            //}

            //int carpim = 1;

            //while (baslangic < bitis)
            //{
            //    carpim = carpim * baslangic;
            //    baslangic++;
            //}
            //Console.WriteLine("Baslangıc ve bitiş değerleri arasındaki sayıların carpimi:"+(carpim));


            #endregion


            #region Müşteri mağazadan alışveriş yapıyor.
            // Müşteriye kaç ürün aldığını soralım.
            // Aldığı ürünlerin sırayla fiyatlarını girmesini isteyelim.
            // Girilen ürün fiyatlarını toplayarak ödeme miktarı müşteriye söyleyelim.

            #region BAYRAM

            //Console.WriteLine("Lütfen ürün miktarını giriniz:");
            //int miktar = Convert.ToInt32(Console.ReadLine());

            //double toplam = 0;

            //while (miktar > 0)
            //{
            //    Console.WriteLine("lütfen " + miktar + ". ürünün fiyatını giriniz:");
            //    double urunfiyati = Convert.ToDouble(Console.ReadLine());

            //    toplam += urunfiyati;

            //    miktar--;
            //}
            //Console.WriteLine("toplam tutar:"+toplam);


            #endregion

            #endregion


            #region RANDOM KÜTÜPHANESİ

            // Belirtilen aralıklarda Rastgele sayı üretir.
            // Başlangıç değeri dahil edilirken, bitiş değeri dahil edilmez.

            //Random r = new Random();

            //int sayi = r.Next();
            //int sayi2 = r.Next(100);
            //int sayi3 = r.Next(1, 5);

            //Console.WriteLine(sayi);
            //Console.WriteLine(sayi2);
            //Console.WriteLine(sayi3);


            //Console.WriteLine(r.Next(1,10));
            #endregion


            #region  Kullanıcıya 3 kez hak vererek kullanıcı adı ve şifre girişi yapalım
            //Kullanıcı adı admin olacak
            //Şifre 123 olacak

            //string kullaniciAdi = "admin";
            //string sifre = "123";

            //int hak = 3;

            //while (hak > 0)
            //{
            //    Console.WriteLine("Kullanıcı Adınız:");
            //    string username = Console.ReadLine();

            //    Console.WriteLine("Şifreniz");
            //    string password = Console.ReadLine();

            //    if(kullaniciAdi==username && sifre == password)
            //    {
            //        Console.WriteLine("Giriş Başarılı");
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Giriş Başarısız!");
            //        hak--;
            //    }

            //}

            //if (hak == 0)
            //{
            //    Console.WriteLine("Hakkınız Bitti");
            //}


            #endregion


            #region CONTINUE KOMUTU

            // 1'den 15'e kadar olan sayıları ekrana yazdırırken 7 sayısını atlayan bir döngü yazınız

            //int i = 1;

            //while (i < 16)
            //{
            //    if (i == 7)
            //    {
            //        i++;
            //        continue;
            //    }

            //    Console.WriteLine(i);
            //    i++;
            //}


            #endregion


            #region Bilgisayar 1-20 arasında bir sayıyı aklında tutsun. 
            //Kullanıcıya 5 hak vererek sayıyı tahmin etmesini isteyelim.
            //Her tahminde kullanıcıyı yönlendirerek tahmininizi büyültünüz veya küçültünüz diye mesajlar verelim.

            #region BAYRAM
            //Random r = new Random();

            //int sayi = r.Next(1, 20);
            //int hak = 5;

            //while (hak <= 5)

            //{
            //    Console.WriteLine("Tahmininiz: ");
            //    int tahmin = Convert.ToInt32(Console.ReadLine());
            //    if (sayi == tahmin)
            //    {
            //        Console.WriteLine("Doğru!!!!");
            //        break;

            //    }
            //    else
            //    {

            //        Console.WriteLine("Yanlış tahmin..");

            //        if (tahmin > sayi)
            //        {
            //            Console.WriteLine("Yukarı:)");

            //        }
            //        else
            //        {


            //            Console.WriteLine("Aşağı:)");

            //        }
            //        hak--;



            //        #endregion
            //    }
            //
            #endregion


            //Random r = new Random();
            //int rastgele = r.Next(1, 20);

            //Console.WriteLine(rastgele);

            //int hak = 5;

            //while (hak > 0)
            //{
            //    Console.WriteLine("Tahmininiz:");
            //    int tahmin = Convert.ToInt32(Console.ReadLine());

            //    if (tahmin == rastgele)
            //    {
            //        Console.WriteLine("TEBRİKLER");
            //        break;
            //    }
            //    else if(tahmin>rastgele)
            //    {
            //        Console.WriteLine("Tahmin küçült..");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Tahmin büyült..");
            //    }
            //    hak--;
            //}


            #endregion
        }
    }
}
