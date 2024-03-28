using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_OOP_Araba
{
    internal class Uretim
    {
        string marka;
        string model;
        string renk;
        int motorHacmi;
        int uretimYili;

        public Uretim() { }
        public Uretim(string marka,string model,string renk,int motorHacmi,int uretimYili)
        {
            this.marka = marka;
            this.model = model;
            this.renk = renk;
            this.motorHacmi = motorHacmi;
            this.uretimYili = uretimYili;
        }
        public static void Yazdir(List<Uretim> liste)
        {
            int i = 1;
            Console.WriteLine("Kayıtlı Arabaların Listesi: \n");
            foreach (Uretim item in liste)
            {
                Console.WriteLine(i+" - "+"Marka: "+item.marka+"\nModel: "+item.model+"\nRenk: "+item.renk+"\nMotor Hacmi: "+item.motorHacmi+"\nÜretim Yılı: "+item.uretimYili);
                Console.WriteLine("\n*******\n");
                i++;
            }
        }
        public static void Guncelle(List<Uretim> liste, int i)
        {
            Console.WriteLine("Arabanın Şuanki Rengi: "+liste[i - 1].renk+" Hangi Renk Yapmak İstiyorsun ?");
            string yeniRenk = Console.ReadLine();
            liste[i - 1].renk = yeniRenk;
        }
        public static void Filtre(List<Uretim> liste, string fmarka)
        {
            for (int i = 0; i < liste.Count; i++)
            {
                if (liste[i].marka == fmarka)
                {
                    Console.WriteLine((i+1)+" - Marka: " + liste[i].marka + "\nModel: " + liste[i].model + "\nRenk: " + liste[i].renk + "\nMotor Hacmi: " + liste[i].motorHacmi + "\nÜretim Yılı: " + liste[i].uretimYili);
                    Console.WriteLine("\n*******\n");
                }
                else
                {
                    continue;
                }
            }
        }
    }
}
