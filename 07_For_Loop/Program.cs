namespace _07_For_Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ornek1
            //int toplam = 0;
            //int sayac = 0;
            //for (int i = 0; i < 500; i+=13)
            //{
            //    if(i == 0)
            //    {
            //        continue;
            //    }
            //    toplam += i;
            //    Console.WriteLine(i);
            //    sayac++;
            //}
            //Console.WriteLine("Toplam: "+toplam);
            //Console.WriteLine(sayac+" Kadar 13'ün Katı Vardır");

            #endregion
            #region ornek2

            //Console.WriteLine("Faktoriyelini İstediğiniz Bir Sayı Giriniz");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //long faktoriyel = 1;
            //for (int i = 1; i <= sayi; i++)
            //{
            //    faktoriyel *= i;
            //}
            //Console.WriteLine("Belirlediğiniz Sayının Faktöriyeli: "+faktoriyel);

            #endregion
            #region Carpım Tablosu

            //for (int i = 1; i <= 10; i++)
            //{
            //    for (int j = 1; j <= 10; j++)
            //    {
            //        Console.Write(i+"*"+j+"="+(i*j)+"\t");
            //    }
            //    Console.WriteLine();
            //}

            #endregion
            #region ornek3

            //for (int i = 1; i <= 7; i++)
            //{
            //    for (int j = 0; j < 1; j++)
            //    {
            //        if(i == 1 || i == 7)
            //        {
            //            Console.WriteLine("***********");
            //            continue;
            //        }
            //        else
            //        {
            //            Console.WriteLine("*         *");
            //        }

            //    }
            //}

            #endregion

            #region TANIM
            /* LOOPS => 
                * While
                * For
                * Do While
                * Foreach

            Belirli bir iş tanımlayan kod bloklarını tekrar tekrar yazmaktan bizi kurtartır.
             */

            // 1-10 arasındaki sayıları ekran yazdırınız

            //Console.WriteLine(1);
            //Console.WriteLine(2);
            //Console.WriteLine(3);
            //Console.WriteLine(4);
            //Console.WriteLine(5);
            //Console.WriteLine(6);
            //Console.WriteLine(7);
            //Console.WriteLine(8);
            //Console.WriteLine(9);
            //Console.WriteLine(10);

            //int i = 1;

            //while (i < 11)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            //for(int i=1; i<11; i++)
            //{
            //    Console.WriteLine(i);
            //}

            // int i => Döngü başlangıç değeri
            // i<11  => Döngü çalışma koşulu(TRUE)
            // i++   => İŞlem sonrası sayaç manipülasyon değeri
            #endregion

            #region 1.Örnek

            //for (int i = 20; i >0 ; i--)
            //{
            //    Console.WriteLine(i);
            //}

            //for (int i = 20; i > 0; i-=2)
            //{
            //    Console.WriteLine(i);
            //}

            #endregion

            #region 1-500 arasındaki sayıların içinden 13 katlarının sayısını ve toplamlarını hesaplayınız         

            //int toplam = 0;
            //int adet = 0;

            //for (int i = 1; i < 500; i++)
            //{
            //    if (i % 13 == 0)
            //    {
            //        toplam += i;
            //        adet++;
            //    }                   
            //}
            //Console.WriteLine($"Toplam:{toplam} Sayı Adeti:{adet}");
            #endregion

            #region Kullanıcıdan alınacak bir sayının faktöriyelini bulan hesaplamayı for ile yapınız

            //5 => 1*2*3*4*5=120

            //int fakt = 1;

            //Console.WriteLine("faktöriyel hesaplanacak sayı:");
            //int sayi = Convert.ToInt32(Console.ReadLine());


            //for (int i = 1; i <= sayi; i++)
            //{
            //    Console.WriteLine(fakt + "*" + i+"="+(fakt*i));
            //    fakt *= i;

            //}

            //Console.WriteLine("Faktöriyel:"+fakt);

            #endregion

            #region ÇARPIM TABLOSU

            /*
             2*1=2
             2*2=4
             2*3=6
             2*4=8
             2*5=10
             ....
             
             */

            //for (int i = 1; i < 11; i++)
            //{
            //    for (int j = 1; j < 11; j++)
            //    {
            //        Console.Write($"{j}*{i}={i*j}\t");
            //    }
            //    Console.WriteLine();
            //}


            #endregion

            #region ŞEKİL

            /*
             ****************
             *              *
             *              *
             *              *
             *              *
             *              *
             ****************
             
             for (int i = 1; i < 10; i++)
            {
                if(i==1 || i == 9)
                {
                    Console.WriteLine("**************");
                }
                else
                {
                    Console.WriteLine("*            *");
                }
            }



             
                    *
                   * *
                  *   *
                 *     *
                *       *
               *         *
              *************         
             */


            int disBosluk = 10;
            int icBosluk = 1;

            for (int i = 1; i < 8; i++)
            {
                for (int k = 0; k < disBosluk; k++)
                {
                    Console.Write(" ");
                }
                disBosluk -= 1;
                Console.Write("*");
                if (i != 1)
                {
                    for (int j = 0; j < icBosluk; j += 1)
                    {
                        Console.Write(" ");
                    }
                    icBosluk += 2;
                    Console.Write("*");
                }

                Console.WriteLine();
                if (i == 7)
                {
                    Console.WriteLine("   ***************  ");
                }
            }



            #endregion
        }
    }
}
