namespace PokerHandDemo.Models.HandRankings
{
    public class StraightFlush : IHandRankCategory
    {
        public string Title { get; set; }
        public bool IsHighRank { get; }
        public bool Calculate(IPokerHand hand)
        {
            var straight = new Straight(hand);
            var flush = new Flush(hand);
            return straight.IsHighRank && flush.IsHighRank;
        }

        public StraightFlush(IPokerHand hand)
        {
            Title = nameof(StraightFlush);
            IsHighRank = Calculate(hand);
        }
    }
}
