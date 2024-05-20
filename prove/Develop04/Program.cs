// stretch functions: After every activity, the user is asked if they want to make a mindfulness journal entry, and in the menu, they can read that journal
using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        
        bool exit = false;

        while (!exit)
        {
            Console.Clear();
            int userChoice = DisplayMenu();
            Console.WriteLine("And how long would you like to do this activity? (Enter whole number of SECONDS)");
            int duration = int.Parse(Console.ReadLine());


            switch (userChoice)
            {
                //breathing exercise
                case 1:
                    BreathingActivity breathingActivity = new BreathingActivity();
                    breathingActivity.Run();
                    break;

                //listing exercise
                case 2:
                    ListingActivity listingActivity = new ListingActivity();
                    listingActivity.Run();
                    break;

                case 3:
                    ReflectingActivity reflectingActivity = new ReflectingActivity();
                    reflectingActivity.Run();
                    break;
                
                case 4:
                    List<string> entries = readJournal();
                    foreach (string line in entries)
                    {
                        Console.WriteLine(line);
                    }
                    Console.Write("Hit enter when done reading to go back to menu.");
                    Console.ReadLine();
                    break;

                case 5:
                    Console.WriteLine(" ");
                    exit = true;
                    break;

            }

        }




        
    }










    static int DisplayMenu()
    {
        Console.WriteLine("Which mindfulness activity would you like to do now?\n1) Guided Breathing Exercise\n2)Guided reflection\n3)Positivity listing\n4)Review Mindfulness Journal\n5)QUIT");
        int userChoice = int.Parse(Console.ReadLine());
        return userChoice;
    }
    public static List<string> readJournal()
    {
        List<string> entries = new List<string>();

        string[] lines = File.ReadAllLines("mindfulnessjournal.txt");
        foreach (string line in lines)
        {
            entries.Add(line);

        }      
        return entries;
    }
}