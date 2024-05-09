using System;

class Program
{
    static void Main(string[] args)
    {
        Journal myJournal = new Journal();
        int userSelection = myJournal.DisplayMenu();

        while (userSelection != 5)
        {
            if (userSelection == 1)
            {
                myJournal.AddEntry();
                userSelection = myJournal.DisplayMenu();
            }
            else if (userSelection == 2)
            {
                myJournal.DisplayAll();
                userSelection = myJournal.DisplayMenu();
            }
            else if (userSelection == 3)
            {
                myJournal.saveToFile();
                userSelection = myJournal.DisplayMenu();
            }
            else if (userSelection == 4)
            {
                myJournal.loadFile();
                userSelection = myJournal.DisplayMenu();
            }

        }
        Console.WriteLine("Thank you for journaling, see you next time!");
        
    }
}

    
        
