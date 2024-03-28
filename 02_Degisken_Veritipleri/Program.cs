namespace _02_Degisken_Veritipleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region DEĞİŞKENLER
            /*  
              ****** BÜTÜN YAZILIM DİLLERİNDE küçük HARF BÜYÜK HARF DUYARLILIĞI VARDIR

            *  DEĞİŞKENLER 
            *  Yazılım içerisinde data tanımlama, data taşıma gibi işlemlerde datayı(veri) tutan yapılardır. 
                ****  Tek bir veri tutabilirler.
                ****  İsimleri unique(özel) olmalıdır

            Ad=Nedim
            ad=Büşra
            aD=Altan
            AD=Esra


            Arkadaşlar 2 tane sayıyı toplayarak ekrana yazdırınız

            sayi1=10
            sayi2=5

            toplam=sayi1+sayi2

            **** DEĞİŞKEN TANIMLAMA

            veritipi değişkenadı = değer

            **** DEĞİŞKEN İSİMLENDİRME KURALLARI(case_sensitive)
            yanlış: 1sayi, ?sayi, sayi?, sa?yi, ad soyad 
            doğru:  sayi1, _sayi, sayi_, ad_soyad, adsoyad

            ** özel karakter olarak yazılımda kabul edilen tek karakter _ alt çizgidir.


            UpperCase => SAYI
            LowerCase => sayi
            SnakeCase => ad_soyad
            KebabCase => ad-soyad
            CamelCase => adSoyad

            

            */
            #endregion

            #region VERİ TİPLERİ

            /* 
            
            SAYISAL TİPLER: 
                INTEGER(TAMSAYI):sbyte,byte,short,ushort,int,uint,long,ulong
                REEL (ONDALIK): float,double,
                DECIMAL : decimal


                int yas = 34;
            
                float bakiye = 10.5f;
                double bakiye2 = 10.5;
                decimal money = 100.5m;
                 
            SÖZEL TİPLER:
                CHAR: Tek bir karakter tutar. char harf = 'A'; ile tanımlanır
                STRING: Ram boyutu kadar karakter tutar. " ile tanımlanır.


            char harf = 'A';
            char harf2 = '1';
            char harf3 = '?';

            string isim = "Büşra";



            MANTIKSAL TİPLER:
                BOOLEAN: bool ile tanımlanır ve sadece True,False değerleri alır.
                bool sonuc = 3 > 2;
             */


            //Arkadaşlar 2 tane sayıyı toplayarak ekrana yazdırınız
            //int sayi1 = 12;
            //int sayi2 = 24;

            //int sonuc = sayi1 + sayi2;

            //Console.WriteLine(sonuc);


            //Console.Write("Altan Emre");
            //Console.Write("Altan Emre");




            #endregion

            #region STRING KAÇIŞ KARAKTERLERİ

            //string ad = "Altan Emre\n";

            //Console.Write(ad);
            //Console.Write(ad);


            //string metin = "Bu ülke çok güzel\n ama ekonomi \n çok daha güzel";

            //Console.WriteLine(metin);


            #endregion


            //{
            //    int sayi = 5;
            //}
            //{
            //    int sayi = 6;
            //}


            //int sayi = 5;
            //{
            //     int sayi = 6;
            //}



            //int sayi = 5;
            //{
            //    long sayi = 6;
            //}


            //{
            //    int a;
            //    {
            //        int b;
            //    }

            //    a = 20;
            //    b = 10;
            //}


            //****** CONSTANT:Sabit değişken: değerini ilk atamadan sonra değiştiremezsiniz.
            //const int sayi = 5;

            //string ad = "ali", soyad = "veli";

            //string ad2 = "ali"; int sayi2 = 5;




            //int b=1;
            //Console.WriteLine("a");
            //Console.WriteLine(b);


            string sayi = "12";
            string sayi2 = "13";

            string s = sayi + sayi2;

            Console.WriteLine(s);


        }
    }
}
