// Written by Noah Coleman
// 11/23/2020

// Credit to Veronica Karlsson https://www.ludd.ltu.se/~vk/pics/ascii/ascii3.shtml for rock, paper, scissor ASSCI art, and inpiration for lizard and Spock shapes


namespace RockPaperScissorsLizardSpock
{
    public class Shapes
    {
        // Class vars
        private string userRock =
            "                   \n" +
            "    _______        \n" +
            "---'   ____)       \n" +
            "      (_____)      \n" +
            "      (_____)      \n" +
            "      (____)       \n" +
            "---.__(___)        \n" +
            "                   \n";
        private string userPaper =
            "                   \n" +
            "    _______        \n" +
            "---'   ____)____   \n" +
            "          ______)  \n" +
            "          _______) \n" +
            "         _______)  \n" +
            "---.__________)    \n" +
            "                   \n";
        private string userScissors =
            "                   \n" +
            "    _______        \n" +
            "---'   ____)____   \n" +
            "          ______)  \n" +
            "       __________) \n" +
            "      (____)       \n" +
            "---.__(___)        \n" +
            "                   \n";
        private string userLizard =
            "                   \n" +
            "     ____________  \n" +
            "    /   _________) \n" +
            "   /   (______     \n" +
            "  /     ______)    \n" +
            " /   __/           \n" +
            "/   /              \n" +
            "                   \n";
        private string userSpock =
            "    __      __     \n" +
            "   _\\ \\    / /_  \n" +
            "   \\ \\ \\  / / / \n" +
            "    \\ \\ \\/ / /  \n" +
            "  ___\\       |    \n" +
            " (____       |     \n" +
            "      \\     /     \n" +
            "       |   |       \n";


        // Accessors
        public string UserRock
        {
            get { return userRock; }
        }
        public string UserPaper
        {
            get { return userPaper; }
        }
        public string UserScissors
        {
            get { return userScissors; }
        }
        public string UserLizard
        {
            get { return userLizard; }
        }
        public string UserSpock
        {
            get { return userSpock; }
        }


        // Methods
        public string DetermineUserShape(string userHand)
        {
            if (userHand == "1" || userHand == "rock")
                return this.UserRock;
            if (userHand == "2" || userHand == "paper")
                return this.UserPaper;
            if (userHand == "3" || userHand == "scissors")
                return this.UserScissors;
            if (userHand == "4" || userHand == "lizard")
                return this.UserLizard;
            if (userHand == "5" || userHand == "spock")
                return this.UserSpock;
            return null;
        }
    }
}
