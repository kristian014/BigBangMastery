namespace BigBangMastery.Constants
{
    public class GameConstants
    {
        public static readonly string[] ChoicesRPS = { ChoiceConstants.Rock, ChoiceConstants.Paper, ChoiceConstants.Scissors };
        public static readonly string[] ChoicesRPSLS = { ChoiceConstants.Rock, ChoiceConstants.Paper, ChoiceConstants.Scissors, ChoiceConstants.Lizard, ChoiceConstants.Spock };

        public static readonly Dictionary<string, string[]> WinningConditionsRPS = new Dictionary<string, string[]>
        {
            { ChoiceConstants.Rock, new string[] { ChoiceConstants.Scissors } },
            { ChoiceConstants.Paper, new string[] { ChoiceConstants.Rock } },
            { ChoiceConstants.Scissors, new string[] { ChoiceConstants.Paper } }
        };

        public static readonly Dictionary<string, string[]> WinningConditionsRPSLS = new Dictionary<string, string[]>
        {
            { ChoiceConstants.Rock, new string[] { ChoiceConstants.Scissors, ChoiceConstants.Lizard } },
            { ChoiceConstants.Paper, new string[] { ChoiceConstants.Rock, ChoiceConstants.Spock } },
            { ChoiceConstants.Scissors, new string[] { ChoiceConstants.Paper, ChoiceConstants.Lizard } },
            { ChoiceConstants.Lizard, new string[] { ChoiceConstants.Spock, ChoiceConstants.Paper } },
            { ChoiceConstants.Spock, new string[] { ChoiceConstants.Scissors, ChoiceConstants.Rock } },
        };
    }
}
