using System;
using DMBot;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter Character Level:");
        string level;
        level = Console.ReadLine();

        Console.WriteLine("Enter Character Class:");
        string charClass;
        charClass = Console.ReadLine();

        if (!string.IsNullOrEmpty(charClass))
        {
            charClass = charClass.ToUpper().Trim();
        }

        object character = InstantiateClass(charClass);

        Console.WriteLine("New Character Ability Scores:");
        Console.WriteLine("STR\tDEX\tCON\tINT\tWIS\tCHA\n");

        int[] stats = Dice.GetStats();

        foreach (int stat in stats)
        {
            Console.Write(stat.ToString() + "\t");
        }

        int iLevel = 1;
        if (!string.IsNullOrEmpty(level))
        {
            int.TryParse(level, out iLevel);
        }

        Cleric npc = new Cleric();
        npc.hp = npc.RollAvgHP(iLevel, npc.hitD, 3);

        Console.WriteLine("\nLevel " + level + " " + charClass + " has " + npc.hp.ToString() + " HP.");

        return;

        /* HELPER FUNCTIONS */
        object InstantiateClass(string charClass)
        {
            switch (charClass)
            {
                case "ARTIFICER":
                    return new Artificer();
                case "BARBARIAN":
                    return new Barbarian();
                case "BARD":
                    return new Bard();
                case "CLERIC":
                    return new Cleric();
                case "DRUID":
                    return new Druid();
                case "FIGHTER":
                    return new Fighter();
                case "MONK":
                    return new Monk();
                case "PALADIN":
                    return new Paladin();
                case "RANGER":
                    return new Ranger();
                case "ROGUE":
                    return new Rogue();
                case "SORCERER":
                    return new Sorcerer();
                case "WARLOCK":
                    return new Warlock();
                case "WIZARD":
                    return new Wizard();
                default:
                    return new Player();

            }
        }
        

    }
}



