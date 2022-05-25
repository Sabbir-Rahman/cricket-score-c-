using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CricketScore
{
    public class Command
    {   
        Situation situation = new Situation();
        
        public void dotBall()
        {
            situation.increaseRun(0);
            Console.WriteLine("Dot ball");
        }

        public void single()
        {
            situation.increaseRun(1);
            Console.WriteLine("Goes for a single");
        }

        public void twoRun()
        {
            situation.increaseRun(2);
            Console.WriteLine("Nice running between the wicket it's a double");
        }

        public void threeRun()
        {
            situation.increaseRun(3);
            Console.WriteLine("Sloppy fielding 3 run ");
        }

        public void fourRun()
        {
            situation.increaseRun(4);
            Console.WriteLine("Nice shot 4 run");
        }

        public void fiveRun()
        {
            situation.increaseRun(5);
            Console.WriteLine("It's rare 5 run");
        }

        public void sixRun()
        {
            situation.increaseRun(6);
            Console.WriteLine("Massive hit it's a six");
        }

        public void wicket()
        {
            situation.increaseWicket();
            Console.WriteLine("Nice bowling it's a wicket");
        }

        public void wide()
        {
            situation.increaseRun(1, Situation.WideNo.wide);
            Console.WriteLine("It's a wide");
        }

        public void noBall(int noBallRun)
        {
            situation.increaseRun(noBallRun + 1, Situation.WideNo.no);
            Console.WriteLine("Enter the free hit run");
            int freeHitRun = Convert.ToInt32(Console.ReadLine());
            situation.increaseRun(freeHitRun);
        }
    }
}
