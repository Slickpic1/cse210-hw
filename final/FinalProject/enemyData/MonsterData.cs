using System.Collections.Generic;
namespace Adventure_Qwest;

public class MonsterData
{
    public Dictionary<string,List<Monster>> beastiary = new Dictionary<string, List<Monster>>();
    public MonsterData()
    {
        List<Monster> undead = new List<Monster>()
        {
            {new Zombie()},
            {new Ghost()}
        };

        List<Monster> beasts = new List<Monster>()
        {
            {new Bear()},
            {new FatRat()},
        };

        List<Monster> plants = new List<Monster>()
        {
            {new Shrub()},
            {new TwigBlight()}
        };

        List<Monster> humanoids = new List<Monster>()
        {
            {new Goblin()}
        };

        List<Monster> fiends = new List<Monster>()
        {
            {new Dretch()}
        };

        List<Monster> fey = new List<Monster>()
        {
            {new FoodWitch()}
        };

        beastiary.Add("undead", undead);
        beastiary.Add("beasts", beasts);
        beastiary.Add("plants", plants);
        beastiary.Add("humanoids", humanoids);
        beastiary.Add("fiends", fiends);
        beastiary.Add("fey", fey);
    }
    
}