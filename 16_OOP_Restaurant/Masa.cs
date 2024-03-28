using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _16_OOP_Restaurant
{
    internal class Masa
    {
        int[] sira = new int[4];
        
        public Masa()
        {
            sira[0] = 0;
            sira[1] = 0;
            sira[2] = 0;
            sira[3] = 0;
        }

        public static void BosYer(Musteri m, List<Masa> masaList)
        {
            for (int i = 0; i < masaList.Count; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (masaList[i].sira[j] == 0)
                    {
                        m.setsiraNo(j);
                        m.setmasaNo(i);
                        m.setoturdu(true);
                        masaList[i].sira[j] = 1;
                        i = masaList.Count-1;
                        j = 3;
                    }
                    else if (i==masaList.Count-1 && j==3 && m.getoturdu() == false)
                    {
                        Console.WriteLine("Tüm Masalar Dolu");
                    }
                    else
                    {
                        continue;
                    }
                }
            }
        }
    }
}
