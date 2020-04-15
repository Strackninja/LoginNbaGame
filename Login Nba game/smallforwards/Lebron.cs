using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login_Nba_game
{
    public class Lebron : Player
    {
        public Lebron()
        {
            outsidescoring = 86;
            insidescoring = 89;
            athleticism = 92;
            playmaking = 92;
            defending = 75;
            rebounding = 60;
            name = "Lebron James";
            Getstats();
        }
    }
}
