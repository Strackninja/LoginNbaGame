using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login_Nba_game
{
    public class James : Player
    {
        public James()
        {
            outsidescoring = 91;
            insidescoring = 79;
            athleticism = 90;
            playmaking = 89;
            defending = 67;
            rebounding = 52;
            name = "James Harden";
            Getstats();
        }
    }
}
