using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");
        Product belt = new Product("Black Carabao Belt", "CB01", 25.00m, 2);
        Console.WriteLine(belt.GetTotalCost());
    }
}