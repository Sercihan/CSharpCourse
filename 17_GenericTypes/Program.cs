using System.Reflection.Metadata;

namespace _17_GenericTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product() { Id = 1, Name = "Elma", Price = 1000, Stock = 100 };
            Product.Insert(product);

            Category category = new Category() { Id = 1, Name = "Meyve", Description = "sebze - meyve" };
            Category.Insert(category);
        }
    }
}
