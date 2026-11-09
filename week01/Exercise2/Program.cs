using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        int percentage = int.Parse(Console.ReadLine());
        if (percentage >= 90)
        {
            Console.WriteLine("A");
        }
        else if (percentage >= 80)
        {
            Console.WriteLine("B");
        }
        else if (percentage >= 70)
        {
            Console.WriteLine("C");
        }
        else if (percentage >= 60)
        {
            Console.WriteLine("D");
        }
        else
        {
            Console.WriteLine("F");
        }
    }
}