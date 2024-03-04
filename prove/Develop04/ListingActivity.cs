public class ListingActivity : Activity
{   
    private List<string> prompts = new List<string>();
    Random rand = new Random();
    public ListingActivity(): base()
    {
        //Initialize Prompts
        InitializePrompts();

        //Initialize type and desc
        _activityType = "Listing Activity";
        _activityDescription = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";

        //Run open message
        OpenMessage();

        //Run our activity
        Listing();

        //Run closing message
        ClosingMessage();
    }

    private void Listing()
    {
        int random = rand.Next(0,prompts.Count());
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine($" --- {prompts[random]} ---");
        Console.Write("You may begin in: ");
        DoCountdown(5);
        this._timer += 5;
        Console.Write("\n");

        DateTime currentTime = DateTime.Now;
        DateTime futureTime = currentTime.AddSeconds(this._duration-this._timer);
        int count = 0;

        while (currentTime < futureTime)
        {
            Console.Write(">");
            Console.ReadLine();
            count += 1;
            currentTime = DateTime.Now;
        }

        Console.WriteLine($"You listed {count} items!");
    }

    private void InitializePrompts()
    {
        prompts.Add("Who are people that you appreciate?");
        prompts.Add("What are personal strengths of yours?");
        prompts.Add("Who are people that have helped this week?");
        prompts.Add("When have you felt the Holy Ghost this month?");
        prompts.Add("Who are some of you personal heroes?");
    }

    
}