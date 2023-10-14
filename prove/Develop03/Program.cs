using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        string usuarioanswer = " ";
        
        Reference reference = new Reference("John", 3, 16);
        string text = " For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.";
        Scripture scripture = new Scripture(reference, text);

        
        
        

        while (usuarioanswer != "quit")
        {
            reference.GetDisplayText();
            scripture.GetDisplayText(text);
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type 'quit' to finish");
            usuarioanswer = Console.ReadLine();
            if (usuarioanswer != "quit")
            {
                scripture.HideRandomWords(3, text);
            }
            Console.Clear();
            
            
            
            

            
           
        }

   
        
    }
}