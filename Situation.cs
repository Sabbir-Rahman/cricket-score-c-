using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CricketScore
{
    class Situation
    {
        public void increaseRun(int run)
        {
            Score.Run += run;
            increaseBall();
        }

        public void increaseRun(int run,ScoreEnum.WideNo isWideOrNo)
        {
            Score.Run += run;
        }

        public void increaseBall()
        {
            Score.Ball += 1;
        }

        public void increaseWicket()
        {
            Score.Wicket += 1;
            increaseBall();
        }

    }
}
