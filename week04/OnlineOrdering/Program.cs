using System;

class Program
{
    static void Main(string[] args)
    {
        Product belt = new Product("Black Carabao Belt", "CB01", 25.00m, 2);
        Product tanBelt = new Product("Light Tan Marbled Carabao Belt", "CB02", 30.00m, 1);

        Address address = new Address("123 Maple Street", "Boise", "Idaho", "USA");
        Customer customer = new Customer("Alex Reyes", address);
        Order order = new Order(customer);

        order.AddProduct(belt);
        order.AddProduct(tanBelt);

        Console.WriteLine("Packing label");
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine();

        Console.WriteLine("Shipping label");
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine();

        Console.WriteLine($"Total (USD): ${order.GetTotalCost():F2}");
        Console.WriteLine();
        Console.WriteLine("Order 2 - Philippines");

        Product brownBelt = new Product("Carved Dark Brown Carabao Belt", "CB03", 28.00m, 1);
        Product marbledBelt = new Product("Black-and-White Marbled Carabao Belt", "CB04", 32.00m, 2);

        Address philippinesAddress = new Address("456 Mabini Street", "Cebu City", "Cebu", "Philippines");
        Customer secondCustomer = new Customer("Sam Rivera", philippinesAddress);
        Order secondOrder = new Order(secondCustomer);

        secondOrder.AddProduct(brownBelt);
        secondOrder.AddProduct(marbledBelt);

        Console.WriteLine("Packing label");
        Console.WriteLine(secondOrder.GetPackingLabel());
        Console.WriteLine();

        Console.WriteLine("Shipping label");
        Console.WriteLine(secondOrder.GetShippingLabel());
        Console.WriteLine();

        Console.WriteLine($"Total (USD): ${secondOrder.GetTotalCost():F2}");
    }
}