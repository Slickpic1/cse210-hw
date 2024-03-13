public class EternalGoal : Goal
{
    
    public EternalGoal() : base()
    {
        goalType = "Eternal Goal";
    }

    public EternalGoal(string values) : base(values.Split($"{Goal.DELIMITER}{Goal.DELIMITER}")[0])
    {
        //Not sure if we need anything here...
        goalType = "Eternal Goal";
    }

    public override void DisplayGoal()
    {
        Console.Write("[ ] ");
        base.DisplayGoal();
        Console.Write("\n");  //Newline
    }
}