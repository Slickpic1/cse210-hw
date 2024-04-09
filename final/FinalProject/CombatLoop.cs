using static TextAnimation.Program;
using System.Diagnostics;

namespace Adventure_Qwest;
public class CombatLoop
{
    //For now, player starts, then enemy, then player, until one is dead (or flees)
    public CombatLoop(Monster monster)
    {   bool inCombat = true;
        while(Program.player.IsAlive() && monster.IsAlive() && inCombat)   //might not need in combat
        {
            //Starting with player
            Debug.WriteLine("Players Turn");
            Debug.WriteLine($"Player health: {Program.player.GetCurrentHP()}");
            string playerAction = Program.player.Action();   //Maybe replace this with actual text block
            switch (playerAction)
            {
                
                case "attack":
                    //Calculate the attack roll and damage roll of the player
                    int playerAttackRoll = Program.player.AttackRoll();
                    int playerDamageRoll = Program.player.DamageRoll();

                    //Display how much the player rolled (or do we want to obfuscate roll?)
                    TextAnimation.Program.DisplaySlowString($"You rolled a {playerAttackRoll}.\n");
                    TextAnimation.Program.DisplaySlowString($"You swing your sword at the {monster.GetName()}!\n");

                    //Attempt to damage monster
                    bool hit = monster.TakeDamage(playerAttackRoll,playerDamageRoll);
                    if (hit)
                    {
                        TextAnimation.Program.DisplaySlowString("And you hit!\n");
                        TextAnimation.Program.DisplaySlowString($"You deal {playerDamageRoll} points of damage!\n");

                        if (monster.IsAlive())
                        {
                            monster.DisplayHealthStatus();
                        }
                    }
                    else
                    {
                        TextAnimation.Program.DisplaySlowString("But you miss!\n");  //can vary this
                    }
                    break;

                case "flee":
                    TextAnimation.Program.DisplaySlowString("You flee from combat!\n");
                    Program.player.Move("back");
                    inCombat = false;  //might be able to remove this
                    return;
            }

            //Check to see if monster is still alive or not
            if (!monster.IsAlive())
            {
                //Add xp to player
                TextAnimation.Program.DisplaySlowString($"You slew the {monster.GetName()}!\n");
                TextAnimation.Program.DisplaySlowString($"You gain {monster.GetXP()} XP!\n");
                Program.player.AddXP(monster.GetXP());
                return;
            }

            //Now time for the monster
            Debug.WriteLine($"{monster.GetName()}'s turn");
            Debug.WriteLine($"{monster.GetName()}'s health: {monster.GetCurrentHP()}");
            string monsterAction = monster.Action();
            switch (monsterAction)
            {
                case "attack":
                    //Calculate the attack roll from the monster
                    int monsterAttackRoll = monster.AttackRoll();
                    Debug.WriteLine($"Monster Attack Roll: {monsterAttackRoll}");
                    int monsterDamageRoll = monster.DamageRoll();
                    Debug.WriteLine($"Monster Dmg Roll: {monsterDamageRoll}");

                    //Attempt to hit player
                    bool hit = Program.player.TakeDamage(monsterAttackRoll,monsterDamageRoll);
                    if (hit)
                    {
                        TextAnimation.Program.DisplaySlowString($"Ouch! The {monster.GetName()} hits you for {monsterDamageRoll} points of damage!\n");
                        if (Program.player.IsAlive())
                        {
                            Program.player.DisplayHealthStatus();
                        }
                        
                    }
                    else
                    {
                        TextAnimation.Program.DisplaySlowString("But you dodge out of the way!\n");
                    }
                    break;

                case "act":
                    break;

                case "use item":
                    break;
                    
            }

            //Check to see if player is alive
            if (!Program.player.IsAlive())
            {
                Program.player.Death();
            }
        }
        
    }
    
}