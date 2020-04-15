using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login_Nba_game
{
    public class Kyrie : Player
    {
        public Kyrie()
        {
            outsidescoring = 91;
            insidescoring = 63;
            athleticism = 80;
            playmaking = 88;
            defending = 65;
            rebounding = 49;
            name = "Kyrie Erving";
            Getstats();
        }
    }
}
