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
        Customer customer3 = new Customer("Viktor Krum", new Address("1 Durmstrang Fjord", "Durmstrang", "Northern Mountains", "Norway"));
        Customer customer4 = new Customer("Fleur Deleclour", new Address("12 Beauxbatons Court", "Paris", "Ile-de-France", "France"));
       
        // Create products with magical themes
        Product product1 = new Product("Elder Wand", "W001", 150.00m, 1);
        Product product2 = new Product("Invisibility Cloak", "W002", 200.00m, 1);
        Product product3 = new Product("Time Turner", "W003", 500.00m, 1);
        Product product4 = new Product("Nimbus 2025", "B001", 300.00m, 1);
        Product product5 = new Product("Dragonhide Gloves", "D001", 50.00m, 1);
        Product product6 = new Product("Enchanted Broomstick", "B002", 200.00m, 1);
        Product product7 = new Product("Veela Hair Wand", "V003", 85.00m, 1);
        Product product8 = new Product("Spellbook: Charms 101", "S004", 25.99m, 2);
        // Product product9 = new Product("Marauder's Map", "M001", 100);

        // Create orders with magical delivery options
        Order order1 = new Order(customer1, "Portkey");
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product4);
        order1.AddProduct(product5);

        Order order2 = new Order(customer2, "Floo Network");
        order2.AddProduct(product3);
        order2.AddProduct(product8);

        Order order3 = new Order(customer3, "Floo Network");
        order3.AddProduct(product5);
        order3.AddProduct(product6);

        Order order4 = new Order(customer4, "Owl Post");
        order4.AddProduct(product6);
        order4.AddProduct(product7);
        order4.AddProduct(product8);

        // Display orders
        List<Order> orders = new List<Order> { order1, order2, order3, order4 };
        foreach (var order in orders)
        {
            Console.WriteLine(order.GetOrderDetails());
            Console.WriteLine();
        }
    }
}