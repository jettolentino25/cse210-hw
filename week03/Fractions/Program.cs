using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction first = new Fraction();
        Fraction second = new Fraction(6);
        Fraction third = new Fraction(6, 7);

        Console.WriteLine("Created three fractions.");
    }
}