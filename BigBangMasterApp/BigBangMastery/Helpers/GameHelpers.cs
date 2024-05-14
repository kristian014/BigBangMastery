using BigBangMastery.Constants;

namespace BigBangMastery.Helpers
{
    public static class GameHelpers
    {
        public static void PrintResult(string userChoice, string computerChoice)
        {
            if (userChoice.Equals(computerChoice))
            {
                Console.WriteLine("It's a tie!");
            }
            else if (IsUserWinner(userChoice, computerChoice))
            {
                Console.WriteLine("You win!");
            }
            else
            {
                Console.WriteLine("You lose!");
            }
        }

        public static bool IsUserWinner(string userChoice, string computerChoice)
        {
            if (!string.IsNullOrEmpty(userChoice) && !string.IsNullOrEmpty(computerChoice) && GameConstants.WinningConditions.TryGetValue(userChoice, out var winningChoices))
            {
                return winningChoices.Contains(computerChoice);
            }
            return false;
        }

        public static void ValidateChoicesLength(string[] _choices)
        {
            if (_choices.Length < 3)
            {
                throw new InvalidOperationException("The choices array must have at least 3 elements.");
            }
        }
    }
}
