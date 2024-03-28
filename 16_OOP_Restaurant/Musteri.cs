using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _16_OOP_Restaurant
{
    internal class Musteri
    {
        int masaNo;
        int siraNo;
        ArrayList siparisler = new ArrayList();
        int hesapTutar = 0;
        bool oturdu = false;

        public Musteri() { }
        public Musteri(List<Masa> masaList) 
        {
            Masa.BosYer(this,masaList);
        }
        public int getmasaNo(Musteri m) { return m.masaNo; }
        public int getsiraNo(Musteri m) { return m.siraNo; }
        public bool getoturdu() { return oturdu; }
        public void setsiraNo(int siraNo) { this.siraNo = siraNo; }
        public void setmasaNo(int masaNo) { this.masaNo = masaNo; }
        public void setoturdu(bool sonuc) { this.oturdu = sonuc; }
        public void SiparisEkle(string urun,int hesapTutar)
        {
            siparisler.Add(urun);
            this.hesapTutar += hesapTutar;
            
        }
        public void HesapAl()
        {
            Console.WriteLine("Aldığınız Ürünler: \n");
            foreach (string item in siparisler)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\n\tÖdenecek Tutar: "+this.hesapTutar+" TL");
        }
    }
}