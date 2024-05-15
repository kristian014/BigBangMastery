using BigBangMastery.Constants;

namespace Test.BigBangMastery
{
    [TestFixture]
    public class GameConstantsTests
    {
        [Test]
        public void ChoicesRPS_ShouldHaveThreeElements()
        {
            int expectedResult = 3;
            Assert.That(expectedResult, Is.EqualTo(GameConstants.ChoicesRPS.Length));
        }

        [Test]
        public void ChoicesRPSLS_ShouldHaveFiveElements()
        {
            int expectedResult = 5;
            Assert.That(expectedResult, Is.EqualTo(GameConstants.ChoicesRPSLS.Length));
        }

        [Test]
        public void WinningConditions_ShouldContainRock()
        {
            Assert.IsTrue(GameConstants.WinningConditionsRPS.ContainsKey("rock"));
        }

        [Test]
        public void WinningConditions_ShouldHaveCorrectValuesForRock()
        {
            var expected = new[] { "scissors", "lizard" };
            CollectionAssert.AreEquivalent(expected, GameConstants.WinningConditionsRPSLS["rock"]);
        }
    }
}