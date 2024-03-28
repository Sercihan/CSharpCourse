namespace _16_OOP_Araba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
         Araba:Marka,Model,Renk,MotorHacmi,UretimYili 
         Kayıt,Listeleme,Guncelleme,Filtreleme(Marka)
            */
            List<Uretim> arabaList = new List<Uretim>()
            {
                new Uretim("opel","corsa","lacivert",1200,2014),
                new Uretim("audi","a3","kırmızı",1600,2017),
                new Uretim("bmw","m3","yeşil",4000,2008),
                new Uretim("volkswagen","passat","gümüş gri",1600,2016),
                new Uretim("volvo","s60","beyaz",2000,2021),
                new Uretim("toyota","corolla","beyaz",1600,2020),
                new Uretim("seat","leon","beyaz",1200,2014),
                new Uretim("skoda","octavia","gri",1600,2019),
                new Uretim("subaru","impreza","mavi",2500,2006),
                new Uretim("renault","megane","beyaz",1500,2012),
                new Uretim("peugeot","207","siyah",1300,2010),
                new Uretim("mitsubishi","lancer","beyaz",1600,2011),
                new Uretim("mercedes","c180","beyaz",1600,2015),
                new Uretim("mazda","rx8","kırmızı",1300,2007),
                new Uretim("lexus","es300h","siyah",2500,2021),
                new Uretim("hyundai","i20","mavi",1400,2020),
                new Uretim("fiat","egea","beyaz",1600,2019),
                new Uretim("dacia","sandero","lacivert",1500,2017),
                new Uretim("chevrolet","cruze","beyaz",1600,2011),
                new Uretim("honda","civic","sarı",1500,2017),
                new Uretim("ford","focus","siyah",1500,2023),
                new Uretim("nissan","350z","turuncu",3500,2005),
                new Uretim("nissan","r35","siyah",4000,2023)
            };
            while (true)
            {
                Console.WriteLine("1 - Kayıt");
                Console.WriteLine("2 - Liste");
                Console.WriteLine("3 - Güncelle");
                Console.WriteLine("4 - Filtre");
                Console.WriteLine("5 - Çıkış");
                int secim = Convert.ToInt32(Console.ReadLine());
                if (secim == 1)
                {
                    Console.Clear();
                    Kayit(arabaList);
                }
                else if (secim == 2)
                {
                    Console.Clear();
                    Listele(arabaList);
                }
                else if (secim == 3)
                {
                    Console.Clear();
                    Guncelleme(arabaList);
                }
                else if (secim == 4)
                {
                    Console.Clear();
                    Filtreleme(arabaList);
                }
                else if (secim == 5)
                {
                    Console.WriteLine("Çıkış Yapılıyor");
                    break;
                }
                else
                {
                    Console.WriteLine("Hatalı Giriş");
                }
            }
        }
        static void Kayit(List<Uretim> liste)
        {
            Console.WriteLine("Araba Kaydına Hoşgeldiniz");
            Console.WriteLine("Marka Girin");
            string marka = Console.ReadLine().ToLower();
            Console.WriteLine("Model Girin");
            string model = Console.ReadLine().ToLower();
            Console.WriteLine("Renk Girin");
            string renk = Console.ReadLine().ToLower();
            Console.WriteLine("Motor Hacmi (cc) Girin");
            int motorHacmi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Üretim Yılı Girin");
            int uretimYili = Convert.ToInt32(Console.ReadLine());
            Uretim uretim = new Uretim(marka,model,renk,motorHacmi,uretimYili);
            liste.Add(uretim);
        }
        static void Listele(List<Uretim> liste)
        {
            Uretim.Yazdir(liste);
        }
        static void Guncelleme(List<Uretim> liste)
        {
            Listele(liste);
            Console.WriteLine("Güncellemek İstediğiniz Arabanın Sırasını Yazın (1,2,5,vb.)");
            int index = Convert.ToInt32(Console.ReadLine());
            Uretim.Guncelle(liste,index);
        }
        static void Filtreleme(List<Uretim> liste)
        {
            Console.WriteLine("Filtrelemek İstediğiniz Arabanın Markasını Yazın");
            string fmarka = Console.ReadLine().ToLower();
            Uretim.Filtre(liste, fmarka);
        }
    }
}
