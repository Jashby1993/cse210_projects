using System;
using Microsoft.VisualBasic;

class ReflectingActivity : Activity
{
    List<string> prompts = new List<string>();
    List<string>questions = new List<String>();

    public ReflectingActivity()
    {
        _name = "Reflection";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";

    }
    public void Run()
    {
        populatePromptList(prompts);
        populateQuestionList(questions);
       _duration = DisplayStartingMessage();
       ;       string prompt = GetRandomPrompt(prompts);
       DisplayPrompt(prompt);
       
       ShowPauseAnimation(10);
       DateTime now = DateTime.Now;
       DateTime end = now.AddSeconds(_duration);
       while (now < end)
       {
        string question = GetRandomQuestion(questions);
        DisplayQuestion(question);
        now=DateTime.Now;
       }

    DisplayEndingMessage();

    }

    private string GetRandomPrompt( List<string> prompts)
    {
        Random random = new Random();
        int randomPrompt = random.Next(0,prompts.Count);
        string mindfulnessPrompt = prompts[randomPrompt];
        return mindfulnessPrompt;
    }
    private void DisplayPrompt(string prompt)
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
        Console.WriteLine($"\n{question}\n");
        ShowPauseAnimation(5);              
    }

    private void populatePromptList(List<string>prompts)
    {
        string[] lines = File.ReadAllLines("reflecting_activity_prompts.txt");
        foreach (string line in lines)
        {
            prompts.Add(line);

        }      

    }

    private void populateQuestionList(List<string>questions)
    {
        string[] lines = File.ReadAllLines("reflection_questions.txt");
        foreach (string line in lines)
        {
            questions.Add(line);

        } 

    }
}