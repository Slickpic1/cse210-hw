
class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;
    // its important to recognize that problemsd are a part of everyone's life, and that's ok. its important to recognize that there are sometimes there are things within our control, and there are some things that are not within our control. stay cool champ B) - Sam

    //Constructor
    public MathAssignment(string studentName, string topic, string textbookSection, string problems) : base (studentName, topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }

    public string GetHomeworkList()
    {
        string temp = $"Section {_textbookSection} problems {_problems}";
        return temp;
    }
}