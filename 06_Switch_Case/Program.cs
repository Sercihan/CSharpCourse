namespace _06_Switch_Case
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Dörtislem
            //Console.WriteLine("Birinci Sayı");
            //int s1 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("İkinci Sayı");
            //int s2 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("İşlem Seçin: +,-,*,/");
            //string i = Console.ReadLine();

            //switch (i)
            //{
            //    case "+":
            //        Console.WriteLine(s1 + s2);
            //        break;
            //    case "-":
            //        Console.WriteLine(s1 - s2);
            //        break;
            //    case "*":
            //        Console.WriteLine(s1 * s2);
            //        break;
            //    case "/":
            //        Console.WriteLine(s1 / s2);
            //        break;
            //    default:
            //        Console.WriteLine("Hatalı Giriş");
            //        break;
            //}
            #endregion

            #region Emekli

            Console.WriteLine("Cinsiyetiniz: erkek yada kadın");
            string c = Console.ReadLine().ToLower();

            Console.WriteLine("Yaşınız");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Maaş");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Çalıştığınız Gün");
            int g = Convert.ToInt32(Console.ReadLine());

            switch (c)
            {
                case "erkek":
                    if (y >= 60)
                    {
                        Console.WriteLine("Emekli Oldunuz. İkramiyeniz: " + (m * 10));
                    }
                    else
                    {
                        if (g >= 6000)
                        {
                            Console.WriteLine("Emekli Oldunuz. İkramiyeniz: " + (m * 11));
                        }
                        else
                        {
                            Console.WriteLine("Emekli Olamadınız");
                        }
                    }
                    break;

                case "kadın":
                    if (y >= 58)
                    {
                        Console.WriteLine("Emekli Oldunuz. İkramiyeniz: " + (m * 10));
                    }
                    else
                    {
                        if (g >= 5600)
                        {
                            Console.WriteLine("Emekli Oldunuz. İkramiyeniz: " + (m * 11));
                        }
                        else
                        {
                            Console.WriteLine("Emekli Olamadınız");
                        }
                    }

                    break;

                default:
                    Console.WriteLine("Hatalı Giriş");
                    break;
            }
            #endregion

            //Console.WriteLine("Bir sayı giriniz:");
            //int sayi = Convert.ToInt32(Console.ReadLine());

            //if (sayi == 1)
            //{
            //    Console.WriteLine("Sayı 1'dir");
            //}

            //if (sayi == 1)
            //{
            //    Console.WriteLine("Sayı 1'dir.");
            //}
            //else if (sayi == 2)
            //{
            //    Console.WriteLine("Sayı 2'dir");
            //}
            //else if (sayi == 3)
            //{
            //    Console.WriteLine("Sayı 3'dir");
            //}
            //else
            //    Console.WriteLine("Sayı 3'den büyüktür");


            //switch (sayi)
            //{
            //    case 1:
            //        Console.WriteLine("sayı 1");
            //        break;

            //    case 2:
            //        Console.WriteLine("sayı 2");
            //        break;
            //    case 3:
            //        Console.WriteLine("sayı 1");
            //        break;

            //    default:
            //        Console.WriteLine("Sayı 3'den büyük");
            //        break;
            //}

            #region Klavyeden iki sayı, bir işlem(+,-,*,/) girilecek. Sayılar girilen işleme göre sonucu ekrana yazdıran switch case.

            //Console.WriteLine("1.sayı");
            //int s1 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("2.sayı");
            //int s2 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("İşlem:+,-,*,/");
            //string islem = Console.ReadLine();

            //switch (islem)
            //{
            //    case "+":
            //        Console.WriteLine(s1+s2);
            //        break;

            //    case "-":
            //        Console.WriteLine(s1 - s2);
            //        break;

            //    case "*":
            //        Console.WriteLine(s1 * s2);
            //        break;

            //    case "/":
            //        Console.WriteLine(s1 / s2);
            //        break;

            //    default:
            //        Console.WriteLine("Hatalı işlem girişi");
            //        break;
            //}


            #endregion

            /*
                kullanıcıdan alınan cinsiyet bilgisine göre
             ==>ERKEK ise
                yaşı 60 ve üstü ise maaşının 10 katı kadar ikramiye alaral emekli edilecek, yaş 60'ın altında ise çalıştığı gün sayısına göre eğer 6000 ve üstü ise maaşının 11 katı kadar ikramiye alarak emekli edilecek,    6000 altında ise emekli edilmeyecek bilgisi kullanıcıya gösterilecek
                ==> KADIN ise   
                 yaşı 58 ve üstü ise maaşının 10 katı kadar ikramiye alarak emekli edilecek, yaş 58'ın altında ise çalıştığı gün sayısına göre eğer 5600 ve üstü ise maaşının 11 katı kadar ikramiye alarak emekli edilecek, 5600 altında ise emekli edilmeyecek bilgisi kullanıcıya gösterilecek
                ==> cinsiyet bilgisi switch-case ile sorgulanacak
             */

            Console.WriteLine("Cinsiyetiniz(E/K):");
            string cinsiyet = Console.ReadLine().ToUpper();// Bütün karakterler BÜYÜK harfe dönüşür.
                                                           //string cinsiyet = Console.ReadLine().ToLower(); // Bütün karakterler küçük harfe dönüşür.

            Console.WriteLine("Yaş:");
            int yas = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Maaş:");
            double maas = Convert.ToDouble(Console.ReadLine());


            if (cinsiyet == "E")
            {
                if (yas >= 60)
                {
                    Console.WriteLine("Emekli ikramiyesi:" + (maas * 10));
                }
                else
                {
                    Console.WriteLine("Prim Gün Sayısı:");
                    int prim = Convert.ToInt32(Console.ReadLine());

                    if (prim >= 6000)
                    {
                        Console.WriteLine("Emekli ikramiyesi:" + (maas * 11));
                    }
                    else
                    {
                        Console.WriteLine("Emeklilik hayal Çalışmaya Devam...");
                    }
                }
            }
            else if (cinsiyet == "K")
            {
                if (yas >= 45)
                {
                    Console.WriteLine("Emekli ikramiyesi:" + (maas * 10));
                }
                else
                {
                    Console.WriteLine("Prim Gün Sayısı:");
                    int prim = Convert.ToInt32(Console.ReadLine());

                    if (prim >= 4500)
                    {
                        Console.WriteLine("Emekli ikramiyesi:" + (maas * 11));
                    }
                    else
                    {
                        Console.WriteLine("Emeklilik hayal Çalışmaya Devam...");
                    }
                }
            }
            else
            {
                Console.WriteLine("Hatalı Cinsiyet Bilgisi!!");
            }

        }
    }
}
