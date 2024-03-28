using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_OOP_2_Constructor
{
    internal class Araba
    {
        internal string marka;
        internal string model;
        internal string renk;
        internal int motorHacmi;
        internal int uretimYili;

        public Araba() { }
        public Araba(string marka, string model, string renk, int motorHacmi, int uretimYili)
        {
            this.marka = marka;
            this.model = model;
            this.renk = renk;
            this.motorHacmi = motorHacmi;
            this.uretimYili = uretimYili;
        }

        internal static void Kayit(List<Araba> liste)
        {
            Araba araba = new Araba();
            Console.WriteLine("markası:");
            araba.marka = Console.ReadLine();
            Console.WriteLine("model:");
            araba.model = Console.ReadLine();
            Console.WriteLine("renk:");
            araba.renk = Console.ReadLine();
            Console.WriteLine("motor hacmi:");
            araba.motorHacmi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("üretim yılı:");
            araba.uretimYili = Convert.ToInt32(Console.ReadLine());

            liste.Add(araba);
        }

        internal void Kayit2()
        {
            Console.WriteLine("markası:");
            marka = Console.ReadLine();
            Console.WriteLine("model:");
            model = Console.ReadLine();
            Console.WriteLine("renk:");
            renk = Console.ReadLine();
            Console.WriteLine("motor hacmi:");
            motorHacmi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("üretim yılı:");
            uretimYili = Convert.ToInt32(Console.ReadLine());
        }

        internal static void Guncelleme(List<Araba> liste)
        {
            Listele(liste);
            Console.WriteLine("Hangi araba güncellenecek Index No?");
            int index = Convert.ToInt32(Console.ReadLine());

            if (index < liste.Count && index >= 0)
            {
                Console.WriteLine("markası:");
                liste[index].marka = Console.ReadLine();
                Console.WriteLine("model:");
                liste[index].model = Console.ReadLine();
                Console.WriteLine("renk:");
                liste[index].renk = Console.ReadLine();
                Console.WriteLine("motor hacmi:");
                liste[index].motorHacmi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("üretim yılı:");
                liste[index].uretimYili = Convert.ToInt32(Console.ReadLine());
            }


        }

        //internal static void Filtreleme(List<Araba> liste)
        //{
        //    Console.WriteLine("Marka?");
        //    string marka = Console.ReadLine();

        //    int i = 0;
        //    foreach (var item in liste)
        //    {
        //        if (item.marka == marka)
        //        {
        //            Console.WriteLine(i + " -Araba Marka: " + item.marka + "\nAraba Modeli: " + item.model + "\nRengi: " + item.renk + "\nMotor Hacmi: " + item.motorHacmi + "\nÜretim Yılı: " + item.uretimYili + "\n");

        //            i++;
        //        }
        //    }

        //}


        //public static void Listele(List<Araba> liste)
        //{
        //    int i = 0;
        //    Console.WriteLine("Arabalar Listesi: \n\n");
        //    foreach (Araba item in liste)
        //    {
        //        Console.WriteLine(i + " -Araba Marka: " + item.marka + "\nAraba Modeli: " + item.model + "\nRengi: " + item.renk + "\nMotor Hacmi: " + item.motorHacmi + "\nÜretim Yılı: " + item.uretimYili + "\n");

        //        i++;
        //    }
        //}


        //marka parametresi gelme durumuna göre listeleme/filtreleme yapan method
        public static void Listele(List<Araba> liste, string marka = null)
        {
            int i = 0;
            Console.WriteLine("Arabalar Listesi: \n\n");
            if (marka == null)
            {
                foreach (Araba item in liste)
                {
                    Console.WriteLine(i + " -Araba Marka: " + item.marka + "\nAraba Modeli: " + item.model + "\nRengi: " + item.renk + "\nMotor Hacmi: " + item.motorHacmi + "\nÜretim Yılı: " + item.uretimYili + "\n");

                    i++;
                }
            }
            else
            {
                foreach (var item in liste)
                {
                    if (item.marka == marka)
                    {
                        Console.WriteLine(i + " -Araba Marka: " + item.marka + "\nAraba Modeli: " + item.model + "\nRengi: " + item.renk + "\nMotor Hacmi: " + item.motorHacmi + "\nÜretim Yılı: " + item.uretimYili + "\n");

                        i++;
                    }
                }
            }

        }

    }
}
