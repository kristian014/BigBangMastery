using BigBangMastery.Constants;
using BigBangMastery.Helpers;
using BigBangMastery.Players.Interfaces;

namespace BigBangMastery.Games
{
    public class Game
    {
        private readonly string[] _choices;
        private string _lastUserChoice = string.Empty;
        private readonly IPlayer _randomComputerPlayer;
        private readonly IPlayer _lastChoiceComputerPlayer;

        public Game(string[] choices, IPlayer randomComputerPlayer, IPlayer lastChoiceComputerPlayer)
        {
            _choices = choices ?? throw new ArgumentNullException(nameof(choices));
            _randomComputerPlayer = randomComputerPlayer ?? throw new ArgumentNullException(nameof(randomComputerPlayer));
            _lastChoiceComputerPlayer = lastChoiceComputerPlayer ?? throw new ArgumentNullException(nameof(lastChoiceComputerPlayer));
            GameHelpers.ValidateChoicesLength(_choices);
        }

        public Game(int gameMode, IPlayer randomComputerPlayer, IPlayer lastChoiceComputerPlayer)
        {
            if (gameMode == 1)
            {
                _choices = GameConstants.ChoicesRPS;
            }
            else
            {
                _choices = GameConstants.ChoicesRPSLS;
            }

            _randomComputerPlayer = randomComputerPlayer;
            _lastChoiceComputerPlayer = lastChoiceComputerPlayer;
        }

        public void Play()
        {
            while (true)
            {
                Console.WriteLine("Enter your choice (rock, paper, scissors" + (_choices.Length > 3 ? ", lizard, spock" : "") + "). To exit the game, type 'exit': ");
                string userChoice = Console.ReadLine().ToLower();

                if (userChoice == "exit")
                {
                    break;
                }

                if (Array.IndexOf(_choices, userChoice) == -1)
                {
                    Console.WriteLine("Invalid choice. Please try again.");
                    continue;
                }

                string computerChoice1 = _randomComputerPlayer.GetChoice(_lastUserChoice);
                string computerChoice2 = _lastChoiceComputerPlayer.GetChoice(_lastUserChoice);
                _lastUserChoice = userChoice;

                Console.WriteLine($"Random Computer chose: {computerChoice1}");
                Console.WriteLine($"Last Choice Computer chose: {computerChoice2}");

                Console.WriteLine("Result for Random Computer:");
                GameHelpers.PrintResult(userChoice, computerChoice1);

                Console.WriteLine("Result for Last Choice Computer:");
                GameHelpers.PrintResult(userChoice, computerChoice2);
            }
        }
    }
}
