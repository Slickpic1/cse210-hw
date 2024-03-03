using System;

class Program
{
    static void DisplayMenu()
    {
        Console.Clear();
        Console.WriteLine($"Menu Options:");
        Console.WriteLine($"  1. Start breathing activity");
        Console.WriteLine($"  2. Start reflecting activity");
        Console.WriteLine($"  3. Start listing activity");
        Console.WriteLine($"  4. Quit");
        Console.Write($"Select a choice from the menu: ");
    }

    static void ChooseActivity()
    {
        string userChoice = Console.ReadLine();
        int choice = int.Parse(userChoice);
        
        switch(choice)
        {
            //Breathing activity
            case 1:
                BreathingActivity choice1 = new BreathingActivity();
                break;

            //Reflection activity
            case 2:
                ReflectionActivity choice2 = new ReflectionActivity();
                break;

            //Listing activity
            case 3:
                ListingActivity choice3 = new ListingActivity();
                break;

            //Quit
            case 4:
                break;

            default:
                break;
        }

        return;
    }

    static void Test()
    {
        //Activity test = new Activity();
        //Test out the Animations
        //test.DotDotDot(6);
        //Console.WriteLine();
        //test.Spinner(6);
        //Console.WriteLine();
        //test.LoadingBar(6);


    }
    static void Main(string[] args)
    {
        //Test();

        DisplayMenu();
        ChooseActivity();
    }
}