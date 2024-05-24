using System;
using System.Collections.Generic;

public class Manager
{
    public int _score;
    public List<Goal> goals = new List<Goal>();

    public int DisplayMenu()
    {
        Console.WriteLine("1) Display Score and Level\n2) New goal\n3) Record Event\n4) Save\n 5) Load file\n6) QUIT");
        int userChoice = int.Parse(Console.ReadLine());

        return userChoice;
    }


    public Goal CreateGoal()
    {
        Console.WriteLine("What kind of goal do you want to add?\n1)One time goal (One time completion)\n2)Step Goal (same activity multiple times)\n3)Eternal Goal (Never 'done'.)");
        int goalType = int.Parse(Console.ReadLine());
        string name;
        string description;
        int pointValue;


        switch (goalType)
        {
            
            case 1:
                Console.WriteLine("What is a simple name for your goal? ");
                name = Console.ReadLine();
                Console.WriteLine("Please give a simple but sufficiently detailed description of your goal: ");
                description = Console.ReadLine();
                Console.WriteLine("How many points is completion of this goal worth?");
                pointValue = int.Parse(Console.ReadLine());
                SimpleGoal newGoal = new SimpleGoal(name, description, pointValue);
                return newGoal;
            
            case 2:
                Console.WriteLine("What is a simple name for your goal? ");
                string name = Console.ReadLine();
                Console.WriteLine("Please give a simple but sufficiently detailed description of your goal: ");
                string description = Console.ReadLine();
                Console.WriteLine("How many points is completion of each step this goal worth?");
                int pointValue = int.Parse(Console.ReadLine());
                Console.WriteLine
            break;
        }
    
    }
    public void Run()
    {

    }
}