public class EternalGoal : Goal
{
    public EternalGoal() : base()
    {
        goalType = "Eternal Goal"; //Can this be abstracted more?
    }

    public EternalGoal(string values) : base(values.Split($"{Goal.DELIMITER}{Goal.DELIMITER}")[0])
    {
        goalType = "Eternal Goal";
    }

    public override void DisplayGoal()
    {
        Console.Write("[ ] ");
        base.DisplayGoal();
        Console.Write("\n");
    }
}