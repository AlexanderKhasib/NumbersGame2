namespace NumbersGame2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create new objects for classes
            CheckGuess checkGuess = new CheckGuess();
            UserStats userStats = new UserStats(0, 5, false);

            // Print out results
            checkGuess.PrintResult();
        }
    }
}
