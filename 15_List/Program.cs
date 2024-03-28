using System.Reflection.Metadata;

namespace _15_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ornek1

            List<Kullanici> users = new List<Kullanici>();
            Kullanici user = new Kullanici();

            user.iD = 1;
            user.userName = "Excalibur";
            user.passWord = "123";
            user.name = "Muhittin";
            user.surName = "Topalak";
            users.Add(user);

            user.iD = 2;
            user.userName = "Kurt";
            user.passWord = "Konsey";
            user.name = "Polat";
            user.surName = "Alemdar";
            users.Add(user);

            Kayit(user,users);
            Giris(users);
            #endregion
        }
        static void Kayit(Kullanici u, List<Kullanici> users)
        {
            Console.WriteLine("Kayıt Kısmı");
            Console.WriteLine("Kullanıcı Adını Girin");
            u.userName = Console.ReadLine();
            Console.WriteLine("İsminizi Girin");
            u.name = Console.ReadLine();
            Console.WriteLine("Soyisminizi Girin");
            u.surName = Console.ReadLine();
            Console.WriteLine("Şifrenizi Girin");
            u.passWord = Console.ReadLine();
            Console.WriteLine("Şifrenizi Tekrar Girin");
            string rp = Console.ReadLine();
            if (u.passWord == rp)
            {
                Console.WriteLine("Kayıt Başarılı");
                users.Add(u);
            }
            else
            {
                Console.WriteLine("Hatalı Şifre");
            }
        }
        static void Giris(List<Kullanici> users)
        {
            Console.WriteLine("Giriş Kısmı");
            Console.WriteLine("Kullanıcı Adınızı Girin");
            string tempUserName = Console.ReadLine();
            Console.WriteLine("Şifrenizi Girin");
            string tempPassWord = Console.ReadLine();
            Boolean basari = false;
            foreach (Kullanici item in users)
            {
                if (item.userName == tempUserName && item.passWord == tempPassWord)
                {
                    Console.WriteLine("Giriş Başarılı");
                    basari = true;
                }
            }
            if (basari == false)
            {
                Console.WriteLine("Giriş Başarısız");
            }
        }
    }
}
