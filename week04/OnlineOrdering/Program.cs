using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        // Addresses
        Address address1 = new Address("1042 NU14 Mdantsane", "East London", "Eastern Cape", "South Africa");
        Address address2 = new Address("111 Pretville Flats", "Pretoria", "Gauteng", "South Africa");

        // Customers
        Customer customer1 = new Customer("Lisakhanya Masiza", address1);
        Customer customer2 = new Customer("Pumzile Gasa", address2);

        // Products
        Product prod1 = new Product("Gold Spoon", 1552, 13.79f, 8);
        Product prod2 = new Product("6m Curtains", 0073, 673.09f, 2);
        Product prod3 = new Product("Mouse Pad", 1093, 63.99f, 1);

        // Order 1
        Order order1 = new Order(customer1);
        order1.AddProduct(prod1);
        order1.AddProduct(prod3);

        // Order 2
        Order order2 = new Order(customer2);
        order2.AddProduct(prod2);

        List<Order> orders = new List<Order> { order1, order2 };

        foreach (Order order in orders)
        {
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine($"Total Price: ${order.GetTotalCost()}");
            Console.WriteLine(new string('-', 40));

        }
    }
}