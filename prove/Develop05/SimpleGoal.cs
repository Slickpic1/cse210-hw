public class SimpleGoal : Goal
{
    private bool isCompleted;
    public SimpleGoal() : base()
    {
        //Default to false when first initializing
        this.isCompleted = false;
        goalType = "Simple Goal";
    }

    public SimpleGoal(string values) : base(values.Split($"{Goal.DELIMITER}{Goal.DELIMITER}")[0])
    {
        var goalValues = values.Split($"{Goal.DELIMITER}{Goal.DELIMITER}");
        isCompleted = bool.Parse(goalValues[1]);
        goalType = "Simple Goal";
    }

    public override void DisplayGoal()
    {
        string checkBox = isCompleted ? "[x]" : "[ ]";
        Console.Write($"{checkBox} ");
        base.DisplayGoal();
        Console.Write("\n");
    }

    public override int GetPoints()
    {
        //Set isCompleted = true and give points
        isCompleted = true;
        return base.GetPoints();
    }

    public override string Export()
    {
        return base.Export() + $"{Goal.DELIMITER}{Goal.DELIMITER}" + $"{isCompleted}";
    }
}