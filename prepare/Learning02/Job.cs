namespace Learning02;

public class Job
{
    public string company;
    public string jobTitle;
    public int startYear;
    public int endYear;

    public void DisplayJobTitle()
    {
        Console.WriteLine($"{jobTitle} ({company}) {startYear}-{endYear}");
    }

}