using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CricketScore
{
    public class ScoreCalculate
    {   
        Situation situation = new Situation();
        Commentery commentery = new Commentery();
        ScoreDisplay scoreDisplay = new ScoreDisplay();
        
        public void calculateRun(int run,ScoreEnum.Situation situationEnum )
        {
            if (situationEnum == ScoreEnum.Situation.run)
            {
                situation.increaseRun(run);
                Console.WriteLine(commentery.loadCommentery(run));
                scoreDisplay.scoreDisplay();

            } else if (situationEnum == ScoreEnum.Situation.wide)
            {
                situation.increaseRun(1, ScoreEnum.Situation.wide);
                Console.WriteLine(commentery.loadCommentery(8));
                scoreDisplay.scoreDisplay();

            } else if (situationEnum == ScoreEnum.Situation.no)
            {
                Console.WriteLine("It's a no ball, Enter the no ball run and next ball is free hit");
                int noBallRun = Convert.ToInt32(Console.ReadLine());

                situation.increaseRun(noBallRun + 1, ScoreEnum.Situation.no);
                Console.WriteLine(commentery.loadCommentery(noBallRun));
                scoreDisplay.scoreDisplay();

                Console.WriteLine(commentery.loadCommentery(9));
                int freeHitRun = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(commentery.loadCommentery(freeHitRun));
                situation.increaseRun(freeHitRun);
                scoreDisplay.scoreDisplay();

            } else if (situationEnum == ScoreEnum.Situation.wicket)
            {
                situation.increaseWicket();
                Console.WriteLine(commentery.loadCommentery(7));
                scoreDisplay.scoreDisplay();

            } else
            {
                Console.WriteLine("Something wrong");
            }
        }
    }
}

// commentry load 
