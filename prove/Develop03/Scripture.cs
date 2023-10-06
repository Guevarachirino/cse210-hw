using System;
using System.Runtime.CompilerServices;

public class Scripture{

    private Reference _reference;  
    private List<Word> _words = new List<Word>();

    //calling class reference
    Reference reference = new Reference();
    public Scripture( Reference reference, string text)
    {
        
        _reference = reference;
        string[] words = text.Split(' ');

        foreach (var word in words)
        {
            Word wordone = new Word(word);
            _words.Add(wordone);

        }

       

    }

    public void HideRandomWords(int numberToHide)
    {

    }

    public void GetDisplayText()
    {
        //isplay the reference and text of the scripture
        Console.WriteLine(reference);
        string[] words = _words.Split(' ');
        
    }

    /*public bool IsCompletelyHidden()
    {

    }*/ 



}