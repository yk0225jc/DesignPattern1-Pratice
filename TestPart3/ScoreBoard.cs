//Written by Jiameng Zhou
//04/02/2021

namespace TestPart3
{
    public class Scoreboard
    {
        private static Scoreboard aScoreBoard = new Scoreboard();
        public int player1Points = 0;
        public int player2Points = 0;
        private Scoreboard() { }




        public static Scoreboard GetScoreBoard()
        {
            return aScoreBoard;
        }

    }
}
