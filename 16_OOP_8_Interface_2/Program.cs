namespace _16_OOP_8_Interface_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    interface IInsan
    {
        public int Yas { get; set; }
        public int Boy { get; set; }
    }
    class Ogrenci
    {
        public int Numara { get; set; }
        public string AdSoyad { get; set; }
    }

    class Ilkokul : Ogrenci, IInsan
    {
        public int Yas { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Boy { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
