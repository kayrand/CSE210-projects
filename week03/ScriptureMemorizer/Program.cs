//For exceeding the requirements, I added a library of scriptures instead of using only one scripture and the program will choose a random scripture each time it runs.

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        List<Scripture> scriptures = new List<Scripture>();

        scriptures.Add(new Scripture(
            new Reference("John", 3, 16),
            "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life."));

        scriptures.Add(new Scripture(
            new Reference("Proverbs", 3, 5, 6),
            "Trust in the Lord with all thine heart; and lean not unto thine own understanding. 6 In all thy ways acknowledge him, and he shall direct thy paths."));

        scriptures.Add(new Scripture(
            new Reference("Mosiah", 2, 17),
            "And behold, I tell you these things that ye may learn wisdom; that ye may learn that when ye are in the service of your fellow beings ye are only in the service of your God."));

        Random random = new Random();
        int index = random.Next(scriptures.Count);
        Scripture scripture = scriptures[index];

        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();

            Console.Write("Press Enter to continue or type 'quit' to finish: ");
            string input = Console.ReadLine() ?? "";

            if (input.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords(3);
        }

        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
    }
}