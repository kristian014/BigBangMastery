using BigBangMastery.Constants;
using BigBangMastery.Games;
using BigBangMastery.Helpers;
using BigBangMastery.Players.Interfaces;
using BigBangMastery.Players;

namespace Test.BigBangMastery
{
    public class GameTests
    {
        private IPlayer _randomPlayer;
        private IPlayer _lastChoicePlayer;
        private Game _game;

        [SetUp]
        public void Setup()
        {
            _randomPlayer = new RandomComputerPlayer(GameConstants.ChoicesRPS);
            _lastChoicePlayer = new LastChoiceComputerPlayer(GameConstants.ChoicesRPS);
            _game = new Game(1, _randomPlayer, _lastChoicePlayer);
        }

        [Test]
        public void IsUserWinner_ShouldReturnTrue_ForWinningScenario()
        {
            var result = GameHelpers.IsUserWinner("rock", "scissors");
            Assert.IsTrue(result);
        }

        [Test]
        public void IsUserWinner_ShouldReturnFalse_ForLosingScenario()
        {
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

        [Test]
        public void Play_ShouldPrintCorrectResults_ForValidInput()
        {
            using (var input = new StringReader("rock\nexit\n"))
            using (var output = new StringWriter())
            {
                Console.SetIn(input);
                Console.SetOut(output);

                _game.Play();

                var consoleOutput = output.ToString();
                StringAssert.Contains("Enter your choice (rock, paper, scissors). To exit the game, type 'exit': ", consoleOutput);
                StringAssert.Contains("Random Computer chose:", consoleOutput);
                StringAssert.Contains("Last Choice Computer chose:", consoleOutput);
            }
        }

        [Test]
        public void Play_ShouldPrintInvalidChoiceMessage_ForInvalidInput()
        {
            using (var input = new StringReader("invalid\nexit\n"))
            using (var output = new StringWriter())
            {
                Console.SetIn(input);
                Console.SetOut(output);

                _game.Play();

                var consoleOutput = output.ToString();
                StringAssert.Contains("Invalid choice. Please try again.", consoleOutput);
            }
        }

        [Test]
        public void Play_ShouldExit_WhenUserTypesExit()
        {
            using (var input = new StringReader("exit\n"))
            using (var output = new StringWriter())
            {
                Console.SetIn(input);
                Console.SetOut(output);

                _game.Play();

                var consoleOutput = output.ToString();
                StringAssert.DoesNotContain("Random Computer chose", consoleOutput);
            }
        }
    }
}
