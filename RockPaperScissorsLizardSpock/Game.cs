// Written by Noah Coleman
// 11/23/2020

using System;

namespace RockPaperScissorsLizardSpock
{
    public class Game
    {
        // Returns a message based on game outcome
        public string DetermineWinner(Player user, Player computer)
        {
            string userHand = user.Hand;
            string computerHand = computer.Hand;

            // Rock
            if (userHand == "1" || userHand == "rock")
            {
                if (computerHand == "rock")
                    return "tie";
                if (computerHand == "paper")
                    return "Paper covers Rock";
                if (computerHand == "scissors")
                    return "Rock crushes Scissors";
                if (computerHand == "lizard")
                    return "Rock crushes Lizard";
                if (computerHand == "spock")
                    return "Spock vaporizes Rock";
            }
            // Paper
            if (userHand == "2" || userHand == "paper")
            {
                if (computerHand == "rock")
                    return "Paper covers Rock";
                if (computerHand == "paper")
                    return "tie";
                if (computerHand == "scissors")
                    return "Scissors cuts Paper";
                if (computerHand == "lizard")
                    return "Lizard eats Paper";
                if (computerHand == "spock")
                    return "Paper disproves Spock";
            }
            // Scissors
            if (userHand == "3" || userHand == "scissors")
            {
                if (computerHand == "rock")
                    return "Rock crushes Scissors";
                if (computerHand == "paper")
                    return "Scissors cuts Paper";
                if (computerHand == "scissors")
                    return "tie";
                if (computerHand == "lizard")
                    return "Scissors decapitates Lizard";
                if (computerHand == "spock")
                    return "Spock smashes Scissors";
            }
            // Lizard
            if (userHand == "4" || userHand == "lizard")
            {
                if (computerHand == "rock")
                    return "Rock crushes Lizard";
                if (computerHand == "paper")
                    return "Lizard eats Paper";
                if (computerHand == "scissors")
                    return "Scissors decapitates Lizard";
                if (computerHand == "lizard")
                    return "tie";
                if (computerHand == "spock")
                    return "Lizard poisons Spock";
            }
            // Spock
            if (userHand == "5" || userHand == "spock")
            {
                if (computerHand == "rock")
                    return "Spock vapoizes Rock";
                if (computerHand == "paper")
                    return "Paper disproves Spock";
                if (computerHand == "scissors")
                    return "Spock smashes Scissors";
                if (computerHand == "lizard")
                    return "Lizard Poisons Spock";
                if (computerHand == "spock")
                    return "tie";
            }
            return "Invalid entry. Please enter a number 1 through 5";
        }

        // Determines the score based on game outcome
        // Returns { userScore, computerScore }.
        public int[] DetermineScore(Player user, Player computer)
        {
            int userScore = user.Score;
            int computerScore = computer.Score;
            string userHand = user.Hand;
            string computerHand = computer.Hand;

            // Rock
            if (userHand == "1" || userHand == "rock")
            {
                if (computerHand == "paper")
                    computerScore += 1;
                if (computerHand == "scissors")
                    userScore += 1;
                if (computerHand == "lizard")
                    userScore += 1;
                if (computerHand == "spock")
                    computerScore += 1;
            }
            // Paper
            if (userHand == "2" || userHand == "paper")
            {
                if (computerHand == "rock")
                    userScore += 1;
                if (computerHand == "scissors")
                    computerScore += 1;
                if (computerHand == "lizard")
                    computerScore += 1;
                if (computerHand == "spock")
                    userScore += 1;
            }
            // Scissors
            if (userHand == "3" || userHand == "scissors")
            {
                if (computerHand == "rock")
                    computerScore += 1;
                if (computerHand == "paper")
                    userScore += 1;
                if (computerHand == "lizard")
                    userScore += 1;
                if (computerHand == "spock")
                    computerScore += 1;
            }
            // Lizard
            if (userHand == "4" || userHand == "lizard")
            {
                if (computerHand == "rock")
                    computerScore += 1;
                if (computerHand == "paper")
                    userScore += 1;
                if (computerHand == "scissors")
                    computerScore += 1;
                if (computerHand == "spock")
                    userScore += 1;
            }
            // Spock
            if (userHand == "5" || userHand == "spock")
            {
                if (computerHand == "rock")
                    userScore += 1;
                if (computerHand == "paper")
                    computerScore += 1;
                if (computerHand == "scissors")
                    userScore += 1;
                if (computerHand == "lizard")
                    computerScore += 1;
            }
            int[] scores = { userScore, computerScore };
            return scores;
        }

        // Returns one of the five hands chosen randomly
        public string RandomlyChoose()
        {
            Random rand = new Random();
            int randInt = rand.Next(1, 6);
            switch (randInt)
            {
                case 1:
                    return "rock";
                case 2:
                    return "paper";
                case 3:
                    return "scissors";
                case 4:
                    return "lizard";
                case 5:
                    return "spock";
                default:
                    return "computer decided not to choose for some reason";
            }
        }
    }
}
