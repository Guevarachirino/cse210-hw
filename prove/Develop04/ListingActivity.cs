using System;
using System.Runtime.CompilerServices;

public class ListingActivity : Activity
{

    private int _count;
    private List<string> _prompts = new List<string>();

    private List<string> _answerList = new List<string>();

    public ListingActivity(string name, string description, int duration, int count, string prompt) : base(name, description, duration)
    {
        _count = count;
       // _prompts = prompt;

    }

    public void Run()
    {
        int _count = GetDuration(); 
        string _prompts = GetListFromUser();

    }

    public string GetRandomPrompt()
    {
        //funcion para el random question. 
        Random rnd = new Random();
        string[] prompts =
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?",
        };

        int mIndex = rnd.Next(prompts.Length);
        Console.WriteLine("{0}", prompts[mIndex]);
        return prompts[mIndex];

    }

    public string GetListFromUser()
    {
        string usuario_answer = Console.ReadLine();
        _answerList.Add(usuario_answer);

        return usuario_answer;
    }
}