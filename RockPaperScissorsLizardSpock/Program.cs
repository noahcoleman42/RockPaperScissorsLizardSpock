// Written by Noah Coleman
// 11/23/2020

// This is a text-based implementation of the classic Rock Paper Scissors Lizard Spock game from "The Big Bang Theory"
// Enjoy!

using System;

namespace RockPaperScissorsLizardSpock
{
    public class Program
    {
        public static void Main(string[] args)
        {
            bool keepPlaying = true;
            while (keepPlaying)
            {
                int userWins = 0;
                int computerWins = 0;
                string userHand;

                // User entry
                Console.WriteLine("Enter a hand:");
                while (userWins < 3 && computerWins < 3)
                {
                    Console.WriteLine(
                        "1) Rock\n" +
                        "2) Paper\n" +
                        "3) Scissors\n" +
                        "4) Lizard\n" +
                        "5) Spock");
                    try
                    {
                        userHand = Console.ReadLine().ToLower();
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Invalid entry. Please enter a number 1 through 5");
                        continue;
                    }

                    // Print user shape to console 
                    Shapes aShape = new Shapes();
                    string userShape = aShape.DetermineUserShape(userHand);
                    Console.WriteLine(userShape);

                    // Make a new player based on user input
                    Player user = new Player(userHand, userWins);

                    // Randomly choose computer hand
                    Game aGame = new Game();
                    string computerHand = aGame.RandomlyChoose();

                    // Create a new computer player based on random choice
                    Player computer = new Player(computerHand, computerWins);

                    // Determine the winner of the game and print to console
                    string winner = aGame.DetermineWinner(user, computer);
                    Console.WriteLine(winner);

                    // Determine the score and print to console
                    int[] scores = aGame.DetermineScore(user, computer);
                    userWins = scores[0];
                    computerWins = scores[1];

                    Console.WriteLine();
                    Console.WriteLine(
                        "Player: \t" + userWins + "\n" +
                        "Computer: \t" + computerWins + "\n");
                    Console.WriteLine("========================================================================================================================");
                }
                // Print who won
                if (userWins > computerWins)
                {
                    Console.WriteLine("YOU WIN!!!\n");
                }
                else
                {
                    Console.WriteLine("YOU LOSE :(\n");
                }
                // Check if the user wants to keep playing
                Console.WriteLine("Keep playing? (Y/N)");
                if (Console.ReadLine().ToLower() == "n")
                    keepPlaying = false;
                else
                    Console.WriteLine("--------------------------------------------------------New Game--------------------------------------------------------\n");
            }
        }
    }
}
