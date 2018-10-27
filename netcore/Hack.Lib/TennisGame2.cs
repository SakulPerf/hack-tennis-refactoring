using System;

namespace Hack.Lib
{
    public class TennisGame2 : ITennisGame
    {
        private int player1Point;
        private int player2Point;
        private string player1Name;
        private string player2Name;

        public TennisGame2(string player1Name, string player2Name)
        {
            this.player1Name = player1Name;
            this.player2Name = player2Name;
        }

        public string SetScore(int Score)
        {
            if (Score == 0)
                return  "Love";
            if (Score == 1)
                return  "Fifteen";
            if (Score == 2)
                return "Thirty";
            if (Score == 3)
                return "Forty";
            throw new Exception();
        }

        public string GetScore()
        {
            string player1Result = "";
            string player2Result = "";
            var score = "";
            if (player1Point == player2Point && player1Point < 3)
            {
                score = string.Format("{0}-All", SetScore(player2Point));
            }
            if (player1Point == player2Point && player1Point > 2)
                score = "Deuce";

            if (player1Point > 0 && player2Point == 0)
            {
                if (player1Point == 1)
                    player1Result = "Fifteen";
                if (player1Point == 2)
                    player1Result = "Thirty";
                if (player1Point == 3)
                    player1Result = "Forty";

                player2Result = "Love";
                score = player1Result + "-" + player2Result;
            }
            if (player2Point > 0 && player1Point == 0)
            {
                if (player2Point == 1)
                    player2Result = "Fifteen";
                if (player2Point == 2)
                    player2Result = "Thirty";
                if (player2Point == 3)
                    player2Result = "Forty";

                player1Result = "Love";
                score = player1Result + "-" + player2Result;
            }

            if (player1Point > player2Point && player1Point < 4)
            {
                if (player1Point == 2)
                    player1Result = "Thirty";
                if (player1Point == 3)
                    player1Result = "Forty";
                if (player2Point == 1)
                    player2Result = "Fifteen";
                if (player2Point == 2)
                    player2Result = "Thirty";
                score = player1Result + "-" + player2Result;
            }
            if (player2Point > player1Point && player2Point < 4)
            {
                if (player2Point == 2)
                    player2Result = "Thirty";
                if (player2Point == 3)
                    player2Result = "Forty";
                if (player1Point == 1)
                    player1Result = "Fifteen";
                if (player1Point == 2)
                    player1Result = "Thirty";
                score = player1Result + "-" + player2Result;
            }

            if (player1Point > player2Point && player2Point >= 3)
            {
                score = "Advantage player1";
            }

            if (player2Point > player1Point && player1Point >= 3)
            {
                score = "Advantage player2";
            }

            if (player1Point >= 4 && player2Point >= 0 && (player1Point - player2Point) >= 2)
            {
                score = "Win for player1";
            }
            if (player2Point >= 4 && player1Point >= 0 && (player2Point - player1Point) >= 2)
            {
                score = "Win for player2";
            }
            return score;
        }

        public void WonPoint(string player)
        {
            if (player == "player1")
                player1Point++;
            else
                player2Point++;
        }

    }
}

