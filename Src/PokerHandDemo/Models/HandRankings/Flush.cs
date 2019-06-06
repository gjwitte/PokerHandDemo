using System.Linq;

namespace PokerHandDemo.Models.HandRankings
{
    public class Flush : IHandRankCategory
    {
        public string Title { get; set; }
        public bool IsHighRank { get; }
        public bool Calculate(IPokerHand hand)
        {
            return hand.Cards.Count > 1 && 
                   hand.Cards
                       .GroupBy(c => c.Suit.Type)
                       .Distinct()
                       .Count() == 1;
        }

        public Flush(IPokerHand hand)
        {
            Title = nameof(Flush);
            IsHighRank = Calculate(hand);
        }
    }
}
