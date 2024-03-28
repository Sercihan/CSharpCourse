namespace _12_Methods_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //klavyeden girilen değerler arasında rastgele sayı üreten  ve bu değerleri 10 elemanlı bir diziye atayan SayiUret() isimli bir metot yazın.
            //Bu dizinin elemanlarını yazan DiziYazdır() isimli bir metot daha yazarak elemanları listeleyin.
            //Daha sonra bu dizi içerisinde EnBuyukDeger() adında bir metot ile dizinin en büyük değerini bulan,
            //en küçük değerinin bulan EnKucukDeger() adından başka bir metot daha yazınız.
            //EnBuyukDeger ve EnKucukDeger metotlarında dönen değerleri ekranda gösteren programı yazınız
            //kullanıcının bütün hataları kontrol altına alınmalı

            Console.Write("Başlangıç Değeri:");
            int basla = Convert.ToInt32(Console.ReadLine());
            Console.Write("Bitiş Değeri:");
            int bitis = Convert.ToInt32(Console.ReadLine());


            int[] anaDizi = SayiUret(basla, bitis);

            DiziYazdir(anaDizi);

            Console.WriteLine("Max:" + EnBuyukDeger(anaDizi));
            Console.WriteLine("Min:" + EnKucukDeger(anaDizi));
        }

        static int[] SayiUret(int a, int b)
        {
            if (a > b)
            {
                int temp = a;
                a = b;
                b = temp;
            }
            int[] sayilar = new int[10];

            Random r = new Random();

            for (int i = 0; i < 10; i++)
            {
                sayilar[i] = r.Next(a, b);
            }

            return sayilar;
        }

        static void DiziYazdir(int[] array)
        {
            foreach (int item in array)
            {
                Console.WriteLine(item);
            }
        }

        static int EnBuyukDeger(int[] array)
        {
            //return array.Max();

            int enBuyuk = array[0];

            foreach (int item in array)
            {
                if (item > enBuyuk)
                    enBuyuk = item;
            }

            return enBuyuk;
        }

        static int EnKucukDeger(int[] array)
        {
            //return array.Min();

            int enKucuk = array[0];

            foreach (int item in array)
            {
                if (item < enKucuk)
                    enKucuk = item;
            }

            return enKucuk;
        }

    }
}
