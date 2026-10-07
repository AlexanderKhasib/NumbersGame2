using System;
using System.Collections.Generic;
using System.Text;
namespace NumbersGame2
{
    internal class UserStats
    {
        // Create a feild for the users default stats.
        public Random random = new Random();
        public int Number { get; set; }

        public int Attempt { get; set; } = 0;
        public int MaxAttempts { get; set; } = 5;
        public bool GameWon { get; set; } = false;


        // Constructor for UserStats class
        public UserStats(int attempt, int maxAttempts, bool gameWon)
        {
            Number = random.Next(1, 20);
            Attempt = attempt;
            MaxAttempts = maxAttempts;
            GameWon = gameWon;
        }
    }
}
