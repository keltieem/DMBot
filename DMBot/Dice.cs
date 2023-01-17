using System;
using Microsoft.VisualBasic;

namespace DMBot
{
	public class Dice
	{
        /*	Constants
			Variable members / fields
			Constructors
			Methods
		*/

        public Dice() {}

		public static int RollDx(int x)
		{
			Random r = new Random();
			return r.Next(1, x);
		}

        public static int RollD4()
        {
            return RollDx(4);
        }

        public static int RollD6()
        {
			return RollDx(6);
        }

        public static int RollD8()
        {
            return RollDx(8);
        }

        public static int RollD10()
        {
            return RollDx(10);
        }

        public static int RollD12()
        {
            return RollDx(12);
        }

        public static int RollD20()
        {
            return RollDx(20);
        }

        public static int[] RollXdY(int x, int y)
		{
			int[] xdy = new int[x];

			for (int i = 0; i < x; i ++)
			{
                xdy[i] = RollDx(y);
			}

			return xdy;
		}

        public static int GetStat()
        {
            int[] rolls = new int[4];

            for (int i = 0; i < 4; i++)
            {
                rolls[i] = RollD6();
            }

            Array.Sort(rolls);

            int sum = 0;

            for (int r = 1; r < 4; r++)
            {
                sum += rolls[r];
            }

            return sum;

        }

        public static int[] GetStats()
        {
            int numStats = 6;
            int[] stats = new int[numStats];

            for (int i = 0; i < numStats; i++)
            {
                stats[i] = GetStat();
            }

            return stats;
        }


	}
}

