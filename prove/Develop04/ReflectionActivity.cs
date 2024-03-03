using System.Diagnostics;

class ReflectionActivity : Activity
{
    private List<string> reflectPrompts = new List<string>();
    private List<string> reflectQuestions = new List<string>();
    public ReflectionActivity() : base()
    {
        //Initialize Lists
        InitializePrompts();
        InitializeQuestions();

        //Initialize type and desc
        _activityType = "Reflection Activity";
        _activityDescription = "This activity will help you reflect on times in your life when you have shown strength and resiliance. This will help you recognize the power you have and how you can use it in other aspects of your life";

        //Run Opening Message
        OpenMessage();

        //Run Activity
        Reflect();

        //Run Closing message
        ClosingMessage();

    }

    private void Reflect()
    {

    }

    private void InitializePrompts()
    {
        reflectPrompts.Add("Think of a time when you stood up for someone else");
        reflectPrompts.Add("Think of a time when you did something really difficult.");
        reflectPrompts.Add("Think of a timw when you helped someone in need.");
        reflectPrompts.Add("Think of a time when you did something truly selfless.");
    }

    private void InitializeQuestions()
    {
        reflectQuestions.Add("Why was this experience meaningful to you?");
        reflectQuestions.Add("Have you ever done anything like this before?");
        reflectQuestions.Add("How did you get started?");
        reflectQuestions.Add("How did you feel when it was completed?");
        reflectQuestions.Add("What made this time different than other times when you didn't succeed?");
        reflectQuestions.Add("What was your favorite thing about this experience?");
        reflectQuestions.Add("How can you keep this experience in mind in the future?");
    }

}