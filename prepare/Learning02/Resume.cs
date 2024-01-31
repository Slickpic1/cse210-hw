namespace Learning02;

public class Resume
{
    public string member;
    public List<Job> jobs = new List<Job>();

    public void DisplayResume()
    {
        Console.WriteLine($"Name: {member}");
        Console.WriteLine($"Jobs:");

        // Loop through the number of jobs in our list
        foreach (Job b in jobs)
        {
            b.DisplayJobTitle();
        }
    }
}