using System;

public class Entry
{

    public string _date;
    public string _promptText;
    public string _entryText;
    // llamando la clase promptgenerator para obtener las preguntas 
    PromptGenerator generator = new PromptGenerator();
                        
    public Entry(){}
    public Entry(string date, string prompt, string entry)
    {
        _date = date;
        _promptText = prompt;
        _entryText = entry;
    }

    public void Display()
    {
        Console.WriteLine($"Date: {_date}\nPrompt: {_promptText}\n Entry: {_entryText}\n");
    }
        //escribiendo en el txt file. 
    public void Write()
    {
        _promptText = generator.GetRandomPrompt();
        _entryText = Console.ReadLine();
        _date = DateTime.Now.ToString();
    }
}

