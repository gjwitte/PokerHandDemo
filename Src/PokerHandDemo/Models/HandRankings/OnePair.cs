using System.Linq;

namespace PokerHandDemo.Models.HandRankings
{
    public class OnePair : IHandRankCategory
    {
        public string Title { get; set; }
        public bool IsHighRank { get; }
        public bool Calculate(IPokerHand hand)
        {
            return hand.Cards
                .GroupBy(c => c.Rank.Rank)
                .Count(g => g.Count() == 2) == 1;
        }

        public OnePair(IPokerHand hand)
        {
            Title = nameof(OnePair);
            IsHighRank = Calculate(hand);
        }
    }
}
