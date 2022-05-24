using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CricketScore
{
    class Score
    {
        private int run, ball, wicket;
        public int Run { get { return run; } set { run = value; } }

        public int Ball { get { return ball; } set { ball = value; } }
        public int Wicket { get { return wicket; } set { wicket = value; } }

    }
}
