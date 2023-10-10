using System;
using System.Linq;
using System.Runtime.CompilerServices;

public class Scripture{

    private Reference _reference; 
    private string _text; 
    private List<Word> _words = new List<Word>();

    //calling class reference
    Reference reference = new Reference();
    public Scripture( Reference reference, string text)
    {
        this._reference = reference;
        this._text = text;
        this._words = new List<Word>();
        /*_reference = reference;
        string[] words = text.Split(' ');

        foreach (var word in words)
        {
            Word word_one = new Word(word);
            _words.Add(word_one);

        }*/

       

    }

    public void HideRandomWords(int numberToHide, string text)
    {
        // Select a random word from the scripture text
        string[] words = text.Split(' ');
        Random rand = new Random();
        int index = rand.Next(words.Length);
        Word wordToHide = _words[index];

        // Add the word to the list of hidden words
        _words.Add(wordToHide);
    
    }

    public void GetDisplayText(string text)
    {
        // Display the reference and text of the scripture
        //Console.WriteLine(reference);
        string[] gettinword = text.Split(' ');
        foreach (string _words in gettinword)
        {
            // Check if the word is hidden
            if (_words.Contains(_words))
            {
                Console.Write("_____ ");
            }
            else
            {
                Console.Write(_words + " ");
            }
        }
        Console.WriteLine();
        
        
    }

    public bool IsCompletelyHidden(string text)
    {
        string[] words = text.Split(' ');
        return _words.Count == words.Length;
    }



}