
namespace CricketScore
{
    class ScoreDisplay
    {
        public void scoreDisplay()
        {
            Score.OversPlayed = Score.Ball / 6;
            int ballPlayedInTheOver = Score.Ball % 6;

            Console.WriteLine("Run : {0}, Wicket : {1}, Ball : {2}, Over - {3}", Score.Run, Score.Wicket, ballPlayedInTheOver, Score.OversPlayed);
            Console.WriteLine("Total Score : {0}/{1} {2}.{3} Overs", Score.Run, Score.Wicket, Score.OversPlayed, ballPlayedInTheOver);
        }
    }
}
