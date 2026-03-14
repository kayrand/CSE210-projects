// Enhancement: I added a cancel option for saving and loading so the user can return to the menu if they choose the wrong option.

using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        int choice = 0;

        while (choice != 5)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("Select a choice from the menu: ");

            string input = Console.ReadLine();
            choice = int.Parse(input);

            if (choice == 1)
            {
                string prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine();
                Console.WriteLine($"Prompt: {prompt}");
                Console.Write("> ");
                string response = Console.ReadLine();

                string date = DateTime.Now.ToShortDateString();

                Entry newEntry = new Entry();
                newEntry._date = date;
                newEntry._promptText = prompt;
                newEntry._entryText = response;

                journal.AddEntry(newEntry);

                Console.WriteLine("Entry added.");
            }
            else if (choice == 2)
            {
                journal.DisplayAll();
            }
            else if (choice == 3)
            {
                Console.Write("Enter filename to load (or type 0 to cancel): ");
                string fileName = Console.ReadLine();

                if (fileName == "0")
                {
                    Console.WriteLine("Returning to menu...");
                }
                else
                {
                    journal.LoadFromFile(fileName);
                }
            }
            else if (choice == 4)
            {
                Console.Write("Enter filename to save (or type 0 to cancel): ");
                string fileName = Console.ReadLine();

                if (fileName == "0")
                {
                    Console.WriteLine("Returning to menu...");
                }
                else
                {
                    journal.SaveToFile(fileName);
                }
            }
            else if (choice == 5)
            {
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid option. Returning to menu.");
            }

            Console.WriteLine();
        }
    }
}