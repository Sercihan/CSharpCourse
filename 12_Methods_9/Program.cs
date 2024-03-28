namespace _12_Methods_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyForm();
        }

        static int sayac = 0;
        static void MyForm()
        {
            Console.WriteLine(sayac);//ilk önce sıfır ile başladık
            sayac++;
            if (sayac < 10)//if ile şart yazarak şart sağlanmazsa işlem sonlandırılacak
            {
                MyForm();
            }

        }
    }
}
