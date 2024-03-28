namespace _16_OOP_8_Interface_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Çoklu İmplementasyon 
             
             * Bir sınıfa birden fazla arayüz implement edilebilir. 
             * Örnek bir senaryo üzerinden konuyu anlatacak olursak; 
             * Bir fabrika için otomasyon programı yazdığımızı düşünelim. 
             * Fabrikada 3 farklı çalışan türü olsun, bunlar yönetici, işçi ve robot. 
             * Her bir çalışanın ID, ad-soyad, adres, maaş, departman ve toplam çalışma saati bilgisi olsun. 
             */


        }
    }

    interface IKisi
    {
        string AdSoyad { get; set; }
        string Adres { get; set; }
        double Maas { get; set; }

        void Yaz();
    }

    interface ICalisan
    {
        int Id { get; set; }
        string Departman { get; set; }
        int ToplamCalismaSaati { get; set; }
    }
    class Isci : ICalisan, IKisi
    {
        public int Id { get; set; }
        public string Departman { get; set; }
        public int ToplamCalismaSaati { get; set; }
        public string AdSoyad { get; set; }
        public string Adres { get; set; }
        public double Maas { get; set; }

        public void Yaz()
        {
            throw new NotImplementedException();
        }
    }


    class Yonetici : ICalisan, IKisi
    {
        public int Id { get; set; }
        public string Departman { get; set; }
        public int ToplamCalismaSaati { get; set; }
        public string AdSoyad { get; set; }
        public string Adres { get; set; }
        public double Maas { get; set; }

        public void Yaz()
        {
            throw new NotImplementedException();
        }
    }
    class Robot : ICalisan
    {
        public int Id { get; set; }
        public string Departman { get; set; }
        public int ToplamCalismaSaati { get; set; }
    }
}

