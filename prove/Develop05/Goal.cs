public class Goal
{
    public static readonly string DELIMITER = "~";
    protected int pointValue;
    protected string goalTitle;
    protected string goalDesc;
    protected string goalType;

    //Case where no data is input, we need to get values from user
    protected Goal()
    {
        Console.Write("What is the name of your goal? ");
        this.goalTitle = Console.ReadLine();

        Console.Write("What is a short description of it? ");
        this.goalDesc = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        this.pointValue = int.Parse(Console.ReadLine());
    }

    //Case where we construct from file inputs
    protected Goal(string values)
    {
        //Split the other string based on '~' delimiter
        var goalValues = values.Split(DELIMITER);
        goalTitle = goalValues[0];   
        goalDesc = goalValues[1];
        pointValue = int.Parse(goalValues[2]);

    }

    public virtual int GetPoints()
    {
        return pointValue;
    }

    public string GetGoalTitle()  
    {
        return goalTitle;
    }

    public virtual void DisplayGoal()
    {
        Console.Write($"{goalTitle} ({goalDesc}) ");
    }

    //Export goal as one long string (Serialization)
    public virtual string Export()
    {
        return $"{goalType}:{goalTitle}{DELIMITER}{goalDesc}{DELIMITER}{pointValue}";
    }


}