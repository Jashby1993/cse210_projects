using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int biggest = 0;
        int smallest = 99999;
        int smallest_positive = 99999;
        Console.Write("Please enter a number. When finished with your list, type 0. ");
        string user_entry = Console.ReadLine();
        int entry = int.Parse(user_entry);
        while (entry != 0)
        {
            numbers.Add(entry);
            Console.Write("Please enter another number. When finished with your list, type 0. "); 
            user_entry = Console.ReadLine();
            entry = int.Parse(user_entry);
            if (entry > biggest)
            {
                biggest = entry;
            }
            if ( entry < smallest)
            {
                smallest = entry;
            }
            if (entry < smallest_positive && entry > 0)
            {
                smallest_positive = entry;
            }   
        }
        int sum = numbers.Sum();
        double average = (double) sum / numbers.Count;
        string formatted_average = average.ToString("0.000");
        numbers.Sort();
        Console.WriteLine("The sorted list:");
        foreach (int number in numbers)
        { 
            Console.WriteLine(number);
        }
        Console.WriteLine($"Max: {biggest}.");
        Console.WriteLine($"Min: {smallest}");
        Console.WriteLine($"Smallest positive: {smallest_positive}.");
        Console.WriteLine($"Sum: {sum}");
        Console.WriteLine($"Average: {formatted_average}");
    }
}