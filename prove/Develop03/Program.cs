using System;
using System.Collections.Generic;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        string usuarioanswer = " ";
        
        Reference reference = new Reference();
        string text = " For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.";
        Scripture scripture = new Scripture(reference, text);

        do
        {
            Console.Clear();
            Console.WriteLine(text);
            Console.WriteLine(scripture.GetDisplayText);
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type 'quit' to finish");
            usuarioanswer = Console.ReadLine();
            scripture.GetDisplayText();
            //Console.WriteLine(text);

            if (usuarioanswer != "quit")
            {
                scripture.HideRandomWords(3);
            }
        }

        while (usuarioanswer != "quit");
        
    }
}