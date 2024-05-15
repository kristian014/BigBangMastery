namespace BigBangMastery.Constants
{
    public class GameConstants
    {
        public static readonly string[] ChoicesRPS = { "rock", "paper", "scissors" };
        public static readonly string[] ChoicesRPSLS = { "rock", "paper", "scissors", "lizard", "spock" };

        public static readonly Dictionary<string, string[]> WinningConditionsRPS = new Dictionary<string, string[]>
        {
            { "rock", new string[] { "scissors" } },
            { "paper", new string[] { "rock" } },
            { "scissors", new string[] { "paper" } }
        };

        public static readonly Dictionary<string, string[]> WinningConditionsRPSLS = new Dictionary<string, string[]>
        {
            { "rock", new string[] { "scissors", "lizard" } },
            { "paper", new string[] { "rock", "spock" } },
            { "scissors", new string[] { "paper", "lizard" } },
            { "lizard", new string[] { "spock", "paper" } },
            { "spock", new string[] { "scissors", "rock" } }
        };
    }
}
