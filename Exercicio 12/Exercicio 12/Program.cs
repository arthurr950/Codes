using Exercicio_12.Entities;
using System.Globalization;

namespace Exercicio_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            List<Product> list = new List<Product>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Product #" +i+ " data: ");
                Console.Write("Common, used or imported (c/u/i)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                if (ch == 'i')
                {
                    Console.Write("Customs fee: ");
                    double cf = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new ImportedProduct(name, price, cf));
                }
                else if (ch == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime md = DateTime.Parse(Console.ReadLine());
                    list.Add(new UsedProduct(name, price, md));
                }
                else
                {
                    list.Add(new Product(name, price));
                }
            }

                Console.WriteLine();
                Console.WriteLine("PRICE TAGS:");
                foreach(Product p in list)
                {
                    Console.WriteLine(p.PriceTag());
                }
        }
    }
}