using System;

class Program
{
    static void Main(string[] args)
    {
        //Check Fraction Constructor(s)

        //Default 1/1
        Fraction fraction1 = new Fraction();
        Console.WriteLine($"Fraction 1: {fraction1.GetFractionString()}");

        //Wholenumber / 1
        Fraction fraction2 = new Fraction(5);
        Console.WriteLine($"Fraction 2: {fraction2.GetFractionString()}");

        //Custom fraction
        Fraction fraction3 = new Fraction(3,5);
        Console.WriteLine($"Fraction 3: {fraction3.GetFractionString()}");

        //Checking the setter functionality
        fraction1.SetTop(6);
        fraction1.SetBottom(3);
        Console.WriteLine($"New Frac: {fraction1.GetFractionString()}");
        Console.WriteLine($"in dec form: {fraction1.GetDecimalValue()}");
        

        


    }
}