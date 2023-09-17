using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Prep4 World!");

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");


        
        //creando lista 
        List<int> numbers = new List<int>();
        int number = -1;

        //practicando Do while 
        do 
        {
            
            Console.Write("Enter number:");
            string userInput = Console.ReadLine();
            number = int.Parse(userInput);

            if(number != 0)
            {
                //agregando a la lista 
                numbers.Add(number);

            }
        
            int sum = 0;
            foreach(int totalnumbers in numbers)
            {
                sum += totalnumbers;
            }
        
                Console.WriteLine($"The sum is: {sum}");

                float average = ((float)sum) / numbers.Count;
                Console.WriteLine($"The average is: {average}");


                int max = numbers[0];

            foreach(int totalnumbers in numbers)
            {
                if (totalnumbers > max)
                {
                
                max = totalnumbers;
                }
            }

            Console.WriteLine($"The max is: {max}"); 
        }
    while (number != 0);
        
    }
}