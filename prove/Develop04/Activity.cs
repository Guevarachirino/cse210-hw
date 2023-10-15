using System;

public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;

    }

    public string GetName()
    {
        return _name;
    }

    public string GetDescription()
    {
        return _description;
    }
     public int GetDuration()
     {
        return _duration;
     }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"welcome to the {_name}");

    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("You have done a good job");
    }

    public void ShowSpinner(int seconds)
    {
        
    }
    public void ShowCountDown(int seconds)
    {
        _duration = seconds;

    }

}


