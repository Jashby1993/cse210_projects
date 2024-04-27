using System;
using System.ComponentModel;
using System.Reflection.PortableExecutable;

class Program
{
    static void Main(string[] args)
    {
        bool victory = false;
        Random randomGenerator = new Random();
        int the_number = randomGenerator.Next(1, 101);
        int guess = 0;
        while (!victory )
        {
            Console.Write("What is your guess? ");
            string guess_answer = Console.ReadLine();
            guess = int.Parse(guess_answer);
            if (guess > the_number)
            {
                Console.WriteLine("Guess Lower");
            }
            else if (guess < the_number)
            {
                Console.WriteLine("Guess Higher");
            }
            else{
                victory = true;
                Console.WriteLine("You guessed it, you win!");
            }
        }
    }
}