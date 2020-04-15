using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login_Nba_game
{
    public class Damian : Player
    {
        public Damian()
        {
            outsidescoring = 92;
            insidescoring = 63;
            athleticism = 88;
            playmaking = 90;
            defending = 58;
            rebounding = 42;
            name = "Damian Lillard";

            Getstats();
        }
    }
}
