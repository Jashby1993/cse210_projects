using System;
using System.ComponentModel;
using System.Reflection.PortableExecutable;

class Program
{
    static void Main(string[] args)
    {
        bool victory = false;
        bool keep_playing = true;
        Random randomGenerator = new Random();
        int the_number = randomGenerator.Next(1, 101);
        int guess = 0;
        int guesses = 0;
        while (keep_playing == true)
        {
            while (!victory )
            {
                Console.Write("What is your guess? ");
                string guess_answer = Console.ReadLine();
                guess = int.Parse(guess_answer);
                if (guess > the_number)
                {
                    guesses += 1;
                    Console.WriteLine("Guess Lower");
                }
                else if (guess < the_number)
                {
                    guesses += 1;
                    Console.WriteLine("Guess Higher");
                }
                else{
                    victory = true;
                    Console.WriteLine("You guessed it, you win!");
                    if (guesses == 1)
                    {
                        Console.WriteLine($"Amazing, you got it on the first try!");
                    }
                    else
                    {
                        Console.WriteLine($"You got the answer in {guesses} attempts.");
                    }
                Console.Write("Would you like to play again? Type 'yes' or 'no'");
                string keep_playing_answer = Console.ReadLine();
                if (keep_playing_answer == "no")
                {
                    keep_playing = false;
                    Console.WriteLine("Thanks for playing");
                    break;
                }
                else if (keep_playing_answer == "yes")
                {
                    Console.WriteLine("Ok, let's play again");
                    victory = false;
                    guesses = 0;
                    the_number = randomGenerator.Next(1, 101);
                }
            }
            }    
            }
    }
}