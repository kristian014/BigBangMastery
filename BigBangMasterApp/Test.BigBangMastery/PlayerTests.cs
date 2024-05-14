using BigBangMastery.Constants;
using BigBangMastery.Players;

namespace Test.BigBangMastery
{
    [TestFixture]
    public class PlayerTests
    {
        [Test]
        public void RandomComputerPlayer_ShouldReturnValidChoice()
        {
            var player = new RandomComputerPlayer(GameConstants.ChoicesRPS);
            var choice = player.GetChoice(null);
            CollectionAssert.Contains(GameConstants.ChoicesRPS, choice);
        }

        [Test]
        public void RandomComputerPlayer_ShouldThrowException_WhenChoicesArrayIsEmpty()
        {
            var emptyChoices = new string[0];
            Assert.Throws<InvalidOperationException>(() => new RandomComputerPlayer(emptyChoices));
        }

        [Test]
        public void LastChoiceComputerPlayer_ShouldReturnLastUserChoice_WhenProvided()
        {
            var player = new LastChoiceComputerPlayer(GameConstants.ChoicesRPS);
            var choice = player.GetChoice("rock");
            string expectedResult = "rock";
            Assert.That(expectedResult, Is.EqualTo(choice));
        }

        [Test]
        public void LastChoiceComputerPlayer_ShouldReturnRandomChoice_WhenLastUserChoiceIsNull()
        {
            var player = new LastChoiceComputerPlayer(GameConstants.ChoicesRPS);
            var choice = player.GetChoice(null);
            CollectionAssert.Contains(GameConstants.ChoicesRPS, choice);
        }
    }
}
