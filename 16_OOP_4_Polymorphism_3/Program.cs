using System.Runtime.CompilerServices;

namespace _16_OOP_6_Polymorphism_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*

           Tekstil    : Ad,Fiyat,KumasTuru,Beden,UreticiFirma - KDVUygula(%20)
           CepTelefonu: Ad,Fiyat,Ozellikler,Marka - KDVUygula(%120)
           Ekmek      : Ad,Fiyat,EkmekTuru,Gramaj - KDVUygula(%20)

           Nesne ozelliklerini Contructor method ile alın.

           Sepet : Alınan urunleri bir listeye kaydetsin, Toplamtutarı söylesin

            */

            Sepet s = new Sepet();

            Ekmek ekmek = new Ekmek("Çavdar", 400, "Uno", 70);
            CepTelefonu cepTelefonu = new CepTelefonu("Bluetooth,5G", "Huawei", "Plite20", 20000);

            s.Ekle(ekmek);
            s.Ekle(ekmek);
            s.Ekle(cepTelefonu);

            Console.WriteLine(s.ToplamTutar());
        }
    }
    class Urun
    {
        public string Ad { get; set; }
        public double Fiyat { get; set; }

        public Urun(string ad, double fiyat)
        {
            Ad = ad;
            Fiyat = fiyat;
        }

        public virtual double KDVUygula()
        {
            return Fiyat * 1.2;
        }
    }

    class Tekstil : Urun
    {
        public string KumasTuru { get; set; }
        public int Beden { get; set; }
        public string UreticiFirma { get; set; }

        public Tekstil(string kumasTuru, int beden, string ureticiFirma, string ad, double fiyat) : base(ad, fiyat)
        {
            KumasTuru = kumasTuru;
            Beden = beden;
            UreticiFirma = ureticiFirma;
        }
    }

    class Ekmek : Urun
    {
        public string Turu { get; set; }
        public int Gramaj { get; set; }

        public Ekmek(string turu, int gramaj, string ad, double fiyat) : base(ad, fiyat)
        {
            Turu = turu;
            Gramaj = gramaj;
        }
    }

    class CepTelefonu : Urun
    {
        public string Ozellikleri { get; set; }
        public string Marka { get; set; }

        public CepTelefonu(string ozellikleri, string marka, string ad, double fiyat) : base(ad, fiyat)
        {
            Ozellikleri = ozellikleri;
            Marka = marka;
        }

        public override double KDVUygula()
        {
            return Fiyat * 2.2;
        }
    }

    class Sepet
    {
        private List<Urun> urunler = new List<Urun>();

        public double ToplamTutar()
        {
            double toplamfiyat = 0;
            foreach (Urun item in urunler)
            {
                toplamfiyat += item.Fiyat;
            }

            return toplamfiyat;
        }

        public void Ekle(Urun urun)
        {
            urunler.Add(urun);
        }
    }
    /*
    internal class Tekstil : Urun
    {
        string ad;
        double fiyat;
        string kumasTuru;
        string beden;
        string ureticiFirma;

        public Tekstil(string ad, double fiyat, string kumasTuru, string beden, string ureticiFirma) : base(ad, fiyat)
        {
            this.kumasTuru = kumasTuru;
            this.beden = beden;
            this.ureticiFirma = ureticiFirma;
        }
    }
    internal class CepTelefonu : Urun
    {
        string ad;
        double fiyat;
        string ozellikler;
        string marka;

        public CepTelefonu(string ad, double fiyat, string ozellikler, string marka) : base(ad, fiyat)
        {
            this.ozellikler = ozellikler;
            this.marka = marka;
        }
        public override double KDVUygula()
        {
            return fiyat * 2.2;
        }
    }
    internal class Ekmek : Urun
    {
        string ekmekTuru;
        int gramaj;

        public Ekmek(string ad, double fiyat, string ekmekTuru, int gramaj) : base(ad, fiyat)
        {
            this.ekmekTuru = ekmekTuru;
            this.gramaj = gramaj;
        }
    }
    internal class Urun
    {
        string ad;
        public double fiyat;

        public Urun(string ad, double fiyat)
        {
            this.ad = ad;
            this.fiyat = fiyat;
        }

        public virtual double KDVUygula()
        {
            return fiyat * 1.2;
        }
    }
    internal class Sepet
    {

        private List<Urun> urunler = new List<Urun>();
        public double ToplamTutar()
        {
            double toplamFiyat = 0;
            foreach (Urun item in urunler)
            {
                toplamFiyat += item.fiyat;
            }
            return toplamFiyat;
        }
        public void Ekle(Urun urun)
        {
            urunler.Add(urun);
        }
    }
    */
}
