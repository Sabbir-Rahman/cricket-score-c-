using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CricketScore
{
    class Situation
    {
        public enum WideNo { wide, no }
        Score score = new Score();
        public void increaseRun(int run)
        {
            score.Run += run;
            increaseBall();
            score.scoreDisplay();
        }

        public void increaseRun(int run, WideNo isWideOrNo)
        {
            score.Run += run;
            score.scoreDisplay();
        }

        public void increaseBall()
        {
            score.Ball += 1;
        }

        public void increaseWicket()
        {
            score.Wicket += 1;
            increaseBall();
            score.scoreDisplay();
        }

    }
}
