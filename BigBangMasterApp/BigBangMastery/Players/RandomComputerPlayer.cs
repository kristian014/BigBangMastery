using BigBangMastery.Players.Interfaces;

namespace BigBangMastery.Players
{
    public class RandomComputerPlayer : IPlayer
    {
        private readonly Random _random = new Random();
        private readonly string[] _choices;

        public RandomComputerPlayer(string[] choices)
        {
            _choices = choices;
        }

        public string GetChoice(string lastUserChoice)
        {
            return _choices[_random.Next(_choices.Length)];
        }
    }
}
