using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the OnlineOrdering Project.");
        Console.WriteLine("Welcome to Caitlin's Magical Online Ordering System!\n");

        // Welcome message
        Console.WriteLine("Welcome to the Magical Ordering System!\n");

        // Create customers with magical addresses
        Customer customer1 = new Customer("Albus the Wise", new Address("4 Wandmaker's Way", "Hogsmeade", "Scottish Highlands", "UK"));
        Customer customer2 = new Customer("Viktor the Bold", new Address("1 Durmstrang Fjord", "Durmstrang", "Northern Mountains", "Norway"));
        Customer customer3 = new Customer("Fleur the Elegant", new Address("12 Beauxbatons Court", "Paris", "Ile-de-France", "France"));

        // Create orders
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Phoenix Feather Wand", "W001", 75.50m, 1));
        order1.AddProduct(new Product("Potion Ingredients Kit", "P002", 45.99m, 2));

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Dragonhide Gloves", "D001", 50.00m, 1));
        order2.AddProduct(new Product("Enchanted Broomstick", "B002", 300.00m, 1));

        Order order3 = new Order(customer3);
        order3.AddProduct(new Product("Veela Hair Wand", "V003", 85.00m, 1));
        order3.AddProduct(new Product("Spellbook: Charms 101", "S004", 25.99m, 2));

        // Store orders in a list
        List<Order> orders = new List<Order> { order1, order2, order3 };

        // Display order details
        foreach (var order in orders)
        {
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine($"Total Cost: {order.CalculateTotalCost():C}\n");
            Console.WriteLine(new string('-', 40));
        }
    }
}