using System;
using System.Collections;
namespace CricketScore
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of overs game");
            Score.TotalOvers = Convert.ToInt32(Console.ReadLine());

            Score.BallsRemain = (int)Score.TotalOvers * 6;
            int commandStatus;
            //initialize the class
            ScoreCalculate scoreCalculate = new ScoreCalculate();

            Console.WriteLine("Enter the command 0-6 for run, 7 for wicket, 8 for wide, 9 for no ball");
           
            while (Score.BallsRemain > 0)
            {
                commandStatus = Convert.ToInt32(Console.ReadLine());
                switch (commandStatus)
                {
                    case 0:
                        scoreCalculate.calculateRun(0, ScoreEnum.Situation.run);
                        break;
                    case 1:
                        scoreCalculate.calculateRun(1, ScoreEnum.Situation.run);
                        break;
                    case 2:
                        scoreCalculate.calculateRun(3, ScoreEnum.Situation.run);
                        break;
                    case 3:
                        scoreCalculate.calculateRun(4, ScoreEnum.Situation.run);
                        break;
                    case 4:
                        scoreCalculate.calculateRun(4, ScoreEnum.Situation.run);
                        break;
                    case 5:
                        scoreCalculate.calculateRun(5, ScoreEnum.Situation.run);
                        break;
                    case 6:
                        scoreCalculate.calculateRun(6, ScoreEnum.Situation.run);
                        break;
                    // wicket
                    case 7:
                        scoreCalculate.calculateRun(7, ScoreEnum.Situation.wicket);
                        break;
                    //wide
                    case 8:
                        scoreCalculate.calculateRun(8, ScoreEnum.Situation.wide);
                        break;
                    // no ball
                    case 9:
                        scoreCalculate.calculateRun(9, ScoreEnum.Situation.no);
                        break;
                    default:
                        break;
                }
                Score.BallsRemain--;
            }

        }

    }
}

