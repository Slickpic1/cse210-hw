public class Scripture
{
    private Reference _Ref;
    private List<string> Words = new List<string>();
    private int numBlankedWords;

    public Scripture()
    {
        //Initialize scripture here
        _Ref = new Reference("Daniel","5","6","7");
        //Words = 

        //
    }

    private void EraseWords()
    {
        //Choose Random Number of words to erase
        Random randomGenerator = new Random();
        int numWords = randomGenerator.Next(1,101);

        //"Erase" Random Words

        //
    }

    public void IsAllBlank()
    {

    }

    public void DisplayScripture()
    {

    }
}