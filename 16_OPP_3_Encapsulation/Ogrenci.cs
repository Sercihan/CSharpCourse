using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_OOP_3_Encapsulation
{
    internal class Ogrenci
    {
        private string ad;
        private double vizeNotu;
        private double finalNotu;


        public string Ad
        {
            get { return ad; }
            set { ad = value; }
        }

        public double VizeNotu
        {
            get { return vizeNotu; }
            set
            {
                if (value >= 0 && value <= 100)
                    vizeNotu = value;
                else
                    Console.WriteLine("Vize notu 0 ile 100 arasında olmalıdır.");
            }
        }

        public double FinalNotu
        {
            get { return finalNotu; }
            set
            {
                if (value >= 0 && value <= 100)
                    finalNotu = value;
                else
                {
                    while (true)
                    {
                        Console.WriteLine("Final notu 0 ile 100 arasında olmalıdır.");

                        Console.WriteLine("FinalNotu:");
                        double final = Convert.ToDouble(Console.ReadLine());

                        if (final >= 0 && final <= 100)
                        {
                            finalNotu = final;
                            break;
                        }

                    }
                }

            }
        }


        public double OrtalamaHesapla()
        {
            return (vizeNotu * 0.4) + (finalNotu * 0.6);
        }
    }
}
