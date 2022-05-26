using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CricketScore
{
    class Commentery
    {
        public string loadCommentery(string command)
        {
            switch (command)
            {
                case "dot":
                    return "Dot ball";
                case "single":
                    return "Goes for a single";
                case "double":
                    return "Nice running between the wicket it's a double";
                case "triple":
                    return "Sloppy fielding 3 run";
                case "four":
                    return "Nice shot 4 run";
                case "five":
                    return "It's rare 5 run";
                case "six":
                    return "Massive hit it's a six";
                case "wicket":
                    return "Nice bowling it's a wicket";
                case "wide":
                    return "It's a wide";
                case "no":
                    return "Enter the free hit run";
                default:
                    return "";


            }
        }

    }
}
