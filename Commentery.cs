using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CricketScore
{
    class Commentery
    {
        public string loadCommentery(int command)
        {
            switch (command)
            {
                case 0:
                    return "Dot ball";
                case 1:
                    return "Goes for a single";
                case 2:
                    return "Nice running between the wicket it's a double";
                case 3:
                    return "Sloppy fielding 3 run";
                case 4:
                    return "Nice shot 4 run";
                case 5:
                    return "It's rare 5 run";
                case 6:
                    return "Massive hit it's a six";
                case 7:
                    return "Nice bowling it's a wicket";
                case 8:
                    return "It's a wide";
                case 9:
                    return "Enter the free hit run";
                default:
                    return "";


            }
        }

    }
}
