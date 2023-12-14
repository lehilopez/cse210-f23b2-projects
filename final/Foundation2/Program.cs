using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("Main 123", "Provo", "Utah", "USA");
        Address address2 = new Address("Nacional 123", "Monterrey", "Nuevo Leon", "Mexico");

        Customer customer1 = new Customer("Lehi", address1);
        Customer customer2 = new Customer("Lopez", address2);

        Product product1 = new Product("Book", "P01", 5.50, 2);
        Product product2 = new Product("Toy", "P02", 2.50, 4);
        Product product3 = new Product("Videogame", "P03", 50.00, 3);
        Product product4 = new Product("Cards", "P04", 2.00, 10);
        Product product5 = new Product("Lego", "P05", 20.00, 5);

        
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        Order order2 = new Order(customer2);
        order2.AddProduct(product4);
        order2.AddProduct(product5);
        
        Console.WriteLine("Order 1 Packing label:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine("Order 1 Shipping label:");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine();
        Console.WriteLine($"Order 1 Cost: = {order1.CalculateTotalCost()}");

        Console.WriteLine();
        Console.WriteLine("Order 2 Packing label:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine("Order 1 Shipping label:");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine();
        Console.WriteLine($"Order 2 Cost = {order2.CalculateTotalCost()}");
    }
}