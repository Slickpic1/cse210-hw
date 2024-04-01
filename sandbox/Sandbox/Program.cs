using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {   
        int math = (int) 3/2;
        Console.WriteLine(math);
        Dictionary<string,Monster> fiends = new Dictionary<string, Monster>()
        {
            {"hag",new Monster {name = "hag", type = "fiend", health = 20}},
            {"stag", new Monster {name = "stag", type = "fiend", health = 5}}
        };

        Dictionary<string,Monster> beasts = new Dictionary<string, Monster>()
        {
            {"bear", new Monster {name = "bear", type = "beast", health = 34}}
        };

        Dictionary<string,Monster> undead = new Dictionary<string, Monster>()
        {
            {"banshee", new Monster {name = "banshee", type = "undead", health = 58}},
        };

        Dictionary<string,Monster> plants = new Dictionary<string, Monster>()
        {
            {"twig blight", new Monster {name = "twig blight", type = "plant", health = 4}}
        };

        Dictionary<string,Monster> humanoids = new Dictionary<string, Monster>()
        {
            {"bullywug", new Monster {name = "bullywug", type = "humanoid", health = 11}}
        };

        Dictionary<string,Dictionary<string,Monster>> monsterDirectory = new Dictionary<string, Dictionary<string, Monster>>();


        monsterDirectory.Add("beasts",beasts);
        monsterDirectory.Add("fiends",fiends);
    }
}
public class Monster
{
    public string name;
    public string type;
    public int health;

}