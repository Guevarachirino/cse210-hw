using System;
using System.ComponentModel.Design;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;


class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Develop02 World!");
        Journal journal = new Journal();

        while (true)
        {

            try
            {
                Console.WriteLine("Please Select one of the following choices");
                Console.WriteLine("1. Write");
                Console.WriteLine("2. Display");
                Console.WriteLine("3. Load");
                Console.WriteLine("4. Save");
                Console.WriteLine("5. Quit");
                Console.WriteLine("What would you like to do?");

                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {

                    case 1:

                        journal.AddEntry();
                        break;

                    case 2:
                        journal.DisplayAll();
                        break;

                    case 3:
                        journal.LoadFromFile();
                        break;

                    case 4:
                        journal.SaveToFile();
                        break;

                    case 5:
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