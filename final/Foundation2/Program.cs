using System;
using System.Collections.Generic;

namespace Foundation2 {
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer("John Smith", new Address("123 April St", "New York", "New York", "USA"));
            Customer customer2 = new Customer("Jane Doe", new Address("456 May St", "London", "England", "UK"));

            List<Product> products1 = new List<Product> {new Product("Yo-yo", 15, 12.99, 1), new Product("Tennis Ball", 12, 3.99, 5)};
            List<Product> products2 = new List<Product> {new Product("Dino Figure", 24, 15.99, 2), new Product("Uno", 35, 18.99, 1)};

            Order order1 = new Order(customer1, products1);
            Order order2 = new Order(customer2, products2);

            Console.WriteLine("Order 1: ");
            Console.WriteLine(order1.CalculatePrice());
            Console.WriteLine(order1.GetPackingLabel());
            Console.WriteLine(order1.GetShippingLabel());

            Console.WriteLine("\nOrder 2: ");
            Console.WriteLine(order2.CalculatePrice());
            Console.WriteLine(order2.GetPackingLabel());
            Console.WriteLine(order2.GetShippingLabel());
        }
    }
}