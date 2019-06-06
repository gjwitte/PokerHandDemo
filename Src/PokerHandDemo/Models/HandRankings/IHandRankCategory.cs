namespace PokerHandDemo.Models.HandRankings
{
    public interface IHandRankCategory
    {
        string Title { get; set; }
        bool IsHighRank { get; }
        bool Calculate(IPokerHand hand);
    }
}
