using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryGame
{
    static class DataContainer
    {
        public static string Name { get; set; }
        public static int Time1;
        public static int Time2;
        public static int Tries_Final;
        public static int Time_Final;
        public static Login login = new Login();
        public static ConfigurationPanel configurationPanel = new ConfigurationPanel();
        public static EasyGame easyGame = new EasyGame();
        public static MediumGame mediumGame = new MediumGame();
        public static HardGame hardGame = new HardGame();
        private static Random rng = new Random();
       // public static Top10 top10 = new Top10();   

        public static void Shuffle<T>(this IList<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
    }
}
