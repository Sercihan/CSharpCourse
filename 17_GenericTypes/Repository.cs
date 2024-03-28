using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_GenericTypes
{
    //T: Generic Type
    public class Repository<T>
    {


        public static void Insert(T entity)
        {
            //Parametre ile gelen T Database kaydedilecek.
            List<T> values = new List<T>();
            values.Add(entity);
        }
        public static void Update(T entity)
        {
            //Parametre ile gelen T Database güncellenecek.
        }
        public static void Delete(int id)
        {
            //Parametre ile gelen id deki T Database silinecek.
        }
        public static void List()
        {
            //Databaseden bütün T okunarak listelenecek
        }
        public static void Find(int id)
        {
            //Parametre ile gelen Id deki T Database getirilecek.
        }
    }
}
