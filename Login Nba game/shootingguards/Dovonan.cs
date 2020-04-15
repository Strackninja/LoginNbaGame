using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login_Nba_game
{
    public class Donovan : Player
    {
        public Donovan()
        {
            outsidescoring = 90;
            insidescoring = 63;
            athleticism = 86;
            playmaking = 79;
            defending = 69;
            rebounding = 44;
            name = "Donovan Mitchell";
            Getstats();
        }
    }
}
