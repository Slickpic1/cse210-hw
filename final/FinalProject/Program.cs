
//#define DEBUG

using System;
using System.Diagnostics;
//using TextUtils;

namespace Adventure_Qwest;
class Program
{
    static public World gameWorld;
    static public Player player = new Player();  //Generate new player

    static void Main(string[] args)
    {
        bool testing = false;
        
        Debug.WriteLine($"Debugging mode is running!");
        
        if (testing)
        {
            //This test class will run through a variety of tests. For debugging only.
            Test test = new Test();
        }
        else
        {
            Console.Clear();
            GameEngine gameEngine = new GameEngine();
            gameEngine.DisplayStartMenu();  //will this break out of all if you quit?
            gameEngine.StartGame();
        }
    }

    static void DisplayMenu()
    {
        Console.WriteLine("Welcome to Adventure Quest!");
        Console.WriteLine();
        
    }
}