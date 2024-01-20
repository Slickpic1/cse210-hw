using System;
using System.Globalization;

class Program
{
    static void GuessingGame(int number, int tries, bool win)
    {
        // Define Variables
        int guess;

        // Loop Guessing Game
        do
        {
            // Ask User for Random Number
            Console.Write($"What is the magic number? ");
            guess = int.Parse(Console.ReadLine());

            if (guess == number)
            {
                Console.WriteLine($"You guessed it!");
                Console.WriteLine($"This game took {tries} guesses. ");
                win = true;
            }
            else if (guess > number)
            {
                tries += 1;
                Console.WriteLine($"Lower");
            }
            else
            {
                tries += 1;
                Console.WriteLine($"Higher");
            }
        } while (!win);

        return;
    }
    
    
    
    
    static void Main(string[] args)
    {
        // Define Variables
        int tries = 0;
        bool win = false;
        bool playAgain = true;

        // Run Guessing Game
        do
        {
            // Define a Random Number
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(1,101);

            // Run Actual game
            GuessingGame(number,tries,win);

            // See if player wants to play again
            Console.Write($"Play again? (y/n): ");
            string reply = Console.ReadLine();
            if (reply == "y")
            {
                Console.WriteLine($"==================");
                playAgain = true;
            }
            else
            {
                playAgain = false;
            }

        } while (playAgain);
        
    }
}