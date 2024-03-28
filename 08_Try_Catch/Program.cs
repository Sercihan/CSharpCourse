using System.Security.Cryptography;

namespace _08_Try_Catch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ornek1
            //int s1;
            //int s2;

            //while (true)
            //{
            //    try
            //    {
            //        Console.WriteLine("1.Sayıyı Giriniz");
            //        s1 = Convert.ToInt32(Console.ReadLine());
            //        break;
            //    }
            //    catch (Exception e)
            //    {
            //        Console.WriteLine(e);
            //    }
            //}
            //while (true)
            //{
            //    try
            //    {
            //        Console.WriteLine("2.Sayıyı Giriniz");
            //        s2 = Convert.ToInt32(Console.ReadLine());
            //        break;
            //    }
            //    catch (Exception e)
            //    {
            //        Console.WriteLine(e);
            //    }
            //}
            //Console.WriteLine("Toplam: "+(s1+s2));

            #endregion

            //while (true)
            //{
            //    try
            //    {
            //        Console.WriteLine("Sayı gir:");
            //        int sayi = Convert.ToInt32(Console.ReadLine());

            //        Console.WriteLine(sayi + 5);

            //        break;
            //    }
            //    catch (Exception)
            //    {
            //        Console.WriteLine("Sayıyı lütfen RAKAM ile giriniz...");
            //    }

            //}

            #region Exception Type

            //try
            //{
            //    Console.WriteLine("Sayı gir:");
            //    int sayi = Convert.ToInt32(Console.ReadLine());

            //    int sonuc = sayi / 0;
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("Sayıyı lütfen RAKAM ile giriniz...");
            //}
            //catch (DivideByZeroException)
            //{
            //    Console.WriteLine("0 a bölme hatası");
            //}

            //catch (Exception)
            //{
            //    Console.WriteLine("Bilinmeyen bir hata oluştu");
            //}

            #endregion

            //try
            //{
            //    Console.WriteLine("Sayı gir:");
            //    int sayi = Convert.ToInt32(Console.ReadLine());
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //    Console.WriteLine(e);
            //}

            #region Kullanıcıdan iki sayı alınacak ve toplamı yazdırılacak.
            // Sayı alma işlemi try-catch ile hatalardan arındırılacak.
            // Diyelim ki 1.sayı doğru 2.sayı hatalı tekrar 1.sayı istenmesin

            //int sayi1;
            //int sayi2;

            //while (true)
            //{
            //    try
            //    {
            //        Console.WriteLine("1.sayı:");
            //        sayi1 = Convert.ToInt32(Console.ReadLine());   
            //        break;
            //    }
            //    catch (Exception)
            //    {
            //        Console.WriteLine("Sayı girişi hatalı!");
            //    }
            //}

            //while (true)
            //{
            //    try
            //    {
            //        Console.WriteLine("2.sayı:");
            //        sayi2 = Convert.ToInt32(Console.ReadLine());
            //        //Console.WriteLine(sayi2 + sayi1);

            //        break;
            //    }
            //    catch (Exception)
            //    {
            //        Console.WriteLine("Sayı girişi hatalı!");
            //    }
            //}

            //Console.WriteLine(sayi2 + sayi1);

            #endregion
        }
    }
}
