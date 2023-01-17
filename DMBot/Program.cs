using System;
using DMBot;
using static System.Runtime.InteropServices.JavaScript.JSType;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter Character Level:");
        string level;
        level = Console.ReadLine();

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
        npc.hp = npc.RollHP(iLevel, npc.hitD, 3);

        Console.WriteLine("\nLevel " + level + " cleric has " + npc.hp.ToString() + " HP.");

    }
}



