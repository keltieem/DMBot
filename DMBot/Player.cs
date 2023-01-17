using System;
namespace DMBot
{
	public class Player
	{
        public int hp;
        public int ac;
        public int initiative;
        public int proficiency;
        public int speed;
        public bool inspiration;

        public int str;
        public int dex;
        public int con;
        public int intel;
        public int wis;
        public int cha;

        public Player()
        {
        }

        public int RollHP(int level, int hitD, int conMod)
        {
            double hp = (level * ((hitD / 2) + 0.5)) + conMod;

            //Console.WriteLine("Level: {0}, HitD: {1}, ConMod: {2}, HP: {3}, Floor: {4}", level, hitD, conMod, hp.ToString(), Math.Floor(hp).ToString());

            return Convert.ToInt32(Math.Floor(hp));
        }

	}

    public class Artificer : Player
    {
        public int hitD = 8;
    }
    public class Barbarian : Player
    {
        public int hitD = 12;
    }
    public class Bard : Player
    {
        public int hitD = 8;
    }
    public class Cleric : Player
    {
        public int hitD = 8;
    }
    public class Druid : Player
    {
        public int hitD = 8;
    }
    public class Fighter : Player
    {
        public int hitD = 10;
    }
    public class Monk : Player
    {
        public int hitD = 8;
    }
    public class Paladin : Player
    {
        public int hitD = 10;
    }
    public class Ranger : Player
    {
        public int hitD = 10;
    }
    public class Rogue : Player
    {
        public int hitD = 8;
    }
    public class Sorcerer : Player
    {
        public int hitD = 6;
    }
    public class Warlock : Player
    {
        public int hitD = 8;
    }
    public class Wizard : Player
    {
        public int hitD = 6;
    }
}

