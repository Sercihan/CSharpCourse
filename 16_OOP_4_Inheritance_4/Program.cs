namespace _16_OOP_4_Inheritance_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 
             Şirket Otomasyonu

             IK:Ad,Soyad,TC,SGKGirisTarihi,PersonelSayisi
             IT:Ad,Soyad,TC,SGKGirisTarihi,ProgramSayisi
             MUH:Ad,Soyad,TC,SGKGirisTarihi,HesapSayisi
             PAZ:Ad,Soyad,TC,SGKGirisTarihi,TeklifSayisi

             PersonelEkle(),PersonelListele(),PersonelSil(),PersonelGuncelle()


             */

            List<Personel> IKPersonels = new List<Personel>();
            List<Personel> ITPersonels = new List<Personel>();
            List<Personel> MUHPersonels = new List<Personel>();
            List<Personel> PAZPersonels = new List<Personel>();


            while (true)
            {
                Console.WriteLine("IK-1\nIT-2\nMUH-3\nPAZ-4\nSeçiminiz:");
                string secim = Console.ReadLine();

                if (secim == "1")
                {
                    Console.WriteLine("Ekleme-1\nListeleme-2\nGüncelleme-3\nSilme-4\nİşlem Seçiniz:");
                    string islem = Console.ReadLine();
                    if (islem == "1")
                    {
                        InsanKaynaklari ik = new InsanKaynaklari();
                        ik.Kayit(IKPersonels);
                        Console.Clear();
                    }
                    else if (islem == "2")
                    {
                        InsanKaynaklari.Listele(IKPersonels);
                    }
                    else if (islem == "3")
                    {
                        InsanKaynaklari.Guncelle(IKPersonels);
                    }
                    else if (islem == "4")
                    {
                        InsanKaynaklari.Silme(IKPersonels);
                    }
                }

                else if (secim == "2")
                {
                    //Console.WriteLine("Ekleme-1\nListeleme-2\nGüncelleme-3\nSilme-4\nİşlem Seçiniz:");
                    //string islem = Console.ReadLine();
                    //if (islem == "1")
                    //{
                    //    BilgiIslem ik = new BilgiIslem();
                    //    ik.Kayit(ITPersonels);
                    //    Console.Clear();
                    //}
                    //else if (islem == "2")
                    //{
                    //    BilgiIslem.Listele(ITPersonels);
                    //}
                    //else if (islem == "3")
                    //{
                    //    BilgiIslem.Guncelle(ITPersonels);
                    //}
                    //else if (islem == "4")
                    //{
                    //    BilgiIslem.Silme(ITPersonels);
                    //}
                }
                else if (secim == "3") { }
                else if (secim == "4") { }
                else { Console.WriteLine("HATALI SEÇİM!!"); }
            }
        }
    }
}
