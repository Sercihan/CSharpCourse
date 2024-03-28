namespace _16_OOP_4_Inheritance_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ortak özelliklere sahip classların ortak özelliklerini bir base classda tanımlayarak, base classtan bu özellikleri çekmeye INHERITANCE-KALITIM denir.

            // className:BaseClassName şeklinde tanımlanır.
            // miras alınan sınıfı türeyen sınıf içinde kullanmak istersek BASE kelimesi kullanılır.

            Kopek k = new Kopek();
            k.KuyrukUzunlugu = 10;
            k.Agirlik = 100;
            k.Boy = 30;
            k.Cins = "Kangal";
            k.Yas = 5;
            k.KunyeNo = 111;

            k.OzellikYaz();


            Kartal kartal = new Kartal();
            kartal.KanatUzunlugu = 200;
            kartal.Agirlik = 100;
            kartal.Boy = 10;
            kartal.Cins = "Şampiyon";
            kartal.Yas = 5;
            kartal.KunyeNo = 112;

            kartal.OzellikYaz();

        }
    }

    class Hayvan
    {
        public int Yas { get; set; }
        public string Cins { get; set; }
        public int Agirlik { get; set; }
        public int Boy { get; set; }
        public int KunyeNo { get; set; }

        public void OzellikYaz()
        {
            Console.WriteLine(this.Yas);
            Console.WriteLine(this.Cins);
            Console.WriteLine(this.Agirlik);
            Console.WriteLine(this.Boy);
            Console.WriteLine(this.KunyeNo);
        }
    }

    class Kopek : Hayvan
    {
        public int KuyrukUzunlugu { get; set; }

        public new void OzellikYaz() //NameHiding
        {
            base.OzellikYaz();
            Console.WriteLine(this.KuyrukUzunlugu);
        }
    }

    class Kartal : Hayvan
    {
        public int KanatUzunlugu { get; set; }
        public new void OzellikYaz()
        {
            base.OzellikYaz();
            Console.WriteLine(this.KanatUzunlugu);
        }
    }

    class Balina : Hayvan
    {
        public int YuzgecSayisi { get; set; }
        public new void OzellikYaz()
        {
            base.OzellikYaz();
            Console.WriteLine(this.YuzgecSayisi);
        }
    }
}
