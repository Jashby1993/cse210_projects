using System;

class Program
{
    static void Main(string[] args)
    {
        // Create an instance of the Entry class
        Entry entry = new Entry();

        // Call the DisplayEntry method to display the entry details
        entry.DisplayEntry();

        string userSelection;
        int menuChoice;
        Console.WriteLine("What would you like to do? Please enter the number of your choice: ")
        Console.WriteLine("1. Get a prompt and enter a new journal entry.");
        Console.WriteLine("2. Display the entire journal.");
        Console.WriteLine("3. Save journal to a file.");
        Console.WriteLine("4. Load a journal from a file.");
        Console.WriteLine("5. Quit");
        userSelection =Console.ReadLine();
        menuChoice = int.Parse(userSelection);

        while (menuChoice != 5)
        {
            
        }

    }
}