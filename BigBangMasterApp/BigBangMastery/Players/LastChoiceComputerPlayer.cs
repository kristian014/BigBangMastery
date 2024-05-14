using BigBangMastery.Helpers;
using BigBangMastery.Players.Interfaces;

namespace BigBangMastery.Players
{
    public class LastChoiceComputerPlayer : IPlayer
    {
        private string[] _choices;

        public LastChoiceComputerPlayer(string[] choices)
        {
            _choices = choices;

            GameHelpers.ValidateChoicesLength(_choices);
        }

        public string GetChoice(string lastUserChoice)
        {
            return lastUserChoice ?? _choices[new Random().Next(_choices.Length)];
        }
    }
}
