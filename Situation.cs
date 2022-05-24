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
            stat.Run += run;
        }

        public void increaseBall(int ball)
        {
            stat.Ball += 1;
        }

        public void increaseWicket()
        {
            stat.Wicket += 1;
        }
    }
}
