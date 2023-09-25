using System;
using System.ComponentModel;
using System.IO;
public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry()
    {
        Entry entry = new Entry();
        entry.Write();
        _entries.Add(entry);
        
    }

    public void DisplayAll()
    {
        foreach(Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile()
    {
        // prompt user for the file name
        using (StreamWriter sw = new StreamWriter("lista.txt", true))
        {
            foreach(Entry entry in _entries)
            {
                sw.WriteLine(entry._date);
                sw.WriteLine(entry._promptText);
                sw.WriteLine(entry._entryText);
            }
        }
      
    }
    public void LoadFromFile()
    {
        // prompt the user for the file name
        string path = "lista.txt";
        string[] lines = File.ReadAllLines(path);

        for(int x = 0; x < lines.Length; x+=3)
        {
            string date = lines[x];
            string prompt = lines[x + 1];
            string entryString = lines[x + 2];
            Entry entry = new Entry(date, prompt, entryString);
            _entries.Add(entry);

        }
    }
}