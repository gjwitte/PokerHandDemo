using System.Linq;

namespace PokerHandDemo.Models.HandRankings
{
    public class RoyalFlush : IHandRankCategory
    {
        public string Title { get; set; }
        public bool IsHighRank { get; }
        public bool Calculate(IPokerHand hand)
        {
            var straightFlush = new StraightFlush(hand);
            if (!straightFlush.IsHighRank)
                return false;

            var handRanks = hand.Cards.Select(c => c.Rank.Score);
            return handRanks
                .Any(r => r == 10 && r == 13);
        }

        public RoyalFlush(IPokerHand hand)
        {
            Title = nameof(RoyalFlush);
            IsHighRank = Calculate(hand);
        }
    }
}
