using System;
using Microsoft.VisualBasic;

class ReflectingActivity : Activity
{
    List<string> prompts = new List<string>();
    List<string>questions = new List<String>();

    public ReflectingActivity()
    {

    }
    public void Run()
    {

    }

    public string GetRandomPrompt( List<string> prompts)
    {
        Random random = new Random();
        int randomPrompt = random.Next(0,prompts.Count);
        string mindfulnessPrompt = prompts[randomPrompt];
        return mindfulnessPrompt;
    }
    public void DisplayPrompt(string prompt)
    {
        int consoleWidth = Console.WindowWidth;
        int promptCharacters = prompt.Length;
        string fillRow = new string ('-', consoleWidth);
        string fillSide = new string('-', ((consoleWidth - promptCharacters)/2));
        Console.WriteLine(fillRow);
        Console.WriteLine($"{fillSide}{prompt}{fillSide}");
        Console.WriteLine(fillRow);       
    }
     public string GetRandomQuestion( List<string> questions)
    {
        Random random = new Random();
        int randomQuestion = random.Next(0,questions.Count);
        string mindfulnessQuestion = questions[randomQuestion];
        return mindfulnessQuestion;
    }
    public void DisplayQuestion(string question)
    {
              
    }
}