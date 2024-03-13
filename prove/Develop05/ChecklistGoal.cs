public class ChecklistGoal : Goal
{
    private bool isCompleted;
    private int bonusAmount;
    private int bonusPoints;
    private int numberCompleted;
    public ChecklistGoal() : base()
    {
        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        bonusAmount = int.Parse(Console.ReadLine());
        
        Console.Write("What is the bonus for completing it that many times? ");
        bonusPoints = int.Parse(Console.ReadLine());
        
        numberCompleted = 0;
        isCompleted = false;  //can they double? or just once
        goalType = "Checklist Goal";
    }

    public ChecklistGoal(string values) : base(values.Split($"{Goal.DELIMITER}{Goal.DELIMITER}")[0])
    {
        var goalValues = values.Split($"{Goal.DELIMITER}{Goal.DELIMITER}");
        isCompleted = bool.Parse(goalValues[1]);

        var checklistGoals = goalValues[2].Split($"{Goal.DELIMITER}");
        bonusPoints = int.Parse(checklistGoals[0]);
        bonusAmount = int.Parse(checklistGoals[1]);
        numberCompleted = int.Parse(checklistGoals[2]);
        goalType = "Checklist Goal";
    }

    public override int GetPoints()
    {
        //Increase number of times completed
        numberCompleted += 1;

        //Check to see if number of times completed is enough to earn bonus points
        if (numberCompleted >= bonusAmount)
        {
            isCompleted = true;
            return base.GetPoints() + bonusPoints;
        }
        else
        {
            return base.GetPoints();
        }
        
    }

    public override void DisplayGoal()
    {
        string checkBox = isCompleted ? "[x]" : "[ ]";
        Console.Write($"{checkBox} ");
        base.DisplayGoal();
        Console.Write($"-- Currently completed: {numberCompleted}/{bonusAmount}");
        Console.Write("\n");
    }
    
    public override string Export()
    {
        return base.Export() + $"{Goal.DELIMITER}{Goal.DELIMITER}" + $"{isCompleted}" + $"{Goal.DELIMITER}{Goal.DELIMITER}" 
        + $"{bonusPoints}" + $"{DELIMITER}" + $"{bonusAmount}" + $"{DELIMITER}" + $"{numberCompleted}";
    }
}