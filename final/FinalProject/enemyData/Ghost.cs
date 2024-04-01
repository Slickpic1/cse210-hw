namespace Adventure_Qwest;
public class Ghost : Monster
{
    //Ghost class will mostly be for fun, it won't do anything other than attempt to hit player (but fail) and then flee
    public Ghost() : base()
    {
        stats["str"] = 0;
        name = "ghost";
    }
}