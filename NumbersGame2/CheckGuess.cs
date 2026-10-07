using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace NumbersGame2
{
    internal class CheckGuess
    {
        // Create new object for UserStats
        UserStats userStats = new UserStats(0, 5, false);

        // An Higher or Lower method to compare the userGuess to the random number assigned. 
        // Also keeps tracks of your attempts and game status - Win / Lose.
        public void HigherOrLower()
        {
            // While loop to make sure user is still able to guess as long as 
            // UserAttempts doesn't equal MaxAttempts and the game is NOT won
            while (userStats.Attempt != userStats.MaxAttempts && !userStats.GameWon)
            {
                // Add on attempt after each guess
                userStats.Attempt++;

                // Save user input in string guess
                string guess = Console.ReadLine();

                // TryParse the guess string to int userGuess to only allow numbers and no other charachter
                if (!int.TryParse(guess, out int userGuess))
                {
                    Console.WriteLine("Ange en sifra");

                    // If users enters invalid characater, remove attempt and continue for loop
                    userStats.Attempt--;
                    continue;

                }
                // If the user guesses correct, execute if statment and end game with gameWon = true;
                if (userGuess == userStats.Number)
                {
                    userStats.GameWon = true;
                    Console.WriteLine("Wohoo! Du klarade det!");
                    break;
                }
                
                // If user guess is bigger than the random number, execute this else if statment
                else if (userGuess > userStats.Number)
                {
                    Console.WriteLine("Tyvärr, du gissade för högt!");
                    continue;
                }
               
                // If user guess is less than the random number, execute this else if statment
                else if (userGuess < userStats.Number)
                {
                    Console.WriteLine("Tyvärr, du gissade för lågt!");
                    continue;
                }
            }
            // If statement outside while loop to display loss message.
            if (!userStats.GameWon)
            {
                Console.WriteLine("Tyvärr, du lyckades inte gissa talet på fem försök!");
            }
        }

        // Method to print out welcome message and results
        public void PrintResult()
        {
            Console.WriteLine("Välkommen! Jag tänker på ett nummer. Kan du gissa vilket? Du får fem försök.");
            HigherOrLower();
        }
    }
}
