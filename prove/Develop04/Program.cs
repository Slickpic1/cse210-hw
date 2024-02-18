using System;

class Program
{
    static void Main(string[] args)
    {
        var ref1 = new Reference("John","3","6","9");
        ref1.DisplayReference();

        var word1 = new Words(true, "mop");
        word1.DisplayWord();
    }
}