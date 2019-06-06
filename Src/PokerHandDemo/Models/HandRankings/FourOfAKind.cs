using System.Linq;

namespace PokerHandDemo.Models.HandRankings
{
    public class FourOfAKind : IHandRankCategory
    {
        public string Title { get; set; }
        public bool IsHighRank { get; }
        public bool Calculate(IPokerHand hand)
        {
            return hand.Cards
                       .GroupBy(c => c.Rank.Rank)
                       .Count(g => g.Count() == 4) == 1;
        }

        public FourOfAKind(IPokerHand hand)
        {
            Title = nameof(FourOfAKind);
            IsHighRank = Calculate(hand);
        }
    }
}
