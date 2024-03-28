using System.Collections;

namespace _13_ArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ornek1
            //ArrayList sayilar = new ArrayList();
            //int enKucuk;
            //int enBuyuk;
            //double Toplam = 0;
            //double ortalama = 0;
            //while (true)
            //{
            //    Console.WriteLine("Değer Giriniz. Çıkmak İçin 0 Tuşlayın");
            //    int sayi = Convert.ToInt32(Console.ReadLine());
            //    if (sayi == 0)
            //    {
            //        Console.Clear();
            //        sayilar.Sort();
            //        enKucuk = (int)sayilar[0];
            //        enBuyuk = (int)sayilar[sayilar.Count-1];
            //        ortalama = Toplam / sayilar.Count;
            //        foreach (var item in sayilar)
            //        {
            //            Console.WriteLine(item);
            //        }
            //        Console.WriteLine("\nEn Küçük Sayı: "+enKucuk+"\nEn Büyük Sayı: "+enBuyuk+"\nOrtalama: "+ortalama);
            //        break;
            //    }
            //    else
            //    {
            //        Toplam += sayi;
            //        sayilar.Add(sayi);
            //    }
            //}

            #endregion
            #region ornek2

            //int Toplam = 0;
            //while (true)
            //{
            //    Console.WriteLine("Sayı Girin. Çıkmak İçin (Çık) Yazın");
            //    string sayi = Console.ReadLine().ToLower();
            //    if (sayi == "çık")
            //    {
            //        Console.WriteLine("\nSayıların Toplamı: "+Toplam);
            //        break;
            //    }
            //    else
            //    {
            //        Toplam += Convert.ToInt32(sayi); 
            //    }
            //}

            #endregion
            #region kurs

            #region ARRAYLIST TANIM
            // Değişken Tanımı
            //int sayi = 5;

            // Dizi Tanımı

            //Dizi tanımlarken veritipini ve boyutunu vermek zorundayız.

            //int[] sayilar = { 1, 2, 3, 4 };
            //int[] rakamlar = new int[10];

            /* 
             ******* ARRAYLIST *******
             * Diziden farklı olarak veri tipi ve boyut verme zorunluluğu yoktur.
             * Her veritipinden değer alabilir.
             * Tanımlarken using System.Collections; kütüphanesi kullanılmalıdır.
             
             
             */
            //Boş ArrayList Tanımı
            //ArrayList arrayList = new ArrayList();

            //Dolu ArrayList Tanımı
            //ArrayList arrayList = new ArrayList() {1,2,"Ali",15.9,'?',14.67f,123m };


            //ArrayList arrayList = new ArrayList();

            //Eleman Ekleme
            //arrayList.Add(11);
            //arrayList.Add("11");
            //arrayList.Add('!');
            //arrayList.Add(112);
            //arrayList.Add(123);
            //arrayList.Add(123);
            //arrayList.Add(123);
            //arrayList.Add(123);
            //arrayList.Add(123);
            //arrayList.Add("11");

            //Eleman Sayısı ve Kapasite
            //Console.WriteLine("Eleman Sayısı:" + arrayList.Count);
            //Console.WriteLine("Kapasite:" + arrayList.Capacity);


            //Sınırlı Kapasite Tanımı
            //ArrayList list = new ArrayList(13);
            //list.Add(11);

            //Console.WriteLine("Eleman Sayısı:" + list.Count);
            //Console.WriteLine("Kapasite:" + list.Capacity);



            //ArrayList Yazdırma
            //for (int i = 0; i < arrayList.Count; i++)
            //{
            //    Console.WriteLine(arrayList[i]);
            //}

            //Console.WriteLine("----------------");

            //foreach (var item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Methods

            ArrayList list = new ArrayList();

            list.Add(11);
            list.Add(12);
            list.Add(13);

            //INSERT: istenilen index e değer eklemeyi sağlar.

            list.Insert(1, 14);

            //CLEAR:Bütün elemanları siler.
            //list.Clear();


            //ADDRANGE:Çoklu eleman eklemeyi sağlar. Mutlaka ICollection tipinde bie dataset verilmelidir.

            //ArrayList list2 = new ArrayList() { 1, 2, 3, 4 };

            //list.AddRange(list2);

            //list.AddRange(new ArrayList() { "Emre", "Emel" });


            //INSERTRANGE:İstanilen indexe çoklşu eleman eklemeyi sağlar.
            //list.InsertRange(2, new ArrayList() { "Emre", "Emel" });

            //REMOVE:Verilen değerin ilk kaydı silinir.Bulamadığında hata vermez.
            //list.Remove("Emre");
            //list.Remove("Uğur");

            //REMOVEAT:Verilen index değerindeki kaydı siler.
            //list.RemoveAt(2);


            //REMOVERANGE:Verilen indexden başlayarak istenilen adet kaydı siler.
            //list.RemoveRange(1, 2);

            //INDEXOF: İstenilen değerin ilk indexini bulmayı sağlar.
            //Console.WriteLine(list.IndexOf("Emre"));

            //LASTINDEXOF:İstenilen değerin son indexini bulmayı sağlar.

            //list.Add(11);
            //Console.WriteLine(list.LastIndexOf(11));                        

            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}



            //ArrayList sayilar1 = new ArrayList() { 11, 22, 33 };

            //ArrayList sayilar2 = (ArrayList)sayilar1.Clone();

            //sayilar1.Add(44);

            //foreach (var item in sayilar1)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("***************");
            //foreach (var item in sayilar2)
            //{
            //    Console.WriteLine(item);
            //}


            #endregion

            //0 girilene kadar girilen değerleri ArrayListe atan ve sonunda bu listeyi büyükten küçüğe sıralayan ve listedeki en büyük en küçük ve ortalama değerleri bulan program
            //double toplam = 0;
            //ArrayList arrayList = new ArrayList();

            //while (true)
            //{
            //    Console.WriteLine("Sayı Gir");
            //    int sayi = Convert.ToInt32(Console.ReadLine());

            //    if (sayi != 0)
            //    {
            //        toplam += sayi;
            //        arrayList.Add(sayi);
            //        continue;
            //    }

            //    break;
            //}

            //arrayList.Sort();
            //arrayList.Reverse();

            //foreach (var item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("*************");

            //int max = (int)arrayList[0];
            //int min = (int)arrayList[arrayList.Count-1];
            //Console.WriteLine("En Büyük:"+max);
            //Console.WriteLine("En Küçük:"+min);

            //Console.WriteLine("Ortalama:"+(toplam/arrayList.Count));


            // Kullanıcıdan sayı isteyelim Sayı verdiği sürece toplama yapalım sayı yerine çık yazarsa toplama işlemi bitsin sonuc yazdırılsın.

            //int toplam = 0;
            //while (true)
            //{
            //    Console.WriteLine("Sayı:");
            //    string sayi = Console.ReadLine();

            //    if (sayi == "cik")
            //    {
            //        Console.WriteLine("Toplam:"+toplam);
            //        break;
            //    }
            //    toplam += Convert.ToInt32(sayi);
            //}

           


        }

        #endregion

    }
    
}
