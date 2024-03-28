using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_OOP_1_this
{
    internal class User
    {
        //property
        public string Name;
        public string Surname;


        public static void RegisterStatic()
        {
            User u = new User();
            Console.WriteLine("Name:");
            u.Name = Console.ReadLine();
            Console.WriteLine("Surname:");
            u.Surname = Console.ReadLine();
        }


        //Non-Static Method
        public void RegisterNonStatic()
        {
            Console.WriteLine("Name:");
            Name = Console.ReadLine();
            Console.WriteLine("Surname:");
            Surname = Console.ReadLine();
        }

        public void RegisterNonStaticThis(string Name, string Surname)
        {
            this.Name = Name;
            this.Surname = Surname;
        }

        public static void Yaz(List<User> users)
        {
            foreach (var item in users)
            {
                Console.WriteLine(item.Name);
            }
        }
    }
}
