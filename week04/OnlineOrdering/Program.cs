using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "Phoenix", "Arizona", "USA");
        Customer customer1 = new Customer("John Smith", address1);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", "P100", 800.00, 1));
        order1.AddProduct(new Product("Mouse", "P101", 25.00, 2));
        order1.AddProduct(new Product("Keyboard", "P102", 45.00, 1));

        Address address2 = new Address("456 King Road", "Toronto", "Ontario", "Canada");
        Customer customer2 = new Customer("Emily Davis", address2);

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Notebook", "P200", 3.50, 5));
        order2.AddProduct(new Product("Pen Pack", "P201", 6.00, 2));
        order2.AddProduct(new Product("Backpack", "P202", 40.00, 1));

        Console.WriteLine("Order 1");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine("Total Price: $" + order1.GetTotalCost());
        Console.WriteLine();

        Console.WriteLine("------------------------------");
        Console.WriteLine();

        Console.WriteLine("Order 2");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine("Total Price: $" + order2.GetTotalCost());
    }
}