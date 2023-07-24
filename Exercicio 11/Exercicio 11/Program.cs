using System;
using Exercicio_11.Entities;
using Exercicio_11.Entities.Enums;
using System.Globalization;

namespace Exercicio_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter cliente data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime bd = DateTime.Parse(Console.ReadLine());

            Client client = new Client(name, email, bd);

            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            OrderStatus status = (OrderStatus)Enum.Parse(typeof(OrderStatus), Console.ReadLine());

            Order order = new Order(DateTime.Now, status, client);

            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine("Enter #" +i+ " item data: ");
                Console.Write("Product name: ");
                string namep= Console.ReadLine();
                Console.Write("Product price: ");
                double pricep = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                Console.Write("Quantity: ");
                int quantityp = int.Parse(Console.ReadLine());

                Product product = new Product(namep, pricep);
                OrdemItem ordemItem = new OrdemItem(quantityp, pricep, product);

                order.AddItem(ordemItem);
            }

            

            Console.WriteLine("ORDER SUMMARY:");
            Console.Write(order);




        }
    }
}