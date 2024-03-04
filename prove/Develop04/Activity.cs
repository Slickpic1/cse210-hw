public class Activity
{
    protected int _timer;
    protected string _activityType;
    protected string _activityDescription;
    protected int _duration;

    public Activity()
    {
        //Not sure if anything is needed here tbh
    }

    private void ClearLine()
    {
        //Clear current line
        int currentLineCursor = Console.CursorTop;
        Console.SetCursorPosition(0, Console.CursorTop);
        Console.Write(new string(' ', Console.WindowWidth)); 
        Console.SetCursorPosition(0, currentLineCursor);
    }

    private void PauseClear()
    {
        //Pause for 1/2 a second
        Thread.Sleep(500);
        ClearLine();
    }

    //This will display a spinning char for one cycle over 2 s
    protected void DoSpinner(int time) 
    {
        //Create list of characters for our spinner
        List<char> spinChars = new List<char>{'\\','-','/','|'};

        //Log our current time and run loop for that time
        DateTime currentTime = DateTime.Now;
        DateTime endTime = currentTime.AddSeconds(time);

        while (currentTime <= endTime)
        {
            foreach (char q in spinChars)
            {
                Console.Write(q);
                Thread.Sleep(250);
                Console.Write("\b \b");
            }

            //Update our current time
            currentTime = DateTime.Now;
        }
    }

    protected void DoCountdown(int time)
    {
        for (int i = time; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
    protected void DoDots(int time)
    {
        //Log our current time and run loop for that time
        DateTime currentTime = DateTime.Now;
        DateTime endTime = currentTime.AddSeconds(time);

        while (currentTime <= endTime)
        {
            for (int i = 0; i < 3; i++)
            {
                Console.Write(".");
                Thread.Sleep(500);
            }

            Thread.Sleep(500);
            Console.Write("\b\b\b   \b\b\b");

            //Update our current time
            currentTime = DateTime.Now;
        }
    }

    protected void DoLoadingBar(int time) //Definitely clean up
    {
        //Log our current time and run loop for that time
        DateTime currentTime = DateTime.Now;
        DateTime endTime = currentTime.AddSeconds(time);

        while (currentTime <= endTime)
        {
            //Make loadbar array
            List<char> loadBar = new List<char>{'[',' ',' ',' ',' ',' ',' ',' ',' ',']'};

            //Loop through list and replace values with |
            for(int i = 1; i < loadBar.Count-1; i++)
            {
                loadBar[i] = '|';

                foreach(char q in loadBar)
                {
                    Console.Write(q);
                }

                PauseClear();
            }
            
            ClearLine();  //Might be redundant

            //Update our current time
            currentTime = DateTime.Now;
        }
    }

    public void OpenMessage()
    {

        Console.Clear();

        //Display the welcome message
        Console.WriteLine($"Welcome to the {_activityType}.");
        Console.WriteLine($"");  //Blank space
        Console.WriteLine(_activityDescription);
        Console.WriteLine($"");  //Blank space

        //Ask user how long they want session to last
        Console.Write($"How long, in seconds, would you like your session? ");
        string userInput = Console.ReadLine();
        _duration = int.Parse(userInput);

        //Clear Console and tell user to get ready
        Console.Clear();
        Console.Write("Get Ready");
        DoDots(5);
        this._timer += 5;
        Console.WriteLine("");  //Newline
        Console.WriteLine("");  //Newline

    }

    protected void ClosingMessage()
    {
        //Congratulate user for completing
        Console.Write("\n");
        Console.WriteLine($"Well done!!");
        Console.WriteLine($"");
        Console.WriteLine($"You have completed another {_duration} second(s) of the {_activityType}.");

        //Pause for some time and run animation for effect
        DoSpinner(6);
        Console.Clear();
    }
}