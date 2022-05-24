using System;
using System.Collections;
namespace CricketScore
{
    class Program
    {

        static void Main(string[] args)
        {

            int ballsPlayed, wicket, run, ballsRemain, ballPlayedInTheOver, noBallRun, freeHitBallRun;
            float oversPlayed, oversRemain;
            int commandStatus;

            Console.WriteLine("Enter the number of overs game");
            oversRemain = Convert.ToInt32(Console.ReadLine());

            ballsRemain = (int)oversRemain * 6;
            run = 0;
            ballsPlayed = 0;
            wicket = 0;
            oversPlayed = 0;
            noBallRun = 0;
            freeHitBallRun = 0;
            ballPlayedInTheOver = ballsPlayed - (int)(oversPlayed * 6);

            while (ballsRemain > 0)
            {
                commandStatus = Convert.ToInt32(Console.ReadLine());


                switch (commandStatus)
                {
                    case 0:
                        run += 0;
                        Console.WriteLine("Dot ball");
                        break;
                    case 1:
                        Console.WriteLine("Goes for a single");
                        run += 1;
                        break;
                    case 2:
                        Console.WriteLine("Nice running between the wicket it's a double");
                        run += 2;
                        break;
                    case 3:
                        run += 3;
                        Console.WriteLine("Sloppy fielding 3 run ");
                        break;
                    case 4:
                        Console.WriteLine("Nice shot 4 run");
                        run += 4;
                        break;
                    case 5:
                        Console.WriteLine("It's rare 5 run");
                        run += 5;
                        break;
                    case 6:
                        Console.WriteLine("Massive hit it's a six");
                        run += 6;
                        break;
                    // wicket
                    case 7:
                        Console.WriteLine("Nice bowling it's a wicket");
                        wicket += 1;
                        break;
                    //wide
                    case 8:
                        run += 1;
                        ballsRemain += 1;
                        ballsPlayed -= 1;
                        Console.WriteLine("It's a wide");
                        break;
                    // no ball
                    case 9:
                        run += 1;

                        Console.WriteLine("It's a no ball, Enter the no ball run and next ball is free hit");
                        noBallRun = Convert.ToInt32(Console.ReadLine());
                        run += noBallRun;
                        noBallRun = 0;

                        // display the run
                        Console.WriteLine("Run : {0}, Wicket : {1}, Ball : {2}, Over - {3}", run, wicket, ballPlayedInTheOver, oversPlayed);
                        Console.WriteLine("Total Score : {0}/{1} {2}.{3} Overs", run, wicket, oversPlayed, ballPlayedInTheOver);

                        Console.WriteLine("Enter the free hit run");
                        freeHitBallRun = Convert.ToInt32(Console.ReadLine());
                        run += freeHitBallRun;
                        freeHitBallRun = 0;

                        break;
                    default:
                        break;
                }

                ballsRemain -= 1;
                ballsPlayed += 1;
                oversPlayed = ballsPlayed / 6;
                ballPlayedInTheOver = ballsPlayed - (int)(oversPlayed * 6);

                Console.WriteLine("Run : {0}, Wicket : {1}, Ball : {2}, Over - {3}", run, wicket, ballPlayedInTheOver, oversPlayed);
                Console.WriteLine("Total Score : {0}/{1} {2}.{3} Overs", run, wicket, oversPlayed, ballPlayedInTheOver);
            }


        }

    }
}

