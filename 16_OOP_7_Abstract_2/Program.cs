namespace _16_OOP_7_Abstract_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Yazilim yazilim = new Yazilim();
            yazilim.
        }
    }

    //abstract class Insan
    //{
    //    public string? AdSoyad { get; set; }
    //    public int Boy { get; set; }
    //    public int Yas { get; set; }

    //    public abstract void Konus();
    //}

    abstract class Personel //: Insan
    {
        public abstract DateTime IseBaslangicTarihi { get; set; }
        public string? HesapNo { get; set; }

        public abstract void Yaz();
    }

    class Yazilim : Personel
    {
        public double Maas { get; set; }
        public string ProgramDili { get; set; }
        public override DateTime IseBaslangicTarihi { get; set; }

        public override void Yaz()
        {
            Console.WriteLine("Ben Yazılımcıyım");
        }

        //public override void Konus()
        //{
        //    Console.WriteLine("Ben Insanım");
        //}


    }
}
