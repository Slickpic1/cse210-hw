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
        
    }

}