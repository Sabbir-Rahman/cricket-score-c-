using System;
using System.Collections;
namespace CricketScore
{
    class Program
    {

        static void Main(string[] args)
        {

            int totalBalls, commandStatus, noBallRun, ballsRemain;
            float totalOvers;
            
            Console.WriteLine("Enter the number of overs game");
            totalOvers = Convert.ToInt32(Console.ReadLine());

            totalBalls = (int)totalOvers * 6;
            ballsRemain = totalBalls;

            //initialize the class
            Command command = new Command();
           
            while (ballsRemain> 0)
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
                        Console.WriteLine("It's a no ball, Enter the no ball run and next ball is free hit");
                        noBallRun = Convert.ToInt32(Console.ReadLine());
                        command.noBall(noBallRun);
                        break;
                    default:
                        break;
                }
                ballsRemain--;
            }

        }

    }
}

