
class Assignment
{
    protected string _studentName;
    protected string _topic;

    //Constructor
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    public string GetSummary()
    {
        string temp = $"{_studentName} - {_topic}";
        return temp;
    }
}