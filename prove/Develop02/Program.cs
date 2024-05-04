using System;

class Program
{
    static void Main(string[] args)
    {
        // Create an instance of the Entry class
        Entry entry = new Entry();

        // Call the DisplayEntry method to display the entry details
        entry.DisplayEntry();

        
        int menuChoice;
        menuChoice = DisplayMenu();
        static int DisplayMenu()
        {
            
            Console.WriteLine("What would you like to do? Please enter the number of your choice: ")
            Console.WriteLine("1. Get a prompt and enter a new journal entry.");
            Console.WriteLine("2. Display the entire journal.");
            Console.WriteLine("3. Save journal to a file.");
            Console.WriteLine("4. Load a journal from a file.");
            Console.WriteLine("5. Quit");
            string userSelection = Console.ReadLine();
            int menuChoice = int.Parse(userSelection);

            return menuChoice;
        }
        //if I add more choices, make sure to change the != menu choice to whatever is last. actually... I should make that a list, then if menuChoice < Count(menuChoices)...
        while (menuChoice != 5)
        {
            //new entry
            if (menuChoice == 1)
            {
                Journal myJournal = new Journal();
                myJournal.AddEntry();
                menuChoice = DisplayMenu();
            }
            //display journal
            else if (menuChoice == 2)
            {
                Journal myJournal = new Journal();
                myJournal.DisplayAll();
                menuChoice = DisplayMenu();
            }
            //save to file
            else if (menuChoice == 3)
            {
                Journal myJournal = new Journal();
                myJournal.saveToFile();
                menuChoice = DisplayMenu();
            }
            //load file
            else if (menuChoice == 4)
            {
                Journal myJournal = new Journal();
                myJournal.loadFile();
                menuChoice = DisplayMenu();
            }
            //quit (didn't set to 5, because if I add more choices later, the last one will always be the "else")
            else
            {

            }
        }
    }
    }