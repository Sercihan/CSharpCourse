namespace _07_DoWhile_Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region TANIM
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
            //do
            //{
            //    Console.WriteLine(i);
            //    i++;
            //} while (i<10);

            #endregion

            #region Kullanıcı 0 değerini girene kadar girilen bütün değerleri toplayarak ekrana yazdırınız.


            //int toplam = 0;
            //int sayi;
            //do
            //{

            //    Console.WriteLine("Toplanacak sayı:");
            //    sayi = Convert.ToInt32(Console.ReadLine());

            //    toplam += sayi;

            //} while (sayi!=0);

            //Console.WriteLine("Toplam:"+toplam);
            #endregion

            #region Diğer Sorular

            //kullanıcıdan girilen değerlerin toplamı doğum yılınızı geçene kadar toplayıp hesaplayınız
            //Console.WriteLine("Doğum tarihinizi giriniz");
            //DateTime dtarihi = Convert.ToDateTime(Console.ReadLine());
            //Console.WriteLine(dtarihi);
            //int yil = dtarihi.Year;
            //Console.WriteLine(yil);
            //Console.ReadKey();
            //int ay = dtarihi.Month;
            //int gun = dtarihi.Day;
            //Console.WriteLine(yil);
            //Console.WriteLine(ay);
            //Console.WriteLine(gun);

            //int toplam = 0, adet = 0;
            //do
            //{
            //    try
            //    {
            //        Console.WriteLine("Bir sayı giriniz");
            //        int s1 = Convert.ToInt32(Console.ReadLine());
            //        toplam = toplam + s1;
            //        adet++;//adet değerini alta almamızın nedeni yanlış değer girildiğinde s1 değişkeninde hata verecektir o hata alanında adet değerini artırmak işlem sonucunu değiştirir bu değiştirme hatalı bir sonuç olacaktır
            //    }
            //    catch (Exception)
            //    {
            //        Console.WriteLine(adet + 1 + ".sayısında hatalı giriş yaptınız,tekrar deneyin");
            //    }
            //} while (yil >= toplam);

            //Console.WriteLine("Girilen {0} adet  sayının toplamı:{1}", adet, toplam);
            //Console.WriteLine("Bitti");






            //kullıcıdan alınacak 4 adet sayının toplamlarını hesaplayınız
            //kullanıcı sayı yerine herhangi bir değer girerse kullanıcıyı yanlış değer girdiğini bilgilendiriniz
            //try
            //{
            //int topla = 0, adet = 0, sayi = 0;
            //do
            //{
            //    try
            //    {

            //        Console.WriteLine(adet + 1 + ".sayıyı giriniz");
            //        sayi = Convert.ToInt32(Console.ReadLine());
            //        topla = topla + sayi;
            //        adet++;
            //        //Console.WriteLine("Girilen {0} adet sayının toplamı:{1}",adet,topla);

            //    }
            //    catch (Exception)
            //    {
            //        Console.WriteLine("Hata oluştu");
            //    }
            //} while (adet < 4);

            //Console.WriteLine("Girilen {0} adet sayının toplamı:{1}", adet, topla);
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Hata");
            //}





            //kullanıcıdan alınacak ürün sayısına göre her bir ürünün fiyatını bir bir isteyip kullanıcııya fiyatlarının toplamlarını gösteriniz
            //int u_sayi = 0;
            ////do
            ////{
            //while (true)
            //{
            //    try
            //    {
            //        Console.WriteLine("Ürün sayısını giriniz");
            //        u_sayi = Convert.ToInt32(Console.ReadLine());
            //        if (u_sayi > 0)
            //        {
            //            break;
            //        }
            //    }
            //    catch (Exception)
            //    {
            //        Console.WriteLine("Ürün sayısı için hatalı giriş yaptınız");
            //    }
            //}
            //} while (true);
            //double toplam = 0, sayac = 0;
            //do
            //{
            //    try
            //    {
            //        Console.WriteLine(sayac + 1 + ".ürünün fiyatını giriniz");
            //        double fiyat = Convert.ToDouble(Console.ReadLine());
            //        toplam = toplam + fiyat;
            //        sayac++;
            //        u_sayi--;
            //    }
            //    catch (Exception)
            //    {
            //        Console.WriteLine("Hata Oluştu");
            //    }
            //} while (u_sayi > 0);
            //Console.WriteLine("Girilen {0} adet ürünün fiyatları toplamı:{1}", sayac, toplam);

            //Console.WriteLine("***");





            //kullanıcıdan istenecek sayılar arasında tek sayı girişi olana kadar girilen sayıların toplamını ve sayısını hesaplayan do while 
            //int toplam = 0, adet = 0;
            //do
            //{
            //    try
            //    {
            //        Console.WriteLine("Sayı giriniz");
            //        int sayi = Convert.ToInt32(Console.ReadLine());
            //        if (sayi % 2 == 1)
            //        {
            //            break;
            //        }
            //        adet++;
            //        toplam = toplam + sayi;
            //    }
            //    catch (Exception)
            //    {
            //        Console.WriteLine("\tHata oluştu");
            //    }
            //} while (true);

            //if (adet == 0)
            //{
            //    Console.WriteLine("ilk değeri tek girdiniz toplam bir değer yok");
            //}
            //else if (adet == 1)
            //{
            //    Console.WriteLine("1 adet sayı girdiniz ve değeri:" + toplam);
            //}
            //else
            //{
            //    Console.WriteLine("Girilen {0} adet çift sayının toplamı:{1}", adet, toplam);
            //}





            //bilgisayarın rastgele ürettiği bir sayı sisteminde rastgele sayı değeri 30 olduğunda kullanıcıya kaç adet sayıdan sonra 30 değerinin geldiğini hesaplayınız
            //iki basamaklı sayılar arasında seçim yaptırınız
            //Random r = new Random();//örnekleme=> instance


            //int sayac = 0;
            //do
            //{
            //    int a = r.Next(10, 99);
            //    sayac++;
            //    Console.WriteLine(sayac + "-" + a);
            //    if (a == 30)
            //    {
            //        break;
            //    }
            //} while (true);

            //int b = 0;
            //int x = 0;
            //do
            //{
            //    b = r.Next(10, 99);
            //    x++;
            //    //Console.WriteLine(x+"-"+b);
            //} while (b != 30);
            //Console.WriteLine(x + "-" + b);






            //sistemin rastgele ürettiği sayıyı kullanıcının bulması için bir kod bloğu yazarak, eğer kullanıcının girdiği sayı üretilen sayıdan büyük ise kullanıcının büyük bir sayı girdiğini, küçük ise küçük girdiğini uyarınız ve kullanıcı 3 basamaklı bu tahmin oyununda 5 haka sahip olsun
            //Random r = new Random();
            //int gizlisayi = r.Next(10, 99);
            //uint tahmin = 0, hak = 0;
            //do
            //{
            //    try
            //    {
            //        Console.WriteLine("Tahmin sayısı giriniz==>" + gizlisayi);
            //        tahmin = Convert.ToUInt32(Console.ReadLine());
            //        hak++;
            //        if (hak == 5)
            //        {
            //            break;
            //        }
            //        if (tahmin > gizlisayi)
            //        {
            //            Console.WriteLine("Tahmini küçültün");
            //        }
            //        if (tahmin < gizlisayi)
            //        {
            //            Console.WriteLine("Tahmini büyütün");
            //        }
            //    }
            //    catch (Exception)
            //    {
            //        Console.WriteLine("Hatalı giriş yaptınız");
            //    }

            //} while (tahmin != gizlisayi && hak <= 5);

            //if (tahmin == gizlisayi)
            //{
            //    Console.WriteLine("\tBİLDİNİZ");
            //}
            //else
            //{
            //    Console.WriteLine("Hakkınız bittiğinden dolayı işlem sonlandırıldı");
            //}
            //Console.WriteLine("***");

            #endregion
        }
    }
}
