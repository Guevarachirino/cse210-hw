using System;

public class ReflectingActivity : Activity
{
    
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();

    public ReflectingActivity(string name, string description, int duration) : base(name, description, duration )
    {
        name = "Reflection";
        description = "";
        
    }

    public void Run()
    {
    
    }

    public string GetRandomPrompt()
    {

        //funcion para el random prompt. 
        Random rnd_prompt = new Random();
        string[] prompts =
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless.",
        };

        int mIndex = rnd_prompt.Next(prompts.Length);
        Console.WriteLine("{0}", prompts[mIndex]);
        return prompts[mIndex];
        

    }

    public string GetRandomQuestion()
    {
        //funcion para el random prompt. 
        Random rnd_question = new Random();
        string[] questions =
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?",
        };

        int rQuestion = rnd_question.Next(questions.Length);
        Console.WriteLine("{0}", questions[rQuestion]);
        string text = $"{questions[rQuestion]}";
        _prompts.Append(text);

        return questions[rQuestion];
    }

    public void DisplayPrompt()
    {
        
       
        Console.WriteLine($"{_prompts}");
    }

    public void DisplayQuestions()
    {
        Console.WriteLine($"{_questions}");
    }
}