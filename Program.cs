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
            ScoreCalculate command = new ScoreCalculate();

            Console.WriteLine("Enter the command 0-6 for run, 7 for wicket, 8 for wide, 9 for no ball");
           
            while (Score.BallsRemain > 0)
            {
                commandStatus = Convert.ToInt32(Console.ReadLine());
                switch (commandStatus)
                {
                    case 0:
                        command.dotBall();
                        break;
                    case 1:
                        command.single();
                        break;
                    case 2:
                        command.twoRun();
                        break;
                    case 3:
                        command.threeRun();
                        break;
                    case 4:
                        command.fourRun();
                        break;
                    case 5:
                        command.fiveRun();
                        break;
                    case 6:
                        command.sixRun();
                        break;
                    // wicket
                    case 7:
                        command.wicket();
                        break;
                    //wide
                    case 8:
                        command.wide();
                        break;
                    // no ball
                    case 9:
                        //not in here
                        Console.WriteLine("It's a no ball, Enter the no ball run and next ball is free hit");
                        int noBallRun = Convert.ToInt32(Console.ReadLine());
                        command.noBall(noBallRun);
                        break;
                    default:
                        break;
                }
                Score.BallsRemain--;
            }

        }

    }
}

