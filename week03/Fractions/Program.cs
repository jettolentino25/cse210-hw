using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction first = new Fraction();
        Fraction second = new Fraction(6);
        Fraction third = new Fraction(6, 7);

        third.SetTop(3);
        third.SetBottom(4);
        Console.WriteLine(third.GetTop());
        Console.WriteLine(third.GetBottom());
    }
}