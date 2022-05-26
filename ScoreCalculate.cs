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
        
        public void dotBall()
        {
            situation.increaseRun(0);
            Console.WriteLine(commentery.loadCommentery("dot"));
        }

        public void single()
        {
            situation.increaseRun(1);
            Console.WriteLine(commentery.loadCommentery("single"));
        }

        public void twoRun()
        {
            situation.increaseRun(2);
            Console.WriteLine(commentery.loadCommentery("double"));
        }

        public void threeRun()
        {
            situation.increaseRun(3);
            Console.WriteLine(commentery.loadCommentery("triple"));
        }

        public void fourRun()
        {
            situation.increaseRun(4);
            Console.WriteLine(commentery.loadCommentery("four"));
        }

        public void fiveRun()
        {
            situation.increaseRun(5);
            Console.WriteLine(commentery.loadCommentery("five"));
        }

        public void sixRun()
        {
            situation.increaseRun(6);
            Console.WriteLine(commentery.loadCommentery("six"));
        }

        public void wicket()
        {
            situation.increaseWicket();
            Console.WriteLine(commentery.loadCommentery("wicket"));
        }

        public void wide()
        {
            situation.increaseRun(1, Situation.WideNo.wide);
            Console.WriteLine(commentery.loadCommentery("wide"));
        }

        public void noBall(int noBallRun)
        {
            situation.increaseRun(noBallRun + 1, Situation.WideNo.no);
            Console.WriteLine(commentery.loadCommentery("no"));
            int freeHitRun = Convert.ToInt32(Console.ReadLine());
            situation.increaseRun(freeHitRun);
        }
    }
}

// commentry load 
