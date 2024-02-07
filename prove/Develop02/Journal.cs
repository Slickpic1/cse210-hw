using System.Diagnostics;
namespace Develop02;
public class Journal
{
    public Prompt prompt = new Prompt();
    public static List<Entry> Entries = new List<Entry>();
    public string fileName;

    public void WriteEntry()
    {
        //Create new Entry
        var entry = new Entry();

        //Clear Console
        Console.Clear();

        //Display Prompt
        entry.prompt = prompt.SelectPrompt();
        Console.WriteLine($"Prompt: {entry.prompt}");

        //Log response
        entry.response = Console.ReadLine();

        //Add Entry to list of entries
        Entries.Add(entry);

        //Clear Console
        Console.Clear();

        Console.WriteLine("Response Recorded!");
        Console.WriteLine("");

    }

    public void DisplayJournal()
    {
        //Clear Console
        Console.Clear();

        //Display all journal entries
        foreach (Entry e in Entries)
        {
            e.DisplayEntry();
        }

        //Clear Entries once user is done
        Console.WriteLine($"");
        Console.Write("Press 'Enter' to return.");
        Console.ReadLine();

        //Clear Console (again)
        Console.Clear();
    }

    public void LoadJournal()
    {
        Console.WriteLine($"");
        Console.Write($"Enter the name of the file you wish to load: ");
        fileName = Console.ReadLine();
    }

    public void SaveJournal()
    {
        Console.WriteLine($"");
        Console.Write($"Enter the name of the file you wish to save to: ");
        fileName = Console.ReadLine();
    }
}