//not a lot of error handling, but many attempts are made to prevent the user from overwriting their previous save file, if there is one.
using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Journal myJournal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        string returnUser;
        string fileName;
        Console.Write("Do you already have a journal file saved in this program? Please type Y or N: ");
        returnUser = Console.ReadLine();
        if (returnUser == "Y")
        {
            Console.Write("What is the filename? Make sure to include .txt at the end! Then make sure to use the LOAD FILE option before doing anything else!");
            

        }
        else if (returnUser == "N")
        {
            Console.Write("Please create a filename to save this journal. Make sure to include '.txt' at the end!");
            
        }
        fileName = Console.ReadLine();
        
        int userSelection = DisplayMenu();
        int menuChoice;
        string dateTextInstance;
        string promptInstance;
        


        while (userSelection != 5)
        {
            if (userSelection == 2)
            {  
                promptInstance = promptGenerator.getRandomPrompt();
                DateTime currentDateTime = DateTime.Now;
                dateTextInstance = currentDateTime.ToString("H:mm:ss MMMM dd, yyyy");
                myJournal.AddEntry(promptInstance,dateTextInstance);
                Console.WriteLine("Entry added!");
                userSelection = DisplayMenu();
            }
            else if (userSelection == 3)
            {
                myJournal.DisplayAll();
                userSelection = DisplayMenu();
            }
            else if (userSelection == 4)
            {
                Console.WriteLine("If this ISN'T the first time saving entries, and you DIDN'T load the file first, this will rewrite the file.\n Please enter 1 to continue, 2 to load the file, or 3 to display the menu again.");
                string verifySelection = Console.ReadLine();
                int justToBeSure = int.Parse(verifySelection);
                if (justToBeSure == 1)
                {
                    myJournal.saveToFile(fileName);
                    userSelection = DisplayMenu();
                    Console.WriteLine($"Entry saved to {fileName}!");
                }
                else if (justToBeSure == 2)
                {
                 myJournal.loadFile(fileName);
                userSelection = DisplayMenu();   
                }
                else
                {
                    userSelection = DisplayMenu();
                }
            }
            else if (userSelection == 1)
            {

                myJournal.loadFile(fileName);
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

    
        
