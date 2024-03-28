namespace _12_Methods_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int sonuc = Topla();

            // Console.WriteLine("Sonuc:"+sonuc);

            // Topla(1, 2);

            //kullanıcıdan alınacak iki değer için farklarını, bölümlerinin(ondalıklı) hesabını yapan iki ayrı geriye değer döndüren metot yaparak hesaplayınız

            //Console.WriteLine("1.Sayı:");
            //int s1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("2.Sayı:");
            //int s2 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine(FarkAl(s1,s2));
            //Console.WriteLine(Bol(s1,s2));
        }

        static int Topla()
        {
            Console.WriteLine("1.Sayı:");
            int s1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2.Sayı:");
            int s2 = Convert.ToInt32(Console.ReadLine());

            int toplam = s1 + s2;
            return toplam;
        }

        /// <summary>
        /// İki Sayı Toplanır.
        /// </summary>
        /// <param name="s1">1.Sayı</param>
        /// <param name="s2">2.Sayı</param>
        /// <returns> int 2 değerin toplamı dönecek</returns>
        static int Topla(int s1, int s2)
        {
            return s1 + s2;
        }

        static double FarkAl(double s1, double s2)
        {
            return s1 - s2;
        }

        static double Bol(double s1, double s2)
        {
            return s1 / s2;
        }
    }
}
