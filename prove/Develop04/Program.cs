using System;

class Program
{
    static void Main(string[] args)
    {
        Activity activity = new Activity();
        activity.ShowPauseAnimation(15);



        
    }










static int DisplayMenu()
{
    Console.WriteLine("Which mindfulness activity would you like to do now?\n1) Guided Breathing Exercise\n2)Guided reflection\n3)Positivity listing\n4)Quit");
    int userChoice = int.Parse(Console.ReadLine());
    return userChoice;
}
}