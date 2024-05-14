using BigBangMastery.Constants;
using BigBangMastery.Players.Interfaces;

namespace BigBangMastery.Games
{
    public static class GameInitializer
    {
        public static Game InitializeGame(int gameMode, IPlayer randomComputerPlayer, IPlayer lastChoiceComputerPlayer)
        {
            string[] choices = gameMode == 1 ? GameConstants.ChoicesRPS : GameConstants.ChoicesRPSLS;
            return new Game(choices, randomComputerPlayer, lastChoiceComputerPlayer);
        }
    }
}
