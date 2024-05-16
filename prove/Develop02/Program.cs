using System;

class Program
{
    static void Main(string[] args)
    {
        Journal myJournal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        int userSelection = DisplayMenu();
        int menuChoice;
        string dateTextInstance;
        string promptInstance;


        while (userSelection != 5)
        {
            if (userSelection == 1)
            {  
                promptInstance = promptGenerator.getRandomPrompt();
                DateTime currentDateTime = DateTime.Now;
                dateTextInstance = currentDateTime.ToString("H:mm:ss MMMM dd, yyyy");
                myJournal.AddEntry(promptInstance,dateTextInstance);
                userSelection = DisplayMenu();
            }
            else if (userSelection == 2)
            {
                myJournal.DisplayAll();
                userSelection = DisplayMenu();
            }
            else if (userSelection == 3)
            {
                myJournal.saveToFile();
                userSelection = DisplayMenu();
            }
            else if (userSelection == 4)
            {
                myJournal.loadFile();
                userSelection = DisplayMenu();
            }

        }
        Console.WriteLine("Thank you for journaling, see you next time!");
        
    
    
    
    
    
    
    
    
    
    
    
    int DisplayMenu()
    {
        string userSelection;
        Console.WriteLine("What would you like to do? Please enter the number of your choice:");
        Console.WriteLine("1. Get a prompt and enter a new journal entry.");
        Console.WriteLine("2. Display the entire journal.");
        Console.WriteLine("3. Save journal to a file.");
        Console.WriteLine("4. Load a journal from a file.");
        Console.WriteLine("5. Quit");
        userSelection = Console.ReadLine();
        menuChoice = int.Parse(userSelection);
        return menuChoice;
    }
    }
}

    
        
