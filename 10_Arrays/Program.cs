namespace _10_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ornek1

            //int[] sayilar = { 11, 22, 11, 33, 44, 11, 5, 55, 11, 66, 78, 9 };
            //int i = -1;
            //while (i < sayilar.Length)
            //{
            //    i = Array.IndexOf(sayilar, 11, i + 1);
            //    if (i == -1)
            //    {
            //        break;
            //    }
            //    Console.WriteLine(i);
            //}

            #endregion
            #region ornek2

            //Console.WriteLine("Aileniz Kaç Kişilik");
            //int fert = Convert.ToInt32(Console.ReadLine());
            //string[] aile = new string[fert+1];
            //int sayac = 1;
            //while (sayac <= fert)
            //{
            //    Console.WriteLine("Aile Fertlerinin İsimlerini Giriniz");
            //    aile[sayac] = Console.ReadLine();
            //    sayac++;
            //}
            //foreach (string item in aile)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion
            #region ornek3

            //Console.WriteLine("Kaç Ürün Girilecek");
            //int urunSayi = Convert.ToInt32(Console.ReadLine());
            //string[] urunler = new string[urunSayi];
            //Console.WriteLine("Ürünleri Girin");
            //for (int i = 0; i < urunSayi; i++)
            //{
            //    urunler[i] = Console.ReadLine();
            //}
            //Console.WriteLine("Ürünlerin Fiyatlarını Sırasıyla Girin");
            //double[] fiyatlar = new double[urunSayi];
            //for (int j = 0; j < urunSayi; j++)
            //{
            //    fiyatlar[j] = Convert.ToDouble(Console.ReadLine());
            //}
            //for (int k = 0; k < urunSayi; k++)
            //{
            //    Console.WriteLine("Ürün: "+urunler[k]+" Fiyat: " + fiyatlar[k]);
            //}

            #endregion
            #region ornek4

            //Random r = new Random();
            //int diziRange = r.Next(10, 20);
            //int[] dizi = new int[diziRange];

            //for (int i = 0; i < diziRange; i++)
            //{
            //    dizi[i] = r.Next(0,1000);
            //}
            //Console.WriteLine("Dizinin Eleman Sayısı: "+diziRange);
            //foreach (int item in dizi)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion
            #region ornek5

            //Random r = new Random();
            //int[] sayilar = new int[15];
            //for (int i = 0; i < 15; i++)
            //{
            //    int addSayi = r.Next(0, 20);
            //    if (sayilar.Contains(addSayi))
            //    {
            //        i--;
            //    }
            //    else
            //    {
            //        sayilar[i] = addSayi;
            //    }
            //}
            //foreach (int item in sayilar)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine(sayilar.Length);

            #endregion
            #region ornek6

            //Random r = new Random();
            //int[] dizi = new int[100];
            //int toplam = 0;
            //for (int i = 0; i < 100; i++)
            //{
            //    int sayi = r.Next(0, 1000);
            //    toplam += sayi;
            //    dizi[i] = sayi;
            //}
            //Console.WriteLine("Dizinin Ortalaması: "+(toplam/100)+" En Küçük Değeri: "+dizi.Min()+" En Büyük Değeri: "+dizi.Max());

            #endregion

            /* ********** ARRAYS ************

            */

            // Bir Aile fertlerinin adlarını tutmak istiyoruz.

            string ad1 = "Büşra";
            string ad2 = "Sercihan";
            string ad3 = "Buse";
            string ad4 = "Nedim";

            //Koleksiyon yapılarında  ARRAY kullanılabilir.

            // Diziler aynı veritipinde birden fazla değeri tutabilen yapılardır. Her aldıkları değere INDEX adı verilen 0'dan başlayarak 1'er 1'er artan numaralandırma sistemi ile numara verirler.

            //string[] demircis = { "altan", "ceylan", "uras" };

            //Console.WriteLine(demircis[1]);
            //Console.WriteLine(demircis[0]);
            //Console.WriteLine(demircis[2]);
            //Console.WriteLine(demircis[3]); // Tanımlı olmayan Index çağrılırsa IndexOutOfRangeException hatası alınır.


            #region Dolu bir dizi tanımı ve yazdırma

            //int[] sayilar = { 11, 22, 33, 44, 5, 55, 66, 78, 9 };
            //for (int i = 0; i < 9; i++)
            //{
            //    Console.WriteLine(sayilar[i]);
            //}

            #endregion


            #region Boş dizi tanımı

            // 10 eleman tutabilen bir dizi
            //string[] isimler = new string[10];

            //isimler[4] = "Esra";


            //for (int i = 0; i < isimler.Length; i++)
            //{
            //    Console.WriteLine("İsim:");
            //    isimler[i] = Console.ReadLine();
            //}


            #endregion


            //string[] isimler = new string[10];

            //Console.WriteLine("Dizi Boyutu:"+isimler.Length);


            #region FOREACH LOOP

            // Koleksiyon yapılarında sadece okuma amaçlı kullanılır.

            //int[] sayilar = { 11, 22, 33, 44, 5, 55, 66, 78, 9 };

            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    Console.WriteLine(sayilar[i]);
            //}

            //Console.WriteLine("******************");

            //foreach (int item in sayilar)
            //{
            //    Console.WriteLine(item);
            //}



            #endregion

            //string[] sayilar = new string[10];
            //sayilar[0] = "11";
            //sayilar[1] = "12";
            //sayilar[3] = "14";

            //foreach (string item in sayilar)
            //{
            //    Console.WriteLine(item);
            //}


            #region ARRAY SINIFI METOTLAR

            #region Clear()

            //int[] sayilar = { 11, 22, 33, 44, 5, 55, 66, 78, 9 };

            //foreach (int item in sayilar)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("-----------");

            //Array.Clear(sayilar);

            //Array.Clear(sayilar, 2, 3);

            //foreach (int item in sayilar)
            //{
            //    Console.WriteLine(item);
            //}



            #endregion


            #region Copy()

            //int[] sayilar = { 11, 22, 33, 44, 5, 55, 66, 78, 9 };

            //int[] sayilar2 = new int[10];


            ////Array.Copy(sayilar, sayilar2, 4);

            //Array.Copy(sayilar, 1, sayilar2, 2, 4);

            //foreach (int item in sayilar)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("-------------");

            //foreach (int item in sayilar2)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion


            #region INDEX OF

            // Dizide bulunan bir değerin bulunduğu ilk index numarasını öğrenmemezi sağlar.
            //int[] sayilar = { 11, 22, 11, 33, 44, 11, 5, 55,11, 66, 78, 9 };

            //Console.WriteLine(Array.IndexOf(sayilar,11));

            //Console.WriteLine(Array.IndexOf(sayilar,11,1));


            //int indx = Array.IndexOf(sayilar, 11, 1);
            //Console.WriteLine(indx);

            //SORU: sayilar dizisindeki bütün 11 değerlerinin INDEX değerleri bir döngü ile ekrana yazdırınız.

            //int[] sayilar = { 11, 22, 11, 33, 44, 11, 5, 55, 11, 66, 78, 9 };
            #region BUSE
            //Console.WriteLine("Dizideki 11 değerlerinin index değerleri:");

            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    if (sayilar[i] == 11)
            //    {
            //        Console.WriteLine("Index: " + i);
            //    }
            //}
            #endregion


            //int i = -1;
            //while (i < sayilar.Length)
            //{
            //    i = Array.IndexOf(sayilar, 11, i + 1);
            //    if (i == -1)
            //        break;
            //    Console.WriteLine(i);
            //}


            #endregion


            #region LASTINDEXOF

            //int[] sayilar = { 11, 22, 11, 33, 44, 11, 5, 55, 11, 66, 78, 9 };

            //int indx = Array.LastIndexOf(sayilar, 11);

            //Console.WriteLine(indx);

            #endregion


            #region Sort()
            // Verilen koleksiyonu 0 -> 9  A -> Z ye sıralar.
            //int[] sayilar = { 11, 22,2,99, 11, 33, 44, 11, 5, 55, 11, 66, 78, 9 };

            //Array.Sort(sayilar);

            //string[] sehirler = { "Zonguldak", "Adana", "Kastamonu", "Bayburt", "İzmir", "Çanakkale", "İstanbul", "Kars" };

            //Array.Sort(sehirler);

            //foreach (string item in sehirler)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion


            #region Reverse()

            //string[] sehirler = { "Zonguldak", "Adana", "Kastamonu", "Bayburt", "İzmir", "Çanakkale", "İstanbul", "Kars" };

            //Array.Sort(sehirler);
            //Array.Reverse(sehirler);

            //foreach (string item in sehirler)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion


            #region Resize()

            //int[] rakams = new int[5];

            //rakams[0] = 11;
            //rakams[1] = 11;
            //rakams[2] = 11;
            //rakams[3] = 11;
            //rakams[4] = 11;

            //Array.Resize(ref rakams, 10);

            //rakams[5] = 12;

            #endregion




            #endregion


            #region Kullanıcıdan aile üye sayısını alarak aile fertlerinin isimlerini bir array a ekleyerek ekrana yazdırınız.

            //Console.WriteLine("Kaç Kişisiniz?");
            //int kisiSayisi = Convert.ToInt32(Console.ReadLine());

            //string[] aile = new string[kisiSayisi];

            //for (int i = 0; i < kisiSayisi; i++)
            //{
            //    Console.WriteLine("İsim:");
            //    aile[i] = Console.ReadLine();
            //}


            //int j = 0;

            //while (j < kisiSayisi)
            //{
            //    Console.WriteLine("İsim:");
            //    aile[j] = Console.ReadLine();
            //    j++;
            //}

            //foreach (string item in aile)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion


            #region Bir ismin harflerini alt alta yazdırma

            //string ad = "Altan Emre".ToUpper();

            //Console.WriteLine(ad[5]);

            //for (int i = 0; i < ad.Length; i++)
            //{
            //    Console.WriteLine(ad[i]);
            //}



            #endregion


            #region Kullanıcıdan alınacak ürün sayısına göre ürün isimleri istenerek bir diziye atılacak 
            // Girilen her ürün için bir de fiyat tutan bir dizi oluşturulacak.
            // Ürün adı : Fiyat şeklinde ekrana yazdırılacak

            //Console.WriteLine("Ürün Sayısı:");
            //int adet = Convert.ToInt32(Console.ReadLine());

            //string[] urunler = new string[adet];
            //double[] fiyatlar = new double[adet];

            //for (int i = 0; i < adet; i++)
            //{
            //    Console.WriteLine("Ürün Adı:");
            //    urunler[i] = Console.ReadLine();

            //    Console.WriteLine("Ürün Fiyatı:");
            //    fiyatlar[i] = Convert.ToDouble(Console.ReadLine());
            //}

            //Console.WriteLine("--------------------");

            //for (int i = 0; i < adet; i++)
            //{
            //    Console.WriteLine($"Ürün Adı:{urunler[i]} - Fiyat:{fiyatlar[i]}");
            //}

            #endregion


            #region Bir dizinin eleman sayısı 10 ile 20 arsında olacak şekilde sistem tarafında otomatik atılmaktadır.
            //Bu dizinin elemanlarını da sistem 0,1000 arasında otomatik atmaktadır.
            //Otomatik oluşturulan bu dizinin eleman sayısını ve elemanlarını kullanıcıya gösteriniz

            //Random r = new Random();
            //int[] sayilar = new int[r.Next(10, 20)];

            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    sayilar[i] = r.Next(0, 1000);
            //}

            //foreach (int item in sayilar)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine(sayilar.Length);
            //Console.WriteLine(sayilar.Count());


            #endregion


            #region 15 sayısal değer alan bir diziyi, 0,20 arasında rastgele değerler ile doldurunuz.
            //BONUS: Aynı sayılar birden fazla kez eklenmesin

            //int[] sayilar = new int[15];

            //Random r = new Random();

            //int i = 0;

            //while (i < 15)
            //{
            //    int sayi = r.Next(0, 20);

            //    if (!sayilar.Contains(sayi)) //if(sayilar.Contains(sayi)==false)
            //    {
            //        sayilar[i] = sayi;
            //        i++;
            //    }
            //}

            //for (int i = 0; i < 15; i++)
            //{
            //    int sayi = r.Next(0, 20);

            //    if (!sayilar.Contains(sayi)) 
            //    {
            //        sayilar[i] = sayi;                   
            //    }
            //    else
            //    {
            //        i--;
            //    }
            //}



            //foreach (int item in sayilar)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine(sayilar.Length);







            #endregion


            #region 100 elemanlı bir dizi için 0-1000 arasında rastgele sayılar atayın.
            //Bu dizinin elemanlarının sayı ortalamasını, en küçük değerini ve en büyük değerini gösteriniz

            //int[] sayilar = new int[100];

            //Random r = new Random();

            //int toplam = 0;

            //for (int i = 0; i < 100; i++)
            //{
            //    int sayi = r.Next(0, 1000);
            //    sayilar[i] = sayi;
            //    toplam += sayi;
            //}

            //Console.WriteLine("Ortalama:"+(toplam/sayilar.Length));
            //Console.WriteLine("Min:" + sayilar.Min());
            //Console.WriteLine("Max:"+sayilar.Max());


            //Array.Sort(sayilar);
            //Console.WriteLine(sayilar[0]);
            //Console.WriteLine(sayilar[99]);


            #region BUSE
            //Random random = new Random();
            //int[] dizi = new int[100];
            //int toplam = 0;
            //for (int i = 0; i < dizi.Length; i++)
            //{
            //    dizi[i] = random.Next(1001);
            //    toplam = toplam + dizi[i];


            //}
            //double ortalama = (double)toplam / dizi.Length;

            //int enKucuk = dizi[0];
            //int enBuyuk = dizi[0];
            //for (int i = 1; i < dizi.Length; i++)
            //{
            //    if (dizi[i] < enKucuk)
            //        enKucuk = dizi[i];

            //    if (dizi[i] > enBuyuk)
            //        enBuyuk = dizi[i];
            //}

            //Console.WriteLine($"Dizi elemanlarının ortalama değeri: {ortalama}");
            //Console.WriteLine($"Dizi elemanlarının en küçük değeri: {enKucuk}");
            //Console.WriteLine($"Dizi elemanlarının en büyük değeri: {enBuyuk}");

            #endregion

            #endregion
            #region Kullanıcıdan 4 ürün fiyatı isteyin fiyatı 1200 tl yi geçen ürünlere %32 indirim yapınız ve 
            //        her biri ürünün yeni fiyatını gösteriniz

            //double[] prices = new double[4];

            //for (int i = 0; i < 4; i++)
            //{
            //    Console.WriteLine("Ürün Fiyat:");
            //    double fiyat = Convert.ToDouble(Console.ReadLine());

            //    if (fiyat > 1200)
            //        fiyat *= 0.68;

            //    prices[i] = fiyat;
            //}

            //foreach (var item in prices)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion


            #region e - mail hesabı oluşturma

            //başlangıç:
            //    Console.Write("Oluştumk istediğiniz mail adresini giriniz:");
            //    string email = Console.ReadLine(); //altanemre@gmail.com

            //    #region "@" kontrolü
            //    bool varmi = false;
            //    int sayac = 0;
            //    for (int i = 0; i < email.Length; i++)
            //    {
            //        if (email.Substring(i, 1) == "@")
            //        {
            //            varmi = true;
            //            sayac++;
            //        }
            //    }
            //    if (varmi == false || sayac != 1)
            //    {
            //        Console.WriteLine("emailde bir tane'@' olmalıdır!");
            //        goto bitir;
            //    }
            //    #endregion

            //    #region "." kontrolü
            //    bool varmi2 = false;
            //    for (int i = 0; i < email.Length; i++)
            //    {
            //        if (email.Substring(i, 1) == ".")
            //        {
            //            varmi2 = true;
            //        }
            //    }
            //    if (varmi2 == false)
            //    {
            //        Console.WriteLine("emailde bir tane'.' olmalıdır!");
            //        goto bitir;
            //    }
            //    #endregion

            //    string[] dizi = email.Split('@');  // {"altanemre","gmail.com"}

            //    #region karakter kontrolü
            //    if (dizi[0] == "")
            //    {
            //        Console.WriteLine("'@'den önce en az bir karakter olmalidir");
            //        goto bitir;
            //    }
            //    #endregion

            //    #region @ sonrası kontrol
            //    bool varmi3 = false;
            //    for (int i = 0; i < dizi[1].Length; i++)
            //    {
            //        if (dizi[1].Substring(i, 1) == ".")
            //        {
            //            varmi3 = true;
            //        }
            //    }
            //    if (varmi3 == false)
            //    {
            //        Console.WriteLine("emailde '@' den sonra bir tane'.' olmalıdır!");
            //        goto bitir;
            //    }
            //    #endregion

            //    string[] dizi2 = dizi[1].Split('.'); // {"gmail","com"}

            //    #region @ sonrası '.' kontrolü
            //    bool varmi4 = false;
            //    for (int i = 0; i < dizi2[dizi2.Length - 1].Length; i++)
            //    {
            //        if (dizi2[dizi2.Length - 1].Substring(i, 1) != "")
            //        {
            //            varmi4 = true;
            //        }
            //    }
            //    if (varmi4 == false)
            //    {
            //        Console.WriteLine("emailde '@' den sonraki kısımda '.' dan sonra en az bir tane karakter olmalıdır!");
            //        goto bitir;
            //    }

            //    #endregion

            //    #region ' ' kontrolü
            //    bool varmi5 = true;
            //    char[] dizi3 = email.ToCharArray(); //{'a','l',....}

            //    for (int i = 0; i < dizi3.Length; i++)
            //    {
            //        if (dizi3[i] == ' ')
            //        {
            //            varmi5 = false;
            //        }
            //    }
            //    if (varmi5 == false)
            //    {
            //        Console.WriteLine("emailde ' ' karakteri kullanılamaz");
            //    }
            //    else
            //    {
            //        email = string.Concat(dizi3);
            //        Console.WriteLine("e-mail hesabınız başarıyla oluşturuldu");
            //        goto bitir;
            //    }
            //#endregion

            //#region yeniden deneme
            //bitir:
            //    Console.Write("yeniden denemek ister misiniz?(evet=1/hayır=2):");
            //    int cevap = int.Parse(Console.ReadLine());
            //    switch (cevap)
            //    {
            //        case 1:
            //            goto başlangıç;
            //        case 2:
            //            break;
            //    }
            //    #endregion

            #endregion


            #region  sesli harf kontrolü

            Console.Write("bir kelime girin:"); //altanemre
            string kelime = Console.ReadLine();
            int sayac = 0;
            string karakter = "aeıioöuü";
            char[] kelime_dizi = kelime.ToCharArray();
            char[] karakter_dizi = karakter.ToCharArray();
            for (int i = 0; i < kelime_dizi.Length; i++)
            {
                for (int j = 0; j < karakter_dizi.Length; j++)
                {
                    if (kelime_dizi[i] == karakter_dizi[j])
                        sayac++;
                }
            }
            Console.WriteLine(sayac);

            #endregion
        }
    }
}