using System;

class Program
{
    static void Main(string[] args)
    {
        //Test the basic assignment class
        Assignment assign1 = new Assignment("Kaylee Ball", "Being Cute");
        Console.WriteLine(assign1.GetSummary());

        Console.WriteLine("");

        //Test the Math Assignment Class
        MathAssignment assign2 = new MathAssignment("Matt Smith","Physics","7.9","8-11");
        Console.WriteLine(assign2.GetSummary());
        Console.WriteLine(assign2.GetHomeworkList());

        Console.WriteLine("");

        //Test writing assignment
        WritingAssignment assign3 = new WritingAssignment("Steve Smith","Biology","The Death of Pizarro by Ben Timty");
        Console.WriteLine(assign3.GetSummary());
        Console.WriteLine(assign3.GetWritingInformation());

        Console.WriteLine("");
    }
}

