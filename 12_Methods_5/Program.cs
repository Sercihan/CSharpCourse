namespace _12_Methods_5
{
    internal class Program
    {
        static int tekSayilar = 0;
        static int ciftSayilar = 0;

        static void Main(string[] args)
        {
            //Rastgele 1-100 arasında 15 değer tutan bir dizideki tek ve çiftleri ayrı ayrı dizilere atayan metot 

            int[] sayilar = new int[15];

            DiziDoldur(sayilar);
            //DiziYazdir(sayilar);

            int[] tekDizi = new int[tekSayilar];
            int[] ciftDizi = new int[ciftSayilar];

            DiziYazdir(sayilar, ciftDizi, tekDizi);

        }

        static void DiziYazdir(int[] array, int[] ciftdizi, int[] tekdizi)
        {
            foreach (var item in array) // var: variable 
            {
                if (item % 2 == 0)
                {
                    ciftdizi[ciftSayilar - 1] = item;
                    ciftSayilar--;
                }
                else
                {
                    tekdizi[tekSayilar - 1] = item;
                    tekSayilar--;
                }

            }
        }


        static void DiziDoldur(int[] array)
        {
            Random r = new Random();

            for (int i = 0; i < 15; i++)
            {
                int sayi = r.Next(1, 100);
                if (sayi % 2 == 0)
                    ciftSayilar++;
                else
                    tekSayilar++;

                array[i] = sayi;
            }
        }

    }
}
