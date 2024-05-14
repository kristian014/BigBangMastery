using BigBangMastery.Constants;
using BigBangMastery.Games;
using BigBangMastery.Helpers;
using BigBangMastery.Players;

namespace Test.BigBangMastery
{
    public class GameTests
    {
        [Test]
        public void IsUserWinner_ShouldReturnTrue_ForWinningScenario()
        {
            var game = new Game(1, new RandomComputerPlayer(GameConstants.ChoicesRPS), new LastChoiceComputerPlayer(GameConstants.ChoicesRPS));
            var result = GameHelpers.IsUserWinner("rock", "scissors");
            Assert.IsTrue(result);
        }

        [Test]
        public void IsUserWinner_ShouldReturnFalse_ForLosingScenario()
        {
            var game = new Game(1, new RandomComputerPlayer(GameConstants.ChoicesRPS), new LastChoiceComputerPlayer(GameConstants.ChoicesRPS));
            var result = GameHelpers.IsUserWinner("rock", "paper");
            Assert.IsFalse(result);
        }

        [Test]
        public void IsUserWinner_ShouldReturnTrue_ForWinningScenario_RPSLS()
        {
            var result = GameHelpers.IsUserWinner("spock", "scissors");
            Assert.IsTrue(result);
        }

        [Test]
        public void IsUserWinner_ShouldReturnFalse_ForLosingScenario_RPSLS()
        {
            var result = GameHelpers.IsUserWinner("spock", "lizard");
            Assert.IsFalse(result);
        }

        [Test]
        public void IsUserWinner_ShouldReturnFalse_ForTieScenario()
        {
            var result = GameHelpers.IsUserWinner("rock", "rock");
            Assert.IsFalse(result);
        }
    }
}
