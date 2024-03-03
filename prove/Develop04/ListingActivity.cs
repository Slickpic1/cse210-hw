public class ListingActivity : Activity
{   
    private List<string> prompts = new List<string>();
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