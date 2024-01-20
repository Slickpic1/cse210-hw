using System;

class Program
{
    static void Main(string[] args)
    {
        // Define Variables
        float grade;
        string letterGrade;
        bool pass;

        // Get User input
        Console.Write($"Please input your grade percentage: ");
        grade = Console.Read();

        // Determine Grade and if they passed
        if (grade >= 90)
        {
            letterGrade = "A";
            pass = true;
        }
        else if (grade >= 80)
        {
            letterGrade = "B";
            pass = true;
        }
        else if (grade >= 70)
        {
            letterGrade = "C";
            pass = true;
        } 
        else if (grade >= 60)
        {
            letterGrade = "D";
            pass = false;
        }
        else
        {
            letterGrade = "F";
            pass = false;
        }

        // Print out grade and if they passed
        Console.WriteLine($"You got a[n] {letterGrade} in the class." );
        if (pass)
        {
            Console.WriteLine($"You Passed. Congrations.");
        }
        else
        {
            Console.WriteLine($"You Failed. Outer Darkness.");
        }

    }
}