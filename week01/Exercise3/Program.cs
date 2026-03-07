using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        Console.Write("What is your guess? ");
        string response = Console.ReadLine();
        int guess = int.Parse(response);

        while (guess != magicNumber)
        {
            if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }

            Console.Write("What is your guess? ");
            response = Console.ReadLine();
            guess = int.Parse(response);
        }

        Console.WriteLine("You guessed it!");
    }
}