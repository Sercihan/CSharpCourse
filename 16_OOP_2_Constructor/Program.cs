namespace _16_OOP_2_Constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // CONSTRUCTOR METHOD:
            // * Instance alındığı zaman çalışan bir methoddur.
            // * Default olarak boş bir şekilde gizli yapıda tanımlıdır. 
            // * Class ile aynı isimdedir. Herhangi bir void veya return ifade almaz.

            //User user2 = new User();
            //User user = new User("altan","emre");


            //GARBAGE COLLECTOR : Bütün kodlar,değişkenler,methods her yapı RAM Bellek tutulur. Ram bellek belirli bir doluluğa ulaştığında en eski,en az kullanılan veya en kolay tanımlanabilir yapıları siliyor. 


            #region ARABA URETIM OTOMASYONU
            /*
             Araba:Marka,Model,Renk,MotorHacmi,UretimYili
                * Araba classı oluşturulacak.Oluşturulan classın propertyleri(marka,model,...) eklenecek
            

             Kayıt,Listeleme,Guncelleme,Filtreleme(Marka)
             */

            #region Uzun Yol
            //List<Araba> arabas = new List<Araba>();

            //Araba araba = new Araba();
            //araba.marka = "volkswagen";
            //araba.model = "passat";
            //araba.renk = "siyah";
            //araba.motorHacmi = 2000;
            //araba.uretimYili = 2008;

            //arabas.Add(araba);

            //Araba araba2 = new Araba();
            //araba2.marka = "volkswagen";
            //araba2.model = "golf";
            //araba2.renk = "kırmızı";
            //araba2.motorHacmi = 1400;
            //araba2.uretimYili = 2017;

            //arabas.Add(araba2);
            #endregion

            //List<Araba> aracList = new List<Araba>()
            //{
            //    new Araba("volkswagen","passat","siyah",2000,2008),
            //    new Araba("volkswagen","golf","kırmızı",1400,2017),
            //    new Araba("opel","corsa","siyah",1300,2013),
            //    new Araba("opel","astra","mavi",1600,2012),
            //    new Araba("toyota","corolla","beyaz",1400,2017),
            //    new Araba("toyota","yaris","beyaz",1500,2017),
            //    new Araba("bmw","320d","kahverengi",2000,2018),
            //    new Araba("bmw","520d","mavi",2000,2018),
            //    new Araba("hyundai","accent","gri",1500,1998),
            //    new Araba("hyundai","i20","kırmızı",1400,2023)
            //};

            //while (true)
            //{
            //    Console.WriteLine(" YÜCE OTO HOŞGELDİNİZ ");
            //    Console.WriteLine("1-KAYIT\n2-LİSTELE\n3-GÜNCELLE\n4-FİLTRELE\nSeçiminiz:");
            //    int secim = Convert.ToInt32(Console.ReadLine());

            //    if (secim == 1) 
            //    {
            //        //Static Method Kullanımı
            //        Araba.Kayit(aracList);

            //        //Non-Static Method Kullanımı: Object üzerinden çağrılır.
            //        //Araba araba = new Araba();
            //        //araba.Kayit2();
            //        //aracList.Add(araba);

            //    }
            //    else if (secim == 2) 
            //    {
            //       Araba.Listele(aracList);
            //    }
            //    else if (secim == 3) 
            //    {
            //        Araba.Guncelleme(aracList);
            //    }
            //    else if (secim == 4) 
            //    {
            //        //Araba.Filtreleme(aracList);

            //        Console.WriteLine("Marka?");
            //        string marka = Console.ReadLine();

            //        Araba.Listele(aracList, marka);
            //    }
            //    else
            //    {
            //        break;
            //    }
            //}




            #endregion



            #region  RESTAURANT OTOMASYONU
            /*
            Restaurant Otomasyonu

           * toplam 5 masa olacak
           * Menu=> Çorbalar(3 çeşit) Salatalar(3çeşit) Etler(3çeşit) Makarnalar(3çeşit) İçecekler(3çeşit)
           * 
           * 1-Sipariş Al
           * 2-Hesap Al

            */


            List<Yemek> CORBALAR = new List<Yemek>()
            {
                new Yemek(){Id=1,Ad="Mercimek",Fiyat=100},
                new Yemek(){Id=2,Ad="Yayla",Fiyat=100},
                new Yemek(){Id=3,Ad="Ezogelin",Fiyat=120}
            };
            List<Yemek> ETLER = new List<Yemek>()
            {
                new Yemek(){Id=1,Ad="Pirzola",Fiyat=300},
                new Yemek(){Id=2,Ad="Biftek",Fiyat=400},
                new Yemek(){Id=3,Ad="Antrikot",Fiyat=500}
            };
            List<Yemek> MAKARNALAR = new List<Yemek>()
            {
                new Yemek(){Id=1,Ad="Köri Soslu",Fiyat=200},
                new Yemek(){Id=2,Ad="Spagetti",Fiyat=200},
                new Yemek(){Id=3,Ad="Bolanezli",Fiyat=220}
            };
            List<Yemek> SALATALAR = new List<Yemek>()
            {
                new Yemek(){Id=1,Ad="Sezar",Fiyat=300},
                new Yemek(){Id=2,Ad="Çoban",Fiyat=400},
                new Yemek(){Id=3,Ad="Gavurdağ",Fiyat=500}
            };
            List<Yemek> ICECEKLER = new List<Yemek>()
            {
                new Yemek(){Id=1,Ad="Ayran",Fiyat=30},
                new Yemek(){Id=2,Ad="Şalgam",Fiyat=40},
                new Yemek(){Id=3,Ad="Su",Fiyat=15}
            };

            List<Masa> MASALAR = new List<Masa>
            {
                new Masa(){Id=1,Durum=true},
                new Masa(){Id=2,Durum=true},
                new Masa(){Id=3,Durum=true},
                new Masa(){Id=4,Durum=true},
                new Masa(){Id=5,Durum=true}
            };

            List<Siparis> Siparisler = new List<Siparis>();

            while (true)
            {
                Console.WriteLine("1-Sipariş Al\n2-Hesap Al\nSeçiminiz:");
                string secim = Console.ReadLine();

                if (secim == "1")
                {
                    Console.Clear();
                    Console.WriteLine("Hoşgeldiniz. Kaç kişiniz?");
                    int kisiSayisi = Convert.ToInt32(Console.ReadLine());

                    Siparis siparis = new Siparis();

                    foreach (Masa masa in MASALAR)
                    {
                        if (masa.Durum)//ilk boş masayı doldurduk
                        {
                            masa.Durum = false;
                            siparis.MasaNo = masa.Id;
                            break;
                        }
                    }

                    if (siparis.MasaNo == 0)
                    {
                        Console.WriteLine("Yerimiz YOK!");
                        continue;
                    }

                    Masa.MasaListe(MASALAR);

                    int i = 1;
                    while (i <= kisiSayisi)//2
                    {
                        Console.WriteLine($"{i}. müşteri siparişi");
                        Console.WriteLine("**** MENÜ ****\n1-Çorbalar\n2-Etler\n3-Makarnalar\n4-Salatalar\n5-İçecekler\nSeçiminiz:");
                        string secimMenu = Console.ReadLine();

                        if (secimMenu == "1")
                        {
                            Siparis.SiparisAl(CORBALAR, siparis);
                        }
                        else if (secimMenu == "2")
                        {
                            Siparis.SiparisAl(ETLER, siparis);
                        }
                        else if (secimMenu == "3")
                        {
                            Siparis.SiparisAl(MAKARNALAR, siparis);
                        }
                        else if (secimMenu == "4")
                        {
                            Siparis.SiparisAl(SALATALAR, siparis);
                        }
                        else if (secimMenu == "5")
                        {
                            Siparis.SiparisAl(ICECEKLER, siparis);
                        }
                        else
                        {
                            Console.WriteLine("Hatalı Seçim!");
                        }

                        Console.WriteLine("Başka bir arzunuz var mı?");
                        string cevap = Console.ReadLine().ToLower();
                        if (cevap == "e")
                        {
                            continue;
                        }
                        Console.Clear();
                        i++;
                    }
                    Siparisler.Add(siparis);
                    Console.Clear();


                }
                else if (secim == "2")
                {
                    int masaNo = Siparis.SiparisOdeme(Siparisler);

                    if (masaNo > 0)
                        MASALAR[masaNo - 1].Durum = true;

                }
                else { break; }

            }

            #endregion






        }
    }

    class User
    {
        string Name;
        string Surname;

        //public User()
        //{
        //    Console.WriteLine("Name:");
        //    Name = Console.ReadLine();
        //    Console.WriteLine("Surname:");
        //    Surname = Console.ReadLine();
        //}

        public User()
        {
            Register();
        }

        public User(string name, string surname)
        {

        }


        public void Register()
        {
            Console.WriteLine("Name:");
            Name = Console.ReadLine();
            Console.WriteLine("Surname:");
            Surname = Console.ReadLine();
        }

    }
}
