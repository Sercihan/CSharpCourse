namespace _12_Methods_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //klavyeden girilen değerler arasında rastgele sayı üreten  ve bu değerleri 10 elemanlı bir diziye atayan SayiUret() isimli bir metot yazın.
            //Bu dizinin elemanlarını yazan DiziYazdır() isimli bir metot daha yazarak elemanları listeleyin.
            //Daha sonra bu dizi içerisinde EnBuyukDeger() adında bir metot ile dizinin en büyük değerini bulan,en küçük değerinin bulan EnKucukDeger() adından başka bir metot daha yazınız.
            //EnBuyukDeger ve EnKucukDeger metotlarında dönen değerleri ekranda gösteren programı yazınız
            //kullanıcının bütün hataları kontrol altına alınmalı

            int[] dizi = new int[10];
            SayiUret(dizi);
            DiziYazdir(dizi);
            Console.WriteLine("*****************");
            int enKucuk = EnKucukDeger(dizi);
            int enBuyuk = EnBuyukDeger(dizi);
            DiziYazdir(dizi, enKucuk, enBuyuk);
        }

        /// <summary>
        /// get array and put ten random number 
        /// </summary>
        /// <param name="dizi">int[] array</param>
        static void SayiUret(int[] dizi)
        {
            try
            {
                Random r = new Random();
                for (int i = 0; i < 10; i++)
                {
                    dizi[i] = r.Next(1, 1000);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        static void DiziYazdir(int[] dizi)
        {
            try
            {
                foreach (int i in dizi)
                {
                    Console.WriteLine(i);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        static int EnKucukDeger(int[] dizi)
        {
            try
            {
                int enKucuk = 1000;
                for (int i = 0; i < dizi.Length; i++)
                {
                    if (enKucuk <= dizi[i])
                    {
                        continue;
                    }
                    else
                    {
                        enKucuk = dizi[i];
                    }
                }
                return enKucuk;
            }
            catch (Exception e)
            {
                return -1;
                Console.WriteLine(e);
            }
        }

        static int EnBuyukDeger(int[] dizi)
        {
            try
            {
                int enBuyuk = 0;
                for (int i = 0; i < dizi.Length; i++)
                {
                    if (enBuyuk >= dizi[i])
                    {
                        continue;
                    }
                    else
                    {
                        enBuyuk = dizi[i];
                    }
                }
                return enBuyuk;
            }
            catch (Exception e)
            {
                return -1;
                Console.WriteLine(e);
            }
        }

        /// <summary>
        /// prints array, Min value and Max value
        /// </summary>
        /// <param name="dizi">int[] array</param>
        /// <param name="enKucuk">min value</param>
        /// <param name="enBuyuk">max value</param>
        static void DiziYazdir(int[] dizi, int enKucuk, int enBuyuk)
        {
            try
            {
                foreach (int i in dizi)
                {
                    Console.WriteLine(i);
                }
                Console.WriteLine("\nDizinin En Küçük Elemanı: " + enKucuk + "\nEn Büyük Elemanı: " + enBuyuk);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
