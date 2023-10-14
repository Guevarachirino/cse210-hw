using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Develop04 World!");

        while (true)
        {

            try
            {
                Console.WriteLine("Menu Options:");
                Console.WriteLine("1. Start breathing activity");
                Console.WriteLine("2. Start reflecting activity");
                Console.WriteLine("3. Start listing activity");
                Console.WriteLine("4. Quit");
                Console.WriteLine("Select a choise from the menu:");

                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {

                    case 1:

                        
                        break;

                    case 2:
                        
                        break;

                    case 3:
                        
                        break;

                    
                    case 4:
                        Console.WriteLine("Bye");
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Invalid option");
                        break;

                }
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
        }



    }
}