using BigBangMastery.Games;
using BigBangMastery.Players.Interfaces;
using BigBangMastery.Players;
using BigBangMastery.Constants;

class Program
{
    static void Main(string[] args)
    {
        int gameMode = 0;
        IPlayer randomComputerPlayer;
        IPlayer lastChoiceComputerPlayer;

        while (true)
        {
            Console.WriteLine("Choose game mode:");
            Console.WriteLine("1. Rock, Paper, Scissors");
            Console.WriteLine("2. Rock, Paper, Scissors, Lizard, Spock");

            string input = Console.ReadLine();
            if (int.TryParse(input, out gameMode) && (gameMode == 1 || gameMode == 2))
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please enter 1 or 2.");
            }
        }

        try
        {
            if (gameMode == 1)
            {
                randomComputerPlayer = new RandomComputerPlayer(GameConstants.ChoicesRPS);
                lastChoiceComputerPlayer = new LastChoiceComputerPlayer(GameConstants.ChoicesRPS);
            }
            else
            {
                randomComputerPlayer = new RandomComputerPlayer(GameConstants.ChoicesRPSLS);
                lastChoiceComputerPlayer = new LastChoiceComputerPlayer(GameConstants.ChoicesRPSLS);
            }

            Game game = GameInitializer.InitializeGame(gameMode, randomComputerPlayer, lastChoiceComputerPlayer);
            game.Play();
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}