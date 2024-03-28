namespace _16_OOP_Ogrenci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Ogrenci> liseOgrenci = new List<Ogrenci>();
            List<Ogrenci> lisansOgrenci = new List<Ogrenci>();

            LiseOgrenci lise = new LiseOgrenci();
            LisansOgrenci lisans = new LisansOgrenci();
            lise.Kayit(liseOgrenci);
            OgrenciNotHesapla(lise);
            lisans.Kayit(lisansOgrenci);
            OgrenciNotHesapla(lisans);
        }
        static void OgrenciNotHesapla(Ogrenci ogr)
        {
            ogr.NotHesapla();
        }
    }
}
