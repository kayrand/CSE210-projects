  //Enhancement: I added a counter to keep track of how many activities the user completes during one session.

using System;

class Program
{
    static void Main(string[] args)
    {

        bool quit = false;
        int completedActivities = 0;

        while (!quit)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflection activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");

            string choice = Console.ReadLine() ?? "";

            if (choice == "1")
            {
                BreathingActivity activity = new BreathingActivity();
                activity.Run();
                completedActivities++;
            }
            else if (choice == "2")
            {
                ReflectionActivity activity = new ReflectionActivity();
                activity.Run();
                completedActivities++;
            }
            else if (choice == "3")
            {
                ListingActivity activity = new ListingActivity();
                activity.Run();
                completedActivities++;
            }
            else if (choice == "4")
            {
                quit = true;
            }
        }

        Console.Clear();
        Console.WriteLine("You completed " + completedActivities + " activities during this session.");
        Console.WriteLine("Goodbye!");
    }
}