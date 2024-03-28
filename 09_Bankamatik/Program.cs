namespace _09_Bankamatik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bakiye = 2500;
            string sifre = "ab18";
            int hak = 3;
            int secim = -1;
            bool giris = false;
        DON:
            while (true)
            {
                Console.WriteLine("Şifrenizi Giriniz");
                string password = Console.ReadLine();
                if (hak > 1)
                {
                    if (password == sifre)
                    {
                        Console.WriteLine("Giriş Başarılı");
                        giris = true;
                        break;
                    }
                    else
                    {
                        hak--;
                    }
                }
                else
                {
                    break;
                }
            }
            while (giris)
            {
                try
                {
                    Console.WriteLine("Para Çekmek için    1");
                    Console.WriteLine("Para yatırmak için  2");
                    Console.WriteLine("Para Transferleri   3");
                    Console.WriteLine("Eğitim Ödemeleri    4");
                    Console.WriteLine("Ödemeler            5");
                    Console.WriteLine("Bilgi Güncelleme    6");
                    Console.WriteLine("Çıkış               0");
                    Console.WriteLine();
                    Console.WriteLine("HESAP BAKİYENİZ: " + bakiye + " TL");
                    secim = Convert.ToInt32(Console.ReadLine());

                    if (secim == 1)
                    {
                        Console.WriteLine("Çekeceğiniz Tutarı Giriniz");
                        int tutar = Convert.ToInt32(Console.ReadLine());
                        if (bakiye >= tutar)
                        {
                            bakiye -= tutar;
                            Console.WriteLine("İşleminiz Başarıyla Gerçekleştirildi Mevcut Bakiyeniz: " + bakiye);
                            Console.WriteLine("Ana Menüye Dönmek İçin 9");
                            Console.WriteLine("Çıkış İçin 0");
                            int menuSecimi = Convert.ToInt32(Console.ReadLine());
                            if (menuSecimi == 9)
                            {
                                continue;
                            }
                            else if (menuSecimi == 0)
                            {
                                Console.WriteLine("Çıkış Yapılıyor");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Hatalı Giriş");
                                continue;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Yetersiz Bakiye");
                            Console.WriteLine("Ana Menüye Dönmek İçin 9");
                            Console.WriteLine("Çıkış İçin 0");
                            int menuSecimi = Convert.ToInt32(Console.ReadLine());
                            if (menuSecimi == 9)
                            {
                                continue;
                            }
                            else if (menuSecimi == 0)
                            {
                                Console.WriteLine("Çıkış Yapılıyor");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Hatalı Giriş");
                                continue;
                            }
                        }

                    }
                    else if (secim == 2)
                    {
                        Console.WriteLine("Kredi Kartına Para Yatırmak İçin 1");
                        Console.WriteLine("Kendi Hesabınıza Para Yatırmak İçin 2");
                        int hesapSecimi = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Yatırmak İstediğiniz Miktarı Yazınız");
                        int hesapPara = Convert.ToInt32(Console.ReadLine());
                        if (hesapSecimi == 1)
                        {
                            if (bakiye >= hesapPara)
                            {
                                bakiye -= hesapPara;
                                Console.WriteLine("12 Haneli Kart Numaranızı Giriniz");
                                Console.ReadLine();
                                Console.WriteLine("Kredi Kartınıza " + hesapPara + " Kadar Eklendi " + "Mevcut Bakiyeniz: " + (bakiye));
                                Console.WriteLine("Ana Menüye Dönmek İçin 9");
                                Console.WriteLine("Çıkış İçin 0");
                                int menuSecimi = Convert.ToInt32(Console.ReadLine());
                                if (menuSecimi == 9)
                                {
                                    continue;
                                }
                                else if (menuSecimi == 0)
                                {
                                    Console.WriteLine("Çıkış Yapılıyor");
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Hatalı Giriş");
                                    continue;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Yetersiz Bakiye");
                                Console.WriteLine("Ana Menüye Dönmek İçin 9");
                                Console.WriteLine("Çıkış İçin 0");
                                int menuSecimi = Convert.ToInt32(Console.ReadLine());
                                if (menuSecimi == 9)
                                {
                                    continue;
                                }
                                else if (menuSecimi == 0)
                                {
                                    Console.WriteLine("Çıkış Yapılıyor");
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Hatalı Giriş");
                                    continue;
                                }
                            }
                        }
                        else if (hesapSecimi == 2)
                        {
                            bakiye += hesapPara;
                            Console.WriteLine("Hesabınıza " + hesapPara + " Kadar Eklendi " + "Mevcut Bakiyeniz: " + (bakiye));
                            Console.WriteLine("Ana Menüye Dönmek İçin 9");
                            Console.WriteLine("Çıkış İçin 0");
                            int menuSecimi = Convert.ToInt32(Console.ReadLine());
                            if (menuSecimi == 9)
                            {
                                continue;
                            }
                            else if (menuSecimi == 0)
                            {
                                Console.WriteLine("Çıkış Yapılıyor");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Hatalı Giriş");
                                continue;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Hatalı Giriş");
                            Console.WriteLine("Ana Menüye Dönmek İçin 9");
                            Console.WriteLine("Çıkış İçin 0");
                            int menuSecimi = Convert.ToInt32(Console.ReadLine());
                            if (menuSecimi == 9)
                            {
                                continue;
                            }
                            else if (menuSecimi == 0)
                            {
                                Console.WriteLine("Çıkış Yapılıyor");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Hatalı Giriş");
                                continue;
                            }
                        }
                    }
                    else if (secim == 3)
                    {
                        Console.WriteLine("Başka Hesaba EFT 1");
                        Console.WriteLine("Başka Hesaba Havale 2");
                        int hesapSecimi = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Göndermek İstediğiniz Miktarı Yazınız");
                        int hesapPara = Convert.ToInt32(Console.ReadLine());
                        if (hesapSecimi == 1)
                        {
                            if (bakiye >= hesapPara)
                            {
                                bakiye -= hesapPara;
                                Console.WriteLine("Başında TR Olacak Şekilde 12 Haneli Kart Numaranızı Giriniz");
                                Console.ReadLine();
                                Console.WriteLine("Karşı Hesaba " + hesapPara + " Kadar Gönderildi " + "Mevcut Bakiyeniz: " + (bakiye));
                                Console.WriteLine("Ana Menüye Dönmek İçin 9");
                                Console.WriteLine("Çıkış İçin 0");
                                int menuSecimi = Convert.ToInt32(Console.ReadLine());
                                if (menuSecimi == 9)
                                {
                                    continue;
                                }
                                else if (menuSecimi == 0)
                                {
                                    Console.WriteLine("Çıkış Yapılıyor");
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Hatalı Giriş");
                                    continue;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Yetersiz Bakiye");
                                Console.WriteLine("Ana Menüye Dönmek İçin 9");
                                Console.WriteLine("Çıkış İçin 0");
                                int menuSecimi = Convert.ToInt32(Console.ReadLine());
                                if (menuSecimi == 9)
                                {
                                    continue;
                                }
                                else if (menuSecimi == 0)
                                {
                                    Console.WriteLine("Çıkış Yapılıyor");
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Hatalı Giriş");
                                    continue;
                                }
                            }
                        }
                        else if (hesapSecimi == 2)
                        {
                            if (bakiye >= hesapPara)
                            {
                                bakiye -= hesapPara;
                                Console.WriteLine("11 Haneli Hesap Numarası Giriniz");
                                Console.WriteLine("Hesaba " + hesapPara + " Kadar Gönderildi " + "Mevcut Bakiyeniz: " + (bakiye));
                                Console.WriteLine("Ana Menüye Dönmek İçin 9");
                                Console.WriteLine("Çıkış İçin 0");
                                int menuSecimi = Convert.ToInt32(Console.ReadLine());
                                if (menuSecimi == 9)
                                {
                                    continue;
                                }
                                else if (menuSecimi == 0)
                                {
                                    Console.WriteLine("Çıkış Yapılıyor");
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Hatalı Giriş");
                                    continue;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Yetersiz Bakiye");
                                Console.WriteLine("Ana Menüye Dönmek İçin 9");
                                Console.WriteLine("Çıkış İçin 0");
                                int menuSecimi = Convert.ToInt32(Console.ReadLine());
                                if (menuSecimi == 9)
                                {
                                    continue;
                                }
                                else if (menuSecimi == 0)
                                {
                                    Console.WriteLine("Çıkış Yapılıyor");
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Hatalı Giriş");
                                    continue;
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Hatalı Giriş");
                            continue;
                        }
                    }
                    else if (secim == 4)
                    {
                        Console.WriteLine("Eğitim Ödemeleri Sayfası Arızalıdır");
                        Console.WriteLine("Ana Menüye Dönmek İçin 9");
                        Console.WriteLine("Çıkış İçin 0");
                        int menuSecimi = Convert.ToInt32(Console.ReadLine());
                        if (menuSecimi == 9)
                        {
                            continue;
                        }
                        else if (menuSecimi == 0)
                        {
                            Console.WriteLine("Çıkış Yapılıyor");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Hatalı Giriş");
                            continue;
                        }
                    }
                    else if (secim == 5)
                    {
                        Console.WriteLine("Elektrik Faturası       1");
                        Console.WriteLine("Telefon Faturası        2");
                        Console.WriteLine("İnternet faturası       3");
                        Console.WriteLine("Su Faturası             4");
                        Console.WriteLine("OGS Ödemeleri           5");
                        int hesapSecimi = Convert.ToInt32(Console.ReadLine());
                        if (hesapSecimi == 1)
                        {
                            if (bakiye >= 1000)
                            {
                                bakiye -= 1000;
                                Console.WriteLine("Elektrik Faturası Ödendi. Mevcut Bakiye: " + (bakiye));
                                Console.WriteLine("Ana Menüye Dönmek İçin 9");
                                Console.WriteLine("Çıkış İçin 0");
                                int menuSecimi = Convert.ToInt32(Console.ReadLine());
                                if (menuSecimi == 9)
                                {
                                    continue;
                                }
                                else if (menuSecimi == 0)
                                {
                                    Console.WriteLine("Çıkış Yapılıyor");
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Hatalı Giriş");
                                    continue;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Yetersiz Bakiye");
                                Console.WriteLine("Ana Menüye Dönmek İçin 9");
                                Console.WriteLine("Çıkış İçin 0");
                                int menuSecimi = Convert.ToInt32(Console.ReadLine());
                                if (menuSecimi == 9)
                                {
                                    continue;
                                }
                                else if (menuSecimi == 0)
                                {
                                    Console.WriteLine("Çıkış Yapılıyor");
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Hatalı Giriş");
                                    continue;
                                }
                            }
                        }
                        else if (hesapSecimi == 2)
                        {
                            if (bakiye >= 1000)
                            {
                                bakiye -= 1000;
                                Console.WriteLine("Telefon Faturası Ödendi. Mevcut Bakiye: " + (bakiye));
                                Console.WriteLine("Ana Menüye Dönmek İçin 9");
                                Console.WriteLine("Çıkış İçin 0");
                                int menuSecimi = Convert.ToInt32(Console.ReadLine());
                                if (menuSecimi == 9)
                                {
                                    continue;
                                }
                                else if (menuSecimi == 0)
                                {
                                    Console.WriteLine("Çıkış Yapılıyor");
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Hatalı Giriş");
                                    continue;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Yetersiz Bakiye");
                                Console.WriteLine("Ana Menüye Dönmek İçin 9");
                                Console.WriteLine("Çıkış İçin 0");
                                int menuSecimi = Convert.ToInt32(Console.ReadLine());
                                if (menuSecimi == 9)
                                {
                                    continue;
                                }
                                else if (menuSecimi == 0)
                                {
                                    Console.WriteLine("Çıkış Yapılıyor");
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Hatalı Giriş");
                                    continue;
                                }
                            }
                        }
                        else if (hesapSecimi == 3)
                        {
                            if (bakiye >= 1000)
                            {
                                bakiye -= 1000;
                                Console.WriteLine("İnternet Faturası Ödendi. Mevcut Bakiye: " + (bakiye));
                                Console.WriteLine("Ana Menüye Dönmek İçin 9");
                                Console.WriteLine("Çıkış İçin 0");
                                int menuSecimi = Convert.ToInt32(Console.ReadLine());
                                if (menuSecimi == 9)
                                {
                                    continue;
                                }
                                else if (menuSecimi == 0)
                                {
                                    Console.WriteLine("Çıkış Yapılıyor");
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Hatalı Giriş");
                                    continue;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Yetersiz Bakiye");
                                Console.WriteLine("Ana Menüye Dönmek İçin 9");
                                Console.WriteLine("Çıkış İçin 0");
                                int menuSecimi = Convert.ToInt32(Console.ReadLine());
                                if (menuSecimi == 9)
                                {
                                    continue;
                                }
                                else if (menuSecimi == 0)
                                {
                                    Console.WriteLine("Çıkış Yapılıyor");
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Hatalı Giriş");
                                    continue;
                                }
                            }
                        }
                        else if (hesapSecimi == 4)
                        {
                            if (bakiye >= 1000)
                            {
                                bakiye -= 1000;
                                Console.WriteLine("Su Faturası Ödendi. Mevcut Bakiye: " + (bakiye));
                                Console.WriteLine("Ana Menüye Dönmek İçin 9");
                                Console.WriteLine("Çıkış İçin 0");
                                int menuSecimi = Convert.ToInt32(Console.ReadLine());
                                if (menuSecimi == 9)
                                {
                                    continue;
                                }
                                else if (menuSecimi == 0)
                                {
                                    Console.WriteLine("Çıkış Yapılıyor");
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Hatalı Giriş");
                                    continue;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Yetersiz Bakiye");
                                Console.WriteLine("Ana Menüye Dönmek İçin 9");
                                Console.WriteLine("Çıkış İçin 0");
                                int menuSecimi = Convert.ToInt32(Console.ReadLine());
                                if (menuSecimi == 9)
                                {
                                    continue;
                                }
                                else if (menuSecimi == 0)
                                {
                                    Console.WriteLine("Çıkış Yapılıyor");
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Hatalı Giriş");
                                    continue;
                                }
                            }
                        }
                        else if (hesapSecimi == 5)
                        {
                            if (bakiye >= 1000)
                            {
                                bakiye -= 1000;
                                Console.WriteLine("OGS Faturası Ödendi. Mevcut Bakiye: " + (bakiye));
                                Console.WriteLine("Ana Menüye Dönmek İçin 9");
                                Console.WriteLine("Çıkış İçin 0");
                                int menuSecimi = Convert.ToInt32(Console.ReadLine());
                                if (menuSecimi == 9)
                                {
                                    continue;
                                }
                                else if (menuSecimi == 0)
                                {
                                    Console.WriteLine("Çıkış Yapılıyor");
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Hatalı Giriş");
                                    continue;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Yetersiz Bakiye");
                                Console.WriteLine("Ana Menüye Dönmek İçin 9");
                                Console.WriteLine("Çıkış İçin 0");
                                int menuSecimi = Convert.ToInt32(Console.ReadLine());
                                if (menuSecimi == 9)
                                {
                                    continue;
                                }
                                else if (menuSecimi == 0)
                                {
                                    Console.WriteLine("Çıkış Yapılıyor");
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Hatalı Giriş");
                                    continue;
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Hatalı Giriş");
                            continue;
                        }
                    }
                    else if (secim == 6)
                    {
                        Console.WriteLine("Şifre Değiştirmek İçin 1");
                        int hesapSecimi = Convert.ToInt32(Console.ReadLine());
                        if (hesapSecimi == 1)
                        {
                            Console.WriteLine("Mevcut Şifrenizi Giriniz");
                            string mevcutSifre = Console.ReadLine();
                            if (mevcutSifre == sifre)
                            {
                                Console.WriteLine("Yeni Şifreyi Giriniz");
                                string yeniSifre1 = Console.ReadLine();
                                Console.WriteLine("Yeni Şifreyi Tekrar Giriniz");
                                string yeniSifre2 = Console.ReadLine();
                                if (yeniSifre1 == yeniSifre2)
                                {
                                    sifre = yeniSifre1;
                                    Console.WriteLine("Şifreniz Başarıyla Değiştirilmiştir");
                                    Console.WriteLine("Tekrar Giriş Yapın");
                                    goto DON;
                                }
                                else
                                {
                                    Console.WriteLine("Hatalı Şifre Girdiniz");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Hatalı Şifre Girdiniz");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Hatalı Giriş");
                        }
                    }
                    else if (secim == 0)
                    {
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
        }
    }
}