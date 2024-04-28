using System;
using System.Globalization;

class Program
{
    static void DisplayMessage()
    {
        Console.WriteLine("Welcome to the program!");
    }
    static string get_name()
    {   
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }
    static int get_number()
    {
        Console.Write("Please enter your favorite number: ");
        string entry = Console.ReadLine();
        int number = int.Parse(entry);
        return number;
    }

    static void Main(string[] args)
    {
        DisplayMessage();
        string name = get_name();
        int number = get_number();
        int squared = number * number;
        Console.WriteLine($"{name}, your favorite number ({number}) squared is {squared}.");
    }
}