using System.Runtime.CompilerServices;

namespace _16_OOP_3_Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ornek1

            //Ogrenci ogr = new Ogrenci();
            //ogr._vize = 60;
            //ogr._final = 80;
            //Console.WriteLine(Ogrenci.ort(ogr));
            //Console.WriteLine(ogr._vize);
            //Console.WriteLine(ogr._final);

            #endregion
            #region ornek2

            //List<Musteri> musteris = new List<Musteri>();

            //Musteri m = new Musteri();

            //Console.WriteLine("TC:");
            //m._TC = Convert.ToInt64(Console.ReadLine());//value
            ////m.IBAN = "TR12345678909";
            //m.FullName = "Altan Emre";
            //m.Id = 2;

            //Console.WriteLine(m._TC);


            ////KAYNAK
            //musteris.Add(m);



            // Universite Öğrencilerinin Final ve Vize sınav notlarını öğrenciden alalım. %60 final %40 vize üzerinden ortalama hesaplayarak ekrana yazdırınız. Vize - Final 0-100 aralığı ENCAPSULATION ile kontrol edilecek 


            Ogrenci ogrenci = new Ogrenci();
            ogrenci.VizeNotu = 10;
            ogrenci.FinalNotu = -90;

            Console.WriteLine(ogrenci.OrtalamaHesapla());

            #endregion
        }
    }
    //internal class Ogrenci
    //{
    //    private int vize;
    //    private int final;

    //    internal int _vize
    //    {
    //        get { return vize; }
    //        set
    //        {
    //            if (value > 0 && value < 100)
    //            {
    //                vize = value;
    //            }
    //        }
    //    }
    //    internal int _final
    //    {
    //        get { return final; }
    //        set
    //        {
    //            if (value > 0 && value < 100)
    //            {
    //                final = value;
    //            }
    //        }
    //    }
    //    internal static double ort(Ogrenci ogr)
    //    {
    //        double ortalama = ogr._vize * 0.4 + ogr._final * 0.6;
    //        return ortalama;
    //    }
    //}
    class Musteri
    {
        public int Id;
        public string FullName;
        private long TC;
        private string IBAN;

        public long _TC
        {
            get { return TC; } //readonly
            set
            {
                if (value >= 10000000000 && value < 100000000000)
                {
                    TC = value;
                }
                else
                {
                    TC = 00000000000;
                }

            }
        }

    }
}
