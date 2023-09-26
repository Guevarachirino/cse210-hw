using System;
using Microsoft.VisualBasic;

public class PromptGenerator
{
    public List<PromptGenerator> _prompts = new List<PromptGenerator>();

    public string GetRandomPrompt()
    {
        //funcion para el random question. 
        Random rnd = new Random();
        string[] prompts =
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
        };

        int mIndex = rnd.Next(prompts.Length);
        Console.WriteLine("{0}", prompts[mIndex]);
        return prompts[mIndex];
    }

}
