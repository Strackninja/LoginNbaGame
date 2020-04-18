using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login_Nba_game
{
    public class Player
    {
        //De olika värdena alla spelare kommer ha
        //protected istället för 
        protected int outsidescoring;
        protected int insidescoring;
        protected int athleticism;
        protected int playmaking;
        protected int defending;
        protected int rebounding;
        public string name;

        public void Getstats()//En metod som printar ut spelarens stats 
        {
            Console.WriteLine();
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Outside Scoring: " + outsidescoring);
            Console.WriteLine("Inside Scoring: " + insidescoring);
            Console.WriteLine("Athleticism:" + athleticism);
            Console.WriteLine("Playmaking: " + playmaking);
            Console.WriteLine("Defending: " + defending);
            Console.WriteLine("Reboudning: " + rebounding);
            Console.WriteLine();
        }

        public int AddStats()//en metod som plussar ihop alla spelarens stats
        {
            int playerStats = (outsidescoring + insidescoring + athleticism + playmaking + defending + rebounding);
            return playerStats;
        }
    }

}
