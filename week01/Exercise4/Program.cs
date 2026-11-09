using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int number;
        do
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());

            if (number != 0)
            {
                numbers.Add(number);
            }
        } while (number != 0);
        int sum = 0;
        foreach (int entry in numbers)
        {
            sum += entry;
        }

        Console.WriteLine($"The sum is: {sum}");
        if (numbers.Count > 0)
        {
            double average = (double)sum / numbers.Count;
            Console.WriteLine($"The average is: {average}");
            int largest = numbers[0];
            foreach (int entry in numbers)
            {
                if (entry > largest)
                {
                    largest = entry;
                }
            }

            Console.WriteLine($"The largest number is: {largest}");
        }
    }
}