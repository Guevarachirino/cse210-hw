using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Learning03 World!");

        Fraction fractionone = new Fraction();
        Console.WriteLine(fractionone.GetFractionString());
        Console.WriteLine(fractionone.GetDecimalValue());

        Fraction fractiontwo = new Fraction(5);
        Console.WriteLine(fractiontwo.GetFractionString());
        Console.WriteLine(fractiontwo.GetDecimalValue());

        Fraction fraction3 = new Fraction(3, 4);
        Console.WriteLine(fraction3.GetFractionString());
        Console.WriteLine(fraction3.GetDecimalValue());

        Fraction fraction4 = new Fraction(1, 3);
        Console.WriteLine(fraction4.GetFractionString());
        Console.WriteLine(fraction4.GetDecimalValue());

        //one more example 
        Fraction fraction5 = new Fraction(5, 3);
        Console.WriteLine(fraction5.GetFractionString());
        Console.WriteLine(fraction5.GetDecimalValue());
    }
}