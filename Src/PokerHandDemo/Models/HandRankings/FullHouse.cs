using System.Linq;

namespace PokerHandDemo.Models.HandRankings
{
    public class FullHouse : IHandRankCategory
    {
        public string Title { get; set; }
        public bool IsHighRank { get; }
        public bool Calculate(IPokerHand hand)
        {
            return hand.Cards.Count == 5 &&
                   hand.Cards
                       .GroupBy(c => c.Rank.Rank)
                       .Count() == 2;
        }

        public FullHouse(IPokerHand hand)
        {
            Title = nameof(FullHouse);
            IsHighRank = Calculate(hand);
        }
    }
}
