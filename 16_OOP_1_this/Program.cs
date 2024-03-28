
using System.Xml.Linq;

namespace _16_OOP_1_this
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Static Method
            //User.RegisterStatic();


            //Non-Static Method
            //User user = new User();
            //user.RegisterNonStatic();



            Console.WriteLine("Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Surname:");
            string surname = Console.ReadLine();

            User user = new User();
            user.RegisterNonStaticThis(name, surname);



            // List<User> users = new List<User>()
            // {
            //     new User(){Name="Ali",Surname="Veli"},
            //     new User(){Name="Aliye",Surname="Veliye"}          
            // };

            //User.Yaz(users);


        }
    }
}
