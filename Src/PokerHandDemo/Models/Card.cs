namespace PokerHandDemo.Models
{
    public class Card
    {
        public IPokerSuit Suit { get; set; }
        public IPokerRank Rank { get; set; }
        public string FormattedName => $"{Rank.Rank} of {Suit.Type}";
    }
}
