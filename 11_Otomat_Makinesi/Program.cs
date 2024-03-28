namespace _11_Otomat_Makinesi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string id = "admin";
            string sifre = "qwe";
            int hak = 3;
            string[] urunler = new string[6];
            double[] fiyatlar = new double[6];
            urunler[0] = "Çikolata";
            urunler[1] = "Kek";
            urunler[2] = "Meyve Suyu";
            urunler[3] = "Kraker";
            urunler[4] = "Bisküvi";
            urunler[5] = "Su";
            fiyatlar[0] = 10;
            fiyatlar[1] = 8;
            fiyatlar[2] = 5.5;
            fiyatlar[3] = 4.5;
            fiyatlar[4] = 3.5;
            fiyatlar[5] = 2;

            while (true)
            {
                try
                {
                DON:
                    Console.WriteLine("Müşteri Girişi İçin  1\nAdmin Girişi İçin    2\nÇıkış İçin \t     0");
                    int girisSecim = Convert.ToInt32(Console.ReadLine());

                    if (girisSecim == 1)
                    {
                        Console.Clear();
                        for (int i = 0; i < urunler.Length; i++)
                        {
                            if (urunler[i] == "Boş")
                            {
                                continue;
                            }
                            else
                            {
                                Console.WriteLine(urunler[i] + " Fiyat: " + fiyatlar[i] + " TL Almak İçin " + (i + 1));
                            }
                        }
                        int urunSecim = Convert.ToInt32(Console.ReadLine());

                        Console.Clear();
                        Console.WriteLine(urunler[urunSecim - 1] + " Almak İçin " + fiyatlar[urunSecim - 1] + " TL Yükleyin\n");
                        double odeme = Convert.ToDouble(Console.ReadLine());

                        if (odeme >= fiyatlar[urunSecim - 1])
                        {
                            Console.Clear();
                            Console.WriteLine("Para Üstünü Almayı Unutmayın. Para Üstü: " + (odeme - fiyatlar[urunSecim - 1]) + "\n");
                        }
                        else if (odeme < fiyatlar[urunSecim - 1])
                        {
                            Console.WriteLine("Yetersiz Bakiye " + (fiyatlar[urunSecim - 1] - odeme) + " TL Daha Ekleyin");
                            double yeniOdeme = (Convert.ToDouble(Console.ReadLine()) + odeme);
                            if (yeniOdeme >= fiyatlar[urunSecim - 1])
                            {
                                Console.Clear();
                                Console.WriteLine("Para Üstünü Almayı Unutmayın. Para Üstü: " + (yeniOdeme - fiyatlar[urunSecim - 1]) + "\n");
                            }
                            else if (yeniOdeme < fiyatlar[urunSecim - 1])
                            {
                                Console.WriteLine("Yetersiz Bakiye, Paranızı Almayı Unutmayın\nMenüye Yönlendiriliyorsunuz");
                                Thread.Sleep(2000);
                                Console.Clear();
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Hatalı Giriş");
                                Thread.Sleep(1000);
                                Console.Clear();
                                break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Hatalı Giriş");
                            Thread.Sleep(1000);
                            Console.Clear();
                            break;
                        }
                    }
                    else if (girisSecim == 2)
                    {
                        while (true)
                        {
                            try
                            {
                                Console.WriteLine("Kullanıcı Adınızı Giriniz");
                                string userID = Console.ReadLine();
                                Console.WriteLine("Şifrenizi Giriniz");
                                string userSifre = Console.ReadLine();
                                Console.Clear();
                                if (hak > 0)
                                {
                                    if (userID == id && userSifre == sifre)
                                    {
                                        while (true)
                                        {
                                            Console.WriteLine("Ürün Eklemek İçin 1");
                                            Console.WriteLine("Ürün Silmek İçin 2");
                                            Console.WriteLine("Ürün Güncellemek İçin 3");
                                            Console.WriteLine("Fiyat Güncellemek İçin 4");
                                            Console.WriteLine("Ana Menü İçin 9");
                                            Console.WriteLine("Çıkış İçin 0");
                                            int adminSecim = Convert.ToInt32(Console.ReadLine());
                                            if (adminSecim == 1)
                                            {
                                                Console.Clear();
                                                Console.WriteLine("Eklemek İstediğiniz Ürünün Adını Girin");
                                                string yeniUrun = Console.ReadLine();
                                                Console.WriteLine("Bu Ürünün Fiyatını Belirleyin");
                                                double yeniUrunFiyat = Convert.ToDouble(Console.ReadLine());
                                                Array.Resize(ref urunler, urunler.Length + 1);
                                                urunler[urunler.Length - 1] = yeniUrun;
                                                Array.Resize(ref fiyatlar, fiyatlar.Length + 1);
                                                fiyatlar[fiyatlar.Length - 1] = yeniUrunFiyat;
                                                Console.Clear();
                                            }
                                            else if (adminSecim == 2)
                                            {
                                                Console.Clear();
                                                foreach (string item in urunler)
                                                {
                                                    Console.WriteLine(item);
                                                }
                                                Console.WriteLine("\nSilmek İstediğiniz Ürünün Adını Girin");
                                                string silUrun = Console.ReadLine();
                                                if (urunler.Contains(silUrun))
                                                {
                                                    int silUrunIndex = Array.IndexOf(urunler, silUrun);
                                                    Console.WriteLine("Ürün Siliniyor");
                                                    urunler[silUrunIndex] = "Boş";
                                                    fiyatlar[silUrunIndex] = 0;
                                                }
                                                else
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("Listede Olmayan Ürün Girdiniz\n");
                                                }
                                            }
                                            else if (adminSecim == 3)
                                            {
                                                Console.Clear();
                                                foreach (string item in urunler)
                                                {
                                                    Console.WriteLine(item);
                                                }
                                                Console.WriteLine("İsmini Değiştirmek İstediğiniz Ürünü Girin");
                                                string urunName = Console.ReadLine();
                                                if (urunler.Contains(urunName))
                                                {
                                                    Console.WriteLine("Bu Ürünün Yeni Adını Giriniz");
                                                    string urunNameChange = Console.ReadLine();
                                                    int urunNameIndex = Array.IndexOf(urunler, urunName);
                                                    Console.WriteLine("Ürün Adı Değiştiriliyor");
                                                    urunler[urunNameIndex] = urunNameChange;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Yanlış Ürün Adı Girdiniz");
                                                }
                                            }
                                            else if (adminSecim == 4)
                                            {
                                                Console.Clear();
                                                foreach (string item in urunler)
                                                {
                                                    Console.WriteLine(item);
                                                }
                                                Console.WriteLine("Fiyatını Değiştirmek İstediğiniz Ürünü Girin");
                                                string urunName = Console.ReadLine();
                                                if (urunler.Contains(urunName))
                                                {
                                                    int urunNameIndex = Array.IndexOf(urunler, urunName);
                                                    Console.WriteLine("Ürünün Eski Fiyatı: " + fiyatlar[urunNameIndex] + "\nÜrünün Yeni Fiyatını Girin");
                                                    double newFiyat = Convert.ToDouble(Console.ReadLine());
                                                    Console.WriteLine("Ürün Fiyatı Değiştiriliyor");
                                                    fiyatlar[urunNameIndex] = newFiyat;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Yanlış Ürün Adı Girdiniz");
                                                }
                                            }
                                            else if (adminSecim == 9)
                                            {
                                                Console.Clear();
                                                Console.WriteLine("Ana Menüye Dönülüyor");
                                                goto DON;
                                            }
                                            else if (adminSecim == 0)
                                            {
                                                Console.Clear();
                                                Console.WriteLine("Çıkış Yapılıyor..");
                                                Thread.Sleep(1000);
                                                Environment.Exit(0);
                                            }
                                            else
                                            {
                                                Console.Clear();
                                                Console.WriteLine("Hatalı Seçim, Tekrar Deneyin\n");
                                            }
                                        }
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Kullanıcı Adı veya Şifre Yanlış");
                                        Console.WriteLine("Kalan Hakkınız: " + (hak));
                                        hak--;
                                    }
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine("Deneme Hakkınız Bitti\n");
                                    hak = 3;
                                    break;
                                }
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e);
                                Console.WriteLine("Ana Menüye Dönülüyor");
                                Thread.Sleep(1500);
                                Console.Clear();
                            }
                        }
                    }
                    else if (girisSecim == 0)
                    {
                        Console.WriteLine("Çıkış Yapılıyor");
                        Thread.Sleep(1500);
                        break;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Hatalı Seçim, Tekrar Deneyiniz\n");
                        continue;
                    }
                }
                catch (Exception e)
                {
                    Console.Clear();
                    Console.WriteLine(e);
                    Console.WriteLine();
                }
            }
        }
    }
}