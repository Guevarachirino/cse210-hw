using System;

public class BreathingActivity : Activity
{

    public BreathingActivity(string name, string description, int duration) : base(name, description, duration)
    {
        /*name = "Breahing Activity";
        description = " This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing";
        duration = ' ';*/
    }
    
    public void Run()
    {
        string name = GetName();
        string description = GetDescription();
        int duration = GetDuration();
        Console.WriteLine($"{name} {description} {duration}");
        
    }

}


