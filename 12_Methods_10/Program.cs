namespace _12_Methods_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string.IsNullOrWhiteSpace()==> string ifade içerisinde boş ya da boşluk karakteri kontrolü için kullanılır
            //string .IsNullOrEmpty() ==>string değerin içerisinde null ya da boşluk kontrolü için kullanılır.
            string isim = " ";

            if (string.IsNullOrWhiteSpace(isim))
            {
                Console.WriteLine("Boşlukları kaldırınız");
            }

            if (string.IsNullOrEmpty(isim))
            {
                Console.WriteLine("Boş geçilemez.");
            }

        }
    }
}
