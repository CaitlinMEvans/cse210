// ADDED CREATIVITY: Added a magial currency conversion to real money (Galleon, sickle, knut to USD)
// and a magical delivery system to deliver the items to the wizard's house 
// (owl post = standard, floo powder = express and portkey = instant)

using System;
using System.Collections.Generic;

// Main Program
class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the OnlineOrdering Project.");
        Console.WriteLine("Welcome to the Magical Online Ordering Program!");

        // Create customers with magical addresses
        Customer customer1 = new Customer("Harry Potter", new Address("4 Privet Drive", "Little Whinging", "Surrey", "UK"));
        Customer customer2 = new Customer("Hermione Granger", new Address("Hogwarts School of Witchcraft and Wizardry", "Hogsmeade", "Scotland", "UK"));

        // Create products with magical themes
        Product product1 = new Product("Elder Wand", "W001", 150.00m, 1);
        Product product2 = new Product("Invisibility Cloak", "W002", 200.00m, 1);
        Product product3 = new Product("Time Turner", "W003", 500.00m, 1);
        Product product4 = new Product("Nimbus 2025", "B001", 300.00m, 1);

        // Create orders with magical delivery options
        Order order1 = new Order(customer1, "Owl Post");
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2, "Floo Network");
        order2.AddProduct(product3);
        order2.AddProduct(product4);

        // Display orders
        List<Order> orders = new List<Order> { order1, order2 };
        foreach (var order in orders)
        {
            Console.WriteLine(order.GetOrderDetails());
            Console.WriteLine();
        }
    }
}