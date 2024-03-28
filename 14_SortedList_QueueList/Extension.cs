using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_SortedList_QueueList
{
    public static class Extension
    {
        public static string BasharfBuyut(this string str)
        {
            str = str.Substring(0, 1).ToUpper() + str.Substring(1).ToLower();

            return str;
        }
    }
}
