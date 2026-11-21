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
        Fraction fourth = new Fraction(1, 3);
        Console.WriteLine(first.GetFractionString());
        Console.WriteLine(first.GetDecimalValue());
        Console.WriteLine(second.GetFractionString());
        Console.WriteLine(second.GetDecimalValue());
        Console.WriteLine(third.GetFractionString());
        Console.WriteLine(third.GetDecimalValue());
        Console.WriteLine(fourth.GetFractionString());
        Console.WriteLine(fourth.GetDecimalValue());
    }
}