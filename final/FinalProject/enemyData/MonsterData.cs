using System.Collections.Generic;
namespace Adventure_Qwest;

public class MonsterData
{
    public Dictionary<string,Dictionary<string,Monster>> beastiary = new Dictionary<string, Dictionary<string, Monster>>();
    public MonsterData()
    {
        Dictionary<string, Monster> undead = new Dictionary<string, Monster>()
        {
            {"zombie",new Zombie()},
            {"ghost", new Ghost()}
        };

        Dictionary<string, Monster> beasts = new Dictionary<string, Monster>()
        {
            {"bear", new Bear()},
            {"fat rat", new FatRat()},
        };

        Dictionary<string, Monster> plants = new Dictionary<string, Monster>()
        {
            {"shrub", new Shrub()},
            {"twig blight", new TwigBlight()}
        };

        Dictionary<string, Monster> humanoids = new Dictionary<string, Monster>()
        {
            {"goblin",new Goblin()}
        };

        Dictionary<string, Monster> fiends = new Dictionary<string, Monster>()
        {
            {"dretch",new Dretch()}
        };

        Dictionary<string, Monster> fey = new Dictionary<string, Monster>()
        {
            {"food witch", new FoodWitch()}
        };

        beastiary.Add("undead", undead);
        beastiary.Add("beasts", beasts);
        beastiary.Add("plants", plants);
        beastiary.Add("humanoids", humanoids);
        beastiary.Add("fiends", fiends);
        beastiary.Add("fey", fey);
    }
    
}