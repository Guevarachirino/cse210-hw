using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");


        //tomamos el numero para adivinar. 
        Console.Write("What is the magic number? ");
        string userInput = Console.ReadLine();
        int magicnumber = int.Parse(userInput);

        //numero el cual creemos que es el correcto.
        Console.Write("What is your guess? ");
        string userguess = Console.ReadLine();
        int guessnumber = int.Parse(userguess);

       //proceso para saber si estamos adivinando el numero.  
       while (guessnumber != magicnumber)
        {
            Console.Write("What is your guess? ");
            guessnumber = int.Parse(Console.ReadLine());

            if ( guessnumber > magicnumber)
            {
                Console.WriteLine("Higher");
            }
            else if (guessnumber < magicnumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }

        }                    
    }
}