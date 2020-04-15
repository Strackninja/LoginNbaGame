using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login_Nba_game
{
    public class Russel : Player
    {
        public Russel()
        {
            outsidescoring = 78;
            insidescoring = 74;
            athleticism = 92;
            playmaking = 87;
            defending = 70;
            rebounding = 60;
            name = "Russel Westbrook";
            Getstats();
        }
    }
}
