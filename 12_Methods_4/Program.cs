namespace _12_Methods_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //OVERLOAD METHOD(Aşırı Yüklenme): AYnı isimde birden fazla metot tanımlanmasıdır.

            //Aynı isimde metot tanımlarken metot imzasının farklı olması gereklidir.

            //METOT IMZASI:
            //Parametre sayısı 
            //Parametre veri tipi

            Topla();

            Topla(12.0, 5);
        }

        static void Topla()
        {
            Console.WriteLine("1.Sayı:");
            int s1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2.Sayı:");
            int s2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(s1 + s2);
        }

        static void Topla(int s1, int s2)
        {
            Console.WriteLine(s1 + s2);
        }

        static void Topla(int s1, int s2, int s3)
        {
            Console.WriteLine(s1 + s2 + s3);
        }

        static void Topla(double s1, int s2)
        {
            Console.WriteLine(s1 + s2);
        }

        static void Topla(int s1, double s2)
        {
            Console.WriteLine(s1 + s2);
        }

        static void Topla(double s1, double s2)
        {
            Console.WriteLine(s1 + s2);
        }
    }
}
