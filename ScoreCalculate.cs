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
        
        public void dotBall()
        {
            situation.increaseRun(0);
            Console.WriteLine(commentery.loadCommentery(0));
            scoreDisplay.scoreDisplay();
        }

        public void single()
        {
            situation.increaseRun(1);
            Console.WriteLine(commentery.loadCommentery(1));
            scoreDisplay.scoreDisplay();
        }

        public void twoRun()
        {
            situation.increaseRun(2);
            Console.WriteLine(commentery.loadCommentery(2));
            scoreDisplay.scoreDisplay();
        }

        public void threeRun()
        {
            situation.increaseRun(3);
            Console.WriteLine(commentery.loadCommentery(3));
            scoreDisplay.scoreDisplay();
        }

        public void fourRun()
        {
            situation.increaseRun(4);
            Console.WriteLine(commentery.loadCommentery(4));
            scoreDisplay.scoreDisplay();
        }

        public void fiveRun()
        {
            situation.increaseRun(5);
            Console.WriteLine(commentery.loadCommentery(5));
            scoreDisplay.scoreDisplay();
        }

        public void sixRun()
        {
            situation.increaseRun(6);
            Console.WriteLine(commentery.loadCommentery(6));
            scoreDisplay.scoreDisplay();
        }

        public void wicket()
        {
            situation.increaseWicket();
            Console.WriteLine(commentery.loadCommentery(7));
            scoreDisplay.scoreDisplay();
        }

        public void wide()
        {
            situation.increaseRun(1, ScoreEnum.WideNo.wide);
            Console.WriteLine(commentery.loadCommentery(8));
            scoreDisplay.scoreDisplay();
        }

        public void noBall()
        {
            Console.WriteLine("It's a no ball, Enter the no ball run and next ball is free hit");
            int noBallRun = Convert.ToInt32(Console.ReadLine());
            
            situation.increaseRun(noBallRun + 1, ScoreEnum.WideNo.no);
            Console.WriteLine(commentery.loadCommentery(noBallRun));
            scoreDisplay.scoreDisplay();
            
            Console.WriteLine(commentery.loadCommentery(9));
            int freeHitRun = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine(commentery.loadCommentery(freeHitRun));
            situation.increaseRun(freeHitRun);
            scoreDisplay.scoreDisplay();
        }
    }
}

// commentry load 
