using System;
using System.Collections.Concurrent;
using System.ComponentModel;

public class Reference{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;


    public Reference(){}
    public Reference(string book, int chapter, int verse)
    {   
        _book = book;
        _chapter = chapter;
        _verse = verse;
        
    }

    public Reference(string book, int chapter, int Verse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = Verse;
        _endVerse = endVerse;
    }

    
    public void GetDisplayText()
    {
        Console.WriteLine($"Book: {_book} Chapter: {_chapter} Verse: {_verse}-{_endVerse}");
    }
}