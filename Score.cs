using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CricketScore
{
    class Score
    {
        private int run =0, ball=0, wicket =0, ballPlayedInTheOver = 0;
        private float oversPlayed = 0 ;

        
        public int Run { get { return run; } set { run = value; } }

        public int Ball { get { return ball; } set { ball = value; } }
        public int Wicket { get { return wicket; } set { wicket = value; } }
        public int BallPlayedInTheOver { get { return ballPlayedInTheOver;} set { ballPlayedInTheOver = value; } }
        public float OversPlayed { get { return oversPlayed; } set { oversPlayed = value; } }

        public void scoreDisplay()
        {
            oversPlayed = ball/6;
            ballPlayedInTheOver = ball%6;

            Console.WriteLine("Run : {0}, Wicket : {1}, Ball : {2}, Over - {3}", run, wicket, ballPlayedInTheOver, oversPlayed);
            Console.WriteLine("Total Score : {0}/{1} {2}.{3} Overs", run, wicket, oversPlayed, ballPlayedInTheOver);
        }

    }
}
