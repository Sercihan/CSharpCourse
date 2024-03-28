namespace _16_OOP_7_Abstract_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*ABSTRACT - SOYUTLAMA
            Soyut: Elle tutulamayan, göz ile görüleyen ama varlığa inandığımız şeyler.

            Abstract class : base olarak kullanılacak ve instance (nesne oluşturma) işlemi uygunlmayacak classlardır.
             
            Abstract field : abstract keyword'üne sahip methods,properties oluşturulabilir. Method abstract ise gövdesi yazılmaz sadece tanım amaçlı yazılır. Bu methodun bulunduğu class inheritance(miras-kalıtım) alınırsa abstract metodun kullanılması zorunlu olur ve metot gövdesi türeyen sınıfta tanımlanır.
             
            Abstract bir metot mutlaka abstract tanımlı bir classta olmalıdır ama class Abstract diye içindeki bütün metotlar abstract olmak zorunda değildir.

             */

            /*ABSTRACT CLASS KURALLARI*/

            /*Kullanırken dikkat edilmesi gerekenler:

            Soyut sınıflar “abstract” türünden nesneler tanımlamazlar.

            Soyut sınıflar içerilerinde soyut olmayan metotlar da barındırabilir ancak soyut metotlar sadece soyut sınıflar içerisinde bildirilebilir.

            Soyut metotlar türeyen sınıfta mutlaka bildirilmelidir.

            Soyut metotlar override edilmek zorundadırlar, aksi takdirde derleyici hatası  alınır.

             “Static” metotlar soyut olarak tanımlanamazlar. 

             Soyut sınıflar “private” olarak tanımlanamazlar ama “public” ve “protected” olarak tanımlanabilirler.

             Soyut sınıflar “sealed” anahtar sözcüğü ile ifade edilemezler.  
            */


            //Abstract class Instance YAPILAMAZ.
            //Ogrenci ogrenci = new Ogrenci();

            Lise lise = new Lise();
            lise.AdSoyad = "Altan Emre";
            lise.OgrenciYaz();
        }
    }

    abstract class Ogrenci//base class
    {
        public int Numara { get; set; }
        public string AdSoyad { get; set; }

        //Abstract Metot Gövde YAZILMAZ
        public abstract void OgrenciYaz();

        public void YAZ()
        {
            Console.WriteLine("Abstract classta normal metot bulunabilir.");
        }

    }

    class Ilkokul : Ogrenci
    {
        public string OkulAd { get; set; }
        public string Adres { get; set; }

        //Base sınıftaki abstract metot kullanılması (implementasyon-implement) zorunludur.
        public override void OgrenciYaz()
        {
            Console.WriteLine(AdSoyad);
            Console.WriteLine(Numara);
            Console.WriteLine(OkulAd);
            Console.WriteLine(Adres);
        }
    }

    class Lise : Ogrenci
    {
        public double Not1 { get; set; }
        public double Not2 { get; set; }
        public string OkulAd { get; set; }

        public override void OgrenciYaz()
        {
            Console.WriteLine(AdSoyad);
            Console.WriteLine(Numara);
            Console.WriteLine(OkulAd);
            Console.WriteLine(Not1);
            Console.WriteLine(Not2);
        }
    }
}
