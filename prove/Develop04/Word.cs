public class Word
{
    public bool _isHidden;
    private string _text;
    private string _hiddenText;

    public Word(string text)
    {
        _isHidden = false;
        _text = text;

        //Construct hidden text
        for (int i = 0; i < _text.Length; i++)
        {
            _hiddenText += "-";
        } 
    }

    public void DisplayWord()
    {
        if (_isHidden)
        {
            Console.Write(_hiddenText);
        }
        else
        {
            Console.Write(_text);
        }
    }
}