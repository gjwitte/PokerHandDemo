using System.Linq;

namespace PokerHandDemo.Models.HandRankings
{
    public class Straight : IHandRankCategory
    {
        public string Title { get; set; }
        public bool IsHighRank { get; }
        public bool Calculate(IPokerHand hand)
        {
            var handRanks = hand.Cards.Select(c => c.Rank.Score);
            
            return handRanks.Select((i, j) => i - j)
                       .Distinct()
                       .Count() == 1;
        }

        public Straight(IPokerHand hand)
        {
            Title = nameof(Straight);
            IsHighRank = Calculate(hand);
        }
    }
}
