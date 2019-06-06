using System.Linq;

namespace PokerHandDemo.Models.HandRankings
{
    public class TwoPair : IHandRankCategory
    {
        public string Title { get; set; }
        public bool IsHighRank { get; }
        public bool Calculate(IPokerHand hand)
        {
            return hand.Cards
                   .GroupBy(c => c.Rank.Rank)
                   .Count(g => g.Count() == 2) == 2;
        }

        public TwoPair(IPokerHand hand)
        {
            Title = nameof(TwoPair);
            IsHighRank = Calculate(hand);
        }
    }
}
