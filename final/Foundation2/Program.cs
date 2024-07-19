using System;

class Program
{
    static void Main(string[] args)
    {

        Address address1 = new Address("563 Vista Bonita Dr.", "Pecos", "TX", "USA");
        Address address2 = new Address("327 Coin Ave.", "Geelong", "Victoria", "Australia");

        Customer customer1 = new Customer("James Blanco", address1);
        Customer customer2 = new Customer("Melissa Willmer", address2);

        Product product1 = new Product("Stapler", 550, 11.5, 3);
        Product product2 = new Product("Red Pen", 283, 1.3, 10);
        Product product3 = new Product("Eraser", 303, 1.2, 5);
        Product product4 = new Product("Notepad", 179, 6.8, 2);

        Order order1 = new Order();
        order1.AddCustomer(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order();
        order2.AddCustomer(customer2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);


        Console.WriteLine("Order 1:");
        Console.WriteLine(order1.PackingLabel());
        Console.WriteLine(order1.ShippingLabel());
        Console.WriteLine($"Total: ${order1.CalculateOrderTotal()}");
        Console.WriteLine();

        Console.WriteLine("Order 2:");
        Console.WriteLine(order2.PackingLabel());
        Console.WriteLine(order2.ShippingLabel());
        Console.WriteLine($"Total: ${order2.CalculateOrderTotal()}");
        Console.WriteLine();
    }
}