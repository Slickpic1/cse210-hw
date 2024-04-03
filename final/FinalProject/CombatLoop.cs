namespace Adventure_Qwest;
public class CombatLoop
{
    //For now, player starts, then enemy, then player, until one is dead
    public CombatLoop(Monster monster)
    {
        //Need to assign monster to a specific one
        while(Program.player.IsAlive() || monster.IsAlive())
        {
            //Starting with player
            string playerAction = Program.player.Action();
            switch (playerAction)
            {
                case "attack":
                    //Calculate the attack roll and damage roll of the player
                    int playerAttackRoll = Program.player.AttackRoll();
                    int playerDamageRoll = Program.player.DamageRoll();

                    //Attempt to damage monster
                    monster.TakeDamage(playerAttackRoll,playerDamageRoll);
                    break;

                case "flee":
                    break;
            }

            //Now time for the monster
            string monsterAction = monster.Action();
            switch (monsterAction)
            {
                case "attack":
                    int monsterAttackRoll = monster.AttackRoll();
                    int monsterDamageRoll = monster.DamageRoll();
                    Program.player.TakeDamage(monsterAttackRoll,monsterDamageRoll);
                    break;

                case "act":
                    break;

                case "use item":
                    break;
                    
            }
        }
        
    }
    
}