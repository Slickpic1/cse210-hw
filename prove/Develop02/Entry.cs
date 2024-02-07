namespace Develop02;
public class Entry
{
    //Define Variables
    public string prompt;
    public string response;
    public string date;
    

    //Constructor Class
    public Entry()
    {
        //Log the Date 
        DateTime currentTime = DateTime.Now;
        this.date = currentTime.ToShortDateString();
    }   

    public void DisplayEntry()
    {
        Console.WriteLine($"==============================================");
        Console.WriteLine($"Date: {this.date}");
        Console.WriteLine($"Prompt: {this.prompt}");
        Console.WriteLine($"----------------------------------------------");
        Console.WriteLine($"{this.response}");
    }
    
}