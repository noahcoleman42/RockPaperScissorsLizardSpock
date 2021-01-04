// Written by Noah Coleman
// 11/23/2020

namespace RockPaperScissorsLizardSpock
{
    public class Player
    {
        // Class Vars
        private string hand;
        private int score;

        // Accessors
        public string Hand
        {
            get { return hand; }
            set { hand = value; }
        }
        public int Score
        {
            get { return score; }
            set { score = value; }
        }

        // Constructors
        public Player(string aHand, int aScore)
        {
            this.Hand = aHand;
            this.Score = aScore;
        }
        public Player(int aScore) : this("n/a", aScore)
        {
            // chained constructor
        }
        public Player()
        {
            // Empty constructor
        }
    }
}
