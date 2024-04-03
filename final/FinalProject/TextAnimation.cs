namespace TextAnimation;
class Program
{
    static public void DisplaySlowString(string displayString)
    {
        foreach (var letter in displayString)
        {
            Console.Write(letter);
            Thread.Sleep(25);
        }
    }

    static public void DisplaySpinChar()
    {
        
    }
}