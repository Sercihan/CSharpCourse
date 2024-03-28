namespace _12_Methods_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //kullanıcıdan alınacak 2 ürün fiyatından pahalı olana %30 indirim uygulayan metot 
            //ve 3.ürün almak isterse 3.ürüne %50 indirim uygulayarak metot ile kodlayınız

            Console.WriteLine("1.ürünü giriniz");
            double fiyat1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("2.ürünü giriniz");
            double fiyat2 = Convert.ToDouble(Console.ReadLine());

            //indirim(fiyat1, fiyat2);
            Magaza.indirimClass(fiyat1, fiyat2);
        }
        static void indirim(double fiyat1, double fiyat2)
        {
            if (fiyat1 > fiyat2)
            {
                fiyat1 = fiyat1 * 0.70;
                Console.WriteLine("1.ürüne indirim uygulandı.");
            }
            else if (fiyat2 >= fiyat1)
            {
                fiyat2 = fiyat2 * 0.70;
                Console.WriteLine("2.ürüne indirim uygulandı.");
            }
            Console.WriteLine("3.ürün almak ister misiniz? E/H");
            string cevap = Console.ReadLine().ToLower();

            if (cevap == "e")
            {
                Console.WriteLine("3.ürünü giriniz");
                double fiyat3 = Convert.ToDouble(Console.ReadLine());

                fiyat3 = fiyat3 * 0.50;
                Console.WriteLine("3.ürüne %50 indirim uygulandı. toplam  fiyat:" + (fiyat1 + fiyat2 + fiyat3));
            }
            else
            {
                Console.WriteLine(fiyat2 + fiyat1);
            }

        }
    }
}
