namespace Dice;
public class Dice   //do we want to rename to Roll, and subsequent sets become types, giving Dice.Roll.D20()?
                    // or would we prefer to import as statis to give the functions RollD20() alone
{
    static Random rand = new Random();
    static public int RollD2()
    {
        return rand.Next(1,3);
    }

    static public int RollD4()
    {
        return rand.Next(1,5);
    }

    static public int RollD6()
    {
        return rand.Next(1,7);
    }

    static public int RollD8()
    {
        return rand.Next(1,9);
    }

    static public int RollD10()
    {
        return rand.Next(1,11);
    }

    static public int RollD12()
    {
        return rand.Next(1,13);
    }

    static public int RollD20()
    {
        return rand.Next(1,21);
    }
}