using System;
// Creativity: The Reflecting Activity picks questions in random order.
// It uses every question once before starting a new round.

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflecting Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    new BreathingActivity().Run();
                    break;
                case "2":
                    new ReflectingActivity().Run();
                    break;
                case "3":
                    new ListingActivity().Run();
                    break;
                case "4":
                case null:
                    return;
                default:
                    Console.WriteLine("Please enter a number from 1 to 4.");
                    break;
            }
        }
    }
}