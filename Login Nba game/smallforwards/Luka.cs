using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login_Nba_game
{
    public class Luka : Player
    {
        public Luka()
        {
            outsidescoring = 91;
            insidescoring = 78;
            athleticism = 84;
            playmaking = 90;
            defending = 63;
            rebounding = 78;
            name = "Luka Doncic";
            Getstats();
        }
    }
}
