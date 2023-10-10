using System;

public class Word{

    private string _text;
    private bool _isHidden;

   public Word(string text)
    {
        _text = text;
        _isHidden = false;
        
        
    }

    public string GetText()
    {
        return _text;
    }


    public void Hide()
    {
        //we need the text, we need to check if the text is hidden or not.
        _isHidden = true; 
        

    
    }

    public void Show(string Hide)
    {
       //Reference reference = new Reference();
       _isHidden = false;
        
    }

    public bool IsHidden()
    {
        return _isHidden;
    }
    public string GetDisplayText()
    {
        return _isHidden ? new string('_', _text.Length) : _text;
    }
}