using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CricketScore
{
    class Situation
    {
        Score score = new Score();
        public void increaseRun(int run)
        {
            score.Run += run;
            increaseBall();
        }

        public void increaseBall()
        {
            score.Ball += 1;
        }

        public void increaseWicket()
        {
            score.Wicket += 1;
        }

        public void wide()
        {
            score.Run += 1;
        }

        public void noBall(int run)
        {
            score.Run += run;
        }
    }
}
