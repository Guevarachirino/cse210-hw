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

        bool quit = false;

        while (!quit)
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
                        //mostramos los promts que tenemos en la clase promptGenerator
                        PromptGenerator generator = new PromptGenerator();
                        string var1 = generator.GetRandomPrompt();
                        string escribir = Console.ReadLine();

                        //comenzamos el archivo txt
                        StreamWriter sw = new StreamWriter("lista.txt", true);

                        //obtenemos la fecha de hoy 
                        DateTime date = DateTime.Now;
                        sw.WriteLine(date);
                        
                        sw.WriteLine(var1);

                        sw.WriteLine(escribir);
                    
                        sw.Dispose();
                        

                        break;

                    case 2:

                        const string path = "lista.txt";
                        StreamReader reader = new StreamReader(path);
                        string line = reader.ReadLine();

                         while(line != null)
                        {
                            Console.WriteLine(line);
                            line = reader.ReadLine();

                        }


                        break;

                    case 3:
                        break;

                    case 4:
                        break;

                    case 5:
                            Console.WriteLine("Bye");
                        break;
                    
                    default:
                       Console.WriteLine("What would you like to do?");
                       break;

                }
            }
            catch(FormatException e)
            {
                Console.WriteLine(e.Message);
            }
        }
        Console.ReadLine();
        
    }
}