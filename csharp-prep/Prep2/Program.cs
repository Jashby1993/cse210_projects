using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What was your score? (Please round to nearest percentile. For example, 92.8% would be input 93). ");
        string score = Console.ReadLine();
        char secondDigitChar = score[1];
        int percentage = int.Parse(score);
        string letter = "";
        string suffix = "";
        string adjective = "a";
        int determiner = (int)Char.GetNumericValue(secondDigitChar);
        if (percentage >= 90)
        {
            letter = "A";
        }
        else if (percentage >= 80 && percentage < 90)
        {
            letter = "B";
        }
        else if (percentage >= 70 && percentage < 80)
        {
            letter = "C";
        }
        else if (percentage >= 60 && percentage < 70)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        if (determiner <= 3 && letter != "F")
        {
            suffix = "-";
        }
        else if (determiner >= 7 && letter != "A" && letter != "F")
        {
            suffix = "+" ;
        }
        if (letter == "A" || letter == "F")
        {
            adjective = "an";
        }
        Console.WriteLine($"You got {adjective} {letter}{suffix}.");
        if (percentage >= 70)
        {
            Console.WriteLine("You've passed the class!");
        }
        else
        {
            Console.WriteLine("You have failed this class. Consider speaking to your mentor to see what assistance is available.");
        }
        
    }
}