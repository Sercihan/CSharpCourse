namespace _16_OOP_6_Polymorphism_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Daire d = new Daire(5);
            Console.WriteLine(d.Alan());

            DikDortgen dik = new DikDortgen(3, 4);
            Console.WriteLine(dik.Alan());
        }
    }
    public class Sekil
    {
        public const double PI = Math.PI;

        protected double x;
        protected double y;

        public Sekil(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public virtual double Alan()
        {
            return x * y;
        }
    }

    public class Daire : Sekil
    {
        public Daire(double r) : base(r, 0)
        {

        }

        public override double Alan()
        {
            return PI * x * x;
        }
    }

    public class Kure : Sekil
    {
        public Kure(double r) : base(r, 0)
        {

        }

        public override double Alan()
        {
            return 4 * PI * x * x;
        }
    }

    public class DikDortgen : Sekil
    {
        public DikDortgen(double a, double b) : base(a, b)
        {

        }
    }
}
