public class Goal
{
    public static readonly string DELIMITER = "~";
    protected int pointValue;
    protected string goalTitle;
    protected string goalDesc;
    protected string goalType;

    //Case where no data is input
    protected Goal()
    {
        GetUserInfo();
    }

    //Case where we construct from file inputs
    protected Goal(string values)
    {
        //Split the other string based on '~' delimiter
        var goalValues = values.Split(DELIMITER);
        goalTitle = goalValues[0];   //Does this need a 'this' prefix?
        goalDesc = goalValues[1];
        pointValue = int.Parse(goalValues[2]);

    }

    public virtual int GetPoints()
    {
        return pointValue;
    }

    public virtual void GetUserInfo()  //Maybe just put into first case
    {
        Console.Write("What is the name of your goal? ");
        this.goalTitle = Console.ReadLine();

        Console.Write("What is a short description of it? ");
        this.goalDesc = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        this.pointValue = int.Parse(Console.ReadLine());
    }

    public string GetGoalTitle()  //Can we make this protected or not?
    {
        return goalTitle;
    }

    public virtual void DisplayGoal()
    {
        //Potentially need to fix
        Console.Write($"{goalTitle} ({goalDesc}) ");
    }

    public virtual string Export()
    {
        return $"{goalType}:{goalTitle}{DELIMITER}{goalDesc}{DELIMITER}{pointValue}";
    }


}