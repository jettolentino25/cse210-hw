using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        string choice = "";

        while (choice != "5")
        {
            Console.WriteLine();
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("5. Quit");
            Console.Write("Choose an option: ");

            choice = Console.ReadLine() ?? "5";

            switch (choice)
            {
                case "1":
                    string prompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine(prompt);
                    Console.Write("> ");

                    string response = Console.ReadLine() ?? "";
                    string date = DateTime.Now.ToShortDateString();

                    Entry entry = new Entry(date, prompt, response);
                    journal.AddEntry(entry);
                    break;

                case "2":
                    journal.DisplayAll();
                    break;

                case "5":
                    break;

                default:
                    Console.WriteLine("Please choose 1, 2, or 5.");
                    break;
            }
        }
    }
}