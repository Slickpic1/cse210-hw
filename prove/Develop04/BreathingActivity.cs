class BreathingActivity : Activity
{
    public BreathingActivity() : base ()
    {
        //Initialize type and desc
        _activityType = "Breathing Activity";
        _activityDescription = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing";

        OpenMessage();

        Breathing();

        ClosingMessage();
    }

    private void Breathing()
    {
        while (this._timer <= this._duration)
        {
            Console.Write("Breathe in...");
            DoCountdown(4);
            Console.Write("\n");
            Console.Write("Now Breathe out...");
            DoCountdown(5);
            Console.Write("\n \n");

            this._timer += 9;
        }

    }

}