public class Scripture
{
    private Reference _Ref;
    private List<Word> Words = new List<Word>();
    private int _numBlankedWords;
    private int _scriptureLength;
    

    public Scripture()
    {
        //Initialize scripture here
        _Ref = new Reference("1 Nephi","2","15");
        string scripture = "And my father dwelt in a tent.";
        string separator = " ";
        string[] things = scripture.Split(separator);

        foreach (string temp in things)
        {
            Word word = new Word(temp);
            Words.Add(word);
        }

        //Set number of blank words
        _numBlankedWords = 0;

        //Set length of our scripture
        _scriptureLength = things.Length;
    }

    private int WordsToErase()
    {
        //Check to see how many words are left
        Random randomGenerator = new Random();
        int wordsLeft = _scriptureLength - _numBlankedWords;

        int wordsToErase;
        //Check to see if there are 4+ words left to erase
        if (wordsLeft >= 4)
        {
            //Choose Random Number of words to erase
            wordsToErase = randomGenerator.Next(1,4);
        }
        else if (wordsLeft == 1)
        {
            wordsToErase = 1;
        }
        else
        {
            //make sure no error throws for .Next(1,1) or (1,0)
            wordsToErase = randomGenerator.Next(1,wordsLeft);
        }

        return wordsToErase;
    }

    public void EraseWords()
    {
        //Find words to erase
        int wordsToErase = WordsToErase();
        //Console.WriteLine($"wordsToErase = {wordsToErase}");

        //"Erase" Random Words
        int i = 0;
        while (i < wordsToErase)
        {
            
            //Select a random word from the list of words
            Random rand = new Random();
            int number = rand.Next(0,_scriptureLength);
            //Console.WriteLine($"number: {number}");
            Word word = Words[number];
            //word.DisplayWord();

            //Check to see if it's already blanked
            if (!word._isHidden)
            {
                word._isHidden = true;
                _numBlankedWords += 1;
                i += 1;
            }
        }

        //
    }

    public bool IsAllBlank()
    {
        if (_scriptureLength - _numBlankedWords > 0)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    public void DisplayScripture()
    {
        _Ref.DisplayReference();
        foreach (Word word in Words)
        {
            word.DisplayWord();
            Console.Write(" ");
        }

        Console.WriteLine($"");
    }

    //private void LoadScripture()
    //{
    //    string filename = "scripture.txt";
    //    string[] lines = System.IO.File.ReadAllLines(filename);

    //    foreach (string line in lines)
    //    {
    //        string[] parts = line.Split(",");

            
    //    }
    //}
}