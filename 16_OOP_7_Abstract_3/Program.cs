namespace _16_OOP_7_Abstract_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Sercihan

            //Telefon tel = new Telefon(10000, 30);
            //tel.FiyatHesapla();
            //Bilgisayar pc = new Bilgisayar(50000, 20, 3000);
            //pc.FiyatHesapla();

            #endregion
        }
    }
    /*
    abstract class Elektronik
    {
        internal double alisFiyat;
        internal double karYuzde;

        internal abstract void FiyatHesapla();
    }
    class Telefon : Elektronik
    {
        public Telefon(double alis, double kar)
        {
            this.alisFiyat = alis;
            this.karYuzde = kar;
        }
        internal override void FiyatHesapla()
        {
            double fiyat = this.alisFiyat + (this.alisFiyat * this.karYuzde / 100);
            Console.WriteLine("Telefon Fiyatı: " + fiyat);
        }
    }
    class Bilgisayar : Elektronik
    {
        public Bilgisayar(double alis, double kar, double masraf)
        {
            this.alisFiyat = alis;
            this.karYuzde = kar;
            this.ekmasraf = masraf;
        }
        internal double ekmasraf;
        internal override void FiyatHesapla()
        {
            double fiyat = ekmasraf + this.alisFiyat + (this.alisFiyat * this.karYuzde / 100);
            Console.WriteLine("Telefon Fiyatı: " + fiyat);
        }
    }
    */
    abstract class Elektronik
    {
        public decimal AlisFiyati { get; set; }
        public decimal KarYuzdesi { get; set; }

        public abstract decimal FiyatHesapla();
    }

    class Telefon : Elektronik
    {
        public override decimal FiyatHesapla()
        {
            return AlisFiyati + (AlisFiyati * KarYuzdesi);
        }
    }

    class Bilgisayar : Elektronik
    {
        public decimal EkMasraf { get; set; }

        public override decimal FiyatHesapla()
        {
            return EkMasraf + AlisFiyati + (AlisFiyati * KarYuzdesi);
        }
    }
}
}
