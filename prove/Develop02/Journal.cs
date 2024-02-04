namespace Develop02;
public class Journal
{
    public List<string> prompts = new List<string>();
    public List<Entry> Entries = new List<Entry>();
    public Entry entry = new Entry();

    public Journal()
    {
        //Construct our Prompts
        ConstructPrompts();
        
    }

    
    public void ConstructPrompts()
    {
        prompts.Add("Who was the most interesting person I saw today?");
        prompts.Add("What was the strongest emotion I felt today?");
        prompts.Add("How much homework did I complete today?");
        prompts.Add("What did I enjoy about today?");
        prompts.Add("Did you see the Skin Man again?");
    }

    public void WriteEntry()
    {
        //Choose random number 
        int length = this.prompts.Count;
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1,length);

        //Display Prompt
        entry.prompt = prompts[number];
        Console.WriteLine($"Prompt: {entry.prompt}");

        //Log response
        entry.response = Console.ReadLine();

        //Add Entry to list of entries
        Entries.Add(entry);

    }

    public void DisplayJournal()
    {
        //Display all journal entries
        foreach (Entry e in Entries)
        {
            e.DisplayEntry();
        }
    }

    public void LoadJournal()
    {

    }

    public void SaveJournal()
    {

    }
}