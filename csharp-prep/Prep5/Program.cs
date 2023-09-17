using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Prep5 World!");

        string nombre = PromptUserName();
        int numero = PromptUserNumber();
        //int alcuadrado = SquareNumber(numero);
        DisplayResult(nombre, numero);

        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        static string PromptUserName()
        {
            Console.Write("Please enter your name:");
            string name = Console.ReadLine();

            return name;
        }
        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number:");
            int number = int.Parse(Console.ReadLine());

            return number;
        }

        static double SquareNumber(double number)
        {
            //I have problem to convert double to int. 
            double elevadoAlCuadrado = Math.Pow(number, 2); // Elevarlo a la potencia 2

            double convirtiendo = Convert.ToInt32(elevadoAlCuadrado);
            return convirtiendo;
        
            
        }
         static void DisplayResult(string name, int convirtiendo)
        {
            Console.WriteLine($"{name}, the square of your number is {convirtiendo}");
        }

    }
}