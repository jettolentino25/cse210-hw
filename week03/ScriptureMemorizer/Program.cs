using System;

class Program
{
    static void Main(string[] args)
    {
        // Exceeds requirements by randomly choosing from eight passages across
        // the Bible, the Book of Mormon, and the Doctrine and Covenants.
        // Each round hides only words that are still visible.
        Scripture[] library =
        {
            new Scripture(
                new Reference("Proverbs", 3, 5, 6),
                "Trust in the LORD with all thine heart; and lean not unto thine own " +
                "understanding. In all thy ways acknowledge him, and he shall direct thy paths."),
            new Scripture(
                new Reference("Psalm", 23, 1),
                "The LORD is my shepherd; I shall not want."),
            new Scripture(
                new Reference("James", 1, 5),
                "If any of you lack wisdom, let him ask of God, that giveth to all " +
                "men liberally, and upbraideth not; and it shall be given him."),
            new Scripture(
                new Reference("1 Nephi", 3, 6),
                "Therefore go, my son, and thou shalt be favored of the Lord, " +
                "because thou hast not murmured."),
            new Scripture(
                new Reference("2 Nephi", 2, 25),
                "Adam fell that men might be; and men are, that they might have joy."),
            new Scripture(
                new Reference("Mosiah (excerpt)", 2, 17),
                "When ye are in the service of your fellow beings ye are only in the service of your God."),
            new Scripture(
                new Reference("Doctrine and Covenants", 6, 36),
                "Look unto me in every thought; doubt not, fear not."),
            new Scripture(
                new Reference("Doctrine and Covenants", 18, 10),
                "Remember that the worth of souls is great in the sight of God.")
        };

        Scripture scripture = library[Random.Shared.Next(library.Length)];

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());

            if (scripture.IsCompletelyHidden())
            {
                break;
            }

            Console.WriteLine();
            Console.Write("Press Enter to hide more words or type quit to exit: ");
            string? input = Console.ReadLine();

            if (input == null ||
                input.Trim().Equals("quit", StringComparison.OrdinalIgnoreCase))
            {
                break;
            }

            if (input.Length == 0)
            {
                scripture.HideRandomWords(3);
            }
        }
    }
}