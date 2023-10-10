using System;
using System.Runtime.CompilerServices;

public class ListingActivity : Activity
{

    private int _count;
    private List<prompts> _prompts = new List<prompts>();

    public ListingActivity(string name, string description, int duration, int count, string list_prompts) : base(name, description, duration)
    {
        _count = count;
        _prompts = list_prompts;

    }

    public void Run()
    {

    }

    public void GetRandomPrompt()
    {

    }

    public string GetListFromUser()
    {
        return "";
    }
}