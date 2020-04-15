using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login_Nba_game
{
    public class Devin : Player
    {
        public Devin()
        {
            outsidescoring = 90;
            insidescoring = 54;
            athleticism = 73;
            playmaking = 80;
            defending = 55;
            rebounding = 43;
            name = "Devin Booker";
            Getstats();
        }

    }
}
