using System;
using DMBot;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter Character Level:");
        string level;
        level = Console.ReadLine();

        Console.WriteLine("You entered level: " + level);

        Console.WriteLine("New Character Ability Scores:");
        Console.WriteLine("STR\tDEX\tCON\tINT\tWIS\tCHA\n");

        int[] stats = Dice.GetStats();

        foreach (int stat in stats)
        {
            Console.Write(stat.ToString() + "\t");
        }



        // function to generate HP, AC, etc. based on stats and level
    }
}



