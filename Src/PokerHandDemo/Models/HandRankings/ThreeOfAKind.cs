using System.Linq;

namespace PokerHandDemo.Models.HandRankings
{
    public class ThreeOfAKind : IHandRankCategory
    {
        public string Title { get; set; }
        public bool IsHighRank { get; }
        public bool Calculate(IPokerHand hand)
        {
            return hand.Cards
                       .GroupBy(c => c.Rank.Rank)
                       .Count(g => g.Count() == 3) == 1;
        }

        public ThreeOfAKind(IPokerHand hand)
        {
            Title = nameof(ThreeOfAKind);
            IsHighRank = Calculate(hand);
        }
    }
}
