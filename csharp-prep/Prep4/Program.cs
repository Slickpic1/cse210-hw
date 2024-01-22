using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        // Define Variables/ lists
        int sum = 0;
        int userNumber = -1;
        int largest = 0;
        float avg;
        List<int> numbers = new List<int>();

        // Ask user to input list of numbers
        Console.WriteLine($"Enter a list of numbers, type 0 when finished.");

        // Write into list
        while (userNumber != 0)
        {
            Console.Write($"Enter number: ");

            string userResponse = Console.ReadLine();
            userNumber = int.Parse(userResponse);

            //Check to see if number is zero or not
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        // Sum list
        foreach (int number in numbers)
        {
            sum += number;
        }

        //Print Sum
        Console.WriteLine($"The sum is: {sum}");

        //calculate and print average
        avg = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {avg}");

        //Find and print the largest value
        foreach (int number in numbers)
        {
            if (number > largest)
                largest = number;
        }

        Console.WriteLine($"The largest number is: {largest}");
    }
}

