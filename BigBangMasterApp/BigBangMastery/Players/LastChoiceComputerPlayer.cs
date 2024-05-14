using BigBangMastery.Players.Interfaces;

namespace BigBangMastery.Players
{
    public class LastChoiceComputerPlayer : IPlayer
    {
        private string[] choices;

        public LastChoiceComputerPlayer(string[] choices)
        {
            this.choices = choices;
        }

        public string GetChoice(string lastUserChoice)
        {
            return lastUserChoice ?? choices[new Random().Next(choices.Length)];
        }
    }
}
