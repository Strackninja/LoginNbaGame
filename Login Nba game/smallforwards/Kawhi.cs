using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login_Nba_game
{
    public class Kawhi : Player
    {
        public Kawhi()
        {
            outsidescoring = 89;
            insidescoring = 79;
            athleticism = 83;
            playmaking = 80;
            defending = 89;
            rebounding = 59;
            name = "Kawhi Leonard";
            Getstats();
        }
    }
}
