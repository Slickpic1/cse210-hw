public class Fraction
{
    private int _top;
    private int _bottom;

    //Constructor that initializes both as 1
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    //Constructor that initializes bottom as 1
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    //Constructor that sets both top and bottom values
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    //Getter/setter for top value
    public int GetTop()
    {
        return _top;
    }

    public void SetTop(int top)
    {
        _top = top;
    }

    //Getter and Setter for bottom
    public int GetBottom()
    {
        return _bottom;
    }

    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    //Fraction String maker
    public string GetFractionString()
    {
        string txt = $"{_top}/{_bottom}";
        return txt;
    }

    //Decimal Value Maker
    public double GetDecimalValue()
    {
        return (_top/_bottom);
    }
}