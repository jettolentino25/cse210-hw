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

                case "3":
                    Console.Write("Enter the filename to load: ");
                    string loadFile = Console.ReadLine() ?? "";
                    journal.LoadFromFile(loadFile);
                    Console.WriteLine("Journal loaded.");
                    break;

                case "4":
                    Console.Write("Enter the filename to save: ");
                    string saveFile = Console.ReadLine() ?? "";
                    journal.SaveToFile(saveFile);
                    Console.WriteLine("Journal saved.");
                    break;

                case "5":
                    break;

                default:
                    Console.WriteLine("Please choose an option from 1 to 5.");
                    break;
            }
        }
    }
}