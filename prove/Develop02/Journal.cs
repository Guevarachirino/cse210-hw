using System;
using System.ComponentModel;
using System.IO;
public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(string newEntry)
    {
        
    }

    public void DisplayAll()
    {
        /*StreamReader sr = new StreamReader("lista.txt");
        cargarlista = sr.ReadLine();
        while (cargarlista != null)
        {
            Console.WriteLine(cargarlista);
            cargarlista = sr.ReadLine();
        }
        sr.Close();
        Console.ReadLine();


    }*/
    }

    public void SaveToFile(List<Journal> prompt)
    {
      
    }
    public void LoadFromFile(string file)
    {
        
    }
}